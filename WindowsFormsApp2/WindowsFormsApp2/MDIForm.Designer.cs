using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class MDIForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIForm));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.texteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenêtreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaïqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaïqueHorizontaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.texteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.policeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.ToolBarImageList = new System.Windows.Forms.ImageList(this.components);
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.fenêtreToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(624, 24);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.fermerToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.couperToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.collerToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // couperToolStripMenuItem
            // 
            this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            this.couperToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.couperToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.couperToolStripMenuItem.Text = "Couper";
            this.couperToolStripMenuItem.Click += new System.EventHandler(this.couperToolStripMenuItem_Click);
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.copierToolStripMenuItem.Text = "Copier";
            this.copierToolStripMenuItem.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.collerToolStripMenuItem.Text = "Coller";
            this.collerToolStripMenuItem.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.texteToolStripMenuItem,
            this.policeToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.formatToolStripMenuItem.Text = "Fomat";
            // 
            // texteToolStripMenuItem
            // 
            this.texteToolStripMenuItem.Name = "texteToolStripMenuItem";
            this.texteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.texteToolStripMenuItem.Text = "Texte";
            this.texteToolStripMenuItem.Click += new System.EventHandler(this.texteToolStripMenuItem_Click);
            // 
            // policeToolStripMenuItem
            // 
            this.policeToolStripMenuItem.Name = "policeToolStripMenuItem";
            this.policeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.policeToolStripMenuItem.Text = "Police";
            this.policeToolStripMenuItem.Click += new System.EventHandler(this.policeToolStripMenuItem_Click);
            // 
            // fenêtreToolStripMenuItem
            // 
            this.fenêtreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.mosaïqueToolStripMenuItem,
            this.mosaïqueHorizontaleToolStripMenuItem});
            this.fenêtreToolStripMenuItem.Name = "fenêtreToolStripMenuItem";
            this.fenêtreToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.fenêtreToolStripMenuItem.Text = "Fenêtre";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // mosaïqueToolStripMenuItem
            // 
            this.mosaïqueToolStripMenuItem.Name = "mosaïqueToolStripMenuItem";
            this.mosaïqueToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.mosaïqueToolStripMenuItem.Text = "Mosaïque Verticale";
            this.mosaïqueToolStripMenuItem.Click += new System.EventHandler(this.mosaïqueToolStripMenuItem_Click);
            // 
            // mosaïqueHorizontaleToolStripMenuItem
            // 
            this.mosaïqueHorizontaleToolStripMenuItem.Name = "mosaïqueHorizontaleToolStripMenuItem";
            this.mosaïqueHorizontaleToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.mosaïqueHorizontaleToolStripMenuItem.Text = "Mosaïque Horizontale";
            this.mosaïqueHorizontaleToolStripMenuItem.Click += new System.EventHandler(this.mosaïqueHorizontaleToolStripMenuItem_Click);
            // 
            // texteToolStripMenuItem1
            // 
            this.texteToolStripMenuItem1.Name = "texteToolStripMenuItem1";
            this.texteToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // policeToolStripMenuItem1
            // 
            this.policeToolStripMenuItem1.Name = "policeToolStripMenuItem1";
            this.policeToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // ToolBarImageList
            // 
            this.ToolBarImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ToolBarImageList.ImageStream")));
            this.ToolBarImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ToolBarImageList.Images.SetKeyName(0, "NEW.BMP");
            this.ToolBarImageList.Images.SetKeyName(1, "OPEN.BMP");
            this.ToolBarImageList.Images.SetKeyName(2, "SAVE.BMP");
            this.ToolBarImageList.Images.SetKeyName(3, "COPY.BMP");
            this.ToolBarImageList.Images.SetKeyName(4, "CUT.BMP");
            this.ToolBarImageList.Images.SetKeyName(5, "PASTE.BMP");
            this.ToolBarImageList.Images.SetKeyName(6, "CLOSED.BMP");
            //Toolbar
            System.Windows.Forms.ToolBar maToolbar = new System.Windows.Forms.ToolBar();
            maToolbar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            maToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            maToolbar.ImageList = ToolBarImageList;
            System.Windows.Forms.ToolBarButton toolbarButton0 = new System.Windows.Forms.ToolBarButton();
            System.Windows.Forms.ToolBarButton toolbarButton1 = new System.Windows.Forms.ToolBarButton();
            System.Windows.Forms.ToolBarButton toolbarButton2 = new System.Windows.Forms.ToolBarButton();
            System.Windows.Forms.ToolBarButton toolbarButton3 = new System.Windows.Forms.ToolBarButton();
            System.Windows.Forms.ToolBarButton toolbarButton4 = new System.Windows.Forms.ToolBarButton();
            System.Windows.Forms.ToolBarButton toolbarButton5 = new System.Windows.Forms.ToolBarButton();
            System.Windows.Forms.ToolBarButton toolbarButton6 = new System.Windows.Forms.ToolBarButton();
            toolbarButton0.Text = "New";
            toolbarButton1.Text = "Open";
            toolbarButton2.Text = "Save";
            toolbarButton3.Text = "Copy";
            toolbarButton4.Text = "Cut";
            toolbarButton5.Text = "Paste";
            toolbarButton6.Text = "Close";
            toolbarButton0.ImageIndex = 0;
            toolbarButton1.ImageIndex = 1;
            toolbarButton2.ImageIndex = 2;
            toolbarButton3.ImageIndex = 3;
            toolbarButton4.ImageIndex = 4;
            toolbarButton5.ImageIndex = 5;
            toolbarButton6.ImageIndex = 6;
            maToolbar.Buttons.Add(toolbarButton0);
            maToolbar.Buttons.Add(toolbarButton1);
            maToolbar.Buttons.Add(toolbarButton2);
            maToolbar.Buttons.Add(toolbarButton3);
            maToolbar.Buttons.Add(toolbarButton4);
            maToolbar.Buttons.Add(toolbarButton5);
            maToolbar.Buttons.Add(toolbarButton6);
            maToolbar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.maToolbar_ButtonClick);
            Controls.Add(maToolbar);
            //
            //StatusBar
            //
            StatusBar maStatusBar = new StatusBar();
            maStatusBar.SizingGrip = true;
            Controls.Add(maStatusBar);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.MainMenuStrip);
            this.IsMdiContainer = true;
            this.Name = "MDIForm";
            this.Text = "Editeur dotNET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
#endregion
        }

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem texteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fenêtreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mosaïqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mosaïqueHorizontaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem texteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem policeToolStripMenuItem1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ImageList ToolBarImageList;
    }
}