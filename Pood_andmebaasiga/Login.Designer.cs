namespace Pood_andmebaasiga
{
    partial class Login
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
            this.txtKasutaja = new System.Windows.Forms.TextBox();
            this.txtParool = new System.Windows.Forms.TextBox();
            this.btnLogiSisse = new System.Windows.Forms.Button();
            this.btnRegistreeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKasutaja
            // 
            this.txtKasutaja.Location = new System.Drawing.Point(86, 102);
            this.txtKasutaja.Name = "txtKasutaja";
            this.txtKasutaja.Size = new System.Drawing.Size(100, 20);
            this.txtKasutaja.TabIndex = 0;
            // 
            // txtParool
            // 
            this.txtParool.Location = new System.Drawing.Point(86, 168);
            this.txtParool.Name = "txtParool";
            this.txtParool.Size = new System.Drawing.Size(100, 20);
            this.txtParool.TabIndex = 1;
            // 
            // btnLogiSisse
            // 
            this.btnLogiSisse.Location = new System.Drawing.Point(229, 98);
            this.btnLogiSisse.Name = "btnLogiSisse";
            this.btnLogiSisse.Size = new System.Drawing.Size(75, 23);
            this.btnLogiSisse.TabIndex = 2;
            this.btnLogiSisse.Text = "button1";
            this.btnLogiSisse.UseVisualStyleBackColor = true;
            this.btnLogiSisse.Click += new System.EventHandler(this.btnLogiSisse_Click);
            // 
            // btnRegistreeri
            // 
            this.btnRegistreeri.Location = new System.Drawing.Point(229, 165);
            this.btnRegistreeri.Name = "btnRegistreeri";
            this.btnRegistreeri.Size = new System.Drawing.Size(75, 23);
            this.btnRegistreeri.TabIndex = 3;
            this.btnRegistreeri.Text = "button2";
            this.btnRegistreeri.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistreeri);
            this.Controls.Add(this.btnLogiSisse);
            this.Controls.Add(this.txtParool);
            this.Controls.Add(this.txtKasutaja);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKasutaja;
        private System.Windows.Forms.TextBox txtParool;
        private System.Windows.Forms.Button btnLogiSisse;
        private System.Windows.Forms.Button btnRegistreeri;
    }
}