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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string Passengers;
        public string destination;
        public string date;
        public string returndate;
        public string oneway;
        public string city;
        public int Fee;
        private void Form3_Load(object sender, EventArgs e)
        {
            lbldest.Text = destination;
            lbloneway.Text = oneway;
            lblpassengers.Text = Passengers;
            if(lbloneway.Text == "true")
            {
                lbldate.Text = date;
                Form1 frm = new Form1();

                
                lblfee.Text = Fee.ToString() + "TL";
            }
            if(lbloneway.Text == "false")
            {
                lbldate.Text = date;
                lblreturndate.Text = returndate;
                lblfee.Text = (Fee*2).ToString()+ "TL";
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Reservation res = new Reservation();
            res.nameandsurname = textBox1.Text;
            res.dest = destination;
            res.date = date;
            res.returndate = returndate;
            res.Show();
            this.Hide();
        }
    }
}
