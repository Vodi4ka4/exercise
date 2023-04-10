using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зачётное_задание
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string all = "";
            string[] text = textBox1.Text.Split(new[] {"A","E","Y","U","I","O","a","e","y","u","i","o"},StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i<text.Length;i++)
            {
                all = all + text[i];
            }
            textBox2.Text = Convert.ToString(all.Length);
        }
    }
}
