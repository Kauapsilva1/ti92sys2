namespace ti92app
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtIdNivel = new System.Windows.Forms.TextBox();
            this.txtNomeNivel = new System.Windows.Forms.TextBox();
            this.txtSiglaNivel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsereNIvel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Excluir = new System.Windows.Forms.Button();
            this.EditarUsuario = new System.Windows.Forms.Button();
            this.btnInserirUsuario = new System.Windows.Forms.Button();
            this.txtBuscaUsuario = new System.Windows.Forms.TextBox();
            this.CheckAtivo = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(59, 243);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 95);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtIdNivel
            // 
            this.txtIdNivel.Location = new System.Drawing.Point(75, 32);
            this.txtIdNivel.Name = "txtIdNivel";
            this.txtIdNivel.ReadOnly = true;
            this.txtIdNivel.Size = new System.Drawing.Size(30, 20);
            this.txtIdNivel.TabIndex = 2;
            this.txtIdNivel.TextChanged += new System.EventHandler(this.txtIdNivel_TextChanged);
            // 
            // txtNomeNivel
            // 
            this.txtNomeNivel.Location = new System.Drawing.Point(75, 59);
            this.txtNomeNivel.Name = "txtNomeNivel";
            this.txtNomeNivel.Size = new System.Drawing.Size(100, 20);
            this.txtNomeNivel.TabIndex = 3;
            // 
            // txtSiglaNivel
            // 
            this.txtSiglaNivel.Location = new System.Drawing.Point(75, 86);
            this.txtSiglaNivel.Name = "txtSiglaNivel";
            this.txtSiglaNivel.Size = new System.Drawing.Size(69, 20);
            this.txtSiglaNivel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "NOME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SIGLA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnInsereNIvel
            // 
            this.btnInsereNIvel.Location = new System.Drawing.Point(31, 113);
            this.btnInsereNIvel.Name = "btnInsereNIvel";
            this.btnInsereNIvel.Size = new System.Drawing.Size(75, 23);
            this.btnInsereNIvel.TabIndex = 8;
            this.btnInsereNIvel.Text = "Inserir";
            this.btnInsereNIvel.UseVisualStyleBackColor = true;
            this.btnInsereNIvel.Click += new System.EventHandler(this.btnInsereNIvel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.txtNomeNivel);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnInsereNIvel);
            this.groupBox1.Controls.Add(this.txtIdNivel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSiglaNivel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(59, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 180);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(194, 113);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(112, 113);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(59, 217);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(231, 20);
            this.txtBusca.TabIndex = 10;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "NOME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "EMAIL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "SENHA";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(85, 26);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(35, 20);
            this.txtIdUsuario.TabIndex = 15;
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.txtIdUsuario_TextChanged);
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(85, 53);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(127, 20);
            this.txtNomeUsuario.TabIndex = 16;
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Location = new System.Drawing.Point(85, 83);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(146, 20);
            this.txtEmailUsuario.TabIndex = 17;
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Location = new System.Drawing.Point(85, 113);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaUsuario.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbNivel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CheckAtivo);
            this.groupBox2.Controls.Add(this.Excluir);
            this.groupBox2.Controls.Add(this.EditarUsuario);
            this.groupBox2.Controls.Add(this.btnInserirUsuario);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSenhaUsuario);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtEmailUsuario);
            this.groupBox2.Controls.Add(this.txtIdUsuario);
            this.groupBox2.Controls.Add(this.txtNomeUsuario);
            this.groupBox2.Location = new System.Drawing.Point(508, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 247);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(167, 201);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 23;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            // 
            // EditarUsuario
            // 
            this.EditarUsuario.Location = new System.Drawing.Point(85, 201);
            this.EditarUsuario.Name = "EditarUsuario";
            this.EditarUsuario.Size = new System.Drawing.Size(75, 23);
            this.EditarUsuario.TabIndex = 22;
            this.EditarUsuario.Text = "Editar";
            this.EditarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnInserirUsuario
            // 
            this.btnInserirUsuario.Location = new System.Drawing.Point(3, 201);
            this.btnInserirUsuario.Name = "btnInserirUsuario";
            this.btnInserirUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnInserirUsuario.TabIndex = 21;
            this.btnInserirUsuario.Text = "Inserir";
            this.btnInserirUsuario.UseVisualStyleBackColor = true;
            // 
            // txtBuscaUsuario
            // 
            this.txtBuscaUsuario.Location = new System.Drawing.Point(508, 278);
            this.txtBuscaUsuario.Name = "txtBuscaUsuario";
            this.txtBuscaUsuario.Size = new System.Drawing.Size(263, 20);
            this.txtBuscaUsuario.TabIndex = 22;
            // 
            // CheckAtivo
            // 
            this.CheckAtivo.AutoSize = true;
            this.CheckAtivo.Location = new System.Drawing.Point(29, 178);
            this.CheckAtivo.Name = "CheckAtivo";
            this.CheckAtivo.Size = new System.Drawing.Size(58, 17);
            this.CheckAtivo.TabIndex = 24;
            this.CheckAtivo.Text = "ATIVO";
            this.CheckAtivo.UseVisualStyleBackColor = true;
            this.CheckAtivo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "NIVEL";
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(85, 141);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(121, 21);
            this.cmbNivel.TabIndex = 26;
            this.cmbNivel.SelectedIndexChanged += new System.EventHandler(this.cmbNivelUsuario_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(511, 305);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(260, 95);
            this.listBox2.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.txtBuscaUsuario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtIdNivel;
        private System.Windows.Forms.TextBox txtNomeNivel;
        private System.Windows.Forms.TextBox txtSiglaNivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsereNIvel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuscaUsuario;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button EditarUsuario;
        private System.Windows.Forms.Button btnInserirUsuario;
        private System.Windows.Forms.CheckBox CheckAtivo;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox2;
    }
}

