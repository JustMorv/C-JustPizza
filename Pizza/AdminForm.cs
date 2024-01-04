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
    public partial class AdminForm : Form
    {
        private TextBox ProductNameinput;
        private TextBox ProductPriceinput;
        private TextBox ProductImginput;
        public AdminForm()
        {
            InitializeComponent();
        }
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            LoadAllProduct();
        }
        public void LoadAllProduct()
        {
            flowLayoutPanel1.Controls.Clear();

            Label ProductNameLabel = new Label();
            ProductNameLabel.Text = "название Продуста:";
            ProductNameLabel.Dock = DockStyle.Top;
            ProductNameLabel.Width = 200;

            ProductNameinput = new TextBox();
            ProductNameinput.Dock = DockStyle.Top;
            ProductNameinput.Name = "ProductNameinput";
            ProductNameinput.Width = 300;

            Label ProductPriceLabel = new Label();
            ProductPriceLabel.Text = "цена Продуста:";
            ProductPriceLabel.Dock = DockStyle.Top;
            ProductPriceLabel.Width = 200;


            ProductPriceinput = new TextBox();
            ProductPriceinput.Dock = DockStyle.Top;
            ProductPriceinput.Name = "ProductPriceinput";
            ProductPriceinput.Width = 300;

            Label ProductPriceImg = new Label();
            ProductPriceImg.Text = "изобрацение Продуста:";
            ProductPriceImg.Dock = DockStyle.Top;
            ProductPriceImg.Width = 200;

            ProductImginput = new TextBox();
            ProductImginput.Dock = DockStyle.Top;
            ProductImginput.Name = "ProductImginput";
            ProductImginput.Width = 300;

            Button ProductButtonAdd = new Button();
            ProductButtonAdd.Dock = DockStyle.Top;
            ProductButtonAdd.Name = "ProductButtonAdd";
            ProductButtonAdd.Width = 300;
            ProductButtonAdd.Text = "Добавить";
            ProductButtonAdd.Height = 30;
            ProductButtonAdd.Click += Button_add_Click;

            flowLayoutPanel1.Controls.Add(ProductNameLabel);
            flowLayoutPanel1.Controls.Add(ProductNameinput);


            flowLayoutPanel1.Controls.Add(ProductPriceLabel);
            flowLayoutPanel1.Controls.Add(ProductPriceinput);


            flowLayoutPanel1.Controls.Add(ProductPriceImg);
            flowLayoutPanel1.Controls.Add(ProductImginput);

            flowLayoutPanel1.Controls.Add(ProductButtonAdd);
        }

        private void Button_add_Click(object? sender, EventArgs e)
        {
            string textBoxName = ProductNameinput.Text;
            string textBoxPrice = ProductPriceinput.Text;
            string textBoximage = ProductImginput.Text;

            ProductDataAccess productDataAccess = new ProductDataAccess();
            productDataAccess.addProduct(textBoxName, textBoxPrice, textBoximage);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            CreateProductCards();

        }
        private DataTable GetProductData()
        {
            DataTable dataTable = new DataTable();
            DB connection = new DB();
            connection.openConnection();
            string query = "SELECT * FROM Products";
            using (MySqlCommand command = new MySqlCommand(query, connection.getConnection()))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
        public void CreateProductCards()
        {
            DataTable data = GetProductData();
            foreach (DataRow row in data.Rows)
            {
                Panel productPanel = new Panel();
                productPanel.BorderStyle = BorderStyle.FixedSingle;
                productPanel.Width = 250;
                productPanel.Height = 300;

                string originalPath = StatusData.GetApplicationPath();
                string formattedPath = StatusData.RemovePathLevels(originalPath, 3);
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 150;
                pictureBox.Height = 150;
                pictureBox.Image = Image.FromFile(formattedPath + "images/" + row["ProductImage"]);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;


                Label ProductNameLabel = new Label();
                ProductNameLabel.Text = $"Цена: {row["ProductName"]:C}";
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

        }

        public void CreateProductCardsUpdate()
        {
            DataTable data = GetProductData();
            foreach (DataRow row in data.Rows)
            {
                Panel productPanel = new Panel();
                productPanel.BorderStyle = BorderStyle.FixedSingle;
                productPanel.Width = 250;
                productPanel.Height = 300;

                string originalPath = StatusData.GetApplicationPath();
                string formattedPath = StatusData.RemovePathLevels(originalPath, 3);
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 150;
                pictureBox.Height = 150;
                pictureBox.Image = Image.FromFile(formattedPath + "images/" + row["ProductImage"]);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;


                Label ProductNameLabel = new Label();
                ProductNameLabel.Text = $"Наименование: {row["ProductName"]:C}";
                ProductNameLabel.Dock = DockStyle.Top;

                Label priceLabel = new Label();
                priceLabel.Text = $"Цена: {row["ProductPrice"]:C}";
                priceLabel.Dock = DockStyle.Bottom;

                Button buttonUpdate = new Button();
                buttonUpdate.Text = "Изменить";
                buttonUpdate.Height = 40;
                buttonUpdate.Dock = DockStyle.Bottom;
                buttonUpdate.Click += buttonUpdate_click;
                buttonUpdate.Tag = row["ProductID"];

                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(ProductNameLabel);
                productPanel.Controls.Add(priceLabel);
                productPanel.Controls.Add(buttonUpdate);

                flowLayoutPanel1.AutoScroll = true;
                flowLayoutPanel1.Controls.Add(productPanel);

            }
        }

        public void CreateProductCardsDelite()
        {
            DataTable data = GetProductData();
            foreach (DataRow row in data.Rows)
            {
                Panel productPanel = new Panel();
                productPanel.BorderStyle = BorderStyle.FixedSingle;
                productPanel.Width = 250;
                productPanel.Height = 300;

                string originalPath = StatusData.GetApplicationPath();
                string formattedPath = StatusData.RemovePathLevels(originalPath, 3);
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 150;
                pictureBox.Height = 150;
                pictureBox.Image = Image.FromFile(formattedPath + "images/" + row["ProductImage"]);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;


                Label ProductNameLabel = new Label();
                ProductNameLabel.Text = $"Наименование: {row["ProductName"]:C}";
                ProductNameLabel.Dock = DockStyle.Top;

                Label priceLabel = new Label();
                priceLabel.Text = $"Цена: {row["ProductPrice"]:C}";
                priceLabel.Dock = DockStyle.Bottom;

                Button buttonUpdate = new Button();
                buttonUpdate.Text = "Удалить";
                buttonUpdate.Height = 40;
                buttonUpdate.Dock = DockStyle.Bottom;
                buttonUpdate.Click += buttonDelite_click;
                buttonUpdate.Tag = row["ProductID"];

                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(ProductNameLabel);
                productPanel.Controls.Add(priceLabel);
                productPanel.Controls.Add(buttonUpdate);

                flowLayoutPanel1.AutoScroll = true;
                flowLayoutPanel1.Controls.Add(productPanel);

            }

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            CreateProductCardsUpdate();
        }
        private void buttonUpdate_click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            int ProductID = (int)button.Tag;
            UpdateFormCard updateFormCard = new UpdateFormCard(ProductID);
            updateFormCard.Show();




        }
        private void buttonDelite_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int ProductID = (int)button.Tag;
            ProductDataAccess.deliteProduct(ProductID);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            CreateProductCardsDelite();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
