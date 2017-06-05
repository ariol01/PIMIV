namespace ProjetoIntegrador.Formularios
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblIdAcesso = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtIdLogin = new System.Windows.Forms.TextBox();
            this.btnInscrever = new System.Windows.Forms.Button();
            this.btnLogar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdAcesso
            // 
            this.lblIdAcesso.AutoSize = true;
            this.lblIdAcesso.Location = new System.Drawing.Point(82, 16);
            this.lblIdAcesso.Name = "lblIdAcesso";
            this.lblIdAcesso.Size = new System.Drawing.Size(33, 13);
            this.lblIdAcesso.TabIndex = 0;
            this.lblIdAcesso.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(82, 52);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // txtIdLogin
            // 
            this.txtIdLogin.Location = new System.Drawing.Point(130, 13);
            this.txtIdLogin.Name = "txtIdLogin";
            this.txtIdLogin.Size = new System.Drawing.Size(100, 20);
            this.txtIdLogin.TabIndex = 2;
           
            // 
            // btnInscrever
            // 
            this.btnInscrever.Location = new System.Drawing.Point(104, 100);
            this.btnInscrever.Name = "btnInscrever";
            this.btnInscrever.Size = new System.Drawing.Size(75, 23);
            this.btnInscrever.TabIndex = 4;
            this.btnInscrever.Text = "Inscrever-se";
            this.btnInscrever.UseVisualStyleBackColor = true;
            this.btnInscrever.Click += new System.EventHandler(this.btnInscrever_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(197, 100);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLogar.TabIndex = 5;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.txtIdLogin);
            this.groupBox1.Controls.Add(this.lblSenha);
            this.groupBox1.Controls.Add(this.lblIdAcesso);
            this.groupBox1.Controls.Add(this.btnInscrever);
            this.groupBox1.Controls.Add(this.btnLogar);
            this.groupBox1.Location = new System.Drawing.Point(37, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 164);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(126, 49);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 6;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 288);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Acesso Sistema";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIdAcesso;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtIdLogin;
        private System.Windows.Forms.Button btnInscrever;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtSenha;
    }
}