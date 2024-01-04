namespace Pizza
{
    partial class HeaderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pageSetupDialog1 = new PageSetupDialog();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrchid;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 666);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkOrchid;
            button5.ForeColor = Color.White;
            button5.Location = new Point(48, 473);
            button5.Name = "button5";
            button5.Size = new Size(184, 49);
            button5.TabIndex = 6;
            button5.Text = "Выйти";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkOrchid;
            button4.ForeColor = Color.White;
            button4.Location = new Point(48, 392);
            button4.Name = "button4";
            button4.Size = new Size(184, 49);
            button4.TabIndex = 5;
            button4.Text = "Корзина";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOrchid;
            button3.ForeColor = Color.White;
            button3.Location = new Point(48, 312);
            button3.Name = "button3";
            button3.Size = new Size(184, 49);
            button3.TabIndex = 4;
            button3.Text = "пиццы";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrchid;
            button2.ForeColor = Color.White;
            button2.Location = new Point(48, 234);
            button2.Name = "button2";
            button2.Size = new Size(184, 49);
            button2.TabIndex = 3;
            button2.Text = "Коктейли";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrchid;
            button1.ForeColor = Color.White;
            button1.Location = new Point(48, 150);
            button1.Name = "button1";
            button1.Size = new Size(184, 49);
            button1.TabIndex = 2;
            button1.Text = "Главная";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(111, 37);
            label1.Name = "label1";
            label1.Size = new Size(155, 45);
            label1.TabIndex = 1;
            label1.Text = "JustPizza";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._221;
            pictureBox1.Location = new Point(34, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel1.Location = new Point(306, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(911, 666);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // HeaderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 666);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "HeaderForm";
            Text = "JustPizza";
            FormClosing += HeaderForm_FormClosing;
            Load += HeaderForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private PageSetupDialog pageSetupDialog1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}