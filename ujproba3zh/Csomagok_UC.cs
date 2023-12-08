using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ujproba3zh.Models;

namespace ujproba3zh
{
    public partial class Csomagok_UC : UserControl
    {
        TelefonContext telefonContext = new TelefonContext();
        public Csomagok_UC()
        {
            InitializeComponent();
            csomagoklistb.DisplayMember = "CsomagNév";
            SzűrésCsomag();
        }
        private void SzűrésCsomag()
        {
            csomagoklistb.DataSource =
            (
            from s in telefonContext.Csomagoks
            where s.CsomagNév.Contains(csomgaszurtxtb.Text)
            select s
            ).ToList();

        }

        private void csomagoklistb_SelectedIndexChanged(object sender, EventArgs e)
        {
            időttxtb.Text = ((Csomagok)csomagoklistb.SelectedItem).Időtartam.ToString();
            fizütxtb.Text = ((Csomagok)csomagoklistb.SelectedItem).FizÜtemezés.ToString();
            ártxtb.Text = ((Csomagok)csomagoklistb.SelectedItem).Ár.ToString();

        }

        private void csomgaszurtxtb_TextChanged(object sender, EventArgs e)
        {
            SzűrésCsomag();
        }
    }
}
