
namespace SportDiary
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddNewMeat = new System.Windows.Forms.Button();
            this.EditMeat = new System.Windows.Forms.Button();
            this.AddNewProduct = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.GetInfographics = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddNewMeat
            // 
            this.AddNewMeat.Location = new System.Drawing.Point(37, 37);
            this.AddNewMeat.Name = "AddNewMeat";
            this.AddNewMeat.Size = new System.Drawing.Size(181, 92);
            this.AddNewMeat.TabIndex = 0;
            this.AddNewMeat.Text = "Добавить новый прием пищи";
            this.AddNewMeat.UseVisualStyleBackColor = true;
            this.AddNewMeat.Click += new System.EventHandler(this.AddNewMeat_Click);
            // 
            // EditMeat
            // 
            this.EditMeat.Location = new System.Drawing.Point(224, 37);
            this.EditMeat.Name = "EditMeat";
            this.EditMeat.Size = new System.Drawing.Size(181, 92);
            this.EditMeat.TabIndex = 1;
            this.EditMeat.Text = "Редактировать старый прием пищи";
            this.EditMeat.UseVisualStyleBackColor = true;
            // 
            // AddNewProduct
            // 
            this.AddNewProduct.Location = new System.Drawing.Point(37, 181);
            this.AddNewProduct.Name = "AddNewProduct";
            this.AddNewProduct.Size = new System.Drawing.Size(181, 92);
            this.AddNewProduct.TabIndex = 2;
            this.AddNewProduct.Text = "Добавить новый продукт";
            this.AddNewProduct.UseVisualStyleBackColor = true;
            this.AddNewProduct.Click += new System.EventHandler(this.AddNewProduct_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Location = new System.Drawing.Point(224, 181);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(181, 92);
            this.DeleteProduct.TabIndex = 3;
            this.DeleteProduct.Text = "Удалить продукт";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // GetInfographics
            // 
            this.GetInfographics.Location = new System.Drawing.Point(37, 343);
            this.GetInfographics.Name = "GetInfographics";
            this.GetInfographics.Size = new System.Drawing.Size(181, 92);
            this.GetInfographics.TabIndex = 4;
            this.GetInfographics.Text = "Вывести инфографику";
            this.GetInfographics.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Завтрак";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Обед";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ужин";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(592, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(270, 116);
            this.listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(592, 239);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(270, 116);
            this.listBox2.TabIndex = 9;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(592, 410);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(270, 116);
            this.listBox3.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 547);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetInfographics);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.AddNewProduct);
            this.Controls.Add(this.EditMeat);
            this.Controls.Add(this.AddNewMeat);
            this.Name = "Main";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewMeat;
        private System.Windows.Forms.Button EditMeat;
        private System.Windows.Forms.Button AddNewProduct;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button GetInfographics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}

