using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;




namespace Pizza
{
    public partial class HeaderForm : Form
    {
        public HeaderForm()
        {
            InitializeComponent();
        }
        public StatusData statusData;
        public HeaderForm(StatusData statusData)
        {
            this.statusData = statusData;
            InitializeComponent();

            CreateProductCards();
            Label headerLabel = new Label();
        }

        private void HeaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void HeaderForm_Load(object sender, EventArgs e)
        {
            CreateProductCards();

        }



        private void buttonAddCart_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            StatusData statusData = new StatusData();
            int ProductID = (int)button.Tag;

            ProductDataAccess.addProductToCart(this.statusData.Id, ProductID);

        }


        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            DataTable data = DisplayUserOrders();
            foreach (DataRow row in data.Rows)
            {
                Panel productPanel = new Panel();
                productPanel.BorderStyle = BorderStyle.FixedSingle;
                productPanel.Width = 250;
                productPanel.Height = 300;
                productPanel.Margin = new Padding(10);

                string originalPath = StatusData.GetApplicationPath();
                string formattedPath = StatusData.RemovePathLevels(originalPath, 3);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 150;
                pictureBox.Height = 170;
                pictureBox.Image = Image.FromFile(formattedPath + "images/" + row["ProductImage"]);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;

                Label ProductNameLabel = new Label();
                ProductNameLabel.Text = $"наименование: {row["ProductName"]:C}";
                ProductNameLabel.Dock = DockStyle.Top;

                Label priceLabel = new Label();
                priceLabel.Text = $"Цена: {row["ProductPrice"]:C}";
                priceLabel.Dock = DockStyle.Bottom;


                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(ProductNameLabel);
                productPanel.Controls.Add(priceLabel);

                flowLayoutPanel1.AutoScroll = true;
                flowLayoutPanel1.Controls.Add(productPanel);

            }
            Button buttonAddCartOrder = new Button();
            buttonAddCartOrder.Text = $"Оформить заказ";
            buttonAddCartOrder.Dock = DockStyle.Bottom;
            buttonAddCartOrder.Width = 400;
            buttonAddCartOrder.Height = 40;
            buttonAddCartOrder.Click += buttonAddCartOreder_Click;

            Button buttonDeliteCart = new Button();
            buttonDeliteCart.Text = $"Отчистить корзину";
            buttonDeliteCart.Dock = DockStyle.Bottom;
            buttonDeliteCart.Width = 400;
            buttonDeliteCart.Height = 40;
            buttonDeliteCart.Click += DeliteAllCart_Click;

            flowLayoutPanel1.Controls.Add(buttonDeliteCart);
            flowLayoutPanel1.Controls.Add(buttonAddCartOrder);

        }

        public DataTable DisplayUserOrders()
        {
            DataTable dataTable = new DataTable();
            DB connection = new DB();

            connection.openConnection();

            string query = @"SELECT p.ProductID, p.ProductName, p.ProductPrice, p.ProductImage
                                 FROM Products p
                                 JOIN Cart c ON p.ProductID = c.product_id
                                 WHERE c.user_id = @UserId";
            using (MySqlCommand command = new MySqlCommand(query, connection.getConnection()))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    command.Parameters.AddWithValue("@UserId", this.statusData.Id);

                    adapter.Fill(dataTable);

                }
            }
            return dataTable;
        }


        public void CreateProductCards()
        {
            flowLayoutPanel1.Controls.Clear();




            Label headerLabel = new Label();
            headerLabel.Text = $"наименование";
            headerLabel.Dock = DockStyle.Top;

            DataTable data = StatusData.GetProductAll();
            foreach (DataRow row in data.Rows)
            {
                Panel productPanel = new Panel();
                productPanel.BorderStyle = BorderStyle.FixedSingle;
                productPanel.Width = 250;
                productPanel.Height = 300;
                productPanel.Margin = new Padding(10);

                string originalPath = StatusData.GetApplicationPath();
                string formattedPath = StatusData.RemovePathLevels(originalPath, 3);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 150;
                pictureBox.Height = 170;
                pictureBox.Image = Image.FromFile(formattedPath + "images/" + row["ProductImage"]);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;

                Label ProductNameLabel = new Label();
                ProductNameLabel.Text = $"наименование: {row["ProductName"]:C}";
                ProductNameLabel.Dock = DockStyle.Top;

                Label priceLabel = new Label();
                priceLabel.Text = $"Цена: {row["ProductPrice"]:C}";
                priceLabel.Dock = DockStyle.Bottom;

                Button buttonAddCart = new Button();
                buttonAddCart.Text = $"Добавить";
                buttonAddCart.Dock = DockStyle.Bottom;
                buttonAddCart.Height = 40;
                buttonAddCart.Tag = row["ProductID"];

                buttonAddCart.Click += buttonAddCart_Click;

                // Добавление элементов на панель карточки товара
                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(ProductNameLabel);
                productPanel.Controls.Add(priceLabel);
                productPanel.Controls.Add(buttonAddCart);

                // Добавление панели к FlowLayoutPanel
                flowLayoutPanel1.AutoScroll = true;
                flowLayoutPanel1.Controls.Add(productPanel);

            }
        }
        public void DeliteAllCart()
        {
            DataTable dataTable = new DataTable();
            DB connection = new DB();

            connection.openConnection();

            string query = @"DELETE FROM `cart` WHERE `user_id` = @UserId;";
            using (MySqlCommand command = new MySqlCommand(query, connection.getConnection()))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    command.Parameters.AddWithValue("@UserId", this.statusData.Id);

                    adapter.Fill(dataTable);


                }
            }

        }
        private void DeliteAllCart_Click(object sender, EventArgs e)
        {
            DeliteAllCart();
            flowLayoutPanel1.Controls.Clear();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();


            CreateProductCards();

        }
        private void buttonAddCartOreder_Click(object sender, EventArgs e)
        {

            List<OrderData> orders = new List<OrderData>();
            string originalPath = StatusData.GetApplicationPath();

            DataTable data = DisplayUserOrders();

            foreach (DataRow row in data.Rows)
            {

                OrderData order = new OrderData
                {
                    ProductName = row["ProductName"].ToString(),
                    ProductPrice = row["ProductPrice"].ToString(),
                    ProductImage = row["ProductImage"].ToString()
                };
                orders.Add(order);

            }

            string textData = $"Login: {this.statusData.Login}\nPhone: {this.statusData.Phone.ToString()}\nOrders:\n";

            foreach (var order in orders)
            {
                textData += $"Product Name: {order.ProductName}\nProduct Price: {order.ProductPrice:C}\nProduct Image: {order.ProductImage}\n\n";
            }

            SaveTextToFile(textData);
            DeliteAllCart();
            flowLayoutPanel1.Controls.Clear();

        }
        private void SaveTextToFile(string textData)

        {

            string filePath = StatusData.GetApplicationPath();
            string formattedPath = StatusData.RemovePathLevels(filePath, 3);


            File.WriteAllText(formattedPath + "ordersData/data.txt", textData);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();


            DataTable data = StatusData.GetProductData(1200);
            foreach (DataRow row in data.Rows)
            {
                Panel productPanel = new Panel();
                productPanel.BorderStyle = BorderStyle.FixedSingle;
                productPanel.Width = 250;
                productPanel.Height = 300;
                productPanel.Margin = new Padding(10);

                string originalPath = StatusData.GetApplicationPath();
                string formattedPath = StatusData.RemovePathLevels(originalPath, 3);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 150;
                pictureBox.Height = 170;
                pictureBox.Image = Image.FromFile(formattedPath + "images/" + row["ProductImage"]);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;

                Label ProductNameLabel = new Label();
                ProductNameLabel.Text = $"наименование: {row["ProductName"]:C}";
                ProductNameLabel.Dock = DockStyle.Top;

                Label priceLabel = new Label();
                priceLabel.Text = $"Цена: {row["ProductPrice"]:C}";
                priceLabel.Dock = DockStyle.Bottom;

                Button buttonAddCart = new Button();
                buttonAddCart.Text = $"Добавить";
                buttonAddCart.Dock = DockStyle.Bottom;
                buttonAddCart.Height = 40;
                buttonAddCart.Tag = row["ProductID"];

                buttonAddCart.Click += buttonAddCart_Click;

                // Добавление элементов на панель карточки товара
                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(ProductNameLabel);
                productPanel.Controls.Add(priceLabel);
                productPanel.Controls.Add(buttonAddCart);

                // Добавление панели к FlowLayoutPanel
                flowLayoutPanel1.AutoScroll = true;
                flowLayoutPanel1.Controls.Add(productPanel);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            DataTable data = StatusData.GetProductData(1000);
            foreach (DataRow row in data.Rows)
            {
                Panel productPanel = new Panel();
                productPanel.BorderStyle = BorderStyle.FixedSingle;
                productPanel.Width = 250;
                productPanel.Height = 300;
                productPanel.Margin = new Padding(10);

                string originalPath = StatusData.GetApplicationPath();
                string formattedPath = StatusData.RemovePathLevels(originalPath, 3);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 150;
                pictureBox.Height = 170;
                pictureBox.Image = Image.FromFile(formattedPath + "images/" + row["ProductImage"]);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;

                Label ProductNameLabel = new Label();
                ProductNameLabel.Text = $"наименование: {row["ProductName"]:C}";
                ProductNameLabel.Dock = DockStyle.Top;

                Label priceLabel = new Label();
                priceLabel.Text = $"Цена: {row["ProductPrice"]:C}";
                priceLabel.Dock = DockStyle.Bottom;

                Button buttonAddCart = new Button();
                buttonAddCart.Text = $"Добавить";
                buttonAddCart.Dock = DockStyle.Bottom;
                buttonAddCart.Height = 40;
                buttonAddCart.Tag = row["ProductID"];

                buttonAddCart.Click += buttonAddCart_Click;

                // Добавление элементов на панель карточки товара
                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(ProductNameLabel);
                productPanel.Controls.Add(priceLabel);
                productPanel.Controls.Add(buttonAddCart);

                // Добавление панели к FlowLayoutPanel
                flowLayoutPanel1.AutoScroll = true;
                flowLayoutPanel1.Controls.Add(productPanel);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }

}
