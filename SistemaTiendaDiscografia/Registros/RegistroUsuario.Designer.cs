namespace SistemaTiendaDiscografia
{
    partial class RegistroUsuario
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
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ContrasenatextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.ConfirmarContrasenatextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buscarbutton.Location = new System.Drawing.Point(111, 25);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(60, 31);
            this.Buscarbutton.TabIndex = 0;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ContrasenatextBox
            // 
            this.ContrasenatextBox.Location = new System.Drawing.Point(252, 27);
            this.ContrasenatextBox.MaxLength = 10;
            this.ContrasenatextBox.Name = "ContrasenatextBox";
            this.ContrasenatextBox.PasswordChar = '*';
            this.ContrasenatextBox.Size = new System.Drawing.Size(108, 20);
            this.ContrasenatextBox.TabIndex = 2;
            this.ContrasenatextBox.TextChanged += new System.EventHandler(this.ContrasenatextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirmar ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(71, 31);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(34, 20);
            this.IdtextBox.TabIndex = 6;
            this.IdtextBox.TextChanged += new System.EventHandler(this.IdtextBox_TextChanged);
            this.IdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdtextBox_KeyPress);
            // 
            // ConfirmarContrasenatextBox
            // 
            this.ConfirmarContrasenatextBox.Location = new System.Drawing.Point(252, 72);
            this.ConfirmarContrasenatextBox.MaxLength = 10;
            this.ConfirmarContrasenatextBox.Name = "ConfirmarContrasenatextBox";
            this.ConfirmarContrasenatextBox.PasswordChar = '*';
            this.ConfirmarContrasenatextBox.Size = new System.Drawing.Size(108, 20);
            this.ConfirmarContrasenatextBox.TabIndex = 7;
            this.ConfirmarContrasenatextBox.TextChanged += new System.EventHandler(this.ConfirmarContrasenatextBox_TextChanged);
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(71, 72);
            this.NombretextBox.MaxLength = 12;
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(100, 20);
            this.NombretextBox.TabIndex = 8;
            this.NombretextBox.TextChanged += new System.EventHandler(this.NombretextBox_TextChanged);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nuevobutton.Location = new System.Drawing.Point(262, 131);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(95, 31);
            this.Nuevobutton.TabIndex = 9;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Eliminarbutton.Location = new System.Drawing.Point(161, 131);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(95, 33);
            this.Eliminarbutton.TabIndex = 10;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guardarbutton.Location = new System.Drawing.Point(71, 132);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(84, 33);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::SistemaTiendaDiscografia.Properties.Resources.j;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(381, 219);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.ConfirmarContrasenatextBox);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContrasenatextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscarbutton);
            this.DoubleBuffered = true;
            this.Name = "RegistroUsuario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ContrasenatextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.TextBox ConfirmarContrasenatextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
    }
}

