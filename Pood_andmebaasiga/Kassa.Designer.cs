namespace Pood_andmebaasiga
{
    partial class Kassa
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewShop = new System.Windows.Forms.DataGridView();
            this.dataGridViewKorv = new System.Windows.Forms.DataGridView();
            this.btnLisaKorvi = new System.Windows.Forms.Button();
            this.btnOsta = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShop
            // 
            this.dataGridViewShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShop.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewShop.Name = "dataGridViewShop";
            this.dataGridViewShop.Size = new System.Drawing.Size(280, 250);
            this.dataGridViewShop.TabIndex = 0;
            // 
            // dataGridViewKorv
            // 
            this.dataGridViewKorv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKorv.Location = new System.Drawing.Point(400, 12);
            this.dataGridViewKorv.Name = "dataGridViewKorv";
            this.dataGridViewKorv.Size = new System.Drawing.Size(280, 250);
            this.dataGridViewKorv.TabIndex = 1;
            // 
            // btnLisaKorvi
            // 
            this.btnLisaKorvi.Location = new System.Drawing.Point(305, 100);
            this.btnLisaKorvi.Name = "btnLisaKorvi";
            this.btnLisaKorvi.Size = new System.Drawing.Size(80, 45);
            this.btnLisaKorvi.TabIndex = 2;
            this.btnLisaKorvi.Text = "Lisa >>";
            this.btnLisaKorvi.Click += new System.EventHandler(this.btnLisaKorvi_Click);
            // 
            // btnOsta
            // 
            this.btnOsta.Location = new System.Drawing.Point(400, 280);
            this.btnOsta.Name = "btnOsta";
            this.btnOsta.Size = new System.Drawing.Size(280, 40);
            this.btnOsta.TabIndex = 3;
            this.btnOsta.Text = "Osta / PDF";
            this.btnOsta.Click += new System.EventHandler(this.btnOsta_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(12, 330);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(300, 23);
            this.lblStatus.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(400, 265);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total: 0.00 €";
            // 
            // Kassa
            // 
            this.ClientSize = new System.Drawing.Size(700, 380);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnOsta);
            this.Controls.Add(this.btnLisaKorvi);
            this.Controls.Add(this.dataGridViewKorv);
            this.Controls.Add(this.dataGridViewShop);
            this.Name = "Kassa";
            this.Text = "Kassa ja Ostukorv";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewShop;
        private System.Windows.Forms.DataGridView dataGridViewKorv;
        private System.Windows.Forms.Button btnLisaKorvi;
        private System.Windows.Forms.Button btnOsta;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTotal;
    }
}