
namespace Tela_desk
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnConsulte = new System.Windows.Forms.Button();
            this.btnInsira = new System.Windows.Forms.Button();
            this.btnAltere = new System.Windows.Forms.Button();
            this.btnExclua = new System.Windows.Forms.Button();
            this.lbAgenda = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(70, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(455, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(71, 33);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 3;
            // 
            // btnConsulte
            // 
            this.btnConsulte.Location = new System.Drawing.Point(13, 61);
            this.btnConsulte.Name = "btnConsulte";
            this.btnConsulte.Size = new System.Drawing.Size(75, 23);
            this.btnConsulte.TabIndex = 4;
            this.btnConsulte.Text = "Consultar";
            this.btnConsulte.UseVisualStyleBackColor = true;
            this.btnConsulte.Click += new System.EventHandler(this.btnConsulte_Click);
            // 
            // btnInsira
            // 
            this.btnInsira.Location = new System.Drawing.Point(95, 60);
            this.btnInsira.Name = "btnInsira";
            this.btnInsira.Size = new System.Drawing.Size(75, 23);
            this.btnInsira.TabIndex = 5;
            this.btnInsira.Text = "Inserir";
            this.btnInsira.UseVisualStyleBackColor = true;
            this.btnInsira.Click += new System.EventHandler(this.btnInsira_Click);
            // 
            // btnAltere
            // 
            this.btnAltere.Location = new System.Drawing.Point(177, 59);
            this.btnAltere.Name = "btnAltere";
            this.btnAltere.Size = new System.Drawing.Size(75, 23);
            this.btnAltere.TabIndex = 6;
            this.btnAltere.Text = "Alterar";
            this.btnAltere.UseVisualStyleBackColor = true;
            this.btnAltere.Click += new System.EventHandler(this.btnAltere_Click);
            // 
            // btnExclua
            // 
            this.btnExclua.Location = new System.Drawing.Point(259, 60);
            this.btnExclua.Name = "btnExclua";
            this.btnExclua.Size = new System.Drawing.Size(75, 23);
            this.btnExclua.TabIndex = 7;
            this.btnExclua.Text = "Excluir";
            this.btnExclua.UseVisualStyleBackColor = true;
            this.btnExclua.Click += new System.EventHandler(this.btnExclua_Click);
            // 
            // lbAgenda
            // 
            this.lbAgenda.FormattingEnabled = true;
            this.lbAgenda.Location = new System.Drawing.Point(19, 100);
            this.lbAgenda.Name = "lbAgenda";
            this.lbAgenda.Size = new System.Drawing.Size(505, 316);
            this.lbAgenda.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.lbAgenda);
            this.Controls.Add(this.btnExclua);
            this.Controls.Add(this.btnAltere);
            this.Controls.Add(this.btnInsira);
            this.Controls.Add(this.btnConsulte);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Agenda de Telefones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnConsulte;
        private System.Windows.Forms.Button btnInsira;
        private System.Windows.Forms.Button btnAltere;
        private System.Windows.Forms.Button btnExclua;
        private System.Windows.Forms.ListBox lbAgenda;
    }
}

