namespace Project
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prijemnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stavkePrijemniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobavljacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.magacinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prijemnicaToolStripMenuItem,
            this.stavkePrijemniceToolStripMenuItem,
            this.dobavljacToolStripMenuItem,
            this.artikalToolStripMenuItem,
            this.magacinToolStripMenuItem,
            this.radnikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(125, 410);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prijemnicaToolStripMenuItem
            // 
            this.prijemnicaToolStripMenuItem.Name = "prijemnicaToolStripMenuItem";
            this.prijemnicaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 30);
            this.prijemnicaToolStripMenuItem.Size = new System.Drawing.Size(113, 49);
            this.prijemnicaToolStripMenuItem.Text = "Prijemnica";
            this.prijemnicaToolStripMenuItem.Click += new System.EventHandler(this.prijemnicaToolStripMenuItem_Click);
            // 
            // stavkePrijemniceToolStripMenuItem
            // 
            this.stavkePrijemniceToolStripMenuItem.Name = "stavkePrijemniceToolStripMenuItem";
            this.stavkePrijemniceToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 30);
            this.stavkePrijemniceToolStripMenuItem.Size = new System.Drawing.Size(113, 49);
            this.stavkePrijemniceToolStripMenuItem.Text = "Stavke Prijemnice";
            this.stavkePrijemniceToolStripMenuItem.Click += new System.EventHandler(this.stavkePrijemniceToolStripMenuItem_Click);
            // 
            // dobavljacToolStripMenuItem
            // 
            this.dobavljacToolStripMenuItem.Name = "dobavljacToolStripMenuItem";
            this.dobavljacToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 30);
            this.dobavljacToolStripMenuItem.Size = new System.Drawing.Size(113, 49);
            this.dobavljacToolStripMenuItem.Text = "Dobavljac";
            this.dobavljacToolStripMenuItem.Click += new System.EventHandler(this.dobavljacToolStripMenuItem_Click);
            // 
            // artikalToolStripMenuItem
            // 
            this.artikalToolStripMenuItem.Name = "artikalToolStripMenuItem";
            this.artikalToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 30);
            this.artikalToolStripMenuItem.Size = new System.Drawing.Size(113, 49);
            this.artikalToolStripMenuItem.Text = "Artikal";
            this.artikalToolStripMenuItem.Click += new System.EventHandler(this.artikalToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(141, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(846, 389);
            this.pnlMain.TabIndex = 2;
            // 
            // magacinToolStripMenuItem
            // 
            this.magacinToolStripMenuItem.Name = "magacinToolStripMenuItem";
            this.magacinToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 30);
            this.magacinToolStripMenuItem.Size = new System.Drawing.Size(113, 49);
            this.magacinToolStripMenuItem.Text = "Magacin";
            this.magacinToolStripMenuItem.Click += new System.EventHandler(this.magacinToolStripMenuItem_Click);
            // 
            // radnikToolStripMenuItem
            // 
            this.radnikToolStripMenuItem.Name = "radnikToolStripMenuItem";
            this.radnikToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 30);
            this.radnikToolStripMenuItem.Size = new System.Drawing.Size(113, 49);
            this.radnikToolStripMenuItem.Text = "Radnik";
            this.radnikToolStripMenuItem.Click += new System.EventHandler(this.radnikToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 410);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KSOP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prijemnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stavkePrijemniceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobavljacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artikalToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem magacinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radnikToolStripMenuItem;
    }
}

