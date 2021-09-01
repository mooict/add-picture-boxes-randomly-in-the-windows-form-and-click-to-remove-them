using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Spawn_and_Click_Picture_Box_MOO_ICT
{
    public partial class Form1 : Form
    {

        Random rand = new Random();
        List<PictureBox> items = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
        }
        private void MakePictureBox()
        {

            PictureBox newPic = new PictureBox();
            newPic.Height = 50;
            newPic.Width = 50;
            newPic.BackColor = Color.Maroon;

            int x = rand.Next(10, this.ClientSize.Width - newPic.Width);
            int y = rand.Next(10, this.ClientSize.Height - newPic.Height);
            newPic.Location = new Point(x, y);

            newPic.Click += NewPic_Click;

            items.Add(newPic);
            this.Controls.Add(newPic);
        }

        private void NewPic_Click(object sender, EventArgs e)
        {
            PictureBox temPic = sender as PictureBox;

            items.Remove(temPic);

            this.Controls.Remove(temPic);

            lblItemCount.Text = "Items: " + items.Count();
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            MakePictureBox();

            lblItemCount.Text = "Items: " + items.Count();
        }
    }
}
