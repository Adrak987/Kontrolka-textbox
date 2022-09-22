using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace essa1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string es1 = textBox1.Text;
            string es2 = textBox2.Text;
            string es3 = dateTimePicker1.Text;
            if (es1.Length == 0 || es2.Length == 0)
            {
                MessageBox.Show("Nie podano wszystkich danych");
            }
            else
            {
                MessageBox.Show("Podane imię: " + es1 + ", nazwisko: " + es2 + ", data urodzenia: " + es3);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
