
namespace SportDiary.Forms
{
    partial class EditProductForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.UpDownCalories = new System.Windows.Forms.NumericUpDown();
            this.UpDownProteins = new System.Windows.Forms.NumericUpDown();
            this.UpDownFats = new System.Windows.Forms.NumericUpDown();
            this.UpDownCarbohydrates = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownProteins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownFats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCarbohydrates)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Калории";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Белки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Жири";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Углеводы";
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(96, 200);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(94, 23);
            this.AcceptButton.TabIndex = 8;
            this.AcceptButton.Text = "Применить";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // UpDownCalories
            // 
            this.UpDownCalories.Location = new System.Drawing.Point(141, 20);
            this.UpDownCalories.Name = "UpDownCalories";
            this.UpDownCalories.Size = new System.Drawing.Size(120, 22);
            this.UpDownCalories.TabIndex = 9;
            // 
            // UpDownProteins
            // 
            this.UpDownProteins.Location = new System.Drawing.Point(141, 65);
            this.UpDownProteins.Name = "UpDownProteins";
            this.UpDownProteins.Size = new System.Drawing.Size(120, 22);
            this.UpDownProteins.TabIndex = 10;
            // 
            // UpDownFats
            // 
            this.UpDownFats.Location = new System.Drawing.Point(141, 108);
            this.UpDownFats.Name = "UpDownFats";
            this.UpDownFats.Size = new System.Drawing.Size(120, 22);
            this.UpDownFats.TabIndex = 11;
            // 
            // UpDownCarbohydrates
            // 
            this.UpDownCarbohydrates.Location = new System.Drawing.Point(141, 155);
            this.UpDownCarbohydrates.Name = "UpDownCarbohydrates";
            this.UpDownCarbohydrates.Size = new System.Drawing.Size(120, 22);
            this.UpDownCarbohydrates.TabIndex = 12;
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 235);
            this.Controls.Add(this.UpDownCarbohydrates);
            this.Controls.Add(this.UpDownFats);
            this.Controls.Add(this.UpDownProteins);
            this.Controls.Add(this.UpDownCalories);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditProductForm";
            this.Text = "EditProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCalories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownProteins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownFats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCarbohydrates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.NumericUpDown UpDownCalories;
        private System.Windows.Forms.NumericUpDown UpDownProteins;
        private System.Windows.Forms.NumericUpDown UpDownFats;
        private System.Windows.Forms.NumericUpDown UpDownCarbohydrates;
    }
}