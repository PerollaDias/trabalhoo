﻿namespace Trabalho_3BIMESTRE
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_Ccliente = new System.Windows.Forms.Button();
            this.bt_Cservicos = new System.Windows.Forms.Button();
            this.bt_Cproduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Ccliente
            // 
            this.bt_Ccliente.BackColor = System.Drawing.Color.White;
            this.bt_Ccliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Ccliente.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Ccliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Ccliente.Location = new System.Drawing.Point(12, 403);
            this.bt_Ccliente.Name = "bt_Ccliente";
            this.bt_Ccliente.Size = new System.Drawing.Size(146, 32);
            this.bt_Ccliente.TabIndex = 0;
            this.bt_Ccliente.Text = "Cadastrar Cliente";
            this.bt_Ccliente.UseVisualStyleBackColor = false;
            this.bt_Ccliente.Click += new System.EventHandler(this.bt_Ccliente_Click);
            // 
            // bt_Cservicos
            // 
            this.bt_Cservicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cservicos.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cservicos.Location = new System.Drawing.Point(191, 402);
            this.bt_Cservicos.Name = "bt_Cservicos";
            this.bt_Cservicos.Size = new System.Drawing.Size(146, 33);
            this.bt_Cservicos.TabIndex = 1;
            this.bt_Cservicos.Text = "Cadastrar Serviços";
            this.bt_Cservicos.UseVisualStyleBackColor = true;
            this.bt_Cservicos.Click += new System.EventHandler(this.bt_Cservicos_Click);
            // 
            // bt_Cproduto
            // 
            this.bt_Cproduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cproduto.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cproduto.Location = new System.Drawing.Point(367, 402);
            this.bt_Cproduto.Name = "bt_Cproduto";
            this.bt_Cproduto.Size = new System.Drawing.Size(146, 33);
            this.bt_Cproduto.TabIndex = 2;
            this.bt_Cproduto.Text = "Cadastrar Produto";
            this.bt_Cproduto.UseVisualStyleBackColor = true;
            this.bt_Cproduto.Click += new System.EventHandler(this.bt_Cproduto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trabalho_3BIMESTRE.Properties.Resources.WhatsApp_Image_2023_08_15_at_15_03_13;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.bt_Cproduto);
            this.Controls.Add(this.bt_Cservicos);
            this.Controls.Add(this.bt_Ccliente);
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Ccliente;
        private System.Windows.Forms.Button bt_Cservicos;
        private System.Windows.Forms.Button bt_Cproduto;
    }
}

