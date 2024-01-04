using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public class StatusData
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Phone { get; set; }
        public string IsAdmin { get; set; }


        public static string RemovePathLevels(string path, int levelsToRemove)
        {
            if (string.IsNullOrEmpty(path) || levelsToRemove <= 0)
            {
                return path;
            }
            for (int i = 0; i < levelsToRemove; i++)
            {
                path = Path.GetDirectoryName(path);

                if (path == null)
                {
                    break;
                }
            }
            if (!path.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                path += Path.DirectorySeparatorChar.ToString();
            }

            return path;
        }
        public static string GetApplicationPath()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            string codeBase = assembly.CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);

            return Path.GetDirectoryName(path);
        }

        public static DataTable GetProductData(int productType)
        {
            DataTable dataTable = new DataTable();
            DB connection = new DB();
            connection.openConnection();
            string query = "SELECT * FROM Products WHERE ProductIType = @productType";
            connection.closeConnection();

            using (MySqlCommand command = new MySqlCommand(query, connection.getConnection()))
            {
                command.Parameters.Add("@productType", MySqlDbType.Int32).Value = productType;

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }



        public static DataTable GetProductAll()
        {
            DataTable dataTable = new DataTable();
            DB connection = new DB();
            connection.openConnection();
            string query = "SELECT * FROM Products";
            connection.closeConnection();

            using (MySqlCommand command = new MySqlCommand(query, connection.getConnection()))
            {

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

    }
}
