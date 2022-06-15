<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    
    public partial class PDFDemo : Form
    {
        string path = @"C:\Users\Ngqabutho Moyo\Documents\Software Engineering Part 4\HIT 400\demo.pdf";
        public PDFDemo()
        {
            InitializeComponent();
        }

        

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SavePDF();
            MessageBox.Show("Saved!");
        }

        private void SavePDF()
        {
            String header_1 = txtHeader.Text;
            String subheader_1 = txtSubHeader.Text;
            String body_1 = txtBody.Text;
            try
            {
                PdfWriter writer = new PdfWriter(path);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                Paragraph header = new Paragraph(header_1)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(20);

                Paragraph subheader = new Paragraph(subheader_1)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(15);

                LineSeparator ls = new LineSeparator(new SolidLine());
                
                Paragraph body = new Paragraph(body_1)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(10);

                document.Add(header);
                document.Add(subheader);
                document.Add(ls);
                document.Add(body);
                document.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    
    public partial class PDFDemo : Form
    {
        string path = @"C:\Users\Ngqabutho Moyo\Documents\Software Engineering Part 4\HIT 400\demo.pdf";
        public PDFDemo()
        {
            InitializeComponent();
        }

        

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SavePDF();
            MessageBox.Show("Saved!");
        }

        private void SavePDF()
        {
            String header_1 = txtHeader.Text;
            String subheader_1 = txtSubHeader.Text;
            String body_1 = txtBody.Text;
            try
            {
                PdfWriter writer = new PdfWriter(path);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                Paragraph header = new Paragraph(header_1)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(20);

                Paragraph subheader = new Paragraph(subheader_1)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(15);

                LineSeparator ls = new LineSeparator(new SolidLine());
                
                Paragraph body = new Paragraph(body_1)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(10);

                document.Add(header);
                document.Add(subheader);
                document.Add(ls);
                document.Add(body);
                document.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
>>>>>>> parent of 5a30ca7... commit message
