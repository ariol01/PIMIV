namespace ProjetoIntegrador.Formularios
{
    partial class FormInscricao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscricao));
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.msktxtboxCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msktxtboxNumero = new System.Windows.Forms.MaskedTextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.msktxtboxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.msktxtboxCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.btnSalvarCadastro = new System.Windows.Forms.Button();
            this.lblCadastrarSenha = new System.Windows.Forms.Label();
            this.txtCadastrarSenha = new System.Windows.Forms.TextBox();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.gbDadosPessoais.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.label2);
            this.gbDadosPessoais.Controls.Add(this.msktxtboxCpf);
            this.gbDadosPessoais.Controls.Add(this.lblCpf);
            this.gbDadosPessoais.Controls.Add(this.txtNomeCompleto);
            this.gbDadosPessoais.Controls.Add(this.lblNomeCompleto);
            this.gbDadosPessoais.Location = new System.Drawing.Point(12, 12);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(420, 158);
            this.gbDadosPessoais.TabIndex = 1;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "(Somente Números)";
            // 
            // msktxtboxCpf
            // 
            this.msktxtboxCpf.Location = new System.Drawing.Point(121, 57);
            this.msktxtboxCpf.Mask = "999.999.999-99";
            this.msktxtboxCpf.Name = "msktxtboxCpf";
            this.msktxtboxCpf.Size = new System.Drawing.Size(82, 20);
            this.msktxtboxCpf.TabIndex = 3;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(28, 64);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(121, 25);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(255, 20);
            this.txtNomeCompleto.TabIndex = 1;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(28, 32);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(82, 13);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.label4);
            this.gbEndereco.Controls.Add(this.label3);
            this.gbEndereco.Controls.Add(this.label1);
            this.gbEndereco.Controls.Add(this.msktxtboxNumero);
            this.gbEndereco.Controls.Add(this.lblNumero);
            this.gbEndereco.Controls.Add(this.txtRua);
            this.gbEndereco.Controls.Add(this.lblRua);
            this.gbEndereco.Controls.Add(this.msktxtboxTelefone);
            this.gbEndereco.Controls.Add(this.lblTelefone);
            this.gbEndereco.Controls.Add(this.msktxtboxCep);
            this.gbEndereco.Controls.Add(this.lblCep);
            this.gbEndereco.Location = new System.Drawing.Point(16, 188);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(416, 180);
            this.gbEndereco.TabIndex = 2;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "(Somente Números)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "(Somente Números)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "(Somente Números)";
            // 
            // msktxtboxNumero
            // 
            this.msktxtboxNumero.Location = new System.Drawing.Point(117, 106);
            this.msktxtboxNumero.Mask = "99999999";
            this.msktxtboxNumero.Name = "msktxtboxNumero";
            this.msktxtboxNumero.Size = new System.Drawing.Size(63, 20);
            this.msktxtboxNumero.TabIndex = 7;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(24, 113);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(19, 13);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Nº";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(117, 69);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(255, 20);
            this.txtRua.TabIndex = 5;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(24, 76);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 13);
            this.lblRua.TabIndex = 4;
            this.lblRua.Text = "Rua";
            // 
            // msktxtboxTelefone
            // 
            this.msktxtboxTelefone.Location = new System.Drawing.Point(116, 143);
            this.msktxtboxTelefone.Mask = "(99) 9 9999-9999";
            this.msktxtboxTelefone.Name = "msktxtboxTelefone";
            this.msktxtboxTelefone.Size = new System.Drawing.Size(90, 20);
            this.msktxtboxTelefone.TabIndex = 3;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(24, 150);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // msktxtboxCep
            // 
            this.msktxtboxCep.Location = new System.Drawing.Point(117, 32);
            this.msktxtboxCep.Mask = "99999-999";
            this.msktxtboxCep.Name = "msktxtboxCep";
            this.msktxtboxCep.Size = new System.Drawing.Size(63, 20);
            this.msktxtboxCep.TabIndex = 1;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(24, 39);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 0;
            this.lblCep.Text = "CEP";
            // 
            // btnSalvarCadastro
            // 
            this.btnSalvarCadastro.Location = new System.Drawing.Point(168, 438);
            this.btnSalvarCadastro.Name = "btnSalvarCadastro";
            this.btnSalvarCadastro.Size = new System.Drawing.Size(103, 23);
            this.btnSalvarCadastro.TabIndex = 3;
            this.btnSalvarCadastro.Text = "Salvar e Gerar ID";
            this.btnSalvarCadastro.UseVisualStyleBackColor = true;
            this.btnSalvarCadastro.Click += new System.EventHandler(this.bttSalvarCadastro_Click);
            // 
            // lblCadastrarSenha
            // 
            this.lblCadastrarSenha.AutoSize = true;
            this.lblCadastrarSenha.Location = new System.Drawing.Point(40, 402);
            this.lblCadastrarSenha.Name = "lblCadastrarSenha";
            this.lblCadastrarSenha.Size = new System.Drawing.Size(86, 13);
            this.lblCadastrarSenha.TabIndex = 4;
            this.lblCadastrarSenha.Text = "Cadastrar Senha";
            // 
            // txtCadastrarSenha
            // 
            this.txtCadastrarSenha.Location = new System.Drawing.Point(132, 395);
            this.txtCadastrarSenha.Name = "txtCadastrarSenha";
            this.txtCadastrarSenha.Size = new System.Drawing.Size(182, 20);
            this.txtCadastrarSenha.TabIndex = 5;
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(369, 389);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(63, 26);
            this.btnAvancar.TabIndex = 6;
            this.btnAvancar.Text = "avancar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // FormInscricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 510);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.txtCadastrarSenha);
            this.Controls.Add(this.lblCadastrarSenha);
            this.Controls.Add(this.btnSalvarCadastro);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.gbDadosPessoais);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInscricao";
            this.Text = "Cadastro Funcionário";
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.MaskedTextBox msktxtboxCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktxtboxNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.MaskedTextBox msktxtboxTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox msktxtboxCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Button btnSalvarCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCadastrarSenha;
        private System.Windows.Forms.TextBox txtCadastrarSenha;
        private System.Windows.Forms.Button btnAvancar;
    }
}