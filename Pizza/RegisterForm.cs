using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

            if (EmailField.Text == "" || loginField.Text == "" || PassField.Text == "" || PhoneField.Text == "")
            {
                MessageBox.Show("Заполнете поля!");
            }
            else
            {
                if (cheackUser())
                {
                    return;
                }
                DB dB = new DB();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `email`, `phone`, `password`, `isAdmin`) VALUES (@login, @email, @phone, @pass, '0');", dB.getConnection());
                command.Parameters.Add("@login", MySqlDbType.VarString).Value = loginField.Text;
                command.Parameters.Add("@email", MySqlDbType.VarString).Value = EmailField.Text;
                command.Parameters.Add("@phone", MySqlDbType.VarString).Value = PhoneField.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarString).Value = PassField.Text;

                dB.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
                dB.closeConnection(); 
            }
           

        }
        public Boolean cheackUser()
        {

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @login ", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarString).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже есть");
                return true;

            }
            return false;

        }

        private void auth_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
