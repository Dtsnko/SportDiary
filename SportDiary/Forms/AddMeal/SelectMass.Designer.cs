
namespace SportDiary.Forms.AddMeal
{
    partial class SelectMass
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
            this.LabelSelectMass = new System.Windows.Forms.Label();
            this.UpDownMass = new System.Windows.Forms.NumericUpDown();
            this.AcceptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMass)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelSelectMass
            // 
            this.LabelSelectMass.AutoSize = true;
            this.LabelSelectMass.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelSelectMass.Location = new System.Drawing.Point(0, 0);
            this.LabelSelectMass.Name = "LabelSelectMass";
            this.LabelSelectMass.Size = new System.Drawing.Size(171, 17);
            this.LabelSelectMass.TabIndex = 0;
            this.LabelSelectMass.Text = "Укажите массу продукта";
            // 
            // UpDownMass
            // 
            this.UpDownMass.Location = new System.Drawing.Point(84, 53);
            this.UpDownMass.Name = "UpDownMass";
            this.UpDownMass.Size = new System.Drawing.Size(120, 22);
            this.UpDownMass.TabIndex = 1;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(97, 94);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 2;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // SelectMass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 129);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.UpDownMass);
            this.Controls.Add(this.LabelSelectMass);
            this.Name = "SelectMass";
            this.Text = "SelectMass";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSelectMass;
        private System.Windows.Forms.NumericUpDown UpDownMass;
        private System.Windows.Forms.Button AcceptButton;
    }
}