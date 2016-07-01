using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2x2
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        private int x = 0;
        private int y = 0;
        private int z = 0;
        private int point = 0;
        private int counter = 0;
        private string Humenname ;
        public void NewRandInic()
        {
            x = rand.Next(0, 10);
            y = rand.Next(0, 10);
        }

        public Form1()
        {
            InitializeComponent();
            NewRandInic();
            text();
            textBox1.Text = "Ձեր Միավորը- --" ;
        }
        public void text()
        {
            TextOut.Text = x + " * " + y + "= ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                z = Int32.Parse(TextInp.Text);
                counter++;                
                if (counter != 20)
                {
                    if (x * y == z)
                    {
                        point++;
                        textBox1.Text = "Ձեր Միավորը "+ point.ToString();
                        TextOut.BackColor = Color.LightSeaGreen;
                        TextInp.BackColor = Color.LightSeaGreen;
                        MessageBox.Show("Ճիշտ է ))");
                        NewRandInic();
                        text();
                    }
                    else
                    {
                        point--;
                        textBox1.Text = "Ձեր Միավորը " + point.ToString();
                        TextOut.BackColor = Color.Red;
                        TextInp.BackColor = Color.Red;
                        MessageBox.Show("Սխալ է եղեք ավելի ուշադիր ․․․");
                        text();
                    }
                }
                else
                {
                    counter = 0;
                    if (point>=10 && point<=15)
                    {
                        MessageBox.Show("Խաղն ավարտվեց ձեր միավորը-" + point+" Կրկնեք բազմապատկման աղյուսյակը ;)");
                    }
                    else if (point>15 && point<20)
                    {
                        MessageBox.Show("Խաղն ավարտվեց ձեր միավորը-" + point + " Դուք լավ գիտեք բազմապատկման աղյուսյակու ․Շարունակեք նույն տեմպերով ;)");
                    }
                    else
                    {
                        MessageBox.Show("Ամոթ՝՝՝   նույնիսկ չեմ ուզում նայել ձեր միավորին․․․․ սովորեք բազմապատկման աղյուսյակը  ");
                    }
                    point = 0;
                }
                 }
            catch
            {
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {           
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                OK.Click += button1_Click;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
