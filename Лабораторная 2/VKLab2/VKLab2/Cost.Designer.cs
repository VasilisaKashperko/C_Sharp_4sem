namespace VKLab2
{
    partial class Cost
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
            this.labelInfoCost = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInfoCost
            // 
            this.labelInfoCost.AutoSize = true;
            this.labelInfoCost.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoCost.Location = new System.Drawing.Point(67, 24);
            this.labelInfoCost.Name = "labelInfoCost";
            this.labelInfoCost.Size = new System.Drawing.Size(390, 27);
            this.labelInfoCost.TabIndex = 0;
            this.labelInfoCost.Text = "Цена заданной квартиры составляет:";
            // 
            // labelCost
            // 
            this.labelCost.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCost.Location = new System.Drawing.Point(90, 66);
            this.labelCost.Name = "labelCost";
            this.labelCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCost.Size = new System.Drawing.Size(326, 26);
            this.labelCost.TabIndex = 1;
            this.labelCost.Text = "Вы не ввели все данные";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Cost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(546, 111);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelInfoCost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Cost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Итоговая стоимость квартиры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfoCost;
        private System.Windows.Forms.Label labelCost;
    }
}