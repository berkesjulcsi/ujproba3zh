namespace ujproba3zh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void �gyfelekbttn_Click(object sender, EventArgs e)
        {
            �gyfelek_Form �gyfelek_Form = new �gyfelek_Form();
            �gyfelek_Form.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kil�p�s meger�s�t�se
            DialogResult result = MessageBox.Show("Biztosan kil�p?", "Kil�p�s", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                // Kil�p�s
                e.Cancel = true;
            }
        }

        private void excelbttn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Excel_UC excel_UC = new Excel_UC();
            panel1.Controls.Add(excel_UC);
            excel_UC.Dock = DockStyle.Fill;

        }
    }
}