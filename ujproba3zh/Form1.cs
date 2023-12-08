namespace ujproba3zh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ügyfelekbttn_Click(object sender, EventArgs e)
        {
            Ügyfelek_Form ügyfelek_Form = new Ügyfelek_Form();
            ügyfelek_Form.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kilépés megerõsítése
            DialogResult result = MessageBox.Show("Biztosan kilép?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                // Kilépés
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

        private void üzletekbttn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Üzletek_UC üzletek_UC= new Üzletek_UC();
            panel1.Controls.Add(üzletek_UC);
            üzletek_UC.Dock = DockStyle.Fill;
        }
    }
}