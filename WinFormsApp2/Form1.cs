using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, a = 0; bool ok; ok = false;
            y = Convert.ToInt32(textBox1.Text);
            x = Convert.ToInt32(textBox2.Text);
            if (radioButton1.Checked) 
            {
                a = x + y;
                ok = true;
            }
            else if (radioButton2.Checked)
            {
                a = x - y;
                ok = true;
            }
            else if (radioButton3.Checked)
            {
                a = x * y;
                ok = true;
            }
            else if (radioButton4.Checked)
            {
                a = x / y;
                ok = true;
            }
            else if (radioButton5.Checked)
            {
                a = Math.Pow(x, y);
                ok = true;
            }
            else if (radioButton6.Checked)
            {
                a = Math.Sqrt(x);
                ok = true;
            }
            else if (radioButton7.Checked)
            {
                a = y / x * 100;

                ok = true;
            }
            else if (ok)
                label1.Text = Convert.ToString(a);
            else
            {
                MessageBox.Show("Выберите тип операции.", "Ой-ой", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
