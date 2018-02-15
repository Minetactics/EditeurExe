using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }


        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditeurForm monEditeurForm = new EditeurForm();
            monEditeurForm.Text = "Nouveau document créé le " + DateTime.Now;
            monEditeurForm.MdiParent = this;
            monEditeurForm.Show();
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                EditeurForm monEditeurForm = (EditeurForm)this.ActiveMdiChild;
                RichTextBox Box = (RichTextBox)monEditeurForm.ActiveControl;
                Box.Cut();
            }
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                EditeurForm monEditeurForm = (EditeurForm)this.ActiveMdiChild;
                RichTextBox Box = (RichTextBox)monEditeurForm.ActiveControl;
                Box.Copy();
            }
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                EditeurForm monEditeurForm = (EditeurForm)this.ActiveMdiChild;
                RichTextBox Box = (RichTextBox)monEditeurForm.ActiveControl;
                Box.Paste();
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mosaïqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mosaïqueHorizontaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                SaveFileDialog monSaveFileDialog = new SaveFileDialog();
                monSaveFileDialog.Filter = "Fichier (*.rtf) |*.rtf |Tous les fichiers|*.*";
                monSaveFileDialog.FilterIndex = 1;
                monSaveFileDialog.AddExtension = true;
                DialogResult result = monSaveFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    EditeurForm monEditeurForm = (EditeurForm)this.ActiveMdiChild;
                    RichTextBox rtb = (RichTextBox)monEditeurForm.ActiveControl;
                    rtb.SaveFile(monSaveFileDialog.FileName);
                }
            }
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog monOpenFileDialog = new OpenFileDialog();
            monOpenFileDialog.Filter = "Fichier (*.rtf)|*.rtf |Tous les fichiers|*.*";
            monOpenFileDialog.FilterIndex = 1;
            DialogResult result = monOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                EditeurForm monEditeurForm = new EditeurForm();
                String clearname = monOpenFileDialog.FileName;
                while (clearname.Contains("/")&&clearname.Contains("\\")){
                    clearname.Remove(0, clearname.IndexOf("/"));
                    clearname.Remove(0, clearname.IndexOf("\\"));
                }
                monEditeurForm.Text = clearname;
                monEditeurForm.MdiParent = this;
                monEditeurForm.Show();
                RichTextBox rtb = (RichTextBox)monEditeurForm.ActiveControl;
                rtb.LoadFile(monOpenFileDialog.FileName);

            }
        }

        private void texteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                EditeurForm editeurForm = (EditeurForm)this.ActiveMdiChild;
                FontDialog fontDialog = fontDialog1;
                fontDialog.ShowApply = true;
                fontDialog.ShowColor = true;
                DialogResult result = fontDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    editeurForm.Font = fontDialog.Font;
                    RichTextBox rtb =(RichTextBox)editeurForm.ActiveControl;
                    rtb.SelectAll();
                    rtb.SelectionColor = fontDialog1.Color;

                }
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            EditeurForm editeurForm = (EditeurForm) this.ActiveMdiChild;
            RichTextBox rtb = (RichTextBox)editeurForm.ActiveControl;
            rtb.SelectionFont = fontDialog1.Font;
            rtb.SelectionColor = fontDialog1.Color;
        }

        private void policeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                AfficheurDePolice monAfficheur = new AfficheurDePolice();
                monAfficheur.Show();
            }
        }

        private void maToolbar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            switch (e.Button.ImageIndex)
            {
                case 0:
                    nouveauToolStripMenuItem_Click(this,new EventArgs());
                    break;
                case 1:
                    ouvrirToolStripMenuItem_Click(this, new EventArgs());
                    break;
                case 2:
                    enregistrerToolStripMenuItem_Click(this, new EventArgs());
                    break;
                case 3:
                    copierToolStripMenuItem_Click(this, new EventArgs());
                    break;
                case 4:
                    couperToolStripMenuItem_Click(this, new EventArgs());
                    break;
                case 5:
                    collerToolStripMenuItem_Click(this, new EventArgs());
                    break;
                case 6:
                    fermerToolStripMenuItem_Click(this, new EventArgs());
                    break;
            }
        }
    }
}

