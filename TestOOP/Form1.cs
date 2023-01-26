using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool created1 = false;
        bool created2 = false;
        NPC Vitek;
        Hrac Radek;
        private void Form1_Load(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                comboBox5.Enabled = false;
                checkBox1.Enabled = false;
                numericUpDown2.Enabled = false;
            }
            button3.Enabled = false;
            button2.Enabled = false;
        }
       
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            

                if (e.Button == MouseButtons.Left)
                {
                    int x = Cursor.Position.X;
                    int y = Cursor.Position.Y;
                    if (radioButton1.Checked)
                    {
                        if (created1)
                        {

                        
                        Radek.ZmenaPozice(x, y);
                        }
                    }
                    else
                    {
                        if (created2)
                        {
                            Vitek.ZmenaPozice(x, y);
                        }
                        
                    }
                }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button2.Enabled = false;
            if (radioButton1.Checked)
            {
                checkBox1.Enabled = false;
                numericUpDown2.Enabled = false;
                comboBox5.Enabled = false;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                
                numericUpDown1.Enabled = true;
            }
            else
            {
                checkBox1.Enabled = true;
                numericUpDown2.Enabled = true;
                comboBox5.Enabled = true;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                button2.Enabled = false;
                numericUpDown1.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                Radek = new Hrac((string)comboBox4.SelectedItem,(string)comboBox1.SelectedItem,(string)comboBox2.SelectedItem, (string)comboBox3.SelectedItem, 0, textBox1.Text);
                created1 = true;
                button3.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                
                
                    Vitek = new NPC(true, (string)comboBox5.SelectedItem, (int)numericUpDown2.Value, textBox1.Text);


                created2 = true;
                button3.Enabled = true;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label4.Text=Radek.ToString();

            }
            else
            {
                label4.Text=Vitek.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           MessageBox.Show(Radek.PridejXP((int)numericUpDown1.Value)); 
        }
    }
}
