namespace VectoresyLoops
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
            this.btnPideDatos = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPideDatos
            // 
            this.btnPideDatos.Location = new System.Drawing.Point(201, 112);
            this.btnPideDatos.Name = "btnPideDatos";
            this.btnPideDatos.Size = new System.Drawing.Size(112, 23);
            this.btnPideDatos.TabIndex = 0;
            this.btnPideDatos.Text = "Cargar datos";
            this.btnPideDatos.UseVisualStyleBackColor = true;
            this.btnPideDatos.Click += new System.EventHandler(this.btnPideDatos_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(359, 112);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(128, 23);
            this.btnMostrarDatos.TabIndex = 1;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnPideDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPideDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
    }
}

