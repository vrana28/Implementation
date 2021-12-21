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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrPrijemnice = new System.Windows.Forms.TextBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDob = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbOdgLice = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRadnikPrimio = new System.Windows.Forms.ComboBox();
            this.cbMagacin = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStart
            // 
            this.dgvStart.AllowUserToAddRows = false;
            this.dgvStart.AllowUserToDeleteRows = false;
            this.dgvStart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStart.Location = new System.Drawing.Point(328, 3);
            this.dgvStart.Name = "dgvStart";
            this.dgvStart.ReadOnly = true;
            this.dgvStart.Size = new System.Drawing.Size(506, 367);
            this.dgvStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Br. prijemnice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Napomena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Magacin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Radnik (primio)";
            // 
            // txtBrPrijemnice
            // 
            this.txtBrPrijemnice.Location = new System.Drawing.Point(87, 34);
            this.txtBrPrijemnice.Name = "txtBrPrijemnice";
            this.txtBrPrijemnice.Size = new System.Drawing.Size(100, 20);
            this.txtBrPrijemnice.TabIndex = 8;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(87, 87);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(100, 20);
            this.txtNapomena.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDob);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbOdgLice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbRadnikPrimio);
            this.groupBox1.Controls.Add(this.cbMagacin);
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 243);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PrijemnicaInformacije";
            // 
            // cbDob
            // 
            this.cbDob.FormattingEnabled = true;
            this.cbDob.Location = new System.Drawing.Point(84, 205);
            this.cbDob.Name = "cbDob";
            this.cbDob.Size = new System.Drawing.Size(121, 21);
            this.cbDob.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Dobavljac";
            // 
            // cbOdgLice
            // 
            this.cbOdgLice.FormattingEnabled = true;
            this.cbOdgLice.Location = new System.Drawing.Point(84, 174);
            this.cbOdgLice.Name = "cbOdgLice";
            this.cbOdgLice.Size = new System.Drawing.Size(121, 21);
            this.cbOdgLice.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Odg. lice";
            // 
            // cbRadnikPrimio
            // 
            this.cbRadnikPrimio.FormattingEnabled = true;
            this.cbRadnikPrimio.Location = new System.Drawing.Point(84, 143);
            this.cbRadnikPrimio.Name = "cbRadnikPrimio";
            this.cbRadnikPrimio.Size = new System.Drawing.Size(121, 21);
            this.cbRadnikPrimio.TabIndex = 16;
            // 
            // cbMagacin
            // 
            this.cbMagacin.FormattingEnabled = true;
            this.cbMagacin.Location = new System.Drawing.Point(84, 113);
            this.cbMagacin.Name = "cbMagacin";
            this.cbMagacin.Size = new System.Drawing.Size(121, 21);
            this.cbMagacin.TabIndex = 15;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(84, 58);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(-18, -18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(119, 344);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 24);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(214, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 24);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(119, 300);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 24);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 24);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Prijemnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.txtBrPrijemnice);
            this.Controls.Add(this.dgvStart);
            this.Controls.Add(this.groupBox1);
            this.Name = "Prijemnica";
            this.Size = new System.Drawing.Size(850, 384);
            this.Load += new System.EventHandler(this.Prijemnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBrPrijemnice;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbMagacin;
        private System.Windows.Forms.ComboBox cbDob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbOdgLice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbRadnikPrimio;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}
