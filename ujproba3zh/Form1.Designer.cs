﻿namespace ujproba3zh
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            ügyfelekbttn = new Button();
            label3 = new Label();
            label2 = new Label();
            tudnivalokbttn = new Button();
            excelbttn = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ügyfelekbttn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tudnivalokbttn);
            panel1.Controls.Add(excelbttn);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // ügyfelekbttn
            // 
            ügyfelekbttn.Location = new Point(12, 243);
            ügyfelekbttn.Name = "ügyfelekbttn";
            ügyfelekbttn.Size = new Size(75, 23);
            ügyfelekbttn.TabIndex = 10;
            ügyfelekbttn.Text = "Ügyfelek";
            ügyfelekbttn.UseVisualStyleBackColor = true;
            ügyfelekbttn.Click += ügyfelekbttn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 196);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 9;
            label3.Text = "Formok:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 8;
            label2.Text = "UserControlok:";
            // 
            // tudnivalokbttn
            // 
            tudnivalokbttn.Location = new Point(12, 214);
            tudnivalokbttn.Name = "tudnivalokbttn";
            tudnivalokbttn.Size = new Size(75, 23);
            tudnivalokbttn.TabIndex = 3;
            tudnivalokbttn.Text = "Tudnivalók";
            tudnivalokbttn.UseVisualStyleBackColor = true;
            // 
            // excelbttn
            // 
            excelbttn.Location = new Point(12, 147);
            excelbttn.Name = "excelbttn";
            excelbttn.Size = new Size(75, 23);
            excelbttn.TabIndex = 2;
            excelbttn.Text = "Excel";
            excelbttn.UseVisualStyleBackColor = true;
            excelbttn.Click += excelbttn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 118);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 89);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button tudnivalokbttn;
        private Button excelbttn;
        private Button button2;
        private Button button1;
        private Button ügyfelekbttn;
    }
}