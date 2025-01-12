﻿namespace InterfaceEstoque
{
    partial class FormGerenciarEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerenciarEstoque));
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.addIngrediente = new System.Windows.Forms.Button();
            this.removeIngrediente = new System.Windows.Forms.Button();
            this.attIngrediente = new System.Windows.Forms.Button();
            this.cadastrarIngrediente = new System.Windows.Forms.Button();
            this.esvaziarEstoque = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.completarEstoque = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDados.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDados.Location = new System.Drawing.Point(187, 31);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(566, 236);
            this.dgvDados.TabIndex = 0;
            // 
            // addIngrediente
            // 
            this.addIngrediente.BackgroundImage = global::InterfaceEstoque.Properties.Resources.fundoButtom;
            this.addIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIngrediente.Location = new System.Drawing.Point(187, 311);
            this.addIngrediente.Name = "addIngrediente";
            this.addIngrediente.Size = new System.Drawing.Size(164, 41);
            this.addIngrediente.TabIndex = 1;
            this.addIngrediente.Text = "Adicionar/Remover quantidade ingrediente";
            this.addIngrediente.UseVisualStyleBackColor = true;
            this.addIngrediente.Click += new System.EventHandler(this.buttonAddIngrediente_Click);
            // 
            // removeIngrediente
            // 
            this.removeIngrediente.BackgroundImage = global::InterfaceEstoque.Properties.Resources.fundoButtom;
            this.removeIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeIngrediente.Location = new System.Drawing.Point(391, 311);
            this.removeIngrediente.Name = "removeIngrediente";
            this.removeIngrediente.Size = new System.Drawing.Size(164, 41);
            this.removeIngrediente.TabIndex = 2;
            this.removeIngrediente.Text = "Remover ingrediente do estoque";
            this.removeIngrediente.UseVisualStyleBackColor = true;
            this.removeIngrediente.Click += new System.EventHandler(this.buttonRemoveIngrediente_Click);
            // 
            // attIngrediente
            // 
            this.attIngrediente.BackgroundImage = global::InterfaceEstoque.Properties.Resources.fundoButtom;
            this.attIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attIngrediente.Location = new System.Drawing.Point(589, 311);
            this.attIngrediente.Name = "attIngrediente";
            this.attIngrediente.Size = new System.Drawing.Size(164, 41);
            this.attIngrediente.TabIndex = 3;
            this.attIngrediente.Text = "Atualizar informações ingrediente";
            this.attIngrediente.UseVisualStyleBackColor = true;
            this.attIngrediente.Click += new System.EventHandler(this.buttonAttIngrediente_Click);
            // 
            // cadastrarIngrediente
            // 
            this.cadastrarIngrediente.BackgroundImage = global::InterfaceEstoque.Properties.Resources.fundoButtom;
            this.cadastrarIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarIngrediente.Location = new System.Drawing.Point(187, 386);
            this.cadastrarIngrediente.Name = "cadastrarIngrediente";
            this.cadastrarIngrediente.Size = new System.Drawing.Size(164, 41);
            this.cadastrarIngrediente.TabIndex = 4;
            this.cadastrarIngrediente.Text = "Cadastrar Ingrediente";
            this.cadastrarIngrediente.UseVisualStyleBackColor = true;
            this.cadastrarIngrediente.Click += new System.EventHandler(this.buttonCadastrarIngrediente_Click);
            // 
            // esvaziarEstoque
            // 
            this.esvaziarEstoque.BackgroundImage = global::InterfaceEstoque.Properties.Resources.fundoButtom;
            this.esvaziarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esvaziarEstoque.Location = new System.Drawing.Point(391, 386);
            this.esvaziarEstoque.Name = "esvaziarEstoque";
            this.esvaziarEstoque.Size = new System.Drawing.Size(164, 41);
            this.esvaziarEstoque.TabIndex = 5;
            this.esvaziarEstoque.Text = "Esvaziar Estoque";
            this.esvaziarEstoque.UseVisualStyleBackColor = true;
            this.esvaziarEstoque.Click += new System.EventHandler(this.buttonEsvaziarEstoque_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.Firebrick;
            this.buttonVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.ForeColor = System.Drawing.Color.Silver;
            this.buttonVoltar.Location = new System.Drawing.Point(106, 31);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 6;
            this.buttonVoltar.Text = "VOLTAR";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // completarEstoque
            // 
            this.completarEstoque.BackgroundImage = global::InterfaceEstoque.Properties.Resources.fundoButtom;
            this.completarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completarEstoque.Location = new System.Drawing.Point(589, 386);
            this.completarEstoque.Name = "completarEstoque";
            this.completarEstoque.Size = new System.Drawing.Size(164, 41);
            this.completarEstoque.TabIndex = 7;
            this.completarEstoque.Text = "Completar Estoque";
            this.completarEstoque.UseVisualStyleBackColor = true;
            this.completarEstoque.Click += new System.EventHandler(this.buttonCompletarEstoque_Click);
            // 
            // FormGerenciarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfaceEstoque.Properties.Resources.pizza_4952508_960_720mod1;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.completarEstoque);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.esvaziarEstoque);
            this.Controls.Add(this.cadastrarIngrediente);
            this.Controls.Add(this.attIngrediente);
            this.Controls.Add(this.removeIngrediente);
            this.Controls.Add(this.addIngrediente);
            this.Controls.Add(this.dgvDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGerenciarEstoque";
            this.Text = "GerenciarEstoque";
            this.Load += new System.EventHandler(this.FormGerenciarEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button addIngrediente;
        private System.Windows.Forms.Button removeIngrediente;
        private System.Windows.Forms.Button attIngrediente;
        private System.Windows.Forms.Button cadastrarIngrediente;
        private System.Windows.Forms.Button esvaziarEstoque;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button completarEstoque;
    }
}