namespace WindowsFormsApplication1
{
    partial class Promedio
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
            this.components = new System.ComponentModel.Container();
            this.btnObtProm = new System.Windows.Forms.Button();
            this.AMateria = new System.Windows.Forms.Label();
            this.ANota = new System.Windows.Forms.Label();
            this.txtIngMateria = new System.Windows.Forms.TextBox();
            this.txtIngNota = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblConfirmacionDeAgregado = new System.Windows.Forms.Label();
            this.btnGuardado = new System.Windows.Forms.Button();
            this.timerVerValidacion = new System.Windows.Forms.Timer(this.components);
            this.btnCargarNotas = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObtProm
            // 
            this.btnObtProm.Location = new System.Drawing.Point(46, 158);
            this.btnObtProm.Name = "btnObtProm";
            this.btnObtProm.Size = new System.Drawing.Size(136, 23);
            this.btnObtProm.TabIndex = 0;
            this.btnObtProm.Text = "Obtener promedio";
            this.btnObtProm.UseVisualStyleBackColor = true;
            this.btnObtProm.Click += new System.EventHandler(this.btnObtProm_Click);
            // 
            // AMateria
            // 
            this.AMateria.AutoSize = true;
            this.AMateria.Location = new System.Drawing.Point(43, 23);
            this.AMateria.Name = "AMateria";
            this.AMateria.Size = new System.Drawing.Size(85, 13);
            this.AMateria.TabIndex = 2;
            this.AMateria.Text = "Agregar Materia:";
            // 
            // ANota
            // 
            this.ANota.AutoSize = true;
            this.ANota.Location = new System.Drawing.Point(43, 58);
            this.ANota.Name = "ANota";
            this.ANota.Size = new System.Drawing.Size(73, 13);
            this.ANota.TabIndex = 3;
            this.ANota.Text = "Agregar Nota:";
            // 
            // txtIngMateria
            // 
            this.txtIngMateria.Location = new System.Drawing.Point(131, 20);
            this.txtIngMateria.Name = "txtIngMateria";
            this.txtIngMateria.Size = new System.Drawing.Size(137, 20);
            this.txtIngMateria.TabIndex = 4;
            this.txtIngMateria.TextChanged += new System.EventHandler(this.txtIngMateria_TextChanged);
            // 
            // txtIngNota
            // 
            this.txtIngNota.Location = new System.Drawing.Point(131, 58);
            this.txtIngNota.Name = "txtIngNota";
            this.txtIngNota.Size = new System.Drawing.Size(137, 20);
            this.txtIngNota.TabIndex = 5;
            this.txtIngNota.TextChanged += new System.EventHandler(this.txtIngNota_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(105, 93);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblConfirmacionDeAgregado
            // 
            this.lblConfirmacionDeAgregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacionDeAgregado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblConfirmacionDeAgregado.Location = new System.Drawing.Point(68, 131);
            this.lblConfirmacionDeAgregado.Name = "lblConfirmacionDeAgregado";
            this.lblConfirmacionDeAgregado.Size = new System.Drawing.Size(200, 15);
            this.lblConfirmacionDeAgregado.TabIndex = 7;
            this.lblConfirmacionDeAgregado.Click += new System.EventHandler(this.lblConfirmacionDeAgregado_Click);
            // 
            // btnGuardado
            // 
            this.btnGuardado.Location = new System.Drawing.Point(204, 224);
            this.btnGuardado.Name = "btnGuardado";
            this.btnGuardado.Size = new System.Drawing.Size(97, 23);
            this.btnGuardado.TabIndex = 8;
            this.btnGuardado.Text = "Guardar Datos";
            this.btnGuardado.UseVisualStyleBackColor = true;
            this.btnGuardado.Click += new System.EventHandler(this.btnGuardado_Click);
            // 
            // timerVerValidacion
            // 
            this.timerVerValidacion.Enabled = true;
            this.timerVerValidacion.Interval = 4500;
            this.timerVerValidacion.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCargarNotas
            // 
            this.btnCargarNotas.Location = new System.Drawing.Point(13, 224);
            this.btnCargarNotas.Name = "btnCargarNotas";
            this.btnCargarNotas.Size = new System.Drawing.Size(75, 23);
            this.btnCargarNotas.TabIndex = 10;
            this.btnCargarNotas.Text = "Cargar";
            this.btnCargarNotas.UseVisualStyleBackColor = true;
            this.btnCargarNotas.Click += new System.EventHandler(this.btnCargarNotas_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(13, 253);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(103, 23);
            this.btnListar.TabIndex = 11;
            this.btnListar.Text = "Listar Materias";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Promedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 296);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCargarNotas);
            this.Controls.Add(this.btnGuardado);
            this.Controls.Add(this.lblConfirmacionDeAgregado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtIngNota);
            this.Controls.Add(this.txtIngMateria);
            this.Controls.Add(this.ANota);
            this.Controls.Add(this.AMateria);
            this.Controls.Add(this.btnObtProm);
            this.Name = "Promedio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promedio for Windows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObtProm;
        private System.Windows.Forms.Label AMateria;
        private System.Windows.Forms.Label ANota;
        private System.Windows.Forms.TextBox txtIngMateria;
        private System.Windows.Forms.TextBox txtIngNota;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblConfirmacionDeAgregado;
        private System.Windows.Forms.Button btnGuardado;
        private System.Windows.Forms.Timer timerVerValidacion;
        private System.Windows.Forms.Button btnCargarNotas;
        private System.Windows.Forms.Button btnListar;
    }
}

