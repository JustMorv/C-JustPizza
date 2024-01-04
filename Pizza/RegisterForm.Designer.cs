namespace Pizza
{
    partial class RegisterForm
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
            auth_label = new Label();
            PassField = new TextBox();
            pictureBox3 = new PictureBox();
            PhoneField = new TextBox();
            pictureBox4 = new PictureBox();
            buttonRegister = new Button();
            EmailField = new TextBox();
            pictureBox2 = new PictureBox();
            loginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(auth_label);
            panel1.Controls.Add(PassField);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(PhoneField);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(EmailField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 658);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // auth_label
            // 
            auth_label.AutoSize = true;
            auth_label.Location = new Point(298, 516);
            auth_label.Name = "auth_label";
            auth_label.Size = new Size(162, 25);
            auth_label.TabIndex = 10;
            auth_label.Text = "Уже есть аккаунт? ";
            auth_label.Click += auth_label_Click;
            // 
            // PassField
            // 
            PassField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PassField.Location = new Point(259, 364);
            PassField.Name = "PassField";
            PassField.PlaceholderText = "Ведите Пароль";
            PassField.Size = new Size(268, 39);
            PassField.TabIndex = 9;
            PassField.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pass;
            pictureBox3.Location = new Point(164, 364);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(76, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // PhoneField
            // 
            PhoneField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneField.Location = new Point(259, 300);
            PhoneField.Multiline = true;
            PhoneField.Name = "PhoneField";
            PhoneField.PlaceholderText = "Ведите номер ";
            PhoneField.Size = new Size(268, 43);
            PhoneField.TabIndex = 7;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.tell;
            pictureBox4.Location = new Point(179, 300);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.DarkOrchid;
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(262, 440);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(265, 59);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "Войти";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // EmailField
            // 
            EmailField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmailField.Location = new Point(259, 232);
            EmailField.Name = "EmailField";
            EmailField.PlaceholderText = "Ведите E-mail";
            EmailField.Size = new Size(268, 39);
            EmailField.TabIndex = 4;
            EmailField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.E_mail;
            pictureBox2.Location = new Point(174, 232);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            loginField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginField.Location = new Point(259, 168);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.PlaceholderText = "Ведите логин";
            loginField.Size = new Size(268, 43);
            loginField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(182, 170);
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
            panel2.Size = new Size(804, 150);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkOrchid;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Impact", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(804, 150);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 658);
            Controls.Add(panel1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            FormClosing += RegisterForm_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonRegister;
        private TextBox EmailField;
        private PictureBox pictureBox2;
        private TextBox loginField;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private TextBox PassField;
        private PictureBox pictureBox3;
        private TextBox PhoneField;
        private PictureBox pictureBox4;
        private Label auth_label;
    }
}