namespace Proyecto5_Formulario
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbEstatura = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.gGenero = new System.Windows.Forms.GroupBox();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.btnGuaradar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbNombre
            // 
            this.tbNombre.AutoSize = true;
            this.tbNombre.Location = new System.Drawing.Point(34, 42);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(44, 13);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.Text = "Nombre";
            // 
            // tbApellidos
            // 
            this.tbApellidos.AutoSize = true;
            this.tbApellidos.Location = new System.Drawing.Point(34, 81);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(49, 13);
            this.tbApellidos.TabIndex = 2;
            this.tbApellidos.Text = "Apellidos";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 3;
            // 
            // tbTelefono
            // 
            this.tbTelefono.AutoSize = true;
            this.tbTelefono.Location = new System.Drawing.Point(34, 124);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(49, 13);
            this.tbTelefono.TabIndex = 4;
            this.tbTelefono.Text = "Telefono";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 20);
            this.textBox3.TabIndex = 5;
            // 
            // tbEstatura
            // 
            this.tbEstatura.AutoSize = true;
            this.tbEstatura.Location = new System.Drawing.Point(34, 165);
            this.tbEstatura.Name = "tbEstatura";
            this.tbEstatura.Size = new System.Drawing.Size(46, 13);
            this.tbEstatura.TabIndex = 6;
            this.tbEstatura.Text = "Estatura";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(105, 158);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 20);
            this.textBox4.TabIndex = 7;
            // 
            // tbEdad
            // 
            this.tbEdad.AutoSize = true;
            this.tbEdad.Location = new System.Drawing.Point(34, 205);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(32, 13);
            this.tbEdad.TabIndex = 8;
            this.tbEdad.Text = "Edad";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(105, 198);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(123, 20);
            this.textBox5.TabIndex = 9;
            // 
            // gGenero
            // 
            this.gGenero.Controls.Add(this.rbMujer);
            this.gGenero.Controls.Add(this.rbHombre);
            this.gGenero.Location = new System.Drawing.Point(37, 234);
            this.gGenero.Name = "gGenero";
            this.gGenero.Size = new System.Drawing.Size(200, 100);
            this.gGenero.TabIndex = 10;
            this.gGenero.TabStop = false;
            this.gGenero.Text = "Género";
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(128, 45);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(51, 17);
            this.rbMujer.TabIndex = 1;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(16, 45);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(62, 17);
            this.rbHombre.TabIndex = 0;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            this.rbHombre.CheckedChanged += new System.EventHandler(this.RdMasculino_CheckedChanged);
            // 
            // btnGuaradar
            // 
            this.btnGuaradar.Location = new System.Drawing.Point(81, 340);
            this.btnGuaradar.Name = "btnGuaradar";
            this.btnGuaradar.Size = new System.Drawing.Size(93, 37);
            this.btnGuaradar.TabIndex = 11;
            this.btnGuaradar.Text = "Guardar";
            this.btnGuaradar.UseVisualStyleBackColor = true;
            this.btnGuaradar.Click += new System.EventHandler(this.btnGuaradar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(81, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 37);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuaradar);
            this.Controls.Add(this.gGenero);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tbEstatura);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gGenero.ResumeLayout(false);
            this.gGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tbNombre;
        private System.Windows.Forms.Label tbApellidos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label tbTelefono;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label tbEstatura;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label tbEdad;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox gGenero;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.Button btnGuaradar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

