namespace WindowsForms231135_231100.Views
{
    partial class FrmClientes
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.chkVenda = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbocidades = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.btnincluir = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(43, 44);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 1;
            // 
            // chkVenda
            // 
            this.chkVenda.AutoSize = true;
            this.chkVenda.Location = new System.Drawing.Point(237, 46);
            this.chkVenda.Name = "chkVenda";
            this.chkVenda.Size = new System.Drawing.Size(115, 17);
            this.chkVenda.TabIndex = 2;
            this.chkVenda.Text = "Bloqueia a venda?";
            this.chkVenda.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(43, 114);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(601, 20);
            this.txtNome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cidade:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbocidades
            // 
            this.cbocidades.FormattingEnabled = true;
            this.cbocidades.Location = new System.Drawing.Point(43, 203);
            this.cbocidades.Name = "cbocidades";
            this.cbocidades.Size = new System.Drawing.Size(526, 21);
            this.cbocidades.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "UF:";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(575, 204);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(69, 20);
            this.txtUF.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "CPF:";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(43, 273);
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(181, 20);
            this.mskCPF.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data de Nascimento:";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Location = new System.Drawing.Point(475, 273);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(200, 20);
            this.dtpDataNasc.TabIndex = 13;
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(87, 366);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(112, 44);
            this.btnincluir.TabIndex = 14;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(237, 366);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(112, 44);
            this.btnalterar.TabIndex = 15;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(383, 366);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(112, 44);
            this.btncancelar.TabIndex = 16;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(522, 366);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(112, 44);
            this.btnexcluir.TabIndex = 17;
            this.btnexcluir.Text = "Cancelar";
            this.btnexcluir.UseVisualStyleBackColor = true;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 645);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbocidades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkVenda);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.CheckBox chkVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbocidades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnexcluir;
    }
}