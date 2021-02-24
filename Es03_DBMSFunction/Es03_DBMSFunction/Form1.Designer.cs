
namespace Es03_DBMSFunction
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDriver = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPodiums = new System.Windows.Forms.NumericUpDown();
            this.btnCercaNazionalita = new System.Windows.Forms.Button();
            this.btnContaDriver = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPodiums)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDriver
            // 
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Location = new System.Drawing.Point(12, 73);
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.RowHeadersWidth = 62;
            this.dgvDriver.RowTemplate.Height = 28;
            this.dgvDriver.Size = new System.Drawing.Size(881, 438);
            this.dgvDriver.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drivers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(968, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select country:";
            // 
            // cmbCountries
            // 
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Items.AddRange(new object[] {
            "GB",
            "TH",
            "IT"});
            this.cmbCountries.Location = new System.Drawing.Point(1162, 74);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(159, 28);
            this.cmbCountries.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(968, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "N° podiums:";
            // 
            // nudPodiums
            // 
            this.nudPodiums.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPodiums.Location = new System.Drawing.Point(1162, 137);
            this.nudPodiums.Name = "nudPodiums";
            this.nudPodiums.Size = new System.Drawing.Size(159, 30);
            this.nudPodiums.TabIndex = 5;
            // 
            // btnCercaNazionalita
            // 
            this.btnCercaNazionalita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCercaNazionalita.Location = new System.Drawing.Point(1018, 219);
            this.btnCercaNazionalita.Name = "btnCercaNazionalita";
            this.btnCercaNazionalita.Size = new System.Drawing.Size(276, 68);
            this.btnCercaNazionalita.TabIndex = 6;
            this.btnCercaNazionalita.Text = "Cerca Driver per nazionalità";
            this.btnCercaNazionalita.UseVisualStyleBackColor = true;
            this.btnCercaNazionalita.Click += new System.EventHandler(this.btnCercaNazionalita_Click);
            // 
            // btnContaDriver
            // 
            this.btnContaDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContaDriver.Location = new System.Drawing.Point(1018, 315);
            this.btnContaDriver.Name = "btnContaDriver";
            this.btnContaDriver.Size = new System.Drawing.Size(276, 68);
            this.btnContaDriver.TabIndex = 7;
            this.btnContaDriver.Text = "Conta Driver per n° podi";
            this.btnContaDriver.UseVisualStyleBackColor = true;
            this.btnContaDriver.Click += new System.EventHandler(this.btnContaDriver_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1018, 416);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(276, 68);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 536);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnContaDriver);
            this.Controls.Add(this.btnCercaNazionalita);
            this.Controls.Add(this.nudPodiums);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCountries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDriver);
            this.Name = "Form1";
            this.Text = "DBMS Function";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPodiums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPodiums;
        private System.Windows.Forms.Button btnCercaNazionalita;
        private System.Windows.Forms.Button btnContaDriver;
        private System.Windows.Forms.Button btnReset;
    }
}

