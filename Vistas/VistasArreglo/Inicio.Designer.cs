namespace ProyectoV2
{
    partial class Inicio
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IrArreglos;
        private System.Windows.Forms.Button IrLista;
        private System.Windows.Forms.Button IrPilas;
        private System.Windows.Forms.Button IrColas;

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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(69, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Qué Estructura de Datos Deseas Explorar?";
            // 
            // IrArreglos
            // 
            this.IrArreglos.BackColor = System.Drawing.Color.Teal;
            this.IrArreglos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IrArreglos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IrArreglos.ForeColor = System.Drawing.Color.White;
            this.IrArreglos.Location = new System.Drawing.Point(147, 58);
            this.IrArreglos.Name = "IrArreglos";
            this.IrArreglos.Size = new System.Drawing.Size(215, 40);
            this.IrArreglos.TabIndex = 1;
            this.IrArreglos.Text = "Arreglos";
            this.IrArreglos.UseVisualStyleBackColor = false;
            this.IrArreglos.Click += new System.EventHandler(this.IrArreglos_Click);
            // 
            // IrLista
            // 
            this.IrLista.BackColor = System.Drawing.Color.Teal;
            this.IrLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IrLista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IrLista.ForeColor = System.Drawing.Color.White;
            this.IrLista.Location = new System.Drawing.Point(147, 108);
            this.IrLista.Name = "IrLista";
            this.IrLista.Size = new System.Drawing.Size(215, 40);
            this.IrLista.TabIndex = 2;
            this.IrLista.Text = "Lista Enlazada";
            this.IrLista.UseVisualStyleBackColor = false;
            this.IrLista.Click += new System.EventHandler(this.button2_Click);
            // 
            // IrPilas
            // 
            this.IrPilas.BackColor = System.Drawing.Color.Teal;
            this.IrPilas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IrPilas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IrPilas.ForeColor = System.Drawing.Color.White;
            this.IrPilas.Location = new System.Drawing.Point(147, 158);
            this.IrPilas.Name = "IrPilas";
            this.IrPilas.Size = new System.Drawing.Size(215, 40);
            this.IrPilas.TabIndex = 3;
            this.IrPilas.Text = "Pilas";
            this.IrPilas.UseVisualStyleBackColor = false;
            this.IrPilas.Click += new System.EventHandler(this.IrPilas_Click);
            // 
            // IrColas
            // 
            this.IrColas.BackColor = System.Drawing.Color.Teal;
            this.IrColas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IrColas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IrColas.ForeColor = System.Drawing.Color.White;
            this.IrColas.Location = new System.Drawing.Point(147, 208);
            this.IrColas.Name = "IrColas";
            this.IrColas.Size = new System.Drawing.Size(215, 40);
            this.IrColas.TabIndex = 4;
            this.IrColas.Text = "Colas";
            this.IrColas.UseVisualStyleBackColor = false;
            this.IrColas.Click += new System.EventHandler(this.IrColas_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.IrColas);
            this.Controls.Add(this.IrPilas);
            this.Controls.Add(this.IrLista);
            this.Controls.Add(this.IrArreglos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explorador de Estructuras de Datos";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
