
namespace SportDiary.Forms
{
    partial class DeleteProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelIdOfProduct = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.listBoxOfProducts = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // labelIdOfProduct
            // 
            this.labelIdOfProduct.AutoSize = true;
            this.labelIdOfProduct.Location = new System.Drawing.Point(31, 9);
            this.labelIdOfProduct.Name = "labelIdOfProduct";
            this.labelIdOfProduct.Size = new System.Drawing.Size(131, 17);
            this.labelIdOfProduct.TabIndex = 1;
            this.labelIdOfProduct.Text = "Выберите продукт";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(93, 282);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(116, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // listBoxOfProducts
            // 
            this.listBoxOfProducts.FormattingEnabled = true;
            this.listBoxOfProducts.Location = new System.Drawing.Point(34, 29);
            this.listBoxOfProducts.Name = "listBoxOfProducts";
            this.listBoxOfProducts.Size = new System.Drawing.Size(253, 225);
            this.listBoxOfProducts.TabIndex = 4;
            // 
            // DeleteProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 317);
            this.Controls.Add(this.listBoxOfProducts);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.labelIdOfProduct);
            this.Controls.Add(this.label1);
            this.Name = "DeleteProductForm";
            this.Text = "DeleteProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIdOfProduct;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.CheckedListBox listBoxOfProducts;
    }
}