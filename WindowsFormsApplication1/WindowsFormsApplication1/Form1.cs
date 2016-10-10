using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
   
        private void Form1_Load_1(object sender, EventArgs e)
        {
            Text = "Prvi Program";
            Width = 500;
            Height = 500;
            
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random R = new Random();
            BackColor = Color.FromArgb(R.Next(256), R.Next(256), R.Next(256));
            Width = R.Next(300, 500);
            Height = R.Next(200, 500);
            Text = "Kliknuli ste na polje (" + e.X + "," + e.Y + ")";
        }

        // private void Form1_Load_1_MouseClick(object sender, MouseEventArgs e)
        // {



        // }
    }
}
