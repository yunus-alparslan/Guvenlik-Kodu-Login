using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecCode
{
    public partial class Form1 : Form
    {


        public Form1()
        {

            InitializeComponent();
        }



        int cd1, cd2, cd3, cd4;
        int sec1, sec2, sec3, sec4;
        void secturycode()
        {

            Random code = new Random();

            cd1 = code.Next(2, 6);
            cd2 = code.Next(2, 6);
            cd3 = code.Next(2, 6);
            cd4 = code.Next(2, 6);
            label1.Text = cd1.ToString();
            label2.Text = cd2.ToString();
            label3.Text = cd3.ToString();
            label4.Text = cd4.ToString();





        }


        private void button1_Click(object sender, EventArgs e)
        {

            Form2 formyeni = new Form2();
           
            



            sec1 = Convert.ToInt16(textBox1.Text);
            sec2 = Convert.ToInt16(textBox2.Text);
            sec3 = Convert.ToInt16(textBox3.Text);
            sec4 = Convert.ToInt16(textBox4.Text);

            if (cd1 == sec1 & cd2 == sec2 & cd3 == sec3 & cd4 == sec4)
            {
                MessageBox.Show("Giriş Başarılı !", "Login Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formyeni.Show();
                this.Hide();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            secturycode();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arkaPlanRenkDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
