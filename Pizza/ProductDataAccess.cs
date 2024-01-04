using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    internal class ProductDataAccess
    {

        public DataTable GetProducts()
        {
            DataTable dataTable = new DataTable();
            DB connection = new DB();

            connection.openConnection();

            string query = "SELECT ProductID, ProductName, ProductPrice, ProductImage FROM Products";
            using (MySqlCommand command = new MySqlCommand(query, connection.getConnection()))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
        public void addProduct(string productName, string ProductPrice, string ProductImage)
        {
            DB connection = new DB();

            connection.openConnection(); 
            string query = "INSERT INTO Products (ProductName, ProductPrice, ProductImage) VALUES (@productName, @ProductPrice, @ProductImage)";
            using (MySqlCommand command = new MySqlCommand(query, connection.getConnection())) {
                command.Parameters.AddWithValue("@productName", productName);
                command.Parameters.AddWithValue("@ProductPrice", ProductPrice);
                command.Parameters.AddWithValue("@ProductImage", ProductImage);

                connection.openConnection();
                command.ExecuteNonQuery();
                connection.closeConnection();
            }
        }
        public static void addProductToCart(int user_id, int product_id)
        {
            DB connection = new DB();

            connection.openConnection();
            string query = "INSERT INTO `cart` (`user_id`, `product_id`)VALUES (@user_id, @product_id);";
            using (MySqlCommand command = new MySqlCommand(query, connection.getConnection()))
            {
                command.Parameters.AddWithValue("@user_id", user_id);
                command.Parameters.AddWithValue("@product_id", product_id);

                connection.openConnection();
                command.ExecuteNonQuery();
                connection.closeConnection();
            }
        }
        public static void updateProduct(string productName, string productPrice, string productImage, string productType, int productId)
        {
            DB connection = new DB();

            connection.openConnection();
            string query = "UPDATE `Products` SET `ProductName` = @ProductName, `ProductPrice` = @ProductPrice, `ProductImage` = @ProductImage, `ProductIType` = @ProductIType WHERE `ProductID` = @ProductID";
            using (MySqlCommand command = new MySqlCommand(query, connection.getConnection()))
            {
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@ProductPrice", productPrice);
                command.Parameters.AddWithValue("@ProductImage", productImage);
                command.Parameters.AddWithValue("@ProductIType", productType);
                command.Parameters.AddWithValue("@ProductID", productId);

                command.ExecuteNonQuery();
            }

            connection.closeConnection();
        }


        public static void deliteProduct(int productId)
        {
            DB connection = new DB();

            connection.openConnection();
            string query = "DELETE FROM `Products` WHERE ((`ProductID` = @ProductID));";
            using (MySqlCommand command = new MySqlCommand(query, connection.getConnection()))
            {
                command.Parameters.AddWithValue("@ProductID", productId);

                command.ExecuteNonQuery();
            }

            connection.closeConnection();
        }
    }
}
