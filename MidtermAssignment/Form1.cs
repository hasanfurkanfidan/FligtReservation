using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                dateTimePicker2.Enabled = true;
            }
            dateTimePicker1.MinDate = dateTimePicker1.Value;

            
        }
        public int adult;
       public int chield;
        public int baby;
        private void button1_Click(object sender, EventArgs e)
        {
            adult++;
            lbladult.Text = adult.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            adult--;
            lbladult.Text = adult.ToString();
            if(adult < 0)
            {
                MessageBox.Show("Error,Please enter valid number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chield++;
            lblchield.Text = chield.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            chield--;
            lblchield.Text = chield.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baby++ ;
            lblinfant.Text = baby.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baby--;
            lblinfant.Text = baby.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.destination = cmbto.Text;
            frm.date = dateTimePicker1.Text;
            frm.Passengers = adult.ToString() + " Adult "  + chield.ToString() + " Chield " + baby.ToString() + " Baby";
            frm.city = cmbfrom.Text;
            frm.Fee = baby * 20 + chield * 40 + adult * 80;
            frm.returndate = dateTimePicker2.Text;
           

            if(radioButton2.Checked == true)
            {
                frm.oneway = "true";
            }
            if(radioButton1.Checked == true)
            {
                frm.oneway = "false";
                

            }
            if(radioButton2.Checked ==true||radioButton1.Checked==true)
            {
                frm.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Please enter one way or round trip");
            }
            
                
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = false;
        }
    }
}

