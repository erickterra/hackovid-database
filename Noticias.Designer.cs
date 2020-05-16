using System;

namespace Hackovid_Database
{
    partial class Noticias
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
            this.salvar = new System.Windows.Forms.Button();
            this.pesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtManchete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFonte = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listIndices = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addIndice = new System.Windows.Forms.Button();
            this.remIndice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(431, 12);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 40);
            this.salvar.TabIndex = 7;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // pesquisar
            // 
            this.pesquisar.Location = new System.Drawing.Point(350, 12);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(75, 40);
            this.pesquisar.TabIndex = 8;
            this.pesquisar.Text = "Pesquisar";
            this.pesquisar.UseVisualStyleBackColor = true;
            this.pesquisar.Click += new System.EventHandler(this.pesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cod";
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(126, 12);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(207, 40);
            this.txtCod.TabIndex = 0;
            // 
            // txtManchete
            // 
            this.txtManchete.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManchete.Location = new System.Drawing.Point(126, 72);
            this.txtManchete.Name = "txtManchete";
            this.txtManchete.Size = new System.Drawing.Size(306, 40);
            this.txtManchete.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Manchete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Fonte";
            // 
            // txtFonte
            // 
            this.txtFonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFonte.Location = new System.Drawing.Point(126, 378);
            this.txtFonte.Name = "txtFonte";
            this.txtFonte.Size = new System.Drawing.Size(306, 40);
            this.txtFonte.TabIndex = 3;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(11, 166);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(421, 191);
            this.txtDescricao.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Descrição";
            // 
            // listIndices
            // 
            this.listIndices.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listIndices.FormattingEnabled = true;
            this.listIndices.ItemHeight = 29;
            this.listIndices.Location = new System.Drawing.Point(453, 118);
            this.listIndices.Name = "listIndices";
            this.listIndices.Size = new System.Drawing.Size(259, 91);
            this.listIndices.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Indices";
            // 
            // addIndice
            // 
            this.addIndice.Location = new System.Drawing.Point(543, 68);
            this.addIndice.Name = "addIndice";
            this.addIndice.Size = new System.Drawing.Size(31, 39);
            this.addIndice.TabIndex = 4;
            this.addIndice.Text = "+";
            this.addIndice.UseVisualStyleBackColor = false;
            this.addIndice.Click += new System.EventHandler(this.addIndice_Click);
            // 
            // remIndice
            // 
            this.remIndice.Location = new System.Drawing.Point(718, 118);
            this.remIndice.Name = "remIndice";
            this.remIndice.Size = new System.Drawing.Size(31, 91);
            this.remIndice.TabIndex = 6;
            this.remIndice.Text = "-";
            this.remIndice.UseVisualStyleBackColor = false;
            this.remIndice.Click += new System.EventHandler(this.remIndice_Click);
            // 
            // Noticias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 537);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.remIndice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtFonte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.txtManchete);
            this.Controls.Add(this.pesquisar);
            this.Controls.Add(this.listIndices);
            this.Controls.Add(this.addIndice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCod);
            this.Name = "Noticias";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoadNotifications);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button pesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtManchete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFonte;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listIndices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addIndice;
        private System.Windows.Forms.Button remIndice;
    }
}