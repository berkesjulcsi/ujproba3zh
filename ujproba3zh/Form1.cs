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

        private void csomagokbttn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Csomagok_UC csomagok_UC = new Csomagok_UC();
            panel1.Controls.Add(csomagok_UC);
            csomagok_UC.Dock = DockStyle.Fill;
        }

        private void �zletekbttn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            �zletek_UC �zletek_UC= new �zletek_UC();
            panel1.Controls.Add(�zletek_UC);
            �zletek_UC.Dock = DockStyle.Fill;
        }
    }
}