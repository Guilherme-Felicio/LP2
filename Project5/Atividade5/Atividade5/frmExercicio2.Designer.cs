﻿namespace Atividade5
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
            this.components = new System.ComponentModel.Container();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.btnInsere1 = new System.Windows.Forms.Button();
            this.btnInsere2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(144, 91);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(162, 20);
            this.txtPalavra2.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(144, 41);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(162, 20);
            this.txtPalavra1.TabIndex = 2;
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(64, 230);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(104, 40);
            this.btnComparar.TabIndex = 3;
            this.btnComparar.Text = "Comparar  string 1 com string 2";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // btnInsere1
            // 
            this.btnInsere1.Location = new System.Drawing.Point(202, 230);
            this.btnInsere1.Name = "btnInsere1";
            this.btnInsere1.Size = new System.Drawing.Size(104, 40);
            this.btnInsere1.TabIndex = 4;
            this.btnInsere1.Text = "Insere palavra 1 na 2";
            this.btnInsere1.UseVisualStyleBackColor = true;
            this.btnInsere1.Click += new System.EventHandler(this.btnInsere1_Click);
            // 
            // btnInsere2
            // 
            this.btnInsere2.Location = new System.Drawing.Point(333, 230);
            this.btnInsere2.Name = "btnInsere2";
            this.btnInsere2.Size = new System.Drawing.Size(129, 40);
            this.btnInsere2.TabIndex = 5;
            this.btnInsere2.Text = "Insere ** no meio da palavra 1";
            this.btnInsere2.UseVisualStyleBackColor = true;
            this.btnInsere2.Click += new System.EventHandler(this.btnInsere2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Palavra 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Palavra 2";
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsere2);
            this.Controls.Add(this.btnInsere1);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.txtPalavra2);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Button btnInsere1;
        private System.Windows.Forms.Button btnInsere2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}