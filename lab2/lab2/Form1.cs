using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;


namespace lab2
{
    public partial class pyramidDecButton : Form
    {
        public pyramidDecButton()
        {
            InitializeComponent();
            
        }

        private void openImageFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            imageBox1.Image = new Image<Bgr, byte>(openFileDialog1.FileName);
        }

        private void pyrDecButton_Click(object sender, EventArgs e)
        {
            try
            {
                imageBox2.Image = ImageTransformAlgorithms.pyramideDec(imageBox1.Image);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Null Reference Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void thresholdButton_Click(object sender, EventArgs e)
        {
            try
            {
                imageBox2.Image = ImageTransformAlgorithms.getThreshold(
                    ImageTransformAlgorithms.pyramideDec(imageBox1.Image), int.Parse(textBox1.Text));
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Fromat Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Null Reference Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void findContoursButton_Click(object sender, EventArgs e)
        {
            try
            {
                imageBox2.Image = Drawer.drawContour(imageBox1.Image,
                    ContourFinder.findApproxContours(imageBox1.Image, int.Parse(textBox1.Text)));
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Fromat Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Null Reference Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String currentContuor = comboBox1.SelectedItem.ToString();

                if (currentContuor == "Triangles")
                {
                    imageBox2.Image = Drawer.drawContour(imageBox1.Image,
                        ContourFinder.getTriangles(
                            ContourFinder.findApproxContours(imageBox1.Image, int.Parse(textBox1.Text)),
                            int.Parse(textBox2.Text)
                        )
                    );
                }
                if (currentContuor == "Rectangles")
                {
                    imageBox2.Image = Drawer.drawContour(imageBox1.Image,
                        ContourFinder.getRectangles(
                            ContourFinder.findApproxContours(imageBox1.Image, int.Parse(textBox1.Text)),
                            int.Parse(textBox2.Text)
                        )
                    );
                }
                if (currentContuor == "Circles")
                {
                    imageBox2.Image = Drawer.drawContour(imageBox1.Image, ContourFinder.getCircles(imageBox1.Image, int.Parse(textBox1.Text)));
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Fromat Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Null Reference Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
