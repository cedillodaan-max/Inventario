namespace Inventario
{
    partial class Form2
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
            this.BtnAsistencia = new System.Windows.Forms.Button();
            this.BtnTareas = new System.Windows.Forms.Button();
            this.BtnEE = new System.Windows.Forms.Button();
            this.BtnEx = new System.Windows.Forms.Button();
            this.BtnEv = new System.Windows.Forms.Button();
            this.BtnNF = new System.Windows.Forms.Button();
            this.BtnEAF = new System.Windows.Forms.Button();
            this.Btncasos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnAsistencia
            // 
            this.BtnAsistencia.Location = new System.Drawing.Point(70, 124);
            this.BtnAsistencia.Name = "BtnAsistencia";
            this.BtnAsistencia.Size = new System.Drawing.Size(75, 23);
            this.BtnAsistencia.TabIndex = 1;
            this.BtnAsistencia.Text = "Asistencia";
            this.BtnAsistencia.UseVisualStyleBackColor = true;
            // 
            // BtnTareas
            // 
            this.BtnTareas.Location = new System.Drawing.Point(198, 124);
            this.BtnTareas.Name = "BtnTareas";
            this.BtnTareas.Size = new System.Drawing.Size(75, 23);
            this.BtnTareas.TabIndex = 2;
            this.BtnTareas.Text = "Tareas";
            this.BtnTareas.UseVisualStyleBackColor = true;
            // 
            // BtnEE
            // 
            this.BtnEE.Location = new System.Drawing.Point(399, 124);
            this.BtnEE.Name = "BtnEE";
            this.BtnEE.Size = new System.Drawing.Size(75, 23);
            this.BtnEE.TabIndex = 3;
            this.BtnEE.Text = "Estudiantes retirados";
            this.BtnEE.UseVisualStyleBackColor = true;
            // 
            // BtnEx
            // 
            this.BtnEx.Location = new System.Drawing.Point(536, 124);
            this.BtnEx.Name = "BtnEx";
            this.BtnEx.Size = new System.Drawing.Size(75, 23);
            this.BtnEx.TabIndex = 4;
            this.BtnEx.Text = "Estudiantes Expulsados";
            this.BtnEx.UseVisualStyleBackColor = true;
            // 
            // BtnEv
            // 
            this.BtnEv.Location = new System.Drawing.Point(70, 202);
            this.BtnEv.Name = "BtnEv";
            this.BtnEv.Size = new System.Drawing.Size(75, 23);
            this.BtnEv.TabIndex = 5;
            this.BtnEv.Text = "Evaluacion";
            this.BtnEv.UseVisualStyleBackColor = true;
            // 
            // BtnNF
            // 
            this.BtnNF.Location = new System.Drawing.Point(198, 202);
            this.BtnNF.Name = "BtnNF";
            this.BtnNF.Size = new System.Drawing.Size(75, 23);
            this.BtnNF.TabIndex = 6;
            this.BtnNF.Text = "Nota Final";
            this.BtnNF.UseVisualStyleBackColor = true;
            // 
            // BtnEAF
            // 
            this.BtnEAF.Location = new System.Drawing.Point(399, 202);
            this.BtnEAF.Name = "BtnEAF";
            this.BtnEAF.Size = new System.Drawing.Size(75, 23);
            this.BtnEAF.TabIndex = 7;
            this.BtnEAF.Text = "Estudiantes con Allo Numero de Fallos";
            this.BtnEAF.UseVisualStyleBackColor = true;
            // 
            // Btncasos
            // 
            this.Btncasos.Location = new System.Drawing.Point(536, 202);
            this.Btncasos.Name = "Btncasos";
            this.Btncasos.Size = new System.Drawing.Size(75, 23);
            this.Btncasos.TabIndex = 8;
            this.Btncasos.Text = "Casos Especiales";
            this.Btncasos.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btncasos);
            this.Controls.Add(this.BtnEAF);
            this.Controls.Add(this.BtnNF);
            this.Controls.Add(this.BtnEv);
            this.Controls.Add(this.BtnEx);
            this.Controls.Add(this.BtnEE);
            this.Controls.Add(this.BtnTareas);
            this.Controls.Add(this.BtnAsistencia);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAsistencia;
        private System.Windows.Forms.Button BtnTareas;
        private System.Windows.Forms.Button BtnEE;
        private System.Windows.Forms.Button BtnEx;
        private System.Windows.Forms.Button BtnEv;
        private System.Windows.Forms.Button BtnNF;
        private System.Windows.Forms.Button BtnEAF;
        private System.Windows.Forms.Button Btncasos;
    }
}