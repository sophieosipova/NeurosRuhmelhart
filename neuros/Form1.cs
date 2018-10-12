using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.IO;
//using neuros.Neurons;
using neuros.Data;

namespace neuros
{
    public partial class Form1 : Form
    {
        private Thread _teachThread;
        private readonly Thread _formThread;

        private Int32 _neuronCount = 10;
        private Int32 _imageWidth = 3;
        private Int32 _imageHeight = 5;

        private Perceptron perceptron;

        private void UpdateForm()
        {
                if (_teachThread != null)
                    if (_teachThread.ThreadState == ThreadState.Running)
                    {

                        foreach (var control in Controls.OfType<Button>())
                        {
                            control.Invoke(new Action(() => control.Enabled = false));
                        }
                        progressBar1.Invoke(new Action(() => progressBar1.Visible = true));

                    }
                    else
                    {
                        foreach (var control in Controls.OfType<Button>())
                        {
                            control.Invoke(new Action(() => control.Enabled = true));
                        }
                        progressBar1.Invoke(new Action(() => progressBar1.Visible = false));

                    }
                Thread.Sleep(200);
        }

        public Form1()
        {
            InitializeComponent();
            perceptron = new Perceptron(_neuronCount, _imageWidth * _imageHeight,0.1);
            pictureBox1.Image = new Bitmap(_imageWidth, _imageHeight);
            _formThread = new Thread(UpdateForm);
            _formThread.Start();

            DirectoryLabel.Text = "../../Numbers/";// System.IO.Directory.GetCurrentDirectory();//"/"
        }

        private ImageData[] LoadImage(String path, Int32 count)
        {
            // загрузка всех тестовых изображений в массив bitmaps[]
            var list = Directory.GetFiles(path, "*.bmp");
            var images = new ImageData[list.GetLength(0)];
            for (var s = 0; s < list.GetLength(0); s++)
            {
                images[s] = new ImageData
                {
                    Data = ImageToArray(new Bitmap(list[s])),
                    Class = Convert.ToInt32((Path.GetFileNameWithoutExtension(list[s]).Substring(0, count)))
                };
            }
            return images;
        }


        private double[] ImageToArray(Bitmap bitmap)
        {
            var pixel = new double[bitmap.Height * bitmap.Width];
            var k = 0;
            for (var i = 0; i < bitmap.Width; i++)
                for (var j = 0; j < bitmap.Height; j++)
                {
                    pixel[k] = Step(bitmap.GetPixel(i, j));
                    k++;
                }
            return pixel;
        }

        private Int32 Step(Color c)
        {
            var p = c.R < 100 ? 1 : 0;
            if (p != 1)
                return c.G < 100 ? 1 : 0;
            if (p != 1)
                return c.B < 100 ? 1 : 0;
            return p;
        }

        private void TeachButton_Click(object sender, EventArgs e)
        {
            try
            {
                AnswerLabel.Text = "";
                if (!String.IsNullOrEmpty(DirectoryLabel.Text) && !String.IsNullOrWhiteSpace(DirectoryLabel.Text))
                {
                    _teachThread = new Thread(() => perceptron.Teach(LoadImage(DirectoryLabel.Text, 1)));
                    _teachThread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void RecognizeButton_Click(object sender, EventArgs e)
        {
            try
            {
                AnswerLabel.Text = "Неудача";
                var output = perceptron.Recognize(ImageToArray(new Bitmap(pictureBox1.Image)));
                AnswerLabel.Text = Array.IndexOf(output, output.Max()).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddPictureButton_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog { InitialDirectory = AppDomain.CurrentDomain.BaseDirectory, Filter = ".bmp|*.bmp" })
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(open.FileName);
                }
            }
            AnswerLabel.Text = "";
        }

    }
}
