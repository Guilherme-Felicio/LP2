namespace Atividade6
{
    partial class frmExercicio2
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(175, 72);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 0;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(70, 75);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(55, 13);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "Número N";
            this.lblNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(175, 185);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(125, 48);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "Gerar numero H";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtNum);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnGerar;
    }
}