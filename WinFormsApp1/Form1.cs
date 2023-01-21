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
            StreamReader sr = new StreamReader("D:\\EC utbildning\\Uppgifter\\Uppgift4\\lista.txt");
            string m;
            while ((m = sr.ReadLine()) != null)
            {
                People A;
                A.name = m;
                A.number = sr.ReadLine();
            
                l.Add(A);
            }
            sr.Close();
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
            Form2 s = new Form2();
            s.Show();

            if ((textBox1.Text == "") || (textBox2.Text == ""))
                {
                MessageBox.Show("Du måste skriva Förnamn och Efternamn");
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

            StreamReader sr = new StreamReader("D:\\EC utbildning\\Uppgifter\\Uppgift4\\lista.txt");
            string m;
            while ((m= sr.ReadLine()) != null) 
            {
                People A;
                A.name = m;
                A.number = sr.ReadLine();            
                l.Add(A);
            }
            sr.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}