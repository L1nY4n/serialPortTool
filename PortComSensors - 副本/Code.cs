using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using ZXing.Common;

using ZXing;

using System.Windows.Forms;

using System.Drawing;

using System.Text.RegularExpressions;

using ZXing.QrCode;

namespace NewPortTest

{

    class BarCodeClass

    {

        ///<summary>

        ///生成条形码

        ///</summary>

        ///<paramname="pictureBox1"></param>

        ///<paramname="Contents"></param>

        public void CreateBarCode(PictureBox pictureBox1, string Contents)

        {

            Regex rg = new Regex("^[0-9]{12}$");

            if (!rg.IsMatch(Contents))

            {

                MessageBox.Show("本例子采用EAN_13编码，需要输入12位数字");

                return;

            }
            EncodingOptions options = null;

            BarcodeWriter writer = null;

            options = new EncodingOptions

            {

                Width = pictureBox1.Width,

                Height = pictureBox1.Height

            };

            writer = new BarcodeWriter();

            writer.Format = BarcodeFormat.ITF;

            writer.Options = options;



            Bitmap bitmap = writer.Write(Contents);

            pictureBox1.Image = bitmap;

        }



        ///<summary>

        ///生成二维码

        ///</summary>

        ///<paramname="pictureBox1"></param>

        ///<paramname="Contents"></param>

        public void CreateQuickMark(PictureBox pictureBox1, string Contents,string lable)

        {

            if (Contents == string.Empty)

            {

                MessageBox.Show("输入内容不能为空！");

                return;

            }



            EncodingOptions options = null;

            BarcodeWriter writer = null;



            options = new QrCodeEncodingOptions

           {

                DisableECI = true,

               CharacterSet = "UTF-8",

               Width = pictureBox1.Width,

               Height = pictureBox1.Width


            };

            writer = new BarcodeWriter();

            writer.Format = BarcodeFormat.QR_CODE;

            writer.Options = options;





            Bitmap bitmap = writer.Write(Contents);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            // pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Bitmap text_bitmap = KiSetText(bitmap, lable, new Font("黑体", 18, FontStyle.Bold), Color.Black, 50,pictureBox1.Width-42);
            pictureBox1.Image = text_bitmap;
            //pictureBox1.CreateGraphics().DrawString(Contents, SystemFonts.DefaultFont, Brushes.Red, new Point(0, pictureBox1.Width));

        }
        public static Bitmap KiSetText(Bitmap b, string txt, Font font, Color c, int x, int y)
        {
            if (b == null)
            {
                return null;
            }

            Graphics g = Graphics.FromImage(b);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            SolidBrush sb = new SolidBrush(c);

            g.DrawString(txt, font, sb, new PointF(x, y));
            g.Dispose();

            return b;
        }



        ///<summary>

        ///解码

        ///</summary>

        ///<paramname="pictureBox1"></param>

        public void Decode(PictureBox pictureBox1)

        {

            BarcodeReader reader = new BarcodeReader();

            Result result = reader.Decode((Bitmap)pictureBox1.Image);

        }

    }

}