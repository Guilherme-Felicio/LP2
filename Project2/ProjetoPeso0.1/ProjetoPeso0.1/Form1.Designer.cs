namespace ProjetoPeso0._1
{
    partial class Form1
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
            this.mskbxAltura = new System.Windows.Forms.MaskedTextBox();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.mskbxPeso = new System.Windows.Forms.MaskedTextBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskbxAltura
            // 
            this.mskbxAltura.Location = new System.Drawing.Point(134, 36);
            this.mskbxAltura.Mask = "9.99";
            this.mskbxAltura.Name = "mskbxAltura";
            this.mskbxAltura.Size = new System.Drawing.Size(100, 20);
            this.mskbxAltura.TabIndex = 0;
            this.mskbxAltura.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskbxAltura_MaskInputRejected);
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(84, 196);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 1;
            this.btnCalculo.Text = "Calcular";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Location = new System.Drawing.Point(6, 24);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(54, 17);
            this.rbtnMasc.TabIndex = 2;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "Masc.";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Location = new System.Drawing.Point(6, 65);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(48, 17);
            this.rbtnFem.TabIndex = 3;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "Fem.";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // mskbxPeso
            // 
            this.mskbxPeso.Location = new System.Drawing.Point(134, 77);
            this.mskbxPeso.Name = "mskbxPeso";
            this.mskbxPeso.Size = new System.Drawing.Size(100, 20);
            this.mskbxPeso.TabIndex = 4;
            this.mskbxPeso.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMasc);
            this.gbxSexo.Controls.Add(this.rbtnFem);
            this.gbxSexo.Location = new System.Drawing.Point(265, 12);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(200, 100);
            this.gbxSexo.TabIndex = 5;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(52, 36);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 6;
            this.lblAltura.Text = "Altura";
            this.lblAltura.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(52, 77);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(58, 13);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "Peso Atual";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 327);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.mskbxPeso);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.mskbxAltura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskbxAltura;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.MaskedTextBox mskbxPeso;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
    }
}

