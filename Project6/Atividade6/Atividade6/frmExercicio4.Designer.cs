namespace Atividade6
{
    partial class frmExercicio4
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblInscricao = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblProducao = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGratificacao = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtProducao = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtInscricao = new System.Windows.Forms.TextBox();
            this.btnSalBruto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(175, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 70);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblInscricao
            // 
            this.lblInscricao.AutoSize = true;
            this.lblInscricao.Location = new System.Drawing.Point(27, 106);
            this.lblInscricao.Name = "lblInscricao";
            this.lblInscricao.Size = new System.Drawing.Size(104, 13);
            this.lblInscricao.TabIndex = 2;
            this.lblInscricao.Text = "Numero de inscrição";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(27, 143);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "Cargo";
            // 
            // lblProducao
            // 
            this.lblProducao.AutoSize = true;
            this.lblProducao.Location = new System.Drawing.Point(27, 180);
            this.lblProducao.Name = "lblProducao";
            this.lblProducao.Size = new System.Drawing.Size(53, 13);
            this.lblProducao.TabIndex = 4;
            this.lblProducao.Text = "Produção";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(27, 218);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 5;
            this.lblSalario.Text = "Salário";
            this.lblSalario.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gratificação";
            // 
            // txtGratificacao
            // 
            this.txtGratificacao.Location = new System.Drawing.Point(175, 247);
            this.txtGratificacao.Name = "txtGratificacao";
            this.txtGratificacao.Size = new System.Drawing.Size(100, 20);
            this.txtGratificacao.TabIndex = 7;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(175, 211);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 8;
            // 
            // txtProducao
            // 
            this.txtProducao.Location = new System.Drawing.Point(175, 173);
            this.txtProducao.Name = "txtProducao";
            this.txtProducao.Size = new System.Drawing.Size(100, 20);
            this.txtProducao.TabIndex = 9;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(175, 136);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 10;
            // 
            // txtInscricao
            // 
            this.txtInscricao.Location = new System.Drawing.Point(175, 99);
            this.txtInscricao.Name = "txtInscricao";
            this.txtInscricao.Size = new System.Drawing.Size(100, 20);
            this.txtInscricao.TabIndex = 11;
            // 
            // btnSalBruto
            // 
            this.btnSalBruto.Location = new System.Drawing.Point(388, 213);
            this.btnSalBruto.Name = "btnSalBruto";
            this.btnSalBruto.Size = new System.Drawing.Size(208, 54);
            this.btnSalBruto.TabIndex = 12;
            this.btnSalBruto.Text = "Calcular Salário Bruto";
            this.btnSalBruto.UseVisualStyleBackColor = true;
            this.btnSalBruto.Click += new System.EventHandler(this.btnSalBruto_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalBruto);
            this.Controls.Add(this.txtInscricao);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtProducao);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtGratificacao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblProducao);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblInscricao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.Load += new System.EventHandler(this.frmExercicio4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblInscricao;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblProducao;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGratificacao;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtProducao;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtInscricao;
        private System.Windows.Forms.Button btnSalBruto;
    }
}