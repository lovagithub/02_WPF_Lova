using System;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public struct People
    {
        public string name;
        public string number;

    }
    public partial class Form1 : Form
    {  
        List<People> l = new List<People>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }
        int find(string s)
        {
           for (int i = 0; i < l.Count; i++)
              if (l[i].name.Equals(s)) 
                    return i;
           return -1;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Du måste skriva Namn och adress");
            }
            else
            {
                People A;
                A.name = textBox1.Text;
                A.number = textBox2.Text;
                int x = find(A.name);
                if (x == -1)
                {
                    l.Add(A);
                    textBox1.Text = " ";
                    textBox2.Text = " ";
                    MessageBox.Show("Kontakt är skapad");
                }

                else {
                    MessageBox.Show("Liknannde kontakt finns redan");
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;   
            int x = find(s);
            if (x != -1)
                textBox2.Text = l[x].number;
            else
                MessageBox.Show("Kontakt finns inte");
            
        }
    }

}