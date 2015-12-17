using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TETRISMAZAFAKA
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            var rg = new Registration();
            rg.Show();
        }

        private void AutorizationButton_Click(object sender, EventArgs e)
        {
            var rg = new Autorization();
            rg.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void PlaynowButton_Click(object sender, EventArgs e)
        {
            Play player = new Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Statistic stat = new Statistic();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
