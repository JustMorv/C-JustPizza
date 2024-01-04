using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class UpdateFormCard : Form
    {
        private int ProductID;
        public UpdateFormCard(int productID)
        {
            InitializeComponent();
            this.ProductID = productID;

        }

        private void UpdateFormCard_Load(object sender, EventArgs e)
        {
            
            DataTable table = GetProducts();
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                textBoxName.Text = row["ProductName"].ToString();
                textBoxPrice.Text = row["ProductPrice"].ToString();
                textBoxImages.Text = row["ProductImage"].ToString();
                textBoxType.Text = row["ProductIType"].ToString();
            }
        }

        public DataTable GetProducts()
        {
            DataTable dataTable = new DataTable();
            DB connection = new DB();

            connection.openConnection();

            string query = "SELECT * FROM Products WHERE ProductID = @ProductID";
            using (MySqlCommand command = new MySqlCommand(query, connection.getConnection()))
            {
                command.Parameters.AddWithValue("@ProductID", this.ProductID);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        private void buttonChangeProduct_Click(object sender, EventArgs e)
        {
            DataTable table = GetProducts();
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
            
                ProductDataAccess.updateProduct(textBoxName.Text, textBoxPrice.Text, textBoxImages.Text, textBoxType.Text, Convert.ToInt32(row["ProductID"]));
            }

        }
    }
}
