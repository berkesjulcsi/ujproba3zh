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
    public partial class Üzletek_UC : UserControl
    {
        TelefonContext telefonContext = new TelefonContext();
        public Üzletek_UC()
        {
            InitializeComponent();
            uzletszurtlistb.DisplayMember = "ÜzletNév";
        }

        private void SzűrésÜzlet()
        {
            uzletszurtlistb.DataSource =
            (
            from s in telefonContext.Üzleteks
            where s.ÜzletNév.Contains(üzletszurtxtb.Text)
            select s
            ).ToList();
        }

        private void uzletszurtlistb_SelectedIndexChanged(object sender, EventArgs e)
        {
            helytxtb.Text = ((Üzletek)uzletszurtlistb.SelectedItem).Helyszín.ToString();
            uzletvtxtb.Text = ((Üzletek)uzletszurtlistb.SelectedItem).Üzletvezető.ToString();
            tavalyivtxtb.Text = ((Üzletek)uzletszurtlistb.SelectedItem).TavalyiVásárlóSzám.ToString();
        }

        private void üzletszurtxtb_TextChanged(object sender, EventArgs e)
        {
            SzűrésÜzlet();
        }
    }
}
