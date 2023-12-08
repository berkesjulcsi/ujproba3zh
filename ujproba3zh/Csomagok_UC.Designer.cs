namespace ujproba3zh
{
    partial class Csomagok_UC
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
            csomagoklistb = new ListBox();
            időttxtb = new TextBox();
            fizütxtb = new TextBox();
            ártxtb = new TextBox();
            csomgaszurtxtb = new TextBox();
            SuspendLayout();
            // 
            // csomagoklistb
            // 
            csomagoklistb.FormattingEnabled = true;
            csomagoklistb.ItemHeight = 15;
            csomagoklistb.Location = new Point(434, 58);
            csomagoklistb.Name = "csomagoklistb";
            csomagoklistb.Size = new Size(133, 94);
            csomagoklistb.TabIndex = 0;
            csomagoklistb.SelectedIndexChanged += csomagoklistb_SelectedIndexChanged;
            // 
            // időttxtb
            // 
            időttxtb.Location = new Point(303, 58);
            időttxtb.Name = "időttxtb";
            időttxtb.Size = new Size(100, 23);
            időttxtb.TabIndex = 1;
            // 
            // fizütxtb
            // 
            fizütxtb.Location = new Point(197, 58);
            fizütxtb.Name = "fizütxtb";
            fizütxtb.Size = new Size(100, 23);
            fizütxtb.TabIndex = 2;
            // 
            // ártxtb
            // 
            ártxtb.Location = new Point(91, 58);
            ártxtb.Name = "ártxtb";
            ártxtb.Size = new Size(100, 23);
            ártxtb.TabIndex = 3;
            // 
            // csomgaszurtxtb
            // 
            csomgaszurtxtb.Location = new Point(434, 19);
            csomgaszurtxtb.Name = "csomgaszurtxtb";
            csomgaszurtxtb.Size = new Size(133, 23);
            csomgaszurtxtb.TabIndex = 4;
            csomgaszurtxtb.TextChanged += csomgaszurtxtb_TextChanged;
            // 
            // Csomagok_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(csomgaszurtxtb);
            Controls.Add(ártxtb);
            Controls.Add(fizütxtb);
            Controls.Add(időttxtb);
            Controls.Add(csomagoklistb);
            Name = "Csomagok_UC";
            Size = new Size(602, 423);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox csomagoklistb;
        private TextBox időttxtb;
        private TextBox fizütxtb;
        private TextBox ártxtb;
        private TextBox csomgaszurtxtb;
    }
}
