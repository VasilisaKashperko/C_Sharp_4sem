namespace VKLab2
{
    partial class Sorting
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
            this.listBoxSorting = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxSorting
            // 
            this.listBoxSorting.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSorting.FormattingEnabled = true;
            this.listBoxSorting.HorizontalScrollbar = true;
            this.listBoxSorting.ItemHeight = 22;
            this.listBoxSorting.Location = new System.Drawing.Point(38, 29);
            this.listBoxSorting.Name = "listBoxSorting";
            this.listBoxSorting.Size = new System.Drawing.Size(682, 224);
            this.listBoxSorting.TabIndex = 0;
            // 
            // Sorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(757, 277);
            this.Controls.Add(this.listBoxSorting);
            this.Name = "Sorting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировка";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listBoxSorting;
    }
}