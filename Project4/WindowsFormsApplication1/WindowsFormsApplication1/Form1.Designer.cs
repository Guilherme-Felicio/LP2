namespace WindowsFormsApplication1
{
    partial class lblAliInss
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
            this.mskbxNome = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalariobruto = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.mskbxNumFilhos = new System.Windows.Forms.MaskedTextBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.btnVerificarDesconto = new System.Windows.Forms.Button();
            this.lblAliquotaInss = new System.Windows.Forms.Label();
            this.lblAliquotaIrpf = new System.Windows.Forms.Label();
            this.mskbxAliquotaINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliquotaIRPF = new System.Windows.Forms.MaskedTextBox();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.mskbxSalFamilia = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalLiquido = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.lblDescInss = new System.Windows.Forms.Label();
            this.lblDescIrpf = new System.Windows.Forms.Label();
            this.gbxCasado = new System.Windows.Forms.GroupBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.gbxSexo.SuspendLayout();
            this.gbxCasado.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskbxNome
            // 
            this.mskbxNome.Location = new System.Drawing.Point(146, 40);
            this.mskbxNome.Name = "mskbxNome";
            this.mskbxNome.Size = new System.Drawing.Size(100, 20);
            this.mskbxNome.TabIndex = 0;
            // 
            // mskbxSalariobruto
            // 
            this.mskbxSalariobruto.Location = new System.Drawing.Point(146, 74);
            this.mskbxSalariobruto.Mask = "9999999999.99";
            this.mskbxSalariobruto.Name = "mskbxSalariobruto";
            this.mskbxSalariobruto.Size = new System.Drawing.Size(100, 20);
            this.mskbxSalariobruto.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(38, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(90, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome funcionário";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(38, 74);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(67, 13);
            this.lblSalBruto.TabIndex = 3;
            this.lblSalBruto.Text = "Salário Bruto";
            this.lblSalBruto.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Location = new System.Drawing.Point(38, 107);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(89, 13);
            this.lblNumFilhos.TabIndex = 4;
            this.lblNumFilhos.Text = "Número de Filhos";
            // 
            // mskbxNumFilhos
            // 
            this.mskbxNumFilhos.Location = new System.Drawing.Point(146, 107);
            this.mskbxNumFilhos.Mask = "99";
            this.mskbxNumFilhos.Name = "mskbxNumFilhos";
            this.mskbxNumFilhos.Size = new System.Drawing.Size(100, 20);
            this.mskbxNumFilhos.TabIndex = 5;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMasc);
            this.gbxSexo.Controls.Add(this.rbtnFem);
            this.gbxSexo.Location = new System.Drawing.Point(332, 27);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(262, 100);
            this.gbxSexo.TabIndex = 6;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Location = new System.Drawing.Point(3, 16);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(31, 17);
            this.rbtnFem.TabIndex = 0;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "F";
            this.rbtnFem.UseVisualStyleBackColor = true;
            this.rbtnFem.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Location = new System.Drawing.Point(3, 60);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(34, 17);
            this.rbtnMasc.TabIndex = 1;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "M";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Location = new System.Drawing.Point(6, 19);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(61, 17);
            this.rbtnCasado.TabIndex = 7;
            this.rbtnCasado.TabStop = true;
            this.rbtnCasado.Text = "Casado";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // btnVerificarDesconto
            // 
            this.btnVerificarDesconto.Location = new System.Drawing.Point(75, 149);
            this.btnVerificarDesconto.Name = "btnVerificarDesconto";
            this.btnVerificarDesconto.Size = new System.Drawing.Size(154, 23);
            this.btnVerificarDesconto.TabIndex = 8;
            this.btnVerificarDesconto.Text = "Verificar Desconto";
            this.btnVerificarDesconto.UseVisualStyleBackColor = true;
            this.btnVerificarDesconto.Click += new System.EventHandler(this.btnVerificarDesconto_Click);
            // 
            // lblAliquotaInss
            // 
            this.lblAliquotaInss.AutoSize = true;
            this.lblAliquotaInss.Location = new System.Drawing.Point(38, 295);
            this.lblAliquotaInss.Name = "lblAliquotaInss";
            this.lblAliquotaInss.Size = new System.Drawing.Size(75, 13);
            this.lblAliquotaInss.TabIndex = 9;
            this.lblAliquotaInss.Text = "Alíquota INSS";
            // 
            // lblAliquotaIrpf
            // 
            this.lblAliquotaIrpf.AutoSize = true;
            this.lblAliquotaIrpf.Location = new System.Drawing.Point(38, 323);
            this.lblAliquotaIrpf.Name = "lblAliquotaIrpf";
            this.lblAliquotaIrpf.Size = new System.Drawing.Size(74, 13);
            this.lblAliquotaIrpf.TabIndex = 10;
            this.lblAliquotaIrpf.Text = "Alíquota IRPF";
            // 
            // mskbxAliquotaINSS
            // 
            this.mskbxAliquotaINSS.Enabled = false;
            this.mskbxAliquotaINSS.Location = new System.Drawing.Point(146, 292);
            this.mskbxAliquotaINSS.Name = "mskbxAliquotaINSS";
            this.mskbxAliquotaINSS.Size = new System.Drawing.Size(100, 20);
            this.mskbxAliquotaINSS.TabIndex = 11;
            // 
            // mskbxAliquotaIRPF
            // 
            this.mskbxAliquotaIRPF.Enabled = false;
            this.mskbxAliquotaIRPF.Location = new System.Drawing.Point(146, 323);
            this.mskbxAliquotaIRPF.Name = "mskbxAliquotaIRPF";
            this.mskbxAliquotaIRPF.Size = new System.Drawing.Size(100, 20);
            this.mskbxAliquotaIRPF.TabIndex = 12;
            this.mskbxAliquotaIRPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox5_MaskInputRejected);
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(38, 354);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(74, 13);
            this.lblSalarioFamilia.TabIndex = 13;
            this.lblSalarioFamilia.Text = "Salário Familia";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(38, 383);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(76, 13);
            this.lblSalarioLiquido.TabIndex = 14;
            this.lblSalarioLiquido.Text = "Sálario Liquido";
            // 
            // mskbxSalFamilia
            // 
            this.mskbxSalFamilia.Enabled = false;
            this.mskbxSalFamilia.Location = new System.Drawing.Point(146, 354);
            this.mskbxSalFamilia.Name = "mskbxSalFamilia";
            this.mskbxSalFamilia.Size = new System.Drawing.Size(100, 20);
            this.mskbxSalFamilia.TabIndex = 15;
            // 
            // mskbxSalLiquido
            // 
            this.mskbxSalLiquido.Enabled = false;
            this.mskbxSalLiquido.Location = new System.Drawing.Point(146, 383);
            this.mskbxSalLiquido.Name = "mskbxSalLiquido";
            this.mskbxSalLiquido.Size = new System.Drawing.Size(100, 20);
            this.mskbxSalLiquido.TabIndex = 16;
            // 
            // mskbxDescINSS
            // 
            this.mskbxDescINSS.Enabled = false;
            this.mskbxDescINSS.Location = new System.Drawing.Point(478, 295);
            this.mskbxDescINSS.Name = "mskbxDescINSS";
            this.mskbxDescINSS.Size = new System.Drawing.Size(100, 20);
            this.mskbxDescINSS.TabIndex = 17;
            // 
            // mskbxDescIRPF
            // 
            this.mskbxDescIRPF.Enabled = false;
            this.mskbxDescIRPF.Location = new System.Drawing.Point(478, 333);
            this.mskbxDescIRPF.Name = "mskbxDescIRPF";
            this.mskbxDescIRPF.Size = new System.Drawing.Size(100, 20);
            this.mskbxDescIRPF.TabIndex = 18;
            // 
            // lblDescInss
            // 
            this.lblDescInss.AutoSize = true;
            this.lblDescInss.Location = new System.Drawing.Point(355, 302);
            this.lblDescInss.Name = "lblDescInss";
            this.lblDescInss.Size = new System.Drawing.Size(81, 13);
            this.lblDescInss.TabIndex = 19;
            this.lblDescInss.Text = "Desconto INSS";
            // 
            // lblDescIrpf
            // 
            this.lblDescIrpf.AutoSize = true;
            this.lblDescIrpf.Location = new System.Drawing.Point(355, 333);
            this.lblDescIrpf.Name = "lblDescIrpf";
            this.lblDescIrpf.Size = new System.Drawing.Size(80, 13);
            this.lblDescIrpf.TabIndex = 20;
            this.lblDescIrpf.Text = "Desconto IRPF";
            // 
            // gbxCasado
            // 
            this.gbxCasado.Controls.Add(this.rbtnCasado);
            this.gbxCasado.Location = new System.Drawing.Point(335, 133);
            this.gbxCasado.Name = "gbxCasado";
            this.gbxCasado.Size = new System.Drawing.Size(200, 100);
            this.gbxCasado.TabIndex = 22;
            this.gbxCasado.TabStop = false;
            this.gbxCasado.Text = " ";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Enabled = false;
            this.lblDados.Location = new System.Drawing.Point(79, 199);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(13, 13);
            this.lblDados.TabIndex = 8;
            this.lblDados.Text = "  ";
            // 
            // lblAliInss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 442);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.gbxCasado);
            this.Controls.Add(this.lblDescIrpf);
            this.Controls.Add(this.lblDescInss);
            this.Controls.Add(this.mskbxDescIRPF);
            this.Controls.Add(this.mskbxDescINSS);
            this.Controls.Add(this.mskbxSalLiquido);
            this.Controls.Add(this.mskbxSalFamilia);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.mskbxAliquotaIRPF);
            this.Controls.Add(this.mskbxAliquotaINSS);
            this.Controls.Add(this.lblAliquotaIrpf);
            this.Controls.Add(this.lblAliquotaInss);
            this.Controls.Add(this.btnVerificarDesconto);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.mskbxNumFilhos);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.mskbxSalariobruto);
            this.Controls.Add(this.mskbxNome);
            this.Name = "lblAliInss";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.gbxCasado.ResumeLayout(false);
            this.gbxCasado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskbxNome;
        private System.Windows.Forms.MaskedTextBox mskbxSalariobruto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxNumFilhos;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.Button btnVerificarDesconto;
        private System.Windows.Forms.Label lblAliquotaInss;
        private System.Windows.Forms.Label lblAliquotaIrpf;
        private System.Windows.Forms.MaskedTextBox mskbxAliquotaINSS;
        private System.Windows.Forms.MaskedTextBox mskbxAliquotaIRPF;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.MaskedTextBox mskbxSalFamilia;
        private System.Windows.Forms.MaskedTextBox mskbxSalLiquido;
        private System.Windows.Forms.MaskedTextBox mskbxDescINSS;
        private System.Windows.Forms.MaskedTextBox mskbxDescIRPF;
        private System.Windows.Forms.Label lblDescInss;
        private System.Windows.Forms.Label lblDescIrpf;
        private System.Windows.Forms.GroupBox gbxCasado;
        private System.Windows.Forms.Label lblDados;
    }
}

