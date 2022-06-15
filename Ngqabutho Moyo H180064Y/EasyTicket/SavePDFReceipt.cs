<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace EasyTicket
{
    class SavePDFReceipt
    {
        DateTime date = DateTime.Now;        
        public void SaveReceipt(string username, string _from, string _to, string time, double price)
        {
            String path = @"C:\Users\Ngqabutho Moyo\Documents\Software Engineering Part 4\HIT 400\demo.pdf";
            try
            {
                PdfWriter writer = new PdfWriter(path);
                PdfDocument pdf_document = new PdfDocument(writer);
                Document document = new Document(pdf_document);

                Paragraph todays_date = new Paragraph(date.ToString());
                LineSeparator ls = new LineSeparator(new SolidLine());
                Paragraph _usernameTitle = new Paragraph("Username:");
                Paragraph _username = new Paragraph(username);
                Paragraph fromTitle = new Paragraph("From:");
                Paragraph from = new Paragraph(_from);
                Paragraph toTitle = new Paragraph("To:");
                Paragraph to = new Paragraph(_to);
                Paragraph departsAtTitle = new Paragraph("Departing At:");
                Paragraph departsAt = new Paragraph(time);
                Paragraph priceTitle = new Paragraph("Price:");
                Paragraph _price = new Paragraph(price.ToString());
                //Paragraph _balance = new Paragraph(balance.ToString());

                document.Add(todays_date);
                document.Add(ls);
                document.Add(_usernameTitle);
                document.Add(_username);
                document.Add(fromTitle);
                document.Add(from);
                document.Add(toTitle);
                document.Add(to);
                document.Add(departsAtTitle);
                document.Add(departsAt);
                document.Add(priceTitle);
                document.Add(_price);
                //document.Add(_balance);

                document.Close();

                MessageBox.Show($"Receipt saved successfully in the following directory:\n {path}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace EasyTicket
{
    class SavePDFReceipt
    {
        DateTime date = DateTime.Now;        
        public void SaveReceipt(string username, string _from, string _to, string time, double price)
        {
            String path = @"C:\Users\Ngqabutho Moyo\Documents\Software Engineering Part 4\HIT 400\demo.pdf";
            try
            {
                PdfWriter writer = new PdfWriter(path);
                PdfDocument pdf_document = new PdfDocument(writer);
                Document document = new Document(pdf_document);

                Paragraph todays_date = new Paragraph(date.ToString());
                LineSeparator ls = new LineSeparator(new SolidLine());
                Paragraph _usernameTitle = new Paragraph("Username:");
                Paragraph _username = new Paragraph(username);
                Paragraph fromTitle = new Paragraph("From:");
                Paragraph from = new Paragraph(_from);
                Paragraph toTitle = new Paragraph("To:");
                Paragraph to = new Paragraph(_to);
                Paragraph departsAtTitle = new Paragraph("Departing At:");
                Paragraph departsAt = new Paragraph(time);
                Paragraph priceTitle = new Paragraph("Price:");
                Paragraph _price = new Paragraph(price.ToString());
                //Paragraph _balance = new Paragraph(balance.ToString());

                document.Add(todays_date);
                document.Add(ls);
                document.Add(_usernameTitle);
                document.Add(_username);
                document.Add(fromTitle);
                document.Add(from);
                document.Add(toTitle);
                document.Add(to);
                document.Add(departsAtTitle);
                document.Add(departsAt);
                document.Add(priceTitle);
                document.Add(_price);
                //document.Add(_balance);

                document.Close();

                MessageBox.Show($"Receipt saved successfully in the following directory:\n {path}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
>>>>>>> parent of 5a30ca7... commit message
