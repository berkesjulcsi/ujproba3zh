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
    }
}