﻿namespace PS_ZD_Windows_Form_
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.T1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Folder_path = new System.Windows.Forms.Label();
            this.text_path = new System.Windows.Forms.TextBox();
            this.folder_choose = new System.Windows.Forms.Button();
            this.Listbox = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "DateTime";
            // 
            // T1
            // 
            this.T1.Interval = 1000;
            this.T1.Tick += new System.EventHandler(this.T1_Tick);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // Folder_path
            // 
            this.Folder_path.AutoSize = true;
            this.Folder_path.Location = new System.Drawing.Point(12, 63);
            this.Folder_path.Name = "Folder_path";
            this.Folder_path.Size = new System.Drawing.Size(60, 13);
            this.Folder_path.TabIndex = 1;
            this.Folder_path.Text = "Folder path";
            // 
            // text_path
            // 
            this.text_path.Location = new System.Drawing.Point(78, 60);
            this.text_path.Name = "text_path";
            this.text_path.Size = new System.Drawing.Size(259, 20);
            this.text_path.TabIndex = 2;
            this.text_path.Text = "D:\\";
            // 
            // folder_choose
            // 
            this.folder_choose.Location = new System.Drawing.Point(343, 59);
            this.folder_choose.Name = "folder_choose";
            this.folder_choose.Size = new System.Drawing.Size(71, 20);
            this.folder_choose.TabIndex = 3;
            this.folder_choose.Text = "Choose";
            this.folder_choose.UseVisualStyleBackColor = true;
            this.folder_choose.Click += new System.EventHandler(this.button1_Click);
            // 
            // Listbox
            // 
            this.Listbox.FormattingEnabled = true;
            this.Listbox.Location = new System.Drawing.Point(12, 86);
            this.Listbox.Name = "Listbox";
            this.Listbox.Size = new System.Drawing.Size(402, 199);
            this.Listbox.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 303);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(402, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 348);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Listbox);
            this.Controls.Add(this.folder_choose);
            this.Controls.Add(this.text_path);
            this.Controls.Add(this.Folder_path);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer T1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label Folder_path;
        private System.Windows.Forms.TextBox text_path;
        private System.Windows.Forms.Button folder_choose;
        private System.Windows.Forms.ListBox Listbox;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

