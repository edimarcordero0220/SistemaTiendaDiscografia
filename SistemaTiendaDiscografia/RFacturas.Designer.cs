﻿namespace SistemaTiendaDiscografia
{
    partial class RFacturas
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
            this.FacturaIdtextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DescripcionDiscotextBox = new System.Windows.Forms.TextBox();
            this.IdDiscotextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.ClienteIdtextBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eliminarfilabutton = new System.Windows.Forms.Button();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarDiscbutton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.BuscarClienteButton = new System.Windows.Forms.Button();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ModificadorcomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // FacturaIdtextBox
            // 
            this.FacturaIdtextBox.Location = new System.Drawing.Point(75, 19);
            this.FacturaIdtextBox.Name = "FacturaIdtextBox";
            this.FacturaIdtextBox.Size = new System.Drawing.Size(80, 20);
            this.FacturaIdtextBox.TabIndex = 0;
            this.FacturaIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FacturaIdtextBox_KeyPress);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(185, 19);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 1;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre Disco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Id Discos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cliente Id";
            // 
            // DescripcionDiscotextBox
            // 
            this.DescripcionDiscotextBox.Location = new System.Drawing.Point(325, 19);
            this.DescripcionDiscotextBox.Name = "DescripcionDiscotextBox";
            this.DescripcionDiscotextBox.Size = new System.Drawing.Size(128, 20);
            this.DescripcionDiscotextBox.TabIndex = 10;
            // 
            // IdDiscotextBox
            // 
            this.IdDiscotextBox.Location = new System.Drawing.Point(61, 19);
            this.IdDiscotextBox.Name = "IdDiscotextBox";
            this.IdDiscotextBox.Size = new System.Drawing.Size(80, 20);
            this.IdDiscotextBox.TabIndex = 11;
            this.IdDiscotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdDiscotextBox_KeyPress);
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(227, 23);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(100, 20);
            this.NombretextBox.TabIndex = 12;
            // 
            // ClienteIdtextBox
            // 
            this.ClienteIdtextBox.Location = new System.Drawing.Point(77, 19);
            this.ClienteIdtextBox.Name = "ClienteIdtextBox";
            this.ClienteIdtextBox.Size = new System.Drawing.Size(80, 20);
            this.ClienteIdtextBox.TabIndex = 13;
            this.ClienteIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClienteIdtextBox_KeyPress);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(254, 457);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 14;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(622, 17);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 23);
            this.Agregarbutton.TabIndex = 15;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(366, 18);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.FechadateTimePicker.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eliminarfilabutton);
            this.groupBox1.Controls.Add(this.PreciotextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BuscarDiscbutton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Agregarbutton);
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Controls.Add(this.IdDiscotextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DescripcionDiscotextBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 241);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Factura";
            // 
            // eliminarfilabutton
            // 
            this.eliminarfilabutton.Location = new System.Drawing.Point(679, 100);
            this.eliminarfilabutton.Name = "eliminarfilabutton";
            this.eliminarfilabutton.Size = new System.Drawing.Size(57, 23);
            this.eliminarfilabutton.TabIndex = 23;
            this.eliminarfilabutton.Text = "Eliminar";
            this.eliminarfilabutton.UseVisualStyleBackColor = true;
            this.eliminarfilabutton.Click += new System.EventHandler(this.eliminarfilabutton_Click);
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(534, 18);
            this.PreciotextBox.MaxLength = 3;
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(80, 20);
            this.PreciotextBox.TabIndex = 21;
            this.PreciotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreciotextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Precio";
            // 
            // BuscarDiscbutton
            // 
            this.BuscarDiscbutton.Location = new System.Drawing.Point(164, 15);
            this.BuscarDiscbutton.Name = "BuscarDiscbutton";
            this.BuscarDiscbutton.Size = new System.Drawing.Size(75, 23);
            this.BuscarDiscbutton.TabIndex = 21;
            this.BuscarDiscbutton.Text = "Buscar";
            this.BuscarDiscbutton.UseVisualStyleBackColor = true;
            this.BuscarDiscbutton.Click += new System.EventHandler(this.BuscarDiscbutton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 46);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(668, 181);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(416, 457);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 18;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(335, 457);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 19;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // BuscarClienteButton
            // 
            this.BuscarClienteButton.Location = new System.Drawing.Point(336, 20);
            this.BuscarClienteButton.Name = "BuscarClienteButton";
            this.BuscarClienteButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarClienteButton.TabIndex = 20;
            this.BuscarClienteButton.Text = "Buscar";
            this.BuscarClienteButton.UseVisualStyleBackColor = true;
            this.BuscarClienteButton.Click += new System.EventHandler(this.BuscarClienteButton_Click);
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(627, 457);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(80, 20);
            this.TotaltextBox.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fecha";
            // 
            // ModificadorcomboBox
            // 
            this.ModificadorcomboBox.FormattingEnabled = true;
            this.ModificadorcomboBox.Location = new System.Drawing.Point(615, 19);
            this.ModificadorcomboBox.Name = "ModificadorcomboBox";
            this.ModificadorcomboBox.Size = new System.Drawing.Size(121, 21);
            this.ModificadorcomboBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Usuario Modificador";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClienteIdtextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.NombretextBox);
            this.groupBox2.Controls.Add(this.BuscarClienteButton);
            this.groupBox2.Location = new System.Drawing.Point(10, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 52);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FacturaIdtextBox);
            this.groupBox3.Controls.Add(this.Buscarbutton);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.ModificadorcomboBox);
            this.groupBox3.Controls.Add(this.FechadateTimePicker);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(744, 54);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Factura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(318, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 47);
            this.label9.TabIndex = 27;
            this.label9.Text = "Factura";
            // 
            // RFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(766, 492);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Nuevobutton);
            this.Name = "RFacturas";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FacturaIdtextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DescripcionDiscotextBox;
        private System.Windows.Forms.TextBox IdDiscotextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox ClienteIdtextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button BuscarClienteButton;
        private System.Windows.Forms.Button BuscarDiscbutton;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Button eliminarfilabutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ModificadorcomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
    }
}