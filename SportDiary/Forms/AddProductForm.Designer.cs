
namespace SportDiary.Forms
{
    partial class AddProductForm
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
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.labelCalories = new System.Windows.Forms.Label();
            this.ButtonAcceptNewProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownProteins = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFats = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCarbohydrates = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCalories = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProteins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarbohydrates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCalories)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(120, 20);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(148, 22);
            this.textBoxProductName.TabIndex = 0;
            // 
            // LabelProductName
            // 
            this.LabelProductName.AutoSize = true;
            this.LabelProductName.Location = new System.Drawing.Point(12, 20);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(72, 17);
            this.LabelProductName.TabIndex = 2;
            this.LabelProductName.Text = "Название";
            // 
            // labelCalories
            // 
            this.labelCalories.AutoSize = true;
            this.labelCalories.Location = new System.Drawing.Point(12, 56);
            this.labelCalories.Name = "labelCalories";
            this.labelCalories.Size = new System.Drawing.Size(133, 51);
            this.labelCalories.TabIndex = 3;
            this.labelCalories.Text = "Пищевая ценность\r\n(на кал./100гр.)\r\n\r\n";
            // 
            // ButtonAcceptNewProduct
            // 
            this.ButtonAcceptNewProduct.Location = new System.Drawing.Point(154, 230);
            this.ButtonAcceptNewProduct.Name = "ButtonAcceptNewProduct";
            this.ButtonAcceptNewProduct.Size = new System.Drawing.Size(93, 36);
            this.ButtonAcceptNewProduct.TabIndex = 4;
            this.ButtonAcceptNewProduct.Text = "Добавить";
            this.ButtonAcceptNewProduct.UseVisualStyleBackColor = true;
            this.ButtonAcceptNewProduct.Click += new System.EventHandler(this.ButtonAcceptNewProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Белки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Жиры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Углеводы";
            // 
            // numericUpDownProteins
            // 
            this.numericUpDownProteins.Location = new System.Drawing.Point(154, 146);
            this.numericUpDownProteins.Name = "numericUpDownProteins";
            this.numericUpDownProteins.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownProteins.TabIndex = 11;
            // 
            // numericUpDownFats
            // 
            this.numericUpDownFats.Location = new System.Drawing.Point(154, 174);
            this.numericUpDownFats.Name = "numericUpDownFats";
            this.numericUpDownFats.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownFats.TabIndex = 12;
            // 
            // numericUpDownCarbohydrates
            // 
            this.numericUpDownCarbohydrates.Location = new System.Drawing.Point(154, 202);
            this.numericUpDownCarbohydrates.Name = "numericUpDownCarbohydrates";
            this.numericUpDownCarbohydrates.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCarbohydrates.TabIndex = 13;
            // 
            // numericUpDownCalories
            // 
            this.numericUpDownCalories.Location = new System.Drawing.Point(154, 66);
            this.numericUpDownCalories.Name = "numericUpDownCalories";
            this.numericUpDownCalories.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCalories.TabIndex = 16;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 297);
            this.Controls.Add(this.numericUpDownCalories);
            this.Controls.Add(this.numericUpDownCarbohydrates);
            this.Controls.Add(this.numericUpDownFats);
            this.Controls.Add(this.numericUpDownProteins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonAcceptNewProduct);
            this.Controls.Add(this.labelCalories);
            this.Controls.Add(this.LabelProductName);
            this.Controls.Add(this.textBoxProductName);
            this.Name = "AddProductForm";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProteins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarbohydrates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCalories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label LabelProductName;
        private System.Windows.Forms.Label labelCalories;
        private System.Windows.Forms.Button ButtonAcceptNewProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownProteins;
        private System.Windows.Forms.NumericUpDown numericUpDownFats;
        private System.Windows.Forms.NumericUpDown numericUpDownCarbohydrates;
        private System.Windows.Forms.NumericUpDown numericUpDownCalories;
    }
}