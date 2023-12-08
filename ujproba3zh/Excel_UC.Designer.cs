namespace ujproba3zh
{
    partial class Excel_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ügyfelekbttn = new Button();
            label3 = new Label();
            label2 = new Label();
            tudnivalokbttn = new Button();
            excelbttn = new Button();
            button2 = new Button();
            button1 = new Button();
            excelgen = new Button();
            diagramgen = new Button();
            SuspendLayout();
            // 
            // ügyfelekbttn
            // 
            ügyfelekbttn.Location = new Point(0, 235);
            ügyfelekbttn.Name = "ügyfelekbttn";
            ügyfelekbttn.Size = new Size(75, 26);
            ügyfelekbttn.TabIndex = 17;
            ügyfelekbttn.Text = "Ügyfelek";
            ügyfelekbttn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 191);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 16;
            label3.Text = "Formok:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 66);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 15;
            label2.Text = "UserControlok:";
            // 
            // tudnivalokbttn
            // 
            tudnivalokbttn.Location = new Point(0, 206);
            tudnivalokbttn.Name = "tudnivalokbttn";
            tudnivalokbttn.Size = new Size(75, 26);
            tudnivalokbttn.TabIndex = 14;
            tudnivalokbttn.Text = "Tudnivalók";
            tudnivalokbttn.UseVisualStyleBackColor = true;
            // 
            // excelbttn
            // 
            excelbttn.Location = new Point(0, 139);
            excelbttn.Name = "excelbttn";
            excelbttn.Size = new Size(75, 26);
            excelbttn.TabIndex = 13;
            excelbttn.Text = "Excel";
            excelbttn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(0, 110);
            button2.Name = "button2";
            button2.Size = new Size(75, 26);
            button2.TabIndex = 12;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 81);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // excelgen
            // 
            excelgen.Location = new Point(180, 139);
            excelgen.Name = "excelgen";
            excelgen.Size = new Size(150, 90);
            excelgen.TabIndex = 18;
            excelgen.Text = "ExcelGen";
            excelgen.UseVisualStyleBackColor = true;
            excelgen.Click += excelgen_Click;
            // 
            // diagramgen
            // 
            diagramgen.Location = new Point(371, 139);
            diagramgen.Name = "diagramgen";
            diagramgen.Size = new Size(147, 90);
            diagramgen.TabIndex = 19;
            diagramgen.Text = "DiagramGen";
            diagramgen.UseVisualStyleBackColor = true;
            diagramgen.Click += diagramgen_Click;
            // 
            // Excel_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(diagramgen);
            Controls.Add(excelgen);
            Controls.Add(ügyfelekbttn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tudnivalokbttn);
            Controls.Add(excelbttn);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Excel_UC";
            Size = new Size(607, 387);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ügyfelekbttn;
        private Label label3;
        private Label label2;
        private Button tudnivalokbttn;
        private Button excelbttn;
        private Button button2;
        private Button button1;
        private Button excelgen;
        private Button diagramgen;
    }
}
