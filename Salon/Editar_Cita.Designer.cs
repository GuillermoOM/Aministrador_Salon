namespace Salon
{
    partial class Editar_Cita
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
            this.Generar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Servicios = new System.Windows.Forms.ListBox();
            this.agregar_serv = new System.Windows.Forms.Button();
            this.Fecha_cita = new System.Windows.Forms.DateTimePicker();
            this.eliminar_serv = new System.Windows.Forms.Button();
            this.Es_cliente = new System.Windows.Forms.CheckBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellido_1 = new System.Windows.Forms.TextBox();
            this.Apellido_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Hora_Cita = new System.Windows.Forms.DateTimePicker();
            this.Elegir_cliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Generar
            // 
            this.Generar.Location = new System.Drawing.Point(508, 256);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(75, 36);
            this.Generar.TabIndex = 22;
            this.Generar.Text = "Generar Cita";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Servicios";
            // 
            // Servicios
            // 
            this.Servicios.FormattingEnabled = true;
            this.Servicios.Location = new System.Drawing.Point(248, 45);
            this.Servicios.Name = "Servicios";
            this.Servicios.ScrollAlwaysVisible = true;
            this.Servicios.Size = new System.Drawing.Size(232, 277);
            this.Servicios.Sorted = true;
            this.Servicios.TabIndex = 18;
            // 
            // agregar_serv
            // 
            this.agregar_serv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_serv.Location = new System.Drawing.Point(418, 12);
            this.agregar_serv.Name = "agregar_serv";
            this.agregar_serv.Size = new System.Drawing.Size(28, 25);
            this.agregar_serv.TabIndex = 17;
            this.agregar_serv.Text = "+";
            this.agregar_serv.UseVisualStyleBackColor = true;
            this.agregar_serv.Click += new System.EventHandler(this.agregar_serv_Click);
            // 
            // Fecha_cita
            // 
            this.Fecha_cita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha_cita.Location = new System.Drawing.Point(15, 302);
            this.Fecha_cita.Name = "Fecha_cita";
            this.Fecha_cita.Size = new System.Drawing.Size(109, 20);
            this.Fecha_cita.TabIndex = 16;
            this.Fecha_cita.Value = new System.DateTime(2016, 6, 29, 0, 0, 0, 0);
            // 
            // eliminar_serv
            // 
            this.eliminar_serv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_serv.Location = new System.Drawing.Point(452, 12);
            this.eliminar_serv.Name = "eliminar_serv";
            this.eliminar_serv.Size = new System.Drawing.Size(28, 25);
            this.eliminar_serv.TabIndex = 23;
            this.eliminar_serv.Text = "-";
            this.eliminar_serv.UseVisualStyleBackColor = true;
            // 
            // Es_cliente
            // 
            this.Es_cliente.AutoSize = true;
            this.Es_cliente.Location = new System.Drawing.Point(15, 17);
            this.Es_cliente.Name = "Es_cliente";
            this.Es_cliente.Size = new System.Drawing.Size(109, 17);
            this.Es_cliente.TabIndex = 24;
            this.Es_cliente.Text = "Cliente Salon 16?";
            this.Es_cliente.UseVisualStyleBackColor = true;
            this.Es_cliente.CheckedChanged += new System.EventHandler(this.Es_cliente_CheckedChanged);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(15, 128);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(214, 20);
            this.Nombre.TabIndex = 25;
            // 
            // Apellido_1
            // 
            this.Apellido_1.Location = new System.Drawing.Point(15, 167);
            this.Apellido_1.Name = "Apellido_1";
            this.Apellido_1.Size = new System.Drawing.Size(214, 20);
            this.Apellido_1.TabIndex = 26;
            // 
            // Apellido_2
            // 
            this.Apellido_2.Location = new System.Drawing.Point(15, 206);
            this.Apellido_2.Name = "Apellido_2";
            this.Apellido_2.Size = new System.Drawing.Size(214, 20);
            this.Apellido_2.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Primer apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Segundo apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Hora";
            // 
            // Hora_Cita
            // 
            this.Hora_Cita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Hora_Cita.Location = new System.Drawing.Point(143, 302);
            this.Hora_Cita.Name = "Hora_Cita";
            this.Hora_Cita.ShowUpDown = true;
            this.Hora_Cita.Size = new System.Drawing.Size(99, 20);
            this.Hora_Cita.TabIndex = 32;
            // 
            // Elegir_cliente
            // 
            this.Elegir_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Elegir_cliente.Enabled = false;
            this.Elegir_cliente.FormattingEnabled = true;
            this.Elegir_cliente.Location = new System.Drawing.Point(15, 60);
            this.Elegir_cliente.Name = "Elegir_cliente";
            this.Elegir_cliente.Size = new System.Drawing.Size(214, 21);
            this.Elegir_cliente.Sorted = true;
            this.Elegir_cliente.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Telefono";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(15, 250);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(214, 20);
            this.telefono.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Elegir cliente existente";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(508, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(505, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Precio:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(508, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 39;
            this.textBox1.TabStop = false;
            // 
            // Editar_Cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 332);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Elegir_cliente);
            this.Controls.Add(this.Hora_Cita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Apellido_2);
            this.Controls.Add(this.Apellido_1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Es_cliente);
            this.Controls.Add(this.eliminar_serv);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Servicios);
            this.Controls.Add(this.agregar_serv);
            this.Controls.Add(this.Fecha_cita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Editar_Cita";
            this.Text = "Configurar Cita";
            this.Load += new System.EventHandler(this.Cita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Servicios;
        private System.Windows.Forms.Button agregar_serv;
        private System.Windows.Forms.DateTimePicker Fecha_cita;
        private System.Windows.Forms.Button eliminar_serv;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellido_1;
        private System.Windows.Forms.TextBox Apellido_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Hora_Cita;
        private System.Windows.Forms.ComboBox Elegir_cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.CheckBox Es_cliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
    }
}