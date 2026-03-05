namespace Pood_andmebaasiga
{
    partial class Tooded
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewTooded = new System.Windows.Forms.DataGridView();
            this.btnLisa = new System.Windows.Forms.Button();
            this.btnUuenda = new System.Windows.Forms.Button();
            this.btnKustuta = new System.Windows.Forms.Button();
            this.btnAvaKassa = new System.Windows.Forms.Button();
            this.btnLisaKat = new System.Windows.Forms.Button();
            this.txtNimetus = new System.Windows.Forms.TextBox();
            this.txtKogus = new System.Windows.Forms.TextBox();
            this.txtHind = new System.Windows.Forms.TextBox();
            this.txtUusKat = new System.Windows.Forms.TextBox();
            this.cmbKategooria = new System.Windows.Forms.ComboBox();
            this.picPilt = new System.Windows.Forms.PictureBox();
            this.btnOtsiPilt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTooded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPilt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTooded
            // 
            this.dataGridViewTooded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTooded.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTooded.Name = "dataGridViewTooded";
            this.dataGridViewTooded.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTooded.Size = new System.Drawing.Size(703, 180);
            this.dataGridViewTooded.TabIndex = 0;
            // 
            // btnLisa
            // 
            this.btnLisa.Location = new System.Drawing.Point(180, 210);
            this.btnLisa.Name = "btnLisa";
            this.btnLisa.Size = new System.Drawing.Size(100, 23);
            this.btnLisa.TabIndex = 2;
            this.btnLisa.Text = "Lisa Toode";
            // 
            // btnUuenda
            // 
            this.btnUuenda.Location = new System.Drawing.Point(180, 240);
            this.btnUuenda.Name = "btnUuenda";
            this.btnUuenda.Size = new System.Drawing.Size(100, 23);
            this.btnUuenda.TabIndex = 3;
            this.btnUuenda.Text = "Uuenda";
            this.btnUuenda.Click += new System.EventHandler(this.btnUuenda_Click);
            // 
            // btnKustuta
            // 
            this.btnKustuta.Location = new System.Drawing.Point(180, 270);
            this.btnKustuta.Name = "btnKustuta";
            this.btnKustuta.Size = new System.Drawing.Size(100, 23);
            this.btnKustuta.TabIndex = 4;
            this.btnKustuta.Text = "Kustuta";
            this.btnKustuta.Click += new System.EventHandler(this.btnKustuta_Click);
            // 
            // btnAvaKassa
            // 
            this.btnAvaKassa.Location = new System.Drawing.Point(640, 470);
            this.btnAvaKassa.Name = "btnAvaKassa";
            this.btnAvaKassa.Size = new System.Drawing.Size(75, 23);
            this.btnAvaKassa.TabIndex = 5;
            this.btnAvaKassa.Text = "Kassasse";
            this.btnAvaKassa.Click += new System.EventHandler(this.btnAvaKassa_Click);
            // 
            // btnLisaKat
            // 
            this.btnLisaKat.Location = new System.Drawing.Point(350, 240);
            this.btnLisaKat.Name = "btnLisaKat";
            this.btnLisaKat.Size = new System.Drawing.Size(100, 23);
            this.btnLisaKat.TabIndex = 6;
            this.btnLisaKat.Text = "Lisa Kat.";
            this.btnLisaKat.Click += new System.EventHandler(this.btnLisaKat_Click);
            // 
            // txtNimetus
            // 
            this.txtNimetus.Location = new System.Drawing.Point(12, 210);
            this.txtNimetus.Name = "txtNimetus";
            this.txtNimetus.Size = new System.Drawing.Size(100, 20);
            this.txtNimetus.TabIndex = 7;
            // 
            // txtKogus
            // 
            this.txtKogus.Location = new System.Drawing.Point(12, 240);
            this.txtKogus.Name = "txtKogus";
            this.txtKogus.Size = new System.Drawing.Size(100, 20);
            this.txtKogus.TabIndex = 8;
            // 
            // txtHind
            // 
            this.txtHind.Location = new System.Drawing.Point(12, 270);
            this.txtHind.Name = "txtHind";
            this.txtHind.Size = new System.Drawing.Size(100, 20);
            this.txtHind.TabIndex = 9;
            // 
            // txtUusKat
            // 
            this.txtUusKat.Location = new System.Drawing.Point(350, 210);
            this.txtUusKat.Name = "txtUusKat";
            this.txtUusKat.Size = new System.Drawing.Size(100, 20);
            this.txtUusKat.TabIndex = 10;
            // 
            // cmbKategooria
            // 
            this.cmbKategooria.Location = new System.Drawing.Point(12, 300);
            this.cmbKategooria.Name = "cmbKategooria";
            this.cmbKategooria.Size = new System.Drawing.Size(121, 21);
            this.cmbKategooria.TabIndex = 11;
            // 
            // picPilt
            // 
            this.picPilt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPilt.Location = new System.Drawing.Point(473, 198);
            this.picPilt.Name = "picPilt";
            this.picPilt.Size = new System.Drawing.Size(242, 183);
            this.picPilt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPilt.TabIndex = 1;
            this.picPilt.TabStop = false;
            // 
            // btnOtsiPilt
            // 
            this.btnOtsiPilt.Location = new System.Drawing.Point(473, 387);
            this.btnOtsiPilt.Name = "btnOtsiPilt";
            this.btnOtsiPilt.Size = new System.Drawing.Size(75, 23);
            this.btnOtsiPilt.TabIndex = 0;
            this.btnOtsiPilt.Text = "Vali foto";
            // 
            // Tooded
            // 
            this.ClientSize = new System.Drawing.Size(727, 505);
            this.Controls.Add(this.btnOtsiPilt);
            this.Controls.Add(this.picPilt);
            this.Controls.Add(this.dataGridViewTooded);
            this.Controls.Add(this.btnLisa);
            this.Controls.Add(this.btnUuenda);
            this.Controls.Add(this.btnKustuta);
            this.Controls.Add(this.btnAvaKassa);
            this.Controls.Add(this.btnLisaKat);
            this.Controls.Add(this.txtNimetus);
            this.Controls.Add(this.txtKogus);
            this.Controls.Add(this.txtHind);
            this.Controls.Add(this.txtUusKat);
            this.Controls.Add(this.cmbKategooria);
            this.Name = "Tooded";
            this.Text = "LaoHaldus";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTooded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPilt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridViewTooded;
        private System.Windows.Forms.Button btnLisa, btnUuenda, btnKustuta, btnAvaKassa, btnLisaKat;
        private System.Windows.Forms.TextBox txtNimetus, txtKogus, txtHind, txtUusKat;
        private System.Windows.Forms.ComboBox cmbKategooria;
        private System.Windows.Forms.PictureBox picPilt;
        private System.Windows.Forms.Button btnOtsiPilt;
    }
}