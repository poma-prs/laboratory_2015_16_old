using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplic
{
    public partial class Regsi : Form
    {
        public Regsi()
        {
            InitializeComponent();
        }

        private void Regsi_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Check_in pol=new Check_in();
            pol.Show();
        }
    }
}
