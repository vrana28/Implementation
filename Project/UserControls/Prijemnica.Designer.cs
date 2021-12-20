namespace Project.UserControls
{
    partial class Prijemnica
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStart = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStart
            // 
            this.dgvStart.AllowUserToAddRows = false;
            this.dgvStart.AllowUserToDeleteRows = false;
            this.dgvStart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStart.Location = new System.Drawing.Point(242, 3);
            this.dgvStart.Name = "dgvStart";
            this.dgvStart.ReadOnly = true;
            this.dgvStart.Size = new System.Drawing.Size(366, 367);
            this.dgvStart.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Prijemnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvStart);
            this.Name = "Prijemnica";
            this.Size = new System.Drawing.Size(619, 384);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStart;
        private System.Windows.Forms.Button button1;
    }
}
