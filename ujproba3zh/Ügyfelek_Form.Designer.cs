namespace ujproba3zh
{
    partial class Ügyfelek_Form
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
            components = new System.ComponentModel.Container();
            csomaglistb = new ListBox();
            nevlistb = new ListBox();
            dataGridView1 = new DataGridView();
            névDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            szülIdőDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telSzámDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bővíthetőEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            árDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            percekDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataJelenBindingSource = new BindingSource(components);
            csomagtxtb = new TextBox();
            hozzaadtxtb = new TextBox();
            hozzaadbttn = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataJelenBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // csomaglistb
            // 
            csomaglistb.FormattingEnabled = true;
            csomaglistb.ItemHeight = 15;
            csomaglistb.Location = new Point(30, 93);
            csomaglistb.Name = "csomaglistb";
            csomaglistb.Size = new Size(120, 349);
            csomaglistb.TabIndex = 0;
            csomaglistb.SelectedIndexChanged += csomaglistb_SelectedIndexChanged;
            // 
            // nevlistb
            // 
            nevlistb.FormattingEnabled = true;
            nevlistb.ItemHeight = 15;
            nevlistb.Location = new Point(200, 93);
            nevlistb.Name = "nevlistb";
            nevlistb.Size = new Size(120, 349);
            nevlistb.TabIndex = 1;
            nevlistb.SelectedIndexChanged += nevlistb_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { névDataGridViewTextBoxColumn, szülIdőDataGridViewTextBoxColumn, telSzámDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, bővíthetőEDataGridViewTextBoxColumn, árDataGridViewTextBoxColumn, percekDataGridViewTextBoxColumn });
            dataGridView1.DataSource = dataJelenBindingSource;
            dataGridView1.Location = new Point(374, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(604, 440);
            dataGridView1.TabIndex = 2;
            // 
            // névDataGridViewTextBoxColumn
            // 
            névDataGridViewTextBoxColumn.DataPropertyName = "Név";
            névDataGridViewTextBoxColumn.HeaderText = "Név";
            névDataGridViewTextBoxColumn.Name = "névDataGridViewTextBoxColumn";
            // 
            // szülIdőDataGridViewTextBoxColumn
            // 
            szülIdőDataGridViewTextBoxColumn.DataPropertyName = "SzülIdő";
            szülIdőDataGridViewTextBoxColumn.HeaderText = "SzülIdő";
            szülIdőDataGridViewTextBoxColumn.Name = "szülIdőDataGridViewTextBoxColumn";
            // 
            // telSzámDataGridViewTextBoxColumn
            // 
            telSzámDataGridViewTextBoxColumn.DataPropertyName = "TelSzám";
            telSzámDataGridViewTextBoxColumn.HeaderText = "TelSzám";
            telSzámDataGridViewTextBoxColumn.Name = "telSzámDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // bővíthetőEDataGridViewTextBoxColumn
            // 
            bővíthetőEDataGridViewTextBoxColumn.DataPropertyName = "BővíthetőE";
            bővíthetőEDataGridViewTextBoxColumn.HeaderText = "BővíthetőE";
            bővíthetőEDataGridViewTextBoxColumn.Name = "bővíthetőEDataGridViewTextBoxColumn";
            // 
            // árDataGridViewTextBoxColumn
            // 
            árDataGridViewTextBoxColumn.DataPropertyName = "Ár";
            árDataGridViewTextBoxColumn.HeaderText = "Ár";
            árDataGridViewTextBoxColumn.Name = "árDataGridViewTextBoxColumn";
            // 
            // percekDataGridViewTextBoxColumn
            // 
            percekDataGridViewTextBoxColumn.DataPropertyName = "Percek";
            percekDataGridViewTextBoxColumn.HeaderText = "Percek";
            percekDataGridViewTextBoxColumn.Name = "percekDataGridViewTextBoxColumn";
            // 
            // dataJelenBindingSource
            // 
            dataJelenBindingSource.DataSource = typeof(DataJelen);
            // 
            // csomagtxtb
            // 
            csomagtxtb.Location = new Point(30, 64);
            csomagtxtb.Name = "csomagtxtb";
            csomagtxtb.Size = new Size(120, 23);
            csomagtxtb.TabIndex = 3;
            csomagtxtb.TextChanged += csomagtxtb_TextChanged;
            // 
            // hozzaadtxtb
            // 
            hozzaadtxtb.Location = new Point(200, 481);
            hozzaadtxtb.Name = "hozzaadtxtb";
            hozzaadtxtb.Size = new Size(120, 23);
            hozzaadtxtb.TabIndex = 5;
            hozzaadtxtb.Validating += hozzaadtxtb_Validating;
            hozzaadtxtb.Validated += hozzaadtxtb_Validated;
            // 
            // hozzaadbttn
            // 
            hozzaadbttn.Location = new Point(30, 480);
            hozzaadbttn.Name = "hozzaadbttn";
            hozzaadbttn.Size = new Size(120, 23);
            hozzaadbttn.TabIndex = 6;
            hozzaadbttn.Text = "Hozzáadás";
            hozzaadbttn.UseVisualStyleBackColor = true;
            hozzaadbttn.Click += hozzaadbttn_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Ügyfelek_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 524);
            Controls.Add(hozzaadbttn);
            Controls.Add(hozzaadtxtb);
            Controls.Add(csomagtxtb);
            Controls.Add(dataGridView1);
            Controls.Add(nevlistb);
            Controls.Add(csomaglistb);
            Name = "Ügyfelek_Form";
            Text = "ügyfelek";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataJelenBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox csomaglistb;
        private ListBox nevlistb;
        private DataGridView dataGridView1;
        private TextBox csomagtxtb;
        private DataGridViewTextBoxColumn névDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szülIdőDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telSzámDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bővíthetőEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn árDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn percekDataGridViewTextBoxColumn;
        private BindingSource dataJelenBindingSource;
        private TextBox hozzaadtxtb;
        private Button hozzaadbttn;
        private ErrorProvider errorProvider1;
    }
}