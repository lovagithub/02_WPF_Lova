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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Du måste skriva Namn,telefon, e-mejl och adress");
            }
            else
            {
                string m = textBox1.Text;
                string text = File.ReadAllText("D:\\EC utbildning\\Uppgifter\\Uppgift4\\lista.txt");
                using (StreamReader sr = new StreamReader("D:\\EC utbildning\\Uppgifter\\Uppgift4\\lista.txt"))
                { 
                    if (text.Contains(m))
                    {
                        MessageBox.Show("Kan inte skapa kontakt.Kontakt finns redan");
                    }
                    else
                    {
                        sr.Close();
                        System.IO.StreamWriter writer = new System.IO.StreamWriter("D:\\EC utbildning\\Uppgifter\\Uppgift4\\lista.txt", true);
                        

                        writer.WriteLine(textBox1.Text); 
                        writer.WriteLine(textBox2.Text);
                        
                       
                        writer.Close();
                        textBox1.Text = "";
                        textBox2.Text = "";
                      
                        MessageBox.Show("Skapade kontakt");


                    }

                }
            }
        }
    }
}
