using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ujproba3zh.Models;

namespace ujproba3zh
{
    public partial class Ügyfelek_Form : Form
    {
        TelefonContext telefonContext = new TelefonContext();
        public Ügyfelek_Form()
        {
            InitializeComponent();
            csomaglistb.DisplayMember = "CsomagNév";
            nevlistb.DisplayMember = "Név";
            SzűrésCsomag();
        }
        private void SzűrésCsomag()
        {
            csomaglistb.DataSource =
            (
            from s in telefonContext.Csomagoks
            where s.CsomagNév.Contains(csomagtxtb.Text)
            select s).ToList();

        }

        private void MegjelenNév()
        {
            var csomagvalaszt = ((Csomagok)csomaglistb.SelectedItem).CsomagId;
            var megjelen = from x in telefonContext.Ügyfeleks
                           where x.CsomagId == csomagvalaszt
                           select x;
            nevlistb.DataSource = megjelen.ToList();
        }
        private void MegjelenDataJelen()
        {
            var nevvalaszt = ((Ügyfelek)nevlistb.SelectedItem).Név;
            var megjelen = from x in telefonContext.Ügyfeleks
                           where x.Név == nevvalaszt
                           select new DataJelen
                           {
                               Név = nevvalaszt,
                               SzülIdő = x.SzülIdő,
                               TelSzám = x.TelSzám,
                               Email = x.Email,
                               BővíthetőE = x.BővíthetőE,
                               Ár = x.Csomag.Ár,
                               Percek = x.Csomag.Percek
                           };
            dataJelenBindingSource.DataSource = megjelen.ToList();
        }

        private void csomagtxtb_TextChanged(object sender, EventArgs e)
        {
            SzűrésCsomag();
        }

        private void csomaglistb_SelectedIndexChanged(object sender, EventArgs e)
        {
            MegjelenNév();
        }

        private void nevlistb_SelectedIndexChanged(object sender, EventArgs e)
        {
            MegjelenDataJelen();
        }

        private void hozzaadbttn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan Hozzáad adatot?", "Adat hozzáadása", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Ügyfelek dj = new Ügyfelek();
                dj.ÜgyfélId = telefonContext.Ügyfeleks.Count();
                dj.Név = ((Ügyfelek)nevlistb.SelectedItem).Név;
                dj.TelSzám = hozzaadtxtb.Text;
                telefonContext.Ügyfeleks.Add(dj);
                try
                {
                    telefonContext.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                MegjelenDataJelen();
            }
        }       

        private bool Megfelele(string n)
        {
            Regex r = new Regex("[0-9]{9}$");
            return r.IsMatch(n);
        }

        private void hozzaadtxtb_Validating(object sender, CancelEventArgs e)
        {
    
            if (!Megfelele(hozzaadtxtb.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(hozzaadtxtb, "9db számból kell állnia");
            }
        }

        private void hozzaadtxtb_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(hozzaadtxtb, "");

        }
    }
}
