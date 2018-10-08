using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KANAL_çıkarımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                openFileDialog1.DefaultExt = ".jpg"; openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                String ResminYolu = openFileDialog1.FileName; pictureBox1.Image = Image.FromFile(ResminYolu);
            }


        }

        private void kanalÇıkarımıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap Image = new Bitmap(pictureBox1.Image);
            Bitmap gri = grıyaap(Image);
            pictureBox2.Image = gri;

        }
        private Bitmap grıyaap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height - 1; i++)
            {
                for (int j = 0; j < bmp.Width - 1; j++)
                {
                    int deger = Convert.ToInt16(bmp.GetPixel(j, i).R + bmp.GetPixel(j, i).G  + bmp.GetPixel(j, i).B );
                    Color renk;
                    renk = Color.FromArgb(255,0 ,0 );
                    bmp.SetPixel(j, i, renk);
                }
            }
            return bmp;

        }

        private void grennToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap Image = new Bitmap(pictureBox1.Image);
            Bitmap gri = grıyap(Image);
            pictureBox2.Image = gri;

        }
        private Bitmap grıyap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height - 1; i++)
            {
                for (int j = 0; j < bmp.Width - 1; j++)
                {
                    int deger = Convert.ToInt16(bmp.GetPixel(j, i).R + bmp.GetPixel(j, i).G + bmp.GetPixel(j, i).B);
                    Color renk;
                    renk = Color.FromArgb(0,255, 0);
                    bmp.SetPixel(j, i, renk);
                }
            }
            return bmp;

        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap Image = new Bitmap(pictureBox1.Image);
            Bitmap gri = grıYap(Image);
            pictureBox2.Image = gri;

        }
        private Bitmap grıYap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height - 1; i++)
            {
                for (int j = 0; j < bmp.Width - 1; j++)
                {
                    int deger = Convert.ToInt16(bmp.GetPixel(j, i).R + bmp.GetPixel(j, i).G + bmp.GetPixel(j, i).B);
                    Color renk;
                    renk = Color.FromArgb(0,0, 255);
                    bmp.SetPixel(j, i, renk);
                }
            }
            return bmp;
        }
        Bitmap islem;
        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            ImageFormat format = ImageFormat.Png;
            if (sonuc == DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);
            }
        }
    }
}
