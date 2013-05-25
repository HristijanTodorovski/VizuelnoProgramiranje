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
            String s = Resources.Scores;
            s += "4";
           
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
