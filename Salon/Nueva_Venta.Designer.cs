namespace Salon
{
    partial class Nueva_Venta
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
            this.Servicio = new System.Windows.Forms.ComboBox();
            this.Es_AT = new System.Windows.Forms.ComboBox();
            this.Es_AS = new System.Windows.Forms.ComboBox();
            this.Precio = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Estimado = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Precio)).BeginInit();
            this.SuspendLayout();
            // 
            // Servicio
            // 
            this.Servicio.FormattingEnabled = true;
            this.Servicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Servicio.Location = new System.Drawing.Point(12, 31);
            this.Servicio.Name = "Servicio";
            this.Servicio.Size = new System.Drawing.Size(196, 21);
            this.Servicio.Sorted = true;
            this.Servicio.TabIndex = 0;
            // 
            // Es_AT
            // 
            this.Es_AT.FormattingEnabled = true;
            this.Es_AT.Location = new System.Drawing.Point(225, 31);
            this.Es_AT.Name = "Es_AT";
            this.Es_AT.Size = new System.Drawing.Size(196, 21);
            this.Es_AT.TabIndex = 1;
            // 
            // Es_AS
            // 
            this.Es_AS.FormattingEnabled = true;
            this.Es_AS.Location = new System.Drawing.Point(12, 80);
            this.Es_AS.Name = "Es_AS";
            this.Es_AS.Size = new System.Drawing.Size(196, 21);
            this.Es_AS.TabIndex = 2;
            // 
            // Precio
            // 
            this.Precio.DecimalPlaces = 2;
            this.Precio.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Precio.Location = new System.Drawing.Point(225, 81);
            this.Precio.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(83, 20);
            this.Precio.TabIndex = 3;
            this.Precio.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Atiende";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Asistente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Costo";
            // 
            // Estimado
            // 
            this.Estimado.AutoSize = true;
            this.Estimado.Location = new System.Drawing.Point(323, 83);
            this.Estimado.Name = "Estimado";
            this.Estimado.Size = new System.Drawing.Size(86, 13);
            this.Estimado.TabIndex = 8;
            this.Estimado.Text = "Costo Estimado: ";
            // 
            // Agregar
            // 
            this.Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Agregar.Location = new System.Drawing.Point(326, 110);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 9;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancelar.Location = new System.Drawing.Point(407, 110);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 10;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 142);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Estimado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Es_AS);
            this.Controls.Add(this.Es_AT);
            this.Controls.Add(this.Servicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Venta";
            this.Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)(this.Precio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Servicio;
        private System.Windows.Forms.ComboBox Es_AT;
        private System.Windows.Forms.ComboBox Es_AS;
        private System.Windows.Forms.NumericUpDown Precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Estimado;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Cancelar;
    }
}