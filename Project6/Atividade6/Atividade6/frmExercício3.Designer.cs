namespace Atividade6
{
    partial class frmExercício3
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
            this.rchtxtPalindromo = new System.Windows.Forms.RichTextBox();
            this.btnPalindromo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtPalindromo
            // 
            this.rchtxtPalindromo.Location = new System.Drawing.Point(12, 12);
            this.rchtxtPalindromo.Name = "rchtxtPalindromo";
            this.rchtxtPalindromo.Size = new System.Drawing.Size(776, 206);
            this.rchtxtPalindromo.TabIndex = 0;
            this.rchtxtPalindromo.Text = "";
            // 
            // btnPalindromo
            // 
            this.btnPalindromo.Location = new System.Drawing.Point(334, 254);
            this.btnPalindromo.Name = "btnPalindromo";
            this.btnPalindromo.Size = new System.Drawing.Size(128, 47);
            this.btnPalindromo.TabIndex = 1;
            this.btnPalindromo.Text = "Teste palíndromo ";
            this.btnPalindromo.UseVisualStyleBackColor = true;
            this.btnPalindromo.Click += new System.EventHandler(this.btnPalindromo_Click);
            // 
            // frmExercício3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPalindromo);
            this.Controls.Add(this.rchtxtPalindromo);
            this.Name = "frmExercício3";
            this.Text = "frmExercício3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtPalindromo;
        private System.Windows.Forms.Button btnPalindromo;
    }
}