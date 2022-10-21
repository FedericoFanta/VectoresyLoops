namespace VectoresyLoops
{
    partial class FrmCaso5
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
            this.txtProvincia1 = new System.Windows.Forms.TextBox();
            this.txtProvincia2 = new System.Windows.Forms.TextBox();
            this.txtProvincia3 = new System.Windows.Forms.TextBox();
            this.txtProvincia4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTemperaturas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProvincia1
            // 
            this.txtProvincia1.Location = new System.Drawing.Point(171, 99);
            this.txtProvincia1.Name = "txtProvincia1";
            this.txtProvincia1.Size = new System.Drawing.Size(100, 20);
            this.txtProvincia1.TabIndex = 0;
            // 
            // txtProvincia2
            // 
            this.txtProvincia2.Location = new System.Drawing.Point(171, 148);
            this.txtProvincia2.Name = "txtProvincia2";
            this.txtProvincia2.Size = new System.Drawing.Size(100, 20);
            this.txtProvincia2.TabIndex = 1;
            // 
            // txtProvincia3
            // 
            this.txtProvincia3.Location = new System.Drawing.Point(171, 194);
            this.txtProvincia3.Name = "txtProvincia3";
            this.txtProvincia3.Size = new System.Drawing.Size(100, 20);
            this.txtProvincia3.TabIndex = 2;
            // 
            // txtProvincia4
            // 
            this.txtProvincia4.Location = new System.Drawing.Point(171, 237);
            this.txtProvincia4.Name = "txtProvincia4";
            this.txtProvincia4.Size = new System.Drawing.Size(100, 20);
            this.txtProvincia4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Provincias:";
            // 
            // btnTemperaturas
            // 
            this.btnTemperaturas.Location = new System.Drawing.Point(171, 313);
            this.btnTemperaturas.Name = "btnTemperaturas";
            this.btnTemperaturas.Size = new System.Drawing.Size(173, 23);
            this.btnTemperaturas.TabIndex = 5;
            this.btnTemperaturas.Text = "Calcular Temperaturas";
            this.btnTemperaturas.UseVisualStyleBackColor = true;
            this.btnTemperaturas.Click += new System.EventHandler(this.btnTemperaturas_Click);
            // 
            // FrmCaso5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTemperaturas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProvincia4);
            this.Controls.Add(this.txtProvincia3);
            this.Controls.Add(this.txtProvincia2);
            this.Controls.Add(this.txtProvincia1);
            this.Name = "FrmCaso5";
            this.Text = "FrmCaso5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProvincia1;
        private System.Windows.Forms.TextBox txtProvincia2;
        private System.Windows.Forms.TextBox txtProvincia3;
        private System.Windows.Forms.TextBox txtProvincia4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemperaturas;
    }
}