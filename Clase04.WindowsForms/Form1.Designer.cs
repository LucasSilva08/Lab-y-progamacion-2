namespace Clase04.WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEntero = new System.Windows.Forms.Label();
            this.lblCadena = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtEntero = new System.Windows.Forms.TextBox();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnNegro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEntero
            // 
            this.lblEntero.AutoSize = true;
            this.lblEntero.Location = new System.Drawing.Point(75, 53);
            this.lblEntero.Name = "lblEntero";
            this.lblEntero.Size = new System.Drawing.Size(38, 13);
            this.lblEntero.TabIndex = 0;
            this.lblEntero.Text = "Entero";
            // 
            // lblCadena
            // 
            this.lblCadena.AutoSize = true;
            this.lblCadena.Location = new System.Drawing.Point(75, 90);
            this.lblCadena.Name = "lblCadena";
            this.lblCadena.Size = new System.Drawing.Size(44, 13);
            this.lblCadena.TabIndex = 1;
            this.lblCadena.Text = "Cadena";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(75, 136);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(182, 376);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(119, 36);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtEntero
            // 
            this.txtEntero.Location = new System.Drawing.Point(216, 46);
            this.txtEntero.Name = "txtEntero";
            this.txtEntero.Size = new System.Drawing.Size(199, 20);
            this.txtEntero.TabIndex = 4;
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(216, 87);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(199, 20);
            this.txtCadena.TabIndex = 5;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(216, 129);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(199, 20);
            this.txtFecha.TabIndex = 6;
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(78, 168);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(337, 186);
            this.lstLista.TabIndex = 7;
            // 
            // btnAzul
            // 
            this.btnAzul.Location = new System.Drawing.Point(525, 168);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(75, 23);
            this.btnAzul.TabIndex = 8;
            this.btnAzul.Text = "AZUL";
            this.btnAzul.UseVisualStyleBackColor = true;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnRojo
            // 
            this.btnRojo.Location = new System.Drawing.Point(525, 245);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(75, 23);
            this.btnRojo.TabIndex = 9;
            this.btnRojo.Text = "ROJO";
            this.btnRojo.UseVisualStyleBackColor = true;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            // 
            // btnNegro
            // 
            this.btnNegro.Location = new System.Drawing.Point(525, 331);
            this.btnNegro.Name = "btnNegro";
            this.btnNegro.Size = new System.Drawing.Size(75, 23);
            this.btnNegro.TabIndex = 10;
            this.btnNegro.Text = "NEGRO";
            this.btnNegro.UseVisualStyleBackColor = true;
            this.btnNegro.Click += new System.EventHandler(this.btnNegro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.btnNegro);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.txtEntero);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCadena);
            this.Controls.Add(this.lblEntero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntero;
        private System.Windows.Forms.Label lblCadena;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtEntero;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnNegro;
    }
}

