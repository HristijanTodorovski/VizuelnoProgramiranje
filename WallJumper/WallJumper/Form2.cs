using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WallJumper.Properties;

namespace WallJumper
{
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
            Res k = new Res();
            textBox1.Text = k.score.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Res k = new Res();

            textBox1.Text = k.score.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reset Score", "reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
               // Resources.Scores.ToString() = "0";
            }
        }
    }
}
