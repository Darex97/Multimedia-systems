using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMS_Darko_Stosic_16413
{
    public partial class Form1 : Form
    {
        private Bitmap m_Bitmap, trenutna, undo;

        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trenutna = (Bitmap)view1Slika.Image;
 
            Pixelate.PixelateFilter(trenutna, 15, true);
            view1Slika.Image = trenutna;
            m_Bitmap = (Bitmap)view1Slika.Image;
        }

        private void noGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trenutna = (Bitmap)view1Slika.Image;
            Pixelate.PixelateFilter(trenutna, 15, false);
            view1Slika.Image = trenutna;
            m_Bitmap = (Bitmap)view1Slika.Image;
        }

        private void gammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GammaInput dlg = new GammaInput();
            dlg.red = dlg.green = dlg.blue = 1;
            if (DialogResult.OK == dlg.ShowDialog())
            {

                
                    trenutna = (Bitmap)view1Slika.Image;

                    if (Gamma.GammaFilter(trenutna, dlg.red, dlg.green, dlg.blue))
                    {
                        view1Slika.Image = trenutna;
                        m_Bitmap = (Bitmap)view1Slika.Image;
                        this.Invalidate();
                    }
                
            }
            }

    

        private void embossLaplacianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Convolution.EmbossLaplacian(m_Bitmap))
            {
                view1Slika.Image = m_Bitmap;
              
                this.Invalidate();
            }
        }

        private void edgeDetectHomogenityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EdgeParameter dlg = new EdgeParameter();
            dlg.value = 0;

            if (DialogResult.OK == dlg.ShowDialog())
            {
 
                if (Convolution.EdgeDetectHomogenity(m_Bitmap, (byte)dlg.value))
                {
                    view1Slika.Image = m_Bitmap;
                    this.Invalidate();
                }
                    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void shannonFanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Filter = "My format shanon (*.darkoShanon)|*.darkoShanon";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;



            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {


                CustomImageFormatDownsampling.SaveShannon(saveFileDialog.FileName, m_Bitmap);
            }

        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "My format shanon (*.darkoShanon)|*.darkoShanon";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
               
                m_Bitmap = CustomImageFormatDownsampling.loadShanon(openFileDialog.FileName);
                view1Slika.Image = (Bitmap)m_Bitmap.Clone();

                undo = (Bitmap)m_Bitmap.Clone();

                this.Invalidate();
            }
        }

        private void saveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Filter = "My format downsample shannon (*.yuvDownsampleShannon)|*.yuvDownsampleShannon";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;


            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {


                CustomImageFormatDownsampling.SaveDownsample(saveFileDialog.FileName, m_Bitmap);
            }
        }

        private void loadToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "My format downsample shannon (*.yuvDownsampleShannon)|*.yuvDownsampleShannon";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {

                m_Bitmap = CustomImageFormatDownsampling.loadDownsample(openFileDialog.FileName);
                view1Slika.Image = (Bitmap)m_Bitmap.Clone();

                undo = (Bitmap)m_Bitmap.Clone();

                this.Invalidate();
            }
        }

        private void saveToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Filter = "My format YUV (*.darkoYUV)|*.darkoYUV";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;


            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {


                CustomImageFormatDownsampling.SaveYUV(saveFileDialog.FileName, m_Bitmap);
            }
        }

        private void loadToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "My format YUV (*.darkoYUV)|*.darkoYUV";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {

                m_Bitmap = CustomImageFormatDownsampling.loadYUV(openFileDialog.FileName);

                undo = (Bitmap)m_Bitmap.Clone();

                view1Slika.Image = (Bitmap)m_Bitmap.Clone();
                this.Invalidate();
            }
        }

        private void saveToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Filter = "My format downsample (*.yuvDownsample)|*.yuvDownsample";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;



            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {


                CustomImageFormatDownsampling.SaveDownsampleWithoutShanon(saveFileDialog.FileName, m_Bitmap);
            }
        }

        private void loadToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "My format downsample (*.yuvDownsample)|*.yuvDownsample";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {

                m_Bitmap = CustomImageFormatDownsampling.loadDownsampleWithoutShanon(openFileDialog.FileName);
                view1Slika.Image = (Bitmap)m_Bitmap.Clone();

                undo = (Bitmap)m_Bitmap.Clone();

                this.Invalidate();
            }
        }

        private void yUVToolStripMenuItem_Click(object sender, EventArgs e)
        {
      ;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Vraca inicijalno ucitanu sliku za lakse testiranje

            view1Slika.Image = (Bitmap)undo.Clone();


            this.Invalidate();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|PNG files(*.png)|*.png|All valid files|*.bmp/*.jpg/*.png";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                m_Bitmap = (Bitmap)Bitmap.FromFile(openFileDialog.FileName, false);

                undo = (Bitmap)m_Bitmap.Clone();

                view1Slika.Image = (Bitmap)m_Bitmap.Clone();

              
                this.Invalidate();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp/*.jpg";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {

                view1Slika.Image.Save(saveFileDialog.FileName);


            }
        }
    }
}
