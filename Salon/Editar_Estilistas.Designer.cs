namespace Salon
{
    partial class Editar_Estilistas
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
            this.Aplicar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Agregar_es = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Aplicar
            // 
            this.Aplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Aplicar.Location = new System.Drawing.Point(250, 232);
            this.Aplicar.Name = "Aplicar";
            this.Aplicar.Size = new System.Drawing.Size(75, 23);
            this.Aplicar.TabIndex = 4;
            this.Aplicar.Text = "Aceptar";
            this.Aplicar.UseVisualStyleBackColor = true;
            this.Aplicar.Click += new System.EventHandler(this.Aplicar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Estilistas";
            // 
            // Agregar_es
            // 
            this.Agregar_es.Location = new System.Drawing.Point(250, 30);
            this.Agregar_es.Name = "Agregar_es";
            this.Agregar_es.Size = new System.Drawing.Size(75, 23);
            this.Agregar_es.TabIndex = 9;
            this.Agregar_es.Text = "Agregar";
            this.Agregar_es.UseVisualStyleBackColor = true;
            this.Agregar_es.Click += new System.EventHandler(this.Agregar_es_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(13, 30);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(231, 225);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Estilistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 267);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Agregar_es);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aplicar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Estilistas";
            this.Text = "Editar Estilistas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aplicar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Agregar_es;
        private System.Windows.Forms.ListView listView1;
    }
}