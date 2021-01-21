namespace Projeto_cilindro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtnum3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Volume";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(182, 21);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 3;
            this.txtnum1.Enter += new System.EventHandler(this.txtnum1_Enter);
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(182, 49);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 4;
            // 
            // txtnum3
            // 
            this.txtnum3.Location = new System.Drawing.Point(182, 80);
            this.txtnum3.Name = "txtnum3";
            this.txtnum3.Size = new System.Drawing.Size(100, 20);
            this.txtnum3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 69);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnum3);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtnum3;
        private System.Windows.Forms.Button button1;
    }
}

