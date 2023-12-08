namespace ProyectoV2.Vistas.VistasCatalogo
{
    partial class CategolodeListas
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
            this.volverButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.txtBuscaar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.agregarBici = new System.Windows.Forms.Button();
            this.editarBiciA = new System.Windows.Forms.Button();
            this.eliminarBiciA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // volverButton
            // 
            this.volverButton.Location = new System.Drawing.Point(12, 12);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(75, 23);
            this.volverButton.TabIndex = 4;
            this.volverButton.Text = "Volver";
            this.volverButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenido a nuestro catalogo de bicicletas.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ingrese el nombre de la bicicleta que desea buscar!";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(195, 122);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(125, 23);
            this.Buscar.TabIndex = 12;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // txtBuscaar
            // 
            this.txtBuscaar.Location = new System.Drawing.Point(342, 124);
            this.txtBuscaar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscaar.Name = "txtBuscaar";
            this.txtBuscaar.Size = new System.Drawing.Size(210, 20);
            this.txtBuscaar.TabIndex = 13;
            this.txtBuscaar.TextChanged += new System.EventHandler(this.txtBuscaar_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(163, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 232);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // agregarBici
            // 
            this.agregarBici.Location = new System.Drawing.Point(331, 435);
            this.agregarBici.Name = "agregarBici";
            this.agregarBici.Size = new System.Drawing.Size(118, 28);
            this.agregarBici.TabIndex = 15;
            this.agregarBici.Text = "Agregar";
            this.agregarBici.UseVisualStyleBackColor = true;
            this.agregarBici.Click += new System.EventHandler(this.agregarBici_Click);
            // 
            // editarBiciA
            // 
            this.editarBiciA.Location = new System.Drawing.Point(263, 483);
            this.editarBiciA.Name = "editarBiciA";
            this.editarBiciA.Size = new System.Drawing.Size(75, 23);
            this.editarBiciA.TabIndex = 16;
            this.editarBiciA.Text = "Editar";
            this.editarBiciA.UseVisualStyleBackColor = true;
            this.editarBiciA.Click += new System.EventHandler(this.editarBiciA_Click);
            // 
            // eliminarBiciA
            // 
            this.eliminarBiciA.Location = new System.Drawing.Point(445, 483);
            this.eliminarBiciA.Name = "eliminarBiciA";
            this.eliminarBiciA.Size = new System.Drawing.Size(75, 23);
            this.eliminarBiciA.TabIndex = 17;
            this.eliminarBiciA.Text = "Eliminar";
            this.eliminarBiciA.UseVisualStyleBackColor = true;
            this.eliminarBiciA.Click += new System.EventHandler(this.eliminarBiciA_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Ordenar Ascendente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Ordenar Descendente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CategolodeListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 605);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eliminarBiciA);
            this.Controls.Add(this.editarBiciA);
            this.Controls.Add(this.agregarBici);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBuscaar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volverButton);
            this.Name = "CategolodeListas";
            this.Text = "CategolodeListas";
            this.Load += new System.EventHandler(this.CategolodeListas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox txtBuscaar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button agregarBici;
        private System.Windows.Forms.Button editarBiciA;
        private System.Windows.Forms.Button eliminarBiciA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}