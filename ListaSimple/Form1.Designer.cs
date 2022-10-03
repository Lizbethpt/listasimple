namespace ListaSimple
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
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(57, 54);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(100, 20);
            this.txtNodo.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(203, 52);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(134, 133);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(35, 13);
            this.lblLista.TabIndex = 2;
            this.lblLista.Text = "label1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(203, 81);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 285);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNodo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button btnEliminar;
    }
}

