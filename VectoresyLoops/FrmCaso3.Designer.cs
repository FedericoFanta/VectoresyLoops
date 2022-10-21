namespace VectoresyLoops
{
    partial class FrmCaso3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOp1 = new System.Windows.Forms.TextBox();
            this.txtOp2 = new System.Windows.Forms.TextBox();
            this.txtOp3 = new System.Windows.Forms.TextBox();
            this.txtOp4 = new System.Windows.Forms.TextBox();
            this.btnSueldos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operarios";
            // 
            // txtOp1
            // 
            this.txtOp1.Location = new System.Drawing.Point(221, 44);
            this.txtOp1.Name = "txtOp1";
            this.txtOp1.Size = new System.Drawing.Size(100, 20);
            this.txtOp1.TabIndex = 1;
            // 
            // txtOp2
            // 
            this.txtOp2.Location = new System.Drawing.Point(221, 84);
            this.txtOp2.Name = "txtOp2";
            this.txtOp2.Size = new System.Drawing.Size(100, 20);
            this.txtOp2.TabIndex = 2;
            // 
            // txtOp3
            // 
            this.txtOp3.Location = new System.Drawing.Point(221, 121);
            this.txtOp3.Name = "txtOp3";
            this.txtOp3.Size = new System.Drawing.Size(100, 20);
            this.txtOp3.TabIndex = 3;
            // 
            // txtOp4
            // 
            this.txtOp4.Location = new System.Drawing.Point(221, 168);
            this.txtOp4.Name = "txtOp4";
            this.txtOp4.Size = new System.Drawing.Size(100, 20);
            this.txtOp4.TabIndex = 4;
            // 
            // btnSueldos
            // 
            this.btnSueldos.Location = new System.Drawing.Point(198, 236);
            this.btnSueldos.Name = "btnSueldos";
            this.btnSueldos.Size = new System.Drawing.Size(123, 23);
            this.btnSueldos.TabIndex = 5;
            this.btnSueldos.Text = "Cargar sueldos";
            this.btnSueldos.UseVisualStyleBackColor = true;
            this.btnSueldos.Click += new System.EventHandler(this.btnSueldos_Click);
            // 
            // FrmCaso3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSueldos);
            this.Controls.Add(this.txtOp4);
            this.Controls.Add(this.txtOp3);
            this.Controls.Add(this.txtOp2);
            this.Controls.Add(this.txtOp1);
            this.Controls.Add(this.label1);
            this.Name = "FrmCaso3";
            this.Text = "FrmCaso3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOp1;
        private System.Windows.Forms.TextBox txtOp2;
        private System.Windows.Forms.TextBox txtOp3;
        private System.Windows.Forms.TextBox txtOp4;
        private System.Windows.Forms.Button btnSueldos;
    }
}