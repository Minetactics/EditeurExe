namespace WindowsFormsApp2
{
    partial class EditeurForm
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
            this.RtbDocument = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RtbDocument
            // 
            this.RtbDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtbDocument.Location = new System.Drawing.Point(0, 0);
            this.RtbDocument.Name = "RtbDocument";
            this.RtbDocument.Size = new System.Drawing.Size(584, 362);
            this.RtbDocument.TabIndex = 0;
            this.RtbDocument.Text = "";
            // 
            // EditeurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.RtbDocument);
            this.Name = "EditeurForm";
            this.Text = "EditeurForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RtbDocument;
    }
}