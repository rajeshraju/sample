using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Aspose.BarCode;

namespace GodavariFoods
{
    public partial class Generate_Barcode : Form
    {
        public Generate_Barcode()
        {
            InitializeComponent();
        }

        private void Generate_Barcode_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////Instantiate BarCodeBuilder object
            //BarCodeBuilder bb = new BarCodeBuilder();

            ////Set the Code text for the barcode
            //bb.CodeText = "1234567";

            ////Set the symbology type to Code128
            //bb.SymbologyType = Symbology.Code128;

            ////Set the width of the bars to 1 millimeters
            //bb.xDimension = 1f;

            ////Save the image to your system and set its image format to Jpeg
            //bb.Save("barcode.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            string barcode = txtBarcode.Text.Trim();

            Bitmap bitmap = new Bitmap(barcode.Length * 40, 50);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Font font = new Font("IDAutomationHC39M Free Version", 20);
                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white=new SolidBrush(Color.White);

                graphics.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                graphics.DrawString("*" + barcode + "*", font, black, point);
            }

            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Jpeg);
                pbBarcode.Image = bitmap;
                //pbBarcode.Width = bitmap.Width;
                //pbBarcode.Height = bitmap.Height;
            }


        }

    }
}
