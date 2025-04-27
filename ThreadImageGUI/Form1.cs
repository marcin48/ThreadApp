using System.Threading;

namespace ImageThreadGui
{
    public partial class Form1 : Form
    {
        private Bitmap? originalImage;
        private int threads = 4;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var file = openFileDialog1.FileName;
                if (file != null)
                {
                    originalImage = new Bitmap(file);
                    pictureBox1.Image = originalImage;
                }
            }

        }

        private void button_Single_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;

            Bitmap image1 = new Bitmap(originalImage);
            Bitmap image2 = new Bitmap(originalImage);
            Bitmap image3 = new Bitmap(originalImage);
            Bitmap image4 = new Bitmap(originalImage);

            Thread worker = new Thread(() =>
            {
                GreenFilter(image1);
                GrayScale(image2);
                Threshold(image3);
                Negative(image4);
            });

            worker.Start();
            worker.Join();
        }

        private void button_Process_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;

            Bitmap image1 = new Bitmap(originalImage);
            Bitmap image2 = new Bitmap(originalImage);
            Bitmap image3 = new Bitmap(originalImage);
            Bitmap image4 = new Bitmap(originalImage);

            Thread[] workers = new Thread[threads];

            workers[0] = new Thread(() => GreenFilter(image1));
            workers[1] = new Thread(() => GrayScale(image2));
            workers[2] = new Thread(() => Threshold(image3));
            workers[3] = new Thread(() => Negative(image4));

            for (int i = 0; i < threads; i++)
            {
                workers[i].Start();
            }
            foreach (var thread in workers)
                thread.Join();



        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
  
            pictureBox2.Image?.Dispose();
            pictureBox3.Image?.Dispose();
            pictureBox4.Image?.Dispose();
            pictureBox5.Image?.Dispose();


            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
        }

        private void GreenFilter(Bitmap img)
        {
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color pixel = img.GetPixel(x, y);
                    img.SetPixel(x, y, Color.FromArgb(0, pixel.G, 0));
                }
            }

            pictureBox2.Image = img;
        }


        private void GrayScale(Bitmap img)
        {
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color pixel = img.GetPixel(x, y);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    img.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }

            pictureBox3.Image = img;
        }


        private void Threshold(Bitmap img)
        {
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color pixel = img.GetPixel(x, y);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    if (gray < 128)
                    {
                        img.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        img.SetPixel(x, y, Color.Black);
                    }
                }
            }

            pictureBox4.Image = img;
        }


        private void Negative(Bitmap img)
        {
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color pixel = img.GetPixel(x, y);
                    img.SetPixel(x, y, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }
            }

            pictureBox5.Image = img;
        }

    }
}
