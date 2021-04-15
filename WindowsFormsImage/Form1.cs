using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsImage
{
    public partial class Form1 : Form
    {
        static int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ChangeImage_Click(object sender, EventArgs e)
        {
           /* Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("WindowsFormsImage.Properties.Resources.images");
            Bitmap bmp = new Bitmap(myStream);
            pictureBox1.Image = bmp;*/

            if((counter%2) == 0)
            { 
                pictureBox1.Image = global::WindowsFormsImage.Properties.Resources.images; 
            }
            else
            {
                pictureBox1.Image = global::WindowsFormsImage.Properties.Resources.images2;
                
            }
            lbl_Image.Text = "Image Changed " + ++counter;
            
        }

        private void btn_PlaySound_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(WindowsFormsImage.Properties.Resources.bullet);
            player.Load();
            player.Play();


            if (counter%2 == 0)
            {
                lbl_Sound.Text = "Don't Touch ME !!!!!!!";
                lbl_Sound.Size = new Size(150, 50);
                lbl_Sound.Location = new Point(222, 200);
            }
            else
            {
                lbl_Sound.Text = "Don't Touch ME !!!!!!!";
                lbl_Sound.Size = new Size(110, 23);
                lbl_Sound.Location = new Point(202, 100);
            }
            ++counter;

        }
    }
}
