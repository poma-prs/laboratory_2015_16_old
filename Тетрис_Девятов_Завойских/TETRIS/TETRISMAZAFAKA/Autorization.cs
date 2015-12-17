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
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            var constr = @"Data Source=ALEKSEY-SAMSUNG\SQLEXPRESS;Initial Catalog=Tetris_Base;Integrated Security=True";
            var cn = new SqlConnection(constr);
            cn.Open();
            var command = new SqlCommand();
            command.Connection = cn;
            command.CommandText = "Select *From Регистрация Where Логин='"+LoginTextbox.Text+"'and Пароль='"+PasswordTextbox.Text+"'";
            var result = command.ExecuteScalar();
            if (result == null)
            {
                MessageBox.Show("Ошибка авторизации", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Авторизация пройдена успешно", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
