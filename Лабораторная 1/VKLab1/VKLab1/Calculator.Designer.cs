﻿namespace VKLab1
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
            this.buttonConcat = new System.Windows.Forms.Button();
            this.welcomeLettering = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxForTheFirst = new System.Windows.Forms.TextBox();
            this.inputTheFirstString = new System.Windows.Forms.Label();
            this.inputTheSecondString = new System.Windows.Forms.Label();
            this.textBoxForTheSecond = new System.Windows.Forms.TextBox();
            this.helpingText = new System.Windows.Forms.Label();
            this.buttonReplacement = new System.Windows.Forms.Button();
            this.buttonCut = new System.Windows.Forms.Button();
            this.buttonGetSymbol = new System.Windows.Forms.Button();
            this.buttonLength = new System.Windows.Forms.Button();
            this.buttonDoubleVowels = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.Label();
            this.textBoxResult1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConcat
            // 
            this.buttonConcat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(196)))), ((int)(((byte)(12)))));
            resources.ApplyResources(this.buttonConcat, "buttonConcat");
            this.buttonConcat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.buttonConcat.Name = "buttonConcat";
            this.buttonConcat.UseVisualStyleBackColor = false;
            this.buttonConcat.Click += new System.EventHandler(this.buttonConcat_Click);
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
            this.textBoxForTheFirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.textBoxForTheSecond.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxForTheSecond.Name = "textBoxForTheSecond";
            this.textBoxForTheSecond.Enter += new System.EventHandler(this.textBoxForTheSecond_Enter);
            this.textBoxForTheSecond.Leave += new System.EventHandler(this.textBoxForTheSecond_Leave);
            // 
            // helpingText
            // 
            resources.ApplyResources(this.helpingText, "helpingText");
            this.helpingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.helpingText.Name = "helpingText";
            // 
            // buttonReplacement
            // 
            this.buttonReplacement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(196)))), ((int)(((byte)(12)))));
            resources.ApplyResources(this.buttonReplacement, "buttonReplacement");
            this.buttonReplacement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.buttonReplacement.Name = "buttonReplacement";
            this.buttonReplacement.UseVisualStyleBackColor = false;
            this.buttonReplacement.Click += new System.EventHandler(this.buttonReplacement_Click);
            // 
            // buttonCut
            // 
            this.buttonCut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(196)))), ((int)(((byte)(12)))));
            resources.ApplyResources(this.buttonCut, "buttonCut");
            this.buttonCut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.UseVisualStyleBackColor = false;
            // 
            // buttonGetSymbol
            // 
            this.buttonGetSymbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(196)))), ((int)(((byte)(12)))));
            resources.ApplyResources(this.buttonGetSymbol, "buttonGetSymbol");
            this.buttonGetSymbol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.buttonGetSymbol.Name = "buttonGetSymbol";
            this.buttonGetSymbol.UseVisualStyleBackColor = false;
            // 
            // buttonLength
            // 
            this.buttonLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(196)))), ((int)(((byte)(12)))));
            resources.ApplyResources(this.buttonLength, "buttonLength");
            this.buttonLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.buttonLength.Name = "buttonLength";
            this.buttonLength.UseVisualStyleBackColor = false;
            // 
            // buttonDoubleVowels
            // 
            this.buttonDoubleVowels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(196)))), ((int)(((byte)(12)))));
            resources.ApplyResources(this.buttonDoubleVowels, "buttonDoubleVowels");
            this.buttonDoubleVowels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.buttonDoubleVowels.Name = "buttonDoubleVowels";
            this.buttonDoubleVowels.UseVisualStyleBackColor = false;
            // 
            // resultText
            // 
            resources.ApplyResources(this.resultText, "resultText");
            this.resultText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.resultText.Name = "resultText";
            // 
            // textBoxResult1
            // 
            resources.ApplyResources(this.textBoxResult1, "textBoxResult1");
            this.textBoxResult1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxResult1.Name = "textBoxResult1";
            // 
            // Calculator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.textBoxResult1);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.buttonDoubleVowels);
            this.Controls.Add(this.buttonLength);
            this.Controls.Add(this.buttonGetSymbol);
            this.Controls.Add(this.buttonCut);
            this.Controls.Add(this.buttonReplacement);
            this.Controls.Add(this.helpingText);
            this.Controls.Add(this.textBoxForTheSecond);
            this.Controls.Add(this.inputTheSecondString);
            this.Controls.Add(this.inputTheFirstString);
            this.Controls.Add(this.textBoxForTheFirst);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonConcat);
            this.Name = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConcat;
        private System.Windows.Forms.Label welcomeLettering;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxForTheFirst;
        private System.Windows.Forms.Label inputTheFirstString;
        private System.Windows.Forms.Label inputTheSecondString;
        private System.Windows.Forms.TextBox textBoxForTheSecond;
        private System.Windows.Forms.Label helpingText;
        private System.Windows.Forms.Button buttonReplacement;
        private System.Windows.Forms.Button buttonCut;
        private System.Windows.Forms.Button buttonGetSymbol;
        private System.Windows.Forms.Button buttonLength;
        private System.Windows.Forms.Button buttonDoubleVowels;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.TextBox textBoxResult1;
    }
}