namespace ProyectoV2
{
    partial class Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.IrArreglos = new System.Windows.Forms.Button();
            this.IrLista = new System.Windows.Forms.Button();
            this.IrPilas = new System.Windows.Forms.Button();
            this.IrColas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(144, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(237, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Que Estructura de Datos Deseas?";
            // 
            // IrArreglos
            // 
            this.IrArreglos.BackColor = System.Drawing.Color.CadetBlue;
            this.IrArreglos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IrArreglos.ForeColor = System.Drawing.Color.White;
            this.IrArreglos.Location = new System.Drawing.Point(147, 58);
            this.IrArreglos.Margin = new System.Windows.Forms.Padding(2);
            this.IrArreglos.Name = "IrArreglos";
            this.IrArreglos.Padding = new System.Windows.Forms.Padding(2);
            this.IrArreglos.Size = new System.Drawing.Size(215, 32);
            this.IrArreglos.TabIndex = 1;
            this.IrArreglos.Text = "Arreglos";
            this.IrArreglos.UseVisualStyleBackColor = false;
            this.IrArreglos.Click += new System.EventHandler(this.IrArreglos_Click);
            // 
            // IrLista
            // 
            this.IrLista.BackColor = System.Drawing.Color.CadetBlue;
            this.IrLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IrLista.ForeColor = System.Drawing.Color.White;
            this.IrLista.Location = new System.Drawing.Point(147, 98);
            this.IrLista.Margin = new System.Windows.Forms.Padding(2);
            this.IrLista.Name = "IrLista";
            this.IrLista.Padding = new System.Windows.Forms.Padding(2);
            this.IrLista.Size = new System.Drawing.Size(215, 32);
            this.IrLista.TabIndex = 2;
            this.IrLista.Text = "Lista Enlazada";
            this.IrLista.UseVisualStyleBackColor = false;
            this.IrLista.Click += new System.EventHandler(this.button2_Click);
            // 
            // IrPilas
            // 
            this.IrPilas.BackColor = System.Drawing.Color.CadetBlue;
            this.IrPilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IrPilas.ForeColor = System.Drawing.Color.White;
            this.IrPilas.Location = new System.Drawing.Point(147, 137);
            this.IrPilas.Margin = new System.Windows.Forms.Padding(2);
            this.IrPilas.Name = "IrPilas";
            this.IrPilas.Padding = new System.Windows.Forms.Padding(2);
            this.IrPilas.Size = new System.Drawing.Size(215, 32);
            this.IrPilas.TabIndex = 3;
            this.IrPilas.Text = "Pilas";
            this.IrPilas.UseVisualStyleBackColor = false;
            // 
            // IrColas
            // 
            this.IrColas.BackColor = System.Drawing.Color.CadetBlue;
            this.IrColas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IrColas.ForeColor = System.Drawing.Color.White;
            this.IrColas.Location = new System.Drawing.Point(147, 177);
            this.IrColas.Margin = new System.Windows.Forms.Padding(2);
            this.IrColas.Name = "IrColas";
            this.IrColas.Padding = new System.Windows.Forms.Padding(2);
            this.IrColas.Size = new System.Drawing.Size(215, 32);
            this.IrColas.TabIndex = 4;
            this.IrColas.Text = "Colas";
            this.IrColas.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.IrColas);
            this.Controls.Add(this.IrPilas);
            this.Controls.Add(this.IrLista);
            this.Controls.Add(this.IrArreglos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IrArreglos;
        private System.Windows.Forms.Button IrLista;
        private System.Windows.Forms.Button IrPilas;
        private System.Windows.Forms.Button IrColas;
    }
}

