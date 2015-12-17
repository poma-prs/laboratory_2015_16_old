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
    public partial class Registration : Form
    {

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            var constr = @"Data Source=ALEKSEY-SAMSUNG\SQLEXPRESS;Initial Catalog=Tetris_Base;Integrated Security=True";
            var cn = new SqlConnection(constr);
            cn.Open();
            var command = new SqlCommand();
            command.Connection = cn;
            command.CommandText = "Insert into Регистрация (Логин,Пароль,[e-mail]) values ('" + LoginTextbox.Text + "','"+ PasswordTextbox.Text +"','"+ EmailTextbox.Text +"')";
            command.ExecuteNonQuery();
            this.Close();
        }
    }
}
