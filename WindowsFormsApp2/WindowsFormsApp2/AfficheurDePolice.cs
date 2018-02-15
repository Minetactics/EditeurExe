using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AfficheurDePolice : Form
    {
        public Font PoliceChoisie;
        public AfficheurDePolice()
        {
            InitializeComponent();
            FontFamily[] fontFamilies;
            InstalledFontCollection installedfontCollection = new InstalledFontCollection();
            fontFamilies = installedfontCollection.Families;
            int count = fontFamilies.Length;
            for(int i = 0; i < count; i++)
            {
                this.cboFont.Items.Add(fontFamilies[i].Name);
            }
            foreach(string s in Enum.GetNames(typeof(System.Drawing.FontStyle)))
            {
                this.cboStyle.Items.Add(s.ToString());
            }
            this.nudFontSize.Value = 10;
            this.cboFont.SelectedIndex = 0;
            this.cboStyle.SelectedIndex = 0;
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily myFontFamily = new FontFamily(cboFont.Text);
            try {
                PoliceChoisie = new Font(myFontFamily, (float)nudFontSize.Value, (FontStyle)cboStyle.SelectedIndex);
                fontPanel.Paint += new PaintEventHandler(fontPanel_Paint);
                fontPanel.Refresh();
            } catch { }
        }

        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            float myPoliceSize = (float)nudFontSize.Value;
            try {
                PoliceChoisie = new Font(new FontFamily(cboFont.Text), myPoliceSize, (FontStyle)cboStyle.SelectedIndex);
                fontPanel.Paint += new PaintEventHandler(fontPanel_Paint);
                fontPanel.Refresh();
            } catch { }

        }

        private void cboStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontStyle myFontStyle = (FontStyle)cboStyle.SelectedIndex;
            try {
                PoliceChoisie = new Font(new FontFamily(cboFont.Text), (float)nudFontSize.Value, myFontStyle);
                fontPanel.Paint += new PaintEventHandler(fontPanel_Paint);
                fontPanel.Refresh();
            } catch { }
        }

        private void fontPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Exemple de la police sélectionnée ... (123-abc-?!)", PoliceChoisie, new SolidBrush(Color.Black), new Point(16));
        }
    }
}
