namespace CalculadoraMC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.lblcalculo = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblimc = new System.Windows.Forms.Label();
            this.txtimc = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(277, 154);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 20);
            this.txtpeso.TabIndex = 1;
            // 
            // lblcalculo
            // 
            this.lblcalculo.AutoSize = true;
            this.lblcalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalculo.Location = new System.Drawing.Point(207, 116);
            this.lblcalculo.Name = "lblcalculo";
            this.lblcalculo.Size = new System.Drawing.Size(141, 24);
            this.lblcalculo.TabIndex = 2;
            this.lblcalculo.Text = "calcule seu imc";
            this.lblcalculo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(277, 190);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 5;
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.Location = new System.Drawing.Point(224, 161);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(43, 18);
            this.lblpeso.TabIndex = 8;
            this.lblpeso.Text = "Peso";
            this.lblpeso.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.Location = new System.Drawing.Point(221, 190);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(45, 18);
            this.lblaltura.TabIndex = 9;
            this.lblaltura.Text = "Altura";
            // 
            // lblimc
            // 
            this.lblimc.AutoSize = true;
            this.lblimc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimc.Location = new System.Drawing.Point(224, 262);
            this.lblimc.Name = "lblimc";
            this.lblimc.Size = new System.Drawing.Size(35, 18);
            this.lblimc.TabIndex = 10;
            this.lblimc.Text = "IMC";
            this.lblimc.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // txtimc
            // 
            this.txtimc.Location = new System.Drawing.Point(277, 265);
            this.txtimc.Name = "txtimc";
            this.txtimc.Size = new System.Drawing.Size(100, 20);
            this.txtimc.TabIndex = 11;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(227, 216);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 43);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(230, 315);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(10, 13);
            this.lblresultado.TabIndex = 13;
            this.lblresultado.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtimc);
            this.Controls.Add(this.lblimc);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.lblcalculo);
            this.Controls.Add(this.txtpeso);
            this.Name = "Form1";
            this.Text = "Calculo do IMC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label lblcalculo;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblimc;
        private System.Windows.Forms.TextBox txtimc;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblresultado;
    }
}

