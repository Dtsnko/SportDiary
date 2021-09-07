
namespace SportDiary.Forms
{
    partial class AddMealForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ProductsToAdd = new System.Windows.Forms.ListBox();
            this.AddedProducts = new System.Windows.Forms.ListBox();
            this.NumericUpDownMass = new System.Windows.Forms.NumericUpDown();
            this.AddMassButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMass)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(248, 142);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(66, 37);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = ">";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(375, 344);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(145, 63);
            this.AcceptButton.TabIndex = 4;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(248, 185);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(66, 37);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "<";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // ProductsToAdd
            // 
            this.ProductsToAdd.FormattingEnabled = true;
            this.ProductsToAdd.ItemHeight = 16;
            this.ProductsToAdd.Location = new System.Drawing.Point(21, 12);
            this.ProductsToAdd.Name = "ProductsToAdd";
            this.ProductsToAdd.Size = new System.Drawing.Size(221, 276);
            this.ProductsToAdd.TabIndex = 6;
            // 
            // AddedProducts
            // 
            this.AddedProducts.FormattingEnabled = true;
            this.AddedProducts.ItemHeight = 16;
            this.AddedProducts.Location = new System.Drawing.Point(321, 12);
            this.AddedProducts.Name = "AddedProducts";
            this.AddedProducts.Size = new System.Drawing.Size(221, 276);
            this.AddedProducts.TabIndex = 7;
            // 
            // NumericUpDownMass
            // 
            this.NumericUpDownMass.Location = new System.Drawing.Point(64, 323);
            this.NumericUpDownMass.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericUpDownMass.Name = "NumericUpDownMass";
            this.NumericUpDownMass.Size = new System.Drawing.Size(120, 22);
            this.NumericUpDownMass.TabIndex = 8;
            this.NumericUpDownMass.Visible = false;
            // 
            // AddMassButton
            // 
            this.AddMassButton.Location = new System.Drawing.Point(190, 322);
            this.AddMassButton.Name = "AddMassButton";
            this.AddMassButton.Size = new System.Drawing.Size(99, 23);
            this.AddMassButton.TabIndex = 9;
            this.AddMassButton.Text = "Добавить";
            this.AddMassButton.UseVisualStyleBackColor = true;
            this.AddMassButton.Visible = false;
            this.AddMassButton.Click += new System.EventHandler(this.AddMassButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Укажите массу";
            this.label1.Visible = false;
            // 
            // AddMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddMassButton);
            this.Controls.Add(this.NumericUpDownMass);
            this.Controls.Add(this.AddedProducts);
            this.Controls.Add(this.ProductsToAdd);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.AddButton);
            this.Name = "AddMealForm";
            this.Text = "AddMeat";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ListBox ProductsToAdd;
        private System.Windows.Forms.ListBox AddedProducts;
        private System.Windows.Forms.NumericUpDown NumericUpDownMass;
        private System.Windows.Forms.Button AddMassButton;
        private System.Windows.Forms.Label label1;
    }
}