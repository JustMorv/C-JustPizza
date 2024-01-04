namespace Pizza
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Panel register_label;
            label2 = new Label();
            buttonLogiin = new Button();
            PassField = new TextBox();
            pictureBox2 = new PictureBox();
            loginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            register_label = new Panel();
            register_label.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // register_label
            // 
            register_label.BackColor = SystemColors.ButtonFace;
            register_label.Controls.Add(label2);
            register_label.Controls.Add(buttonLogiin);
            register_label.Controls.Add(PassField);
            register_label.Controls.Add(pictureBox2);
            register_label.Controls.Add(loginField);
            register_label.Controls.Add(pictureBox1);
            register_label.Controls.Add(panel2);
            register_label.Dock = DockStyle.Fill;
            register_label.Location = new Point(0, 0);
            register_label.Name = "register_label";
            register_label.Size = new Size(795, 583);
            register_label.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 482);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 6;
            label2.Text = "У меня нет аккаунта";
            label2.Click += label2_Click;
            // 
            // buttonLogiin
            // 
            buttonLogiin.BackColor = Color.DarkOrchid;
            buttonLogiin.ForeColor = Color.White;
            buttonLogiin.Location = new Point(230, 392);
            buttonLogiin.Name = "buttonLogiin";
            buttonLogiin.Size = new Size(265, 59);
            buttonLogiin.TabIndex = 5;
            buttonLogiin.Text = "Войти";
            buttonLogiin.UseVisualStyleBackColor = false;
            buttonLogiin.Click += buttonLogiin_Click;
            // 
            // PassField
            // 
            PassField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PassField.Location = new Point(230, 307);
            PassField.Name = "PassField";
            PassField.PlaceholderText = "Ведите пароль";
            PassField.Size = new Size(268, 39);
            PassField.TabIndex = 4;
            PassField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pass;
            pictureBox2.Location = new Point(131, 307);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            loginField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginField.Location = new Point(230, 243);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.PlaceholderText = "Ведите логин";
            loginField.Size = new Size(268, 43);
            loginField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(150, 243);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(795, 150);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkOrchid;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Impact", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(795, 150);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 583);
            Controls.Add(register_label);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            register_label.ResumeLayout(false);
            register_label.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox loginField;
        private TextBox PassField;
        private PictureBox pictureBox2;
        private Button buttonLogiin;
        private Label label2;
    }
}