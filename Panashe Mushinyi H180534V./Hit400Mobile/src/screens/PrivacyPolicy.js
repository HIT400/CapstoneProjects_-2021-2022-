import React from 'react';
import Pdf from 'react-native-pdf';
import {
  StyleSheet,
  Dimensions,
  Button,
  Text,
  ScrollView,
  View,
} from 'react-native';

export default function PrivacyPolicy() {
  return (
    <ScrollView style={styles.tcContainer}>
      <Text style={styles.title}>
        The Ministry of Health and Child Care Zimbabwe’s Privacy Policy
      </Text>

      <Text style={styles.tcP}>First Published: 7 December 2020</Text>
      <Text style={styles.tcL}>
        1. The Ministry of Health and Child Care is a fully-fledged Ministry in
        the Government of the Republic of Zimbabwe (hereafter referred to as
        “MoHCC,” “we,” or “us” or “our”) duly authorized in terms of the Public
        Health Act [CHAPTER 15:17], to coordinate and conduct all efforts
        associated with curbing any threats to public health and in these
        current circumstances, combat Covid-19 in the country. In so doing, the
        MoHCC has developed and seeks to utilize mobile and web-based
        applications for use by duly authorized members and employees of the
        Ministry to collect information related to COVID-19 in the country. In
        so doing, the MoHCC is aware of its ethical and legal obligations to
        treat in confidence the information it receives and there is also need
        to protect the privacy of individuals. We have designed this Mobile App
        Privacy Policy (the “Policy”) to explain how and when MoHCC collects,
        uses, and safeguards the information you provide and that we collect
        through the mobile or web-based applications owned and offered for
        download by the MoHCC, including, the “Impilo COVID-19 Surveillance App”
        and any other mobile applications that we may develop and offer in the
        future (collectively, the “Apps” and individually, an “App”).
      </Text>
      <Text style={styles.tcL}>
        Please carefully review this Policy to understand our policies and
        practices regarding the collection, use and treatment of your
        information. By using, accessing, or registering with an App, you
        consent to our collection, use, and disclosure of information in
        accordance with this Policy. You also acknowledge and agree that your
        access to and use of our Apps is subject to our Terms of Use and any
        conflict between this Policy and the Terms and Conditions of Use will be
        determined in favor of the Terms and Conditions of Use. The Privacy
        Policy is expressly made a part of the Terms and Conditions. You also
        acknowledge and agree that we are not responsible for how third parties,
        vendors, and service providers collect or use your information.
      </Text>
      <Text style={styles.tcP}>2. Scope of this Policy</Text>
      <Text style={styles.tcL}>
        This Policy applies to information you provide to us or that we collect
        automatically when you visit, access, use, or register with one or more
        of our Apps and when you interact with App content or applications that
        may link to or be accessible from or on the App that are provided or
        managed by a third party.
      </Text>
      <Text style={styles.tcL}>This Policy will tell you:</Text>
      <Text style={styles.tcL}>{'\u2022'} Who collects information;</Text>
      <Text style={styles.tcL}>
        {'\u2022'} What types of information are collected and how this is done;
      </Text>
      <Text style={styles.tcL}>
        {'\u2022'} How we use and disclose the information that is collected;
      </Text>
      <Text style={styles.tcL}>
        {'\u2022'} How we secure your information; and
      </Text>
      <Text style={styles.tcL}>
        {'\u2022'} Where you can get answers to your questions about this
        Policy.
      </Text>
      <Text style={styles.tcP}>3. Who Collects Information</Text>
      <Text style={styles.tcL}>
        We are the Ministry of Health and Child Care Zimbabwe. Our national
        headquarters office is at Kaguvi Building, Central Avenue, Harare,
        Zimbabwe and the MoHCC shall be the Data Controller.
      </Text>
      <Text style={styles.tcL}>
        3.2 The entire system for the app is under the direct control of the
        MoHCC and is operated technically, on its behalf, by the MoHCC and any
        other third parties as may be identified by the Ministry;
      </Text>
      <Text style={styles.tcL}>
        3.3 Where the MoHCC engages third parties to assist with providing this
        service, they have signed confidentiality agreements, undertaking
        contractually to comply with all requirements of section 39 of the
        Public Health Act [Chapter 15:17], as well as the provisions of the
        Terms and Conditions of Use and this Privacy Policy. The MoHCC monitors
        their compliance with these legal requirements.
      </Text>
      <Text style={styles.tcL}>
        3.4 All employees of the MoHCC, and any other third parties contracted
        in the development and maintenance of the App, are bound by
        confidentiality in the management of data.
      </Text>
      <Text style={styles.tcP}>4. Types of Information Collected</Text>
      <Text style={styles.tcL}>
        Information You Provide Directly. You provide information to us when you
        use our Apps, including when you download, register with, or log into
        our Apps. This information may include, but is not limited to,
        Personally Identifiable Information (‘PII”) including, name, email
        address, phone number, mailing address, device ID, username and
        password, registration ID number, and other information that may
        identify a person. You may also provide, non-personal information such
        as terms used for searches within Apps, responses to questions,
        schedules, bookmarks, notes, content viewed, features used, and other
        information about personal activities within and usage of the Apps.
        Unless otherwise noted within an App or in this Policy, any information
        you provide through the App may be transmitted to or stored by MOHCC
        and/or its third-party providers.
      </Text>
      <Text style={styles.tcL}>
        4.2 In utilizing the Apps such as the “Impilo COVID-19 Surveillance
        App”, you will be able to collect and input the following information
        (which information has been deemed necessary to directly respond to the
        public health emergency, and will support COVID-19-relatedefforts or
        epidemiological research in the Republic of Zimbabwe) from citizens and
        persons entering the Republic of Zimbabwe:
      </Text>
      <Text style={styles.tcL}>
        {'\u2022'} personal identifiers such as identity numbers, passport
        numbers or birth certificate numbers;
      </Text>
      <Text style={styles.tcL}>
        {'\u2022'} demographic information such as dates of birth, gender,
        education level, nationality and country of birth;
      </Text>
      <Text style={styles.tcL}>
        {'\u2022'} Contact details, next of kin and their contact details
        including residential addresses;
      </Text>
      <Text style={styles.tcL}>{'\u2022'}Travel history;</Text>
      <Text style={styles.tcL}>{'\u2022'}COVID-19 Risk Assessment;</Text>
      <Text style={styles.tcL}>{'\u2022'}COVID-19 symptom checklist;</Text>
      <Text style={styles.tcL}>
        {'\u2022'} Any relevant medical history, drug/medicines special needs;
      </Text>
      <Text style={styles.tcL}>
        {'\u2022'} COVID-19 Rapid/laboratory tests done and their results;
      </Text>
      <Text style={styles.tcL}>
        {'\u2022'} Daily follow data for localised follow up for twenty –one
        (21) days
      </Text>
      <Text style={styles.tcL}>
        4.3 Information We Collect Automatically. If you download, access, or
        use our Apps, we may receive and store certain information about you and
        your mobile device(s) automatically using automatic data collection
        technologies, including but not limited to first- and third-party
        Cookies, log files, Web Beacons, Pixels, dynamic tag management and
        other technical means. This information may include:
      </Text>
      <Text style={styles.tcL}>{'\u2022'}Your mobile device ID;</Text>
      <Text style={styles.tcL}>
        {'\u2022'} The type of mobile device and operating system you use to
        access our Apps;
      </Text>
      <Text style={styles.tcL}>{'\u2022'}Your IP address;</Text>
      <Text style={styles.tcL}>
        When you visit or use our Apps we may collect or receive information
        about you as described in this Policy.
      </Text>
      <Text style={styles.tcP}>5. How We Use Information</Text>
      <Text style={styles.tcL}>
        5.1 We may use the information we collect or receive about you to:
      </Text>
      <Text style={styles.tcL}>
        {'\u2022'} Provide our Apps and their content to you;
      </Text>
      <Text style={styles.tcL}>
        {'\u2022'} Complete your requested registrations, transactions or
        subscriptions;
      </Text>
      <Text style={styles.tcL}>
        {'\u2022'} Contact you in connection with requested services or
        inquiries;
      </Text>
      <Text style={styles.tcL}>
        {'\u2022'} Improve the content and functionality of our Apps;
      </Text>
      <Text style={styles.tcL}>
        {'\u2022'} Track the total number of visitors to our Apps and to each
        page or feature of our Apps; and
      </Text>
      <Text style={styles.tcP}>5.2 Use of Third-Party Information</Text>
      <Text style={styles.tcL}>
        The information inputted using the Impilo App is specifically for
        utilization in the MoHCC’s efforts to detect, trace and manage COVID-19
        in the Republic of Zimbabwe, as provided for in terms of the Public
        Health Act [Chapter 15:17]. Accordingly the information will be used for
        the following
      </Text>
      <Text style={styles.tcL}>
        {'\u2022'} to track and trace the COVID-19 virus in the territory of the
        Republic of Zimbabwe;
      </Text>
      <Text style={styles.tcL}>
        {'\u2022'} registration and screening of persons with or at risk of
        contracting COVID-19 disease as well as daily follow-ups by MOHCC health
        care workers;
      </Text>
      <Text style={styles.tcL}>
        {'\u2022'} to register incoming travellers at ports of entry into the
        Republic of Zimbabwe, screen said travellers and perform risk
        assessment/stratification of travellers in accordance with World Health
        Organization’s symptom checker tool.
      </Text>
      <Text style={styles.tcL}>
        {'\u2022'}
        to initiate lab tests/rapid rapid test request on a patient as and when
        appropriate
      </Text>
      <Text style={styles.tcL}>
        The information collected through the use of the App will only be used
        to detect, trace and manage COVID-19 in the Republic of Zimbabwe and
        shall not be availed to any third parties for any other reason that is
        not keeping medical ethics and regulations, detection and combating
        Covid-19 within the territory of Zimbabwe.
      </Text>
      <Text style={styles.tcP}>
        6. How we Secure the Information and Security Measures
      </Text>
      <Text style={styles.tcL}>
        6.1 We take the security of personal data very seriously. Our approach
        to information security is constantly evolving and continually reviewed.
        We have adopted industry best practices from both technological and
        business process perspectives in order to make the security of your data
        a key part of the way we do business.
      </Text>
      <Text style={styles.tcL}>
        6.2 To protect data against unauthorised access, loss, or misuse the app
        makes use of a variety of sophisticated technical security measures
        (including, for instance, encryption; pseudonymisation, logging, access
        controls and restrictions). The MOHCC and its partners also employ
        organisational strategies (including, for example, staff directives,
        confidentiality agreements, reasonably regular inspections) to ensure
        that all legal requirements have been, and are being, complied with.
      </Text>
      <Text style={styles.tcL}>
        6.3 We will never share your user information with third parties for
        promotional purposes. We remain responsible at all times for the
        security of your information.
      </Text>
      <Text style={styles.tcL}>
        6.4 To protect data against unauthorized access, loss, or misuse, the
        MoHCC, in collaboration with Ministry of ICT, Postal and Courier
        Services, will utilise internal and cloud based data storage facilities.
      </Text>
      <Text style={styles.tcL}>
        6.5 However, despite all the security measures adopted, our IT systems
        could be compromised by parties seeking unauthorized access to our data
        or users’ data, by a technological malfunction or by an error by an
        employee, vendor or contractor. In addition, third parties could
        intercept the transmission of information via the Internet or mobile
        data networks. As a result, our efforts to protect our data and users’
        data from unauthorized access may be unsuccessful and we cannot assure
        you that the security measures we have adopted will provide absolute
        certainty. By using, accessing or registering with the Apps, you agree
        that MOHCC is not responsible or liable for any loss or damage of any
        sort arising from or relating to any breach of our security,
        circumvention of any privacy settings or security measures, or
        interception of your transmissions.
      </Text>
      <Text style={styles.tcL}>
        6.6 The safety and security of your information also depends on you.
        Where we have given you (or where you have chosen) a password for access
        to our Apps or certain functions within our Apps, you are responsible
        for keeping this password confidential. We ask you not to share your
        password with anyone.
      </Text>
      <Text style={styles.tcP}>7. How long we hold information for</Text>
      <Text style={styles.tcL}>
        The data and personal information collected through the utilisation of
        the App are considered medical/health records and the manner they are
        handled is in accordance with the Public Health Act and related
        regulations.
      </Text>
      <Text style={styles.tcP}>8.Cookies</Text>
      <Text style={styles.tcL}>
        While we do not intend to use Cookies or expose users to said Cookies,
        we reserve the right to utilize them.
      </Text>
      <Text style={styles.tcP}>9. Changes to This Policy</Text>
      <Text style={styles.tcL}>
        Any changes we may make to our Privacy Policy in the future will be
        posted on this page. Should you register as a user through the App, you
        will be notified the next time you log in to make use of our services.
        The new terms may be displayed on-screen and you will be required to
        read and accept them to continue your use of our services.
      </Text>
      <Text style={styles.tcP}>
        10. Other documents governing privacy and data protection
      </Text>
      <Text style={styles.tcL}>
        This Privacy Policy is not necessarily exhaustive. Specific matters may
        be governed by other data protection statements, similar documents, or
        terms and conditions of use. Where that is so, a link to any such
        documents will be made available to the user in the app.
      </Text>
      <Text style={styles.tcP}>11. Contact Us</Text>
      <Text style={styles.tcL}>
        If you have any concerns about the way we use personal information or
        any questions about this Privacy Notice, please let us know. We can be
        contacted via email at helpdesk@mohcc.org.zw , or you can write to us at
        the address above.
      </Text>
    </ScrollView>
  );
}

const {width, height} = Dimensions.get('window');
const styles = StyleSheet.create({
  pdf: {
    flex: 1,
    height: Dimensions.get('window').height,
    width: Dimensions.get('window').width,
  },
  container: {
    marginTop: 20,
    marginLeft: 10,
    marginRight: 10,
  },
  title: {
    fontSize: 22,
    alignSelf: 'center',
  },
  tcP: {
    marginTop: 10,
    marginBottom: 10,
    fontSize: 14,
    fontWeight: '300',
  },
  tcL: {
    marginLeft: 10,
    marginTop: 10,
    marginBottom: 10,
    fontSize: 12,
  },
  tcContainer: {
    marginTop: 15,
    marginLeft: 10,
    marginRight: 10,
    marginBottom: 15,
    height: height * 0.7,
  },
});
