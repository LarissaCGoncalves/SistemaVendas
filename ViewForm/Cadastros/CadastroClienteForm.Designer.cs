namespace ViewForm.Cadastros
{
    partial class CadastroClienteForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.groupBoxDadosCliente = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNomeCompleto = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelNomeCompleto = new System.Windows.Forms.Label();
            this.groupBoxEnderecoCliente = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxEstados = new System.Windows.Forms.ComboBox();
            this.labelCEP = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.labelLogradouro = new System.Windows.Forms.Label();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.textBoxLogradouro = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxDadosCliente.SuspendLayout();
            this.groupBoxEnderecoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCadastrar.Location = new System.Drawing.Point(592, 234);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(100, 30);
            this.buttonCadastrar.TabIndex = 0;
            this.buttonCadastrar.Text = "Salvar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // groupBoxDadosCliente
            // 
            this.groupBoxDadosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDadosCliente.AutoSize = true;
            this.groupBoxDadosCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxDadosCliente.Controls.Add(this.maskedTextBoxCPF);
            this.groupBoxDadosCliente.Controls.Add(this.maskedTextBoxTelefone);
            this.groupBoxDadosCliente.Controls.Add(this.textBoxEmail);
            this.groupBoxDadosCliente.Controls.Add(this.textBoxNomeCompleto);
            this.groupBoxDadosCliente.Controls.Add(this.labelEmail);
            this.groupBoxDadosCliente.Controls.Add(this.labelTelefone);
            this.groupBoxDadosCliente.Controls.Add(this.labelCPF);
            this.groupBoxDadosCliente.Controls.Add(this.labelNomeCompleto);
            this.groupBoxDadosCliente.Location = new System.Drawing.Point(26, 22);
            this.groupBoxDadosCliente.Name = "groupBoxDadosCliente";
            this.groupBoxDadosCliente.Size = new System.Drawing.Size(595, 198);
            this.groupBoxDadosCliente.TabIndex = 1;
            this.groupBoxDadosCliente.TabStop = false;
            this.groupBoxDadosCliente.Text = "Dados do Cliente";
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(146, 71);
            this.maskedTextBoxCPF.Mask = "999.000.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(208, 27);
            this.maskedTextBoxCPF.TabIndex = 6;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(146, 107);
            this.maskedTextBoxTelefone.Mask = "(999) 00000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(208, 27);
            this.maskedTextBoxTelefone.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(146, 145);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(345, 27);
            this.textBoxEmail.TabIndex = 6;
            // 
            // textBoxNomeCompleto
            // 
            this.textBoxNomeCompleto.Location = new System.Drawing.Point(146, 33);
            this.textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            this.textBoxNomeCompleto.Size = new System.Drawing.Size(443, 27);
            this.textBoxNomeCompleto.TabIndex = 3;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(85, 148);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(55, 20);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "E-mail:";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(71, 110);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(69, 20);
            this.labelTelefone.TabIndex = 2;
            this.labelTelefone.Text = "Telefone:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(104, 74);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(36, 20);
            this.labelCPF.TabIndex = 1;
            this.labelCPF.Text = "CPF:";
            // 
            // labelNomeCompleto
            // 
            this.labelNomeCompleto.AutoSize = true;
            this.labelNomeCompleto.Location = new System.Drawing.Point(17, 36);
            this.labelNomeCompleto.Name = "labelNomeCompleto";
            this.labelNomeCompleto.Size = new System.Drawing.Size(123, 20);
            this.labelNomeCompleto.TabIndex = 0;
            this.labelNomeCompleto.Text = "Nome Completo:";
            // 
            // groupBoxEnderecoCliente
            // 
            this.groupBoxEnderecoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEnderecoCliente.Controls.Add(this.maskedTextBoxCEP);
            this.groupBoxEnderecoCliente.Controls.Add(this.comboBoxEstados);
            this.groupBoxEnderecoCliente.Controls.Add(this.labelCEP);
            this.groupBoxEnderecoCliente.Controls.Add(this.labelEstado);
            this.groupBoxEnderecoCliente.Controls.Add(this.labelNumero);
            this.groupBoxEnderecoCliente.Controls.Add(this.textBoxNumero);
            this.groupBoxEnderecoCliente.Controls.Add(this.textBoxCidade);
            this.groupBoxEnderecoCliente.Controls.Add(this.textBoxBairro);
            this.groupBoxEnderecoCliente.Controls.Add(this.labelLogradouro);
            this.groupBoxEnderecoCliente.Controls.Add(this.textBoxComplemento);
            this.groupBoxEnderecoCliente.Controls.Add(this.labelComplemento);
            this.groupBoxEnderecoCliente.Controls.Add(this.textBoxLogradouro);
            this.groupBoxEnderecoCliente.Controls.Add(this.labelBairro);
            this.groupBoxEnderecoCliente.Controls.Add(this.labelCidade);
            this.groupBoxEnderecoCliente.Location = new System.Drawing.Point(627, 22);
            this.groupBoxEnderecoCliente.Name = "groupBoxEnderecoCliente";
            this.groupBoxEnderecoCliente.Size = new System.Drawing.Size(837, 205);
            this.groupBoxEnderecoCliente.TabIndex = 2;
            this.groupBoxEnderecoCliente.TabStop = false;
            this.groupBoxEnderecoCliente.Text = "Endereço Cliente";
            // 
            // maskedTextBoxCEP
            // 
            this.maskedTextBoxCEP.Location = new System.Drawing.Point(653, 76);
            this.maskedTextBoxCEP.Mask = "00000-9999";
            this.maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            this.maskedTextBoxCEP.Size = new System.Drawing.Size(167, 27);
            this.maskedTextBoxCEP.TabIndex = 21;
            // 
            // comboBoxEstados
            // 
            this.comboBoxEstados.FormattingEnabled = true;
            this.comboBoxEstados.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBoxEstados.Location = new System.Drawing.Point(653, 151);
            this.comboBoxEstados.Name = "comboBoxEstados";
            this.comboBoxEstados.Size = new System.Drawing.Size(167, 28);
            this.comboBoxEstados.TabIndex = 6;
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Location = new System.Drawing.Point(610, 81);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(37, 20);
            this.labelCEP.TabIndex = 19;
            this.labelCEP.Text = "CEP:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(590, 155);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(57, 20);
            this.labelEstado.TabIndex = 17;
            this.labelEstado.Text = "Estado:";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(581, 43);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(66, 20);
            this.labelNumero.TabIndex = 15;
            this.labelNumero.Text = "Número:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(653, 43);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(167, 27);
            this.textBoxNumero.TabIndex = 16;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(118, 152);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(447, 27);
            this.textBoxCidade.TabIndex = 14;
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(118, 114);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(447, 27);
            this.textBoxBairro.TabIndex = 13;
            // 
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Location = new System.Drawing.Point(22, 46);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(90, 20);
            this.labelLogradouro.TabIndex = 7;
            this.labelLogradouro.Text = "Logradouro:";
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.Location = new System.Drawing.Point(118, 78);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(447, 27);
            this.textBoxComplemento.TabIndex = 12;
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Location = new System.Drawing.Point(5, 81);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(107, 20);
            this.labelComplemento.TabIndex = 8;
            this.labelComplemento.Text = "Complemento:";
            // 
            // textBoxLogradouro
            // 
            this.textBoxLogradouro.Location = new System.Drawing.Point(118, 40);
            this.textBoxLogradouro.Name = "textBoxLogradouro";
            this.textBoxLogradouro.Size = new System.Drawing.Size(447, 27);
            this.textBoxLogradouro.TabIndex = 10;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(60, 117);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(52, 20);
            this.labelBairro.TabIndex = 9;
            this.labelBairro.Text = "Bairro:";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(53, 155);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(59, 20);
            this.labelCidade.TabIndex = 11;
            this.labelCidade.Text = "Cidade:";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEditar.Location = new System.Drawing.Point(698, 234);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(100, 30);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonExcluir.Location = new System.Drawing.Point(804, 234);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(100, 30);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.AccessibleName = "";
            this.dataGridViewDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDados.AutoGenerateColumns = false;
            this.dataGridViewDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn});
            this.dataGridViewDados.DataSource = this.clienteBindingSource;
            this.dataGridViewDados.Location = new System.Drawing.Point(26, 274);
            this.dataGridViewDados.MultiSelect = false;
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.ReadOnly = true;
            this.dataGridViewDados.RowHeadersVisible = false;
            this.dataGridViewDados.RowHeadersWidth = 51;
            this.dataGridViewDados.RowTemplate.Height = 29;
            this.dataGridViewDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDados.Size = new System.Drawing.Size(1438, 277);
            this.dataGridViewDados.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 20.42781F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.FillWeight = 100.9144F;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.FillWeight = 70.91444F;
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.FillWeight = 70.91444F;
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 90.91444F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.FillWeight = 110.9144F;
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Model.Cliente);
            // 
            // CadastroClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 578);
            this.Controls.Add(this.dataGridViewDados);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.groupBoxEnderecoCliente);
            this.Controls.Add(this.groupBoxDadosCliente);
            this.Controls.Add(this.buttonCadastrar);
            this.MinimumSize = new System.Drawing.Size(1040, 625);
            this.Name = "CadastroClienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            this.Shown += new System.EventHandler(this.CadastroClienteForm_Shown);
            this.groupBoxDadosCliente.ResumeLayout(false);
            this.groupBoxDadosCliente.PerformLayout();
            this.groupBoxEnderecoCliente.ResumeLayout(false);
            this.groupBoxEnderecoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.GroupBox groupBoxDadosCliente;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelNomeCompleto;
        private System.Windows.Forms.GroupBox groupBoxEnderecoCliente;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox textBoxNomeCompleto;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Label labelLogradouro;
        private System.Windows.Forms.TextBox textBoxComplemento;
        private System.Windows.Forms.Label labelComplemento;
        private System.Windows.Forms.TextBox textBoxLogradouro;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.ComboBox comboBoxEstados;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCEP;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.DataGridView dataGridViewDados;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
    }
}