
namespace RegistroConsumoEnergia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNrCasa = new System.Windows.Forms.TextBox();
            this.lblNrCasa = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvLeituras = new System.Windows.Forms.DataGridView();
            this.btnProcessarDados = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalConsumoSemDesconto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNrCasa
            // 
            this.txtNrCasa.Location = new System.Drawing.Point(78, 32);
            this.txtNrCasa.Name = "txtNrCasa";
            this.txtNrCasa.Size = new System.Drawing.Size(100, 23);
            this.txtNrCasa.TabIndex = 0;
            // 
            // lblNrCasa
            // 
            this.lblNrCasa.AutoSize = true;
            this.lblNrCasa.Location = new System.Drawing.Point(21, 35);
            this.lblNrCasa.Name = "lblNrCasa";
            this.lblNrCasa.Size = new System.Drawing.Size(51, 15);
            this.lblNrCasa.TabIndex = 1;
            this.lblNrCasa.Text = "Nr. Casa";
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(267, 33);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(100, 23);
            this.txtConsumo.TabIndex = 2;
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(202, 36);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(59, 15);
            this.lblConsumo.TabIndex = 3;
            this.lblConsumo.Text = "Consumo";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(389, 32);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvLeituras
            // 
            this.dgvLeituras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeituras.Location = new System.Drawing.Point(21, 71);
            this.dgvLeituras.Name = "dgvLeituras";
            this.dgvLeituras.RowTemplate.Height = 25;
            this.dgvLeituras.Size = new System.Drawing.Size(478, 188);
            this.dgvLeituras.TabIndex = 5;
            // 
            // btnProcessarDados
            // 
            this.btnProcessarDados.Location = new System.Drawing.Point(21, 285);
            this.btnProcessarDados.Name = "btnProcessarDados";
            this.btnProcessarDados.Size = new System.Drawing.Size(107, 23);
            this.btnProcessarDados.TabIndex = 6;
            this.btnProcessarDados.Text = "ProcessarDados";
            this.btnProcessarDados.UseVisualStyleBackColor = true;
            this.btnProcessarDados.Click += new System.EventHandler(this.btnProcessarDados_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(267, 289);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(162, 15);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total consumo sem desconto";
            // 
            // lblTotalConsumoSemDesconto
            // 
            this.lblTotalConsumoSemDesconto.AutoSize = true;
            this.lblTotalConsumoSemDesconto.Location = new System.Drawing.Point(455, 289);
            this.lblTotalConsumoSemDesconto.Name = "lblTotalConsumoSemDesconto";
            this.lblTotalConsumoSemDesconto.Size = new System.Drawing.Size(0, 15);
            this.lblTotalConsumoSemDesconto.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 392);
            this.Controls.Add(this.lblTotalConsumoSemDesconto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnProcessarDados);
            this.Controls.Add(this.dgvLeituras);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.lblNrCasa);
            this.Controls.Add(this.txtNrCasa);
            this.Name = "Form1";
            this.Text = "Registro de Consumo de Energia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNrCasa;
        private System.Windows.Forms.Label lblNrCasa;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvLeituras;
        private System.Windows.Forms.Button btnProcessarDados;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalConsumoSemDesconto;
    }
}

