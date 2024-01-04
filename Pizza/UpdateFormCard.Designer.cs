namespace Pizza
{
    partial class UpdateFormCard
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            textBoxImages = new TextBox();
            textBoxType = new TextBox();
            buttonChangeProduct = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 0;
            label1.Text = "Наименование";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 1;
            label2.Text = "Цена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 2;
            label3.Text = "Изображение";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 192);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 3;
            label4.Text = "Type-продуста";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(167, 35);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(246, 31);
            textBoxName.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(167, 86);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(246, 31);
            textBoxPrice.TabIndex = 5;
            // 
            // textBoxImages
            // 
            textBoxImages.Location = new Point(167, 134);
            textBoxImages.Name = "textBoxImages";
            textBoxImages.Size = new Size(246, 31);
            textBoxImages.TabIndex = 6;
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(167, 192);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(246, 31);
            textBoxType.TabIndex = 7;
            // 
            // buttonChangeProduct
            // 
            buttonChangeProduct.Location = new Point(106, 284);
            buttonChangeProduct.Name = "buttonChangeProduct";
            buttonChangeProduct.Size = new Size(201, 34);
            buttonChangeProduct.TabIndex = 8;
            buttonChangeProduct.Text = "Изменить";
            buttonChangeProduct.UseVisualStyleBackColor = true;
            buttonChangeProduct.Click += buttonChangeProduct_Click;
            // 
            // UpdateFormCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 422);
            Controls.Add(buttonChangeProduct);
            Controls.Add(textBoxType);
            Controls.Add(textBoxImages);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateFormCard";
            Text = "UpdateFormCard";
            Load += UpdateFormCard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private TextBox textBoxImages;
        private TextBox textBoxType;
        private Button buttonChangeProduct;
    }
}