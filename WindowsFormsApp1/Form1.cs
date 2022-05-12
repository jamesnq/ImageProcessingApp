using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Drawing.Imaging;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Mat img = new Mat();

        private void sobel_btn(object sender, EventArgs e)
        {
            Mat img_gray = new Mat();
            Mat img_sobel = new Mat();
            Cv2.CvtColor(img, img_gray, ColorConversionCodes.BGR2GRAY);

            Mat grad_x = new Mat(), grad_y = new Mat();
            Mat abs_grad_x = new Mat(), abs_grad_y = new Mat();
            Cv2.Sobel(img_gray, grad_x, MatType.CV_16U, 1, 0, 3);
            Cv2.Sobel(img_gray, grad_y, MatType.CV_16U, 1, 0, 3);
            Cv2.ConvertScaleAbs(grad_x, abs_grad_x);
            Cv2.ConvertScaleAbs(grad_y, abs_grad_y);
            pictureBox2.Image = img_gray.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            Cv2.AddWeighted(abs_grad_x, 1, abs_grad_y, 1, 1, img_sobel);
            pictureBox2.Image = img_sobel.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        Mat[] rgb = new Mat[3];
        private void split_image_btn(object sender, EventArgs e)
        {
            rgb = Cv2.Split(img);
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            R.Enabled = true;
            trackBar1.Enabled = true;
            pictureBox2.Image = img.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            MessageBox.Show("Split successful");
        }

        private void gause_filter_btn(object sender, EventArgs e)
        {
            Mat img_gray = new Mat();
            Mat img_gause = new Mat();
            Cv2.CvtColor(img, img_gray, ColorConversionCodes.BGR2GRAY);
            Cv2.GaussianBlur(img_gray, img_gause, new OpenCvSharp.Size(3,3), 5.5);
            pictureBox2.Image = img_gause.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void delete_image_btn(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image =null;
            sobelImageBtn.Enabled = false;
            splitImageBtn.Enabled = false;
            deleteImageBtn.Enabled = false;
            convertToGrayBtn.Enabled = false;
            gauseFilterBtn.Enabled = false;
            resizeGroupBox.Enabled = false;
        }

        private void convert_to_gray_btn(object sender, EventArgs e)
        {
            Mat img_gray = new Mat();
            Cv2.CvtColor(img, img_gray, ColorConversionCodes.BGR2GRAY);
            pictureBox2.Image = img_gray.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void show_image_btn(object sender, EventArgs e)
        {
            // Đọc ảnh
            img = Cv2.ImRead(textBox1.Text);
            // Hien thi anh len Picture Box
            pictureBox1.Image = img.ToBitmap();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            sobelImageBtn.Enabled = true;
            splitImageBtn.Enabled = true;
            deleteImageBtn.Enabled = true;
            convertToGrayBtn.Enabled = true;
            gauseFilterBtn.Enabled = true;
            resizeGroupBox.Enabled = true;
        }

        private void open_file_btn(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            if (file.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = file.FileName;
            }
        }

        private void R_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = rgb[2].ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            label1.Text = "Red";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = rgb[1].ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            label1.Text = "Green";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = rgb[0].ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            label1.Text = "Blue";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = img.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            label1.Text = "RGB";
        }

        float gma = 0;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
            float value1 = 0.4f;
            gma = value1 * trackBar1.Value / 10;
            Bitmap bm = img.ToBitmap();
            Graphics g = Graphics.FromImage(bm);
            ImageAttributes ia = new ImageAttributes();

            ia.SetGamma(gma);
            Bitmap newBitmap = img.ToBitmap();
            g.DrawImage(newBitmap, new Rectangle(0, 0, newBitmap.Width, newBitmap.Height), 0, 0, newBitmap.Width, newBitmap.Height, GraphicsUnit.Pixel, ia);
            pictureBox2.Image = bm;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mat imgResize = new Mat();
            if(resizedListBox.SelectedItem.ToString() == "100x100")
            {
                Cv2.Resize(img, imgResize, new OpenCvSharp.Size(100,100));
                pictureBox2.Image = imgResize.ToBitmap();
            }
            else if (resizedListBox.SelectedItem.ToString() == "200x200")
            {
                Cv2.Resize(img, imgResize, new OpenCvSharp.Size(200, 200));
                pictureBox2.Image = imgResize.ToBitmap();
            }
            else if (resizedListBox.SelectedItem.ToString() == "300x300")
            {
                Cv2.Resize(img, imgResize, new OpenCvSharp.Size(300, 300));
                pictureBox2.Image = imgResize.ToBitmap();
            }
        }

        bool img100x100Added = false;
        bool img200x200Added = false;
        bool img300x300Added = false;
        private void buttonResize_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode =PictureBoxSizeMode.Normal;
            Mat imgResize = new Mat();
            if(newSizeList.SelectedItem == null)
            {
                MessageBox.Show("Please select size of new image");
            }
            else if(newSizeList.SelectedItem.ToString() == "100x100")
            {
                Cv2.Resize(img, imgResize, new OpenCvSharp.Size(100,100));
                pictureBox2.Image = imgResize.ToBitmap();
                if(img100x100Added == false)
                {
                    resizedListBox.Items.Add("100x100");
                    img100x100Added = false;
                }
            }
            else if (newSizeList.SelectedItem.ToString() == "200x200")
            {
                Cv2.Resize(img, imgResize, new OpenCvSharp.Size(200, 200));
                pictureBox2.Image = imgResize.ToBitmap();
                if (img200x200Added == false)
                {
                    resizedListBox.Items.Add("200x200");
                    img200x200Added = false;
                }
            }
            else if (newSizeList.SelectedItem.ToString() == "300x300")
            {
                Cv2.Resize(img, imgResize, new OpenCvSharp.Size(300, 300));
                pictureBox2.Image = imgResize.ToBitmap();
                if (img300x300Added == false)
                {
                    resizedListBox.Items.Add("300x300");
                    img300x300Added = false;
                }
            }
        }
    }
}
