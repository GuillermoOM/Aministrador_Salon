namespace Salon
{
    partial class Editar_Clientes
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
            this.Aceptar = new System.Windows.Forms.Button();
            this.AgregarCliente = new System.Windows.Forms.Button();
            this.Tabla_Clientes = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aceptar
            // 
            this.Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Aceptar.Location = new System.Drawing.Point(364, 214);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 4;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // AgregarCliente
            // 
            this.AgregarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AgregarCliente.Location = new System.Drawing.Point(364, 12);
            this.AgregarCliente.Name = "AgregarCliente";
            this.AgregarCliente.Size = new System.Drawing.Size(75, 23);
            this.AgregarCliente.TabIndex = 6;
            this.AgregarCliente.Text = "Agregar";
            this.AgregarCliente.UseVisualStyleBackColor = true;
            this.AgregarCliente.Click += new System.EventHandler(this.AgregarCliente_Click);
            // 
            // Tabla_Clientes
            // 
            this.Tabla_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabla_Clientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Telefono});
            this.Tabla_Clientes.ContextMenuStrip = this.contextMenuStrip1;
            this.Tabla_Clientes.FullRowSelect = true;
            this.Tabla_Clientes.GridLines = true;
            this.Tabla_Clientes.HideSelection = false;
            this.Tabla_Clientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Tabla_Clientes.Location = new System.Drawing.Point(12, 11);
            this.Tabla_Clientes.MultiSelect = false;
            this.Tabla_Clientes.Name = "Tabla_Clientes";
            this.Tabla_Clientes.ShowGroups = false;
            this.Tabla_Clientes.Size = new System.Drawing.Size(346, 225);
            this.Tabla_Clientes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Tabla_Clientes.TabIndex = 8;
            this.Tabla_Clientes.UseCompatibleStateImageBehavior = false;
            this.Tabla_Clientes.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 219;
            // 
            // Telefono
            // 
            this.Telefono.Text = "Telefono";
            this.Telefono.Width = 122;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.EditarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.EliminarToolStripMenuItem_Click_1);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 248);
            this.Controls.Add(this.Tabla_Clientes);
            this.Controls.Add(this.AgregarCliente);
            this.Controls.Add(this.Aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button AgregarCliente;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Telefono;
        private System.Windows.Forms.ListView Tabla_Clientes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}