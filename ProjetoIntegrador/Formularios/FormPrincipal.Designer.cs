﻿namespace ProjetoIntegrador.Formularios
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.gbIngredientes = new System.Windows.Forms.GroupBox();
            this.txtValorIngredientes = new System.Windows.Forms.TextBox();
            this.lblValorIngredientes = new System.Windows.Forms.Label();
            this.lblTamanhoPizzaMontada = new System.Windows.Forms.Label();
            this.cBoxTamanhoPizzaMontada = new System.Windows.Forms.ComboBox();
            this.lblPeitoPeru = new System.Windows.Forms.Label();
            this.lblBacon = new System.Windows.Forms.Label();
            this.lblQueijo = new System.Windows.Forms.Label();
            this.gbSabores = new System.Windows.Forms.GroupBox();
            this.txtPrecoPizzaPronta = new System.Windows.Forms.TextBox();
            this.cBoxTamanhoPizzaPronta = new System.Windows.Forms.ComboBox();
            this.lblTamanhoPizzaPronta = new System.Windows.Forms.Label();
            this.btnFazerPedido = new System.Windows.Forms.Button();
            this.lblSabor = new System.Windows.Forms.Label();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.cBoxSabores = new System.Windows.Forms.ComboBox();
            this.lblTipoPizza = new System.Windows.Forms.Label();
            this.cBoxTipoPizza = new System.Windows.Forms.ComboBox();
            this.gbTipoCliente = new System.Windows.Forms.GroupBox();
            this.rbListarCLientes = new System.Windows.Forms.RadioButton();
            this.rbNovoCliente = new System.Windows.Forms.RadioButton();
            this.numQueijo = new System.Windows.Forms.NumericUpDown();
            this.numPeitoPeru = new System.Windows.Forms.NumericUpDown();
            this.numBacon = new System.Windows.Forms.NumericUpDown();
            this.gbIngredientes.SuspendLayout();
            this.gbSabores.SuspendLayout();
            this.gbTipoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQueijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeitoPeru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBacon)).BeginInit();
            this.SuspendLayout();
            // 
            // gbIngredientes
            // 
            this.gbIngredientes.Controls.Add(this.lblValorIngredientes);
            this.gbIngredientes.Controls.Add(this.cBoxTipoPizza);
            this.gbIngredientes.Controls.Add(this.numBacon);
            this.gbIngredientes.Controls.Add(this.numPeitoPeru);
            this.gbIngredientes.Controls.Add(this.numQueijo);
            this.gbIngredientes.Controls.Add(this.lblPeitoPeru);
            this.gbIngredientes.Controls.Add(this.lblBacon);
            this.gbIngredientes.Controls.Add(this.lblQueijo);
            this.gbIngredientes.Location = new System.Drawing.Point(366, 83);
            this.gbIngredientes.Name = "gbIngredientes";
            this.gbIngredientes.Size = new System.Drawing.Size(261, 227);
            this.gbIngredientes.TabIndex = 0;
            this.gbIngredientes.TabStop = false;
            this.gbIngredientes.Text = "Ingredientes";
            // 
            // txtValorIngredientes
            // 
            this.txtValorIngredientes.Location = new System.Drawing.Point(90, 140);
            this.txtValorIngredientes.Name = "txtValorIngredientes";
            this.txtValorIngredientes.Size = new System.Drawing.Size(120, 20);
            this.txtValorIngredientes.TabIndex = 0;
            // 
            // lblValorIngredientes
            // 
            this.lblValorIngredientes.AutoSize = true;
            this.lblValorIngredientes.Location = new System.Drawing.Point(6, 156);
            this.lblValorIngredientes.Name = "lblValorIngredientes";
            this.lblValorIngredientes.Size = new System.Drawing.Size(112, 13);
            this.lblValorIngredientes.TabIndex = 0;
            this.lblValorIngredientes.Text = "Valor em Ingredientes:";
            // 
            // lblTamanhoPizzaMontada
            // 
            this.lblTamanhoPizzaMontada.AutoSize = true;
            this.lblTamanhoPizzaMontada.Location = new System.Drawing.Point(6, 109);
            this.lblTamanhoPizzaMontada.Name = "lblTamanhoPizzaMontada";
            this.lblTamanhoPizzaMontada.Size = new System.Drawing.Size(140, 13);
            this.lblTamanhoPizzaMontada.TabIndex = 0;
            this.lblTamanhoPizzaMontada.Text = "Tamanho da Pizza Montada";
            // 
            // cBoxTamanhoPizzaMontada
            // 
            this.cBoxTamanhoPizzaMontada.FormattingEnabled = true;
            this.cBoxTamanhoPizzaMontada.Items.AddRange(new object[] {
            "Pequena",
            "Média",
            "Grande ",
            "Família"});
            this.cBoxTamanhoPizzaMontada.Location = new System.Drawing.Point(148, 104);
            this.cBoxTamanhoPizzaMontada.Name = "cBoxTamanhoPizzaMontada";
            this.cBoxTamanhoPizzaMontada.Size = new System.Drawing.Size(91, 21);
            this.cBoxTamanhoPizzaMontada.TabIndex = 0;
            // 
            // lblPeitoPeru
            // 
            this.lblPeitoPeru.AutoSize = true;
            this.lblPeitoPeru.Location = new System.Drawing.Point(23, 109);
            this.lblPeitoPeru.Name = "lblPeitoPeru";
            this.lblPeitoPeru.Size = new System.Drawing.Size(56, 13);
            this.lblPeitoPeru.TabIndex = 6;
            this.lblPeitoPeru.Text = "Peito Peru";
            // 
            // lblBacon
            // 
            this.lblBacon.AutoSize = true;
            this.lblBacon.Location = new System.Drawing.Point(23, 71);
            this.lblBacon.Name = "lblBacon";
            this.lblBacon.Size = new System.Drawing.Size(38, 13);
            this.lblBacon.TabIndex = 3;
            this.lblBacon.Text = "Bacon";
            // 
            // lblQueijo
            // 
            this.lblQueijo.AutoSize = true;
            this.lblQueijo.Location = new System.Drawing.Point(32, 37);
            this.lblQueijo.Name = "lblQueijo";
            this.lblQueijo.Size = new System.Drawing.Size(40, 13);
            this.lblQueijo.TabIndex = 0;
            this.lblQueijo.Text = "Queijo:";
            // 
            // gbSabores
            // 
            this.gbSabores.Controls.Add(this.txtValorIngredientes);
            this.gbSabores.Controls.Add(this.cBoxTamanhoPizzaMontada);
            this.gbSabores.Controls.Add(this.lblTamanhoPizzaMontada);
            this.gbSabores.Controls.Add(this.txtPrecoPizzaPronta);
            this.gbSabores.Controls.Add(this.cBoxTamanhoPizzaPronta);
            this.gbSabores.Controls.Add(this.lblTipoPizza);
            this.gbSabores.Controls.Add(this.lblTamanhoPizzaPronta);
            this.gbSabores.Controls.Add(this.btnFazerPedido);
            this.gbSabores.Controls.Add(this.lblSabor);
            this.gbSabores.Controls.Add(this.lblTotalValor);
            this.gbSabores.Controls.Add(this.cBoxSabores);
            this.gbSabores.Location = new System.Drawing.Point(633, 83);
            this.gbSabores.Name = "gbSabores";
            this.gbSabores.Size = new System.Drawing.Size(253, 299);
            this.gbSabores.TabIndex = 1;
            this.gbSabores.TabStop = false;
            this.gbSabores.Text = "Sabores Prontos";
            // 
            // txtPrecoPizzaPronta
            // 
            this.txtPrecoPizzaPronta.Location = new System.Drawing.Point(70, 207);
            this.txtPrecoPizzaPronta.Name = "txtPrecoPizzaPronta";
            this.txtPrecoPizzaPronta.Size = new System.Drawing.Size(169, 20);
            this.txtPrecoPizzaPronta.TabIndex = 6;
            // 
            // cBoxTamanhoPizzaPronta
            // 
            this.cBoxTamanhoPizzaPronta.FormattingEnabled = true;
            this.cBoxTamanhoPizzaPronta.Items.AddRange(new object[] {
            "Pequena",
            "Média",
            "Grande",
            "Família"});
            this.cBoxTamanhoPizzaPronta.Location = new System.Drawing.Point(102, 71);
            this.cBoxTamanhoPizzaPronta.Name = "cBoxTamanhoPizzaPronta";
            this.cBoxTamanhoPizzaPronta.Size = new System.Drawing.Size(137, 21);
            this.cBoxTamanhoPizzaPronta.TabIndex = 5;
            // 
            // lblTamanhoPizzaPronta
            // 
            this.lblTamanhoPizzaPronta.AutoSize = true;
            this.lblTamanhoPizzaPronta.Location = new System.Drawing.Point(6, 78);
            this.lblTamanhoPizzaPronta.Name = "lblTamanhoPizzaPronta";
            this.lblTamanhoPizzaPronta.Size = new System.Drawing.Size(95, 13);
            this.lblTamanhoPizzaPronta.TabIndex = 4;
            this.lblTamanhoPizzaPronta.Text = "Tamanho da Pizza";
            // 
            // btnFazerPedido
            // 
            this.btnFazerPedido.Location = new System.Drawing.Point(90, 245);
            this.btnFazerPedido.Name = "btnFazerPedido";
            this.btnFazerPedido.Size = new System.Drawing.Size(106, 23);
            this.btnFazerPedido.TabIndex = 3;
            this.btnFazerPedido.Text = "Fazer Pedido";
            this.btnFazerPedido.UseVisualStyleBackColor = true;
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Location = new System.Drawing.Point(6, 42);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(78, 13);
            this.lblSabor.TabIndex = 2;
            this.lblSabor.Text = "Sabor da Pizza";
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.AutoSize = true;
            this.lblTotalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValor.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblTotalValor.Location = new System.Drawing.Point(12, 207);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(48, 20);
            this.lblTotalValor.TabIndex = 1;
            this.lblTotalValor.Text = "Total:";
            // 
            // cBoxSabores
            // 
            this.cBoxSabores.FormattingEnabled = true;
            this.cBoxSabores.Items.AddRange(new object[] {
            "Calabresa",
            "Portuguesa",
            "Três Quijos",
            "Chocolate",
            "Frango"});
            this.cBoxSabores.Location = new System.Drawing.Point(102, 34);
            this.cBoxSabores.Name = "cBoxSabores";
            this.cBoxSabores.Size = new System.Drawing.Size(137, 21);
            this.cBoxSabores.TabIndex = 0;
            // 
            // lblTipoPizza
            // 
            this.lblTipoPizza.AutoSize = true;
            this.lblTipoPizza.Location = new System.Drawing.Point(13, 143);
            this.lblTipoPizza.Name = "lblTipoPizza";
            this.lblTipoPizza.Size = new System.Drawing.Size(71, 13);
            this.lblTipoPizza.TabIndex = 5;
            this.lblTipoPizza.Text = "Tipo de Pizza";
            // 
            // cBoxTipoPizza
            // 
            this.cBoxTipoPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxTipoPizza.FormattingEnabled = true;
            this.cBoxTipoPizza.Items.AddRange(new object[] {
            "Montada ",
            "Pronta"});
            this.cBoxTipoPizza.Location = new System.Drawing.Point(124, 153);
            this.cBoxTipoPizza.Name = "cBoxTipoPizza";
            this.cBoxTipoPizza.Size = new System.Drawing.Size(121, 21);
            this.cBoxTipoPizza.TabIndex = 6;
            // 
            // gbTipoCliente
            // 
            this.gbTipoCliente.Controls.Add(this.rbListarCLientes);
            this.gbTipoCliente.Controls.Add(this.rbNovoCliente);
            this.gbTipoCliente.Location = new System.Drawing.Point(12, 12);
            this.gbTipoCliente.Name = "gbTipoCliente";
            this.gbTipoCliente.Size = new System.Drawing.Size(121, 65);
            this.gbTipoCliente.TabIndex = 13;
            this.gbTipoCliente.TabStop = false;
            this.gbTipoCliente.Text = "Tipo de Cliente:";
            // 
            // rbListarCLientes
            // 
            this.rbListarCLientes.AutoSize = true;
            this.rbListarCLientes.Location = new System.Drawing.Point(9, 42);
            this.rbListarCLientes.Name = "rbListarCLientes";
            this.rbListarCLientes.Size = new System.Drawing.Size(90, 17);
            this.rbListarCLientes.TabIndex = 15;
            this.rbListarCLientes.TabStop = true;
            this.rbListarCLientes.Text = "Listar Clientes";
            this.rbListarCLientes.UseVisualStyleBackColor = true;
            this.rbListarCLientes.CheckedChanged += new System.EventHandler(this.rbListarCLientes_CheckedChanged);
            // 
            // rbNovoCliente
            // 
            this.rbNovoCliente.AutoSize = true;
            this.rbNovoCliente.Location = new System.Drawing.Point(9, 19);
            this.rbNovoCliente.Name = "rbNovoCliente";
            this.rbNovoCliente.Size = new System.Drawing.Size(51, 17);
            this.rbNovoCliente.TabIndex = 14;
            this.rbNovoCliente.TabStop = true;
            this.rbNovoCliente.Text = "Novo";
            this.rbNovoCliente.UseVisualStyleBackColor = true;
            this.rbNovoCliente.CheckedChanged += new System.EventHandler(this.rbNovoCliente_CheckedChanged);
            // 
            // numQueijo
            // 
            this.numQueijo.Location = new System.Drawing.Point(85, 37);
            this.numQueijo.Name = "numQueijo";
            this.numQueijo.Size = new System.Drawing.Size(120, 20);
            this.numQueijo.TabIndex = 9;
            // 
            // numPeitoPeru
            // 
            this.numPeitoPeru.Location = new System.Drawing.Point(85, 102);
            this.numPeitoPeru.Name = "numPeitoPeru";
            this.numPeitoPeru.Size = new System.Drawing.Size(120, 20);
            this.numPeitoPeru.TabIndex = 10;
            // 
            // numBacon
            // 
            this.numBacon.Location = new System.Drawing.Point(85, 69);
            this.numBacon.Name = "numBacon";
            this.numBacon.Size = new System.Drawing.Size(120, 20);
            this.numBacon.TabIndex = 11;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 505);
            this.Controls.Add(this.gbTipoCliente);
            this.Controls.Add(this.gbSabores);
            this.Controls.Add(this.gbIngredientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Text = "Pedido ";
            this.gbIngredientes.ResumeLayout(false);
            this.gbIngredientes.PerformLayout();
            this.gbSabores.ResumeLayout(false);
            this.gbSabores.PerformLayout();
            this.gbTipoCliente.ResumeLayout(false);
            this.gbTipoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQueijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeitoPeru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBacon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIngredientes;
        private System.Windows.Forms.Label lblQueijo;
        private System.Windows.Forms.Label lblBacon;
        private System.Windows.Forms.GroupBox gbSabores;
        private System.Windows.Forms.Label lblPeitoPeru;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.ComboBox cBoxSabores;
        private System.Windows.Forms.ComboBox cBoxTamanhoPizzaMontada;
        private System.Windows.Forms.ComboBox cBoxTamanhoPizzaPronta;
        private System.Windows.Forms.Label lblTamanhoPizzaPronta;
        private System.Windows.Forms.Button btnFazerPedido;
        private System.Windows.Forms.Label lblTamanhoPizzaMontada;
        private System.Windows.Forms.Label lblValorIngredientes;
        private System.Windows.Forms.TextBox txtPrecoPizzaPronta;
        private System.Windows.Forms.TextBox txtValorIngredientes;
        private System.Windows.Forms.Label lblTipoPizza;
        private System.Windows.Forms.ComboBox cBoxTipoPizza;
        private System.Windows.Forms.GroupBox gbTipoCliente;
        private System.Windows.Forms.RadioButton rbListarCLientes;
        private System.Windows.Forms.RadioButton rbNovoCliente;
        private System.Windows.Forms.NumericUpDown numBacon;
        private System.Windows.Forms.NumericUpDown numPeitoPeru;
        private System.Windows.Forms.NumericUpDown numQueijo;
    }
}