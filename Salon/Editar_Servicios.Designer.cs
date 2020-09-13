namespace Salon
{
    partial class Editar_Servicios
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
            this.Agregar_es = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Tabla_Servicios = new System.Windows.Forms.ListView();
            this.Servicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Agregar_es
            // 
            this.Agregar_es.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Agregar_es.Location = new System.Drawing.Point(330, 12);
            this.Agregar_es.Name = "Agregar_es";
            this.Agregar_es.Size = new System.Drawing.Size(75, 23);
            this.Agregar_es.TabIndex = 14;
            this.Agregar_es.Text = "Agregar";
            this.Agregar_es.UseVisualStyleBackColor = true;
            // 
            // Aceptar
            // 
            this.Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Aceptar.Location = new System.Drawing.Point(330, 264);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 12;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Tabla_Servicios
            // 
            this.Tabla_Servicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabla_Servicios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Servicio});
            this.Tabla_Servicios.FullRowSelect = true;
            this.Tabla_Servicios.GridLines = true;
            this.Tabla_Servicios.HideSelection = false;
            this.Tabla_Servicios.Location = new System.Drawing.Point(12, 12);
            this.Tabla_Servicios.Name = "Tabla_Servicios";
            this.Tabla_Servicios.Size = new System.Drawing.Size(312, 275);
            this.Tabla_Servicios.TabIndex = 18;
            this.Tabla_Servicios.UseCompatibleStateImageBehavior = false;
            this.Tabla_Servicios.View = System.Windows.Forms.View.Details;
            // 
            // Servicio
            // 
            this.Servicio.Text = "Servicio";
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 299);
            this.Controls.Add(this.Tabla_Servicios);
            this.Controls.Add(this.Agregar_es);
            this.Controls.Add(this.Aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Servicios";
            this.Text = "Servicios";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Agregar_es;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.ListView Tabla_Servicios;
        private System.Windows.Forms.ColumnHeader Servicio;
    }
}