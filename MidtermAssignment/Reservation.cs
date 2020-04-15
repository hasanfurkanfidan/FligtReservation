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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }
       public string nameandsurname;
        public string dest;
        public string date;
        public string returndate;
        private void Reservation_Load(object sender, EventArgs e)
        {
            lblname.Text = nameandsurname;
            lbldes.Text = dest;
            lbldate.Text = date;
            lblreturndate.Text = returndate;

        }
    }
}
