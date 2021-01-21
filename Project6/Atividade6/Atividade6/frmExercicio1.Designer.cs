namespace Atividade6
{
    partial class frmExercicio1
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
            this.rchtxtExe1 = new System.Windows.Forms.RichTextBox();
            this.btnEspaços = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnPar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtExe1
            // 
            this.rchtxtExe1.Location = new System.Drawing.Point(12, 12);
            this.rchtxtExe1.Name = "rchtxtExe1";
            this.rchtxtExe1.Size = new System.Drawing.Size(764, 185);
            this.rchtxtExe1.TabIndex = 2;
            this.rchtxtExe1.Text = "";
            // 
            // btnEspaços
            // 
            this.btnEspaços.Location = new System.Drawing.Point(68, 266);
            this.btnEspaços.Name = "btnEspaços";
            this.btnEspaços.Size = new System.Drawing.Size(111, 55);
            this.btnEspaços.TabIndex = 3;
            this.btnEspaços.Text = "Numero de espaços";
            this.btnEspaços.UseVisualStyleBackColor = true;
            this.btnEspaços.Click += new System.EventHandler(this.btnEspaços_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(312, 266);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(119, 55);
            this.btnR.TabIndex = 4;
            this.btnR.Text = "Número de \"R\"";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnPar
            // 
            this.btnPar.Location = new System.Drawing.Point(540, 266);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(105, 55);
            this.btnPar.TabIndex = 5;
            this.btnPar.Text = "Par de letras";
            this.btnPar.UseVisualStyleBackColor = true;
            this.btnPar.Click += new System.EventHandler(this.btnPar_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnEspaços);
            this.Controls.Add(this.rchtxtExe1);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtExe1;
        private System.Windows.Forms.Button btnEspaços;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnPar;
    }
}