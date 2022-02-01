namespace VKLab1
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.button1 = new System.Windows.Forms.Button();
            this.welcomeLettering = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxForTheFirst = new System.Windows.Forms.TextBox();
            this.inputTheFirstString = new System.Windows.Forms.Label();
            this.inputTheSecondString = new System.Windows.Forms.Label();
            this.textBoxForTheSecond = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // welcomeLettering
            // 
            resources.ApplyResources(this.welcomeLettering, "welcomeLettering");
            this.welcomeLettering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(196)))), ((int)(((byte)(12)))));
            this.welcomeLettering.Name = "welcomeLettering";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.welcomeLettering);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // textBoxForTheFirst
            // 
            resources.ApplyResources(this.textBoxForTheFirst, "textBoxForTheFirst");
            this.textBoxForTheFirst.Name = "textBoxForTheFirst";
            this.textBoxForTheFirst.Enter += new System.EventHandler(this.textBoxForTheFirst_Enter);
            this.textBoxForTheFirst.Leave += new System.EventHandler(this.textBoxForTheFirst_Leave);
            // 
            // inputTheFirstString
            // 
            resources.ApplyResources(this.inputTheFirstString, "inputTheFirstString");
            this.inputTheFirstString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.inputTheFirstString.Name = "inputTheFirstString";
            // 
            // inputTheSecondString
            // 
            resources.ApplyResources(this.inputTheSecondString, "inputTheSecondString");
            this.inputTheSecondString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.inputTheSecondString.Name = "inputTheSecondString";
            // 
            // textBoxForTheSecond
            // 
            resources.ApplyResources(this.textBoxForTheSecond, "textBoxForTheSecond");
            this.textBoxForTheSecond.Name = "textBoxForTheSecond";
            // 
            // Calculator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.textBoxForTheSecond);
            this.Controls.Add(this.inputTheSecondString);
            this.Controls.Add(this.inputTheFirstString);
            this.Controls.Add(this.textBoxForTheFirst);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label welcomeLettering;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxForTheFirst;
        private System.Windows.Forms.Label inputTheFirstString;
        private System.Windows.Forms.Label inputTheSecondString;
        private System.Windows.Forms.TextBox textBoxForTheSecond;
    }
}