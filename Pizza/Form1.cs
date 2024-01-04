using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System.Data;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Size.Width, 46);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogiin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = PassField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ul AND `password` = @up", db.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarString).Value = loginUser;
            command.Parameters.Add("@up", MySqlDbType.VarString).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            StatusData statusData = new StatusData();


            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                statusData.Id = Convert.ToInt32(row["id"]);
                statusData.Login = row["login"].ToString();
                statusData.Phone = row["phone"].ToString();
                statusData.IsAdmin = row["isAdmin"].ToString();

                if (statusData.IsAdmin == "1")
                {
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else
                {

                    this.Hide();
                    HeaderForm header = new HeaderForm(statusData);
                    header.Show();
                }
            }
            else
            {
                MessageBox.Show("не правельный логин/пароль");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm form = new RegisterForm();
            form.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}