using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading;


namespace WallJumper
{
    public partial class Form1 : Form
    {
        Background zaz = new Background();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawImage(zaz.Backpicture, 0, 0);
        }  
    }
}
