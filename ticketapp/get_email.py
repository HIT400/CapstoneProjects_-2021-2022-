import csv
import json
import random
import shelve
import email
import imaplib
from django.contrib.auth.models import User
from django.core.mail import send_mail
from django.conf import settings
from .models import Ticket
from .email_regex import GetEmailDetails



class EmailDownload:

    """This Class Downloads emails in the inbox of a particular gmail account and create a csv file with the information"""

   #############################################################

    def __init__(self, email, password):
        """Yeah, initializing everything"""
        self.email = str(email)
        self.password = str(password)

   #############################################################

    def login_to_imap_server(self):
        """Log in to the imap server"""

        # connecting to the server
        print("Trying to connect to the server")

        try:
            imapObj = imaplib.IMAP4_SSL('imap.gmail.com')
            print("Successfully connected to the IMAP server...")

            # Try logging into gmail
            print("Trying to log in to gmail...")

            try:
                imapObj.login(self.email, self.password)
                print("Logged in")
                self.select_email_uids(imapObj)
            except Exception as e:
                print(e)
                print("Failed to log you in, make sure your password and email are correct \nand that your have enabled non-google apps in the google settings")

        except:
            print("Failed to connect, probably some network error")

   #############################################################

    def select_email_uids(self, imap_object):
        """Select uids for email data to be extracted"""
        imap_object.select('INBOX')
        _, self.uids = imap_object.search(None, 'ALL')
        self.get_email_content_from_uids(imap_object)
        self.logout_of_imap_server(imap_object)

   #############################################################

    # TODO: Create a function that calls envelope with args self.uids
    def get_email_content_from_uids(self, imap_object):
        """Get email data from the respective email uid"""
        try:
            with shelve.open('data') as db:
                counter = db['counter']
        except KeyError:
            counter = 0

        if counter == 0:

            for num in self.uids[0].split():
                try:
                    _, data = imap_object.fetch(num, '(RFC822)')
                    _, bytes_data = data[0]

                    # convert the byte data to message
                    email_message = email.message_from_bytes(bytes_data)

                    self.save_data_in_json(email_message)
                    self.save_to_db(email_message)
                except Exception as e:
                    print(e)
        else:
            for num in self.uids[0].split()[counter:]:
                try:
                    _, data = imap_object.fetch(num, '(RFC822)')
                    _, bytes_data = data[0]

                    # convert the byte data to message
                    email_message = email.message_from_bytes(bytes_data)

                    self.save_data_in_json(email_message)
                except Exception as e:
                    print(e)

        print("saving counter")
        with shelve.open('data') as db:
            db['counter'] = counter

   #############################################################

    def save_data_in_csv(self, email_message):
        """Writing the information to a csv file"""

        subject = email_message["subject"]
        to = email_message["to"]
        from_ = email_message["from"]
        date_ = email_message["date"]
        for part in email_message.walk():
            if part.get_content_type() == "text/plain" or part.get_content_type() == "text/html":
                message = part.get_payload(decode=True)
                message = message.decode('utf-8', 'ignore')
                break

        data_output_file = open('email_data.csv', 'a', newline='')
        csv_writer = csv.writer(data_output_file)

        csv_writer.writerow([date_, from_, to, subject, message])
        data_output_file.close()

   #############################################################

    def save_to_db(self, email_message):
        """Save the information extracted to a database

        Args:
            email_message (dict): The dictionary containing information about the ticket
        """

        user = User.objects.get(username='chatbot')
        subject = email_message["subject"]
        # to = email_message["to"]
        # from_ = email_message["from"]
        date_ = email_message["date"]
        for part in email_message.walk():
            if part.get_content_type() == "text/plain" or part.get_content_type() == "text/html":
                message = part.get_payload(decode=True)
                message = message.decode('utf-8', 'ignore')
                break

        email_details = GetEmailDetails(message)

        ticket_object = Ticket.objects.create(
            user=user,
            title=subject,
            customer_full_name=email_details.get_name(),
            customer_phone_number=email_details.get_phone_number(),
            customer_email=email_details.get_email(),
            issue_description=email_details.get_issue_description(),
            ticket_section=email_details.get_issue_section(),
            created_date=date_
        )
        
        assigned_to = random.choice(User.objects.exclude(username='chatbot'))
        
        ticket_object.assigned_to = assigned_to
        
        subject = 'Issue recieved'
        message = 'Good day.\n Your issue has been created successfully. You will recieve an email once it has been resolved.\n Regards,\n ICT Helpdesk'
        email_from = settings.EMAIL_HOST_USER
        recipient_list = [email_details.get_email(),]
        send_mail( subject, message, email_from, recipient_list )
        
        print("Ticket created successfully")

   ##############################################################

    def save_data_in_json(self, email_message):
        """Writing the information to a json file"""

        subject = email_message["subject"]
        to = email_message["to"]
        from_ = email_message["from"]
        date_ = email_message["date"]
        for part in email_message.walk():
            if part.get_content_type() == "text/plain" or part.get_content_type() == "text/html":
                message = part.get_payload(decode=True)
                message = message.decode('utf-8', 'ignore')
                break

        # 1. Convert the data into a dictionary
        email_dict = {
            "date": date_,
            "from": from_,
            "to": to,
            "subject": subject,
            "text": message,
        }

        # 2. Convert the dictionary into json then dump the shit into a json file
        with open("email_data.json", 'a') as f:
            f.write(json.dumps(email_dict, sort_keys=True,
                    indent=4))

   #############################################################

    def logout_of_imap_server(self, imap_object):
        """This function logs out of the imap server"""

        print("Logging Out...")
        imap_object.close()
        imap_object.logout()
        print("Logged Out!!")

   #############################################################