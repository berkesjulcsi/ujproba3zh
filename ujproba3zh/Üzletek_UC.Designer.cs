namespace ujproba3zh
{
    partial class Üzletek_UC
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
            uzletszurtlistb = new ListBox();
            üzletszurtxtb = new TextBox();
            helytxtb = new TextBox();
            uzletvtxtb = new TextBox();
            tavalyivtxtb = new TextBox();
            SuspendLayout();
            // 
            // uzletszurtlistb
            // 
            uzletszurtlistb.FormattingEnabled = true;
            uzletszurtlistb.ItemHeight = 15;
            uzletszurtlistb.Location = new Point(464, 45);
            uzletszurtlistb.Name = "uzletszurtlistb";
            uzletszurtlistb.Size = new Size(120, 274);
            uzletszurtlistb.TabIndex = 0;
            uzletszurtlistb.SelectedIndexChanged += uzletszurtlistb_SelectedIndexChanged;
            // 
            // üzletszurtxtb
            // 
            üzletszurtxtb.Location = new Point(464, 325);
            üzletszurtxtb.Name = "üzletszurtxtb";
            üzletszurtxtb.Size = new Size(120, 23);
            üzletszurtxtb.TabIndex = 3;
            üzletszurtxtb.TextChanged += üzletszurtxtb_TextChanged;
            // 
            // helytxtb
            // 
            helytxtb.Location = new Point(337, 45);
            helytxtb.Name = "helytxtb";
            helytxtb.Size = new Size(100, 23);
            helytxtb.TabIndex = 4;
            // 
            // uzletvtxtb
            // 
            uzletvtxtb.Location = new Point(337, 93);
            uzletvtxtb.Name = "uzletvtxtb";
            uzletvtxtb.Size = new Size(100, 23);
            uzletvtxtb.TabIndex = 5;
            // 
            // tavalyivtxtb
            // 
            tavalyivtxtb.Location = new Point(337, 139);
            tavalyivtxtb.Name = "tavalyivtxtb";
            tavalyivtxtb.Size = new Size(100, 23);
            tavalyivtxtb.TabIndex = 6;
            // 
            // Üzletek_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tavalyivtxtb);
            Controls.Add(uzletvtxtb);
            Controls.Add(helytxtb);
            Controls.Add(üzletszurtxtb);
            Controls.Add(uzletszurtlistb);
            Name = "Üzletek_UC";
            Size = new Size(623, 435);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox uzletszurtlistb;
        private TextBox üzletszurtxtb;
        private TextBox helytxtb;
        private TextBox uzletvtxtb;
        private TextBox tavalyivtxtb;
    }
}
