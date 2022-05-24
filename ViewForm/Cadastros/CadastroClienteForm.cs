using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ViewForm.Cadastros
{
    public partial class CadastroClienteForm : Form
    {
        private ClienteController _clienteController = new ClienteController();
        private EnderecoController _enderecoController = new EnderecoController();
        private bool _editando;
        private int? _idClienteEditando;
        public CadastroClienteForm()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (!_editando)
            {
                string mensagem = "";

                Endereco endereco = new Endereco();
                endereco.Logradouro = textBoxLogradouro.Text;
                endereco.Numero = textBoxNumero.Text;
                endereco.Bairro = textBoxBairro.Text;
                endereco.Cidade = textBoxCidade.Text;
                endereco.Estado = comboBoxEstados.Text;
                endereco.CEP = maskedTextBoxCEP.Text;
                endereco.Complemento = textBoxComplemento.Text;

                Cliente cliente = new Cliente();
                cliente.Nome = textBoxNomeCompleto.Text;
                cliente.CPF = maskedTextBoxCPF.Text;
                cliente.Telefone = maskedTextBoxTelefone.Text;
                cliente.Email = textBoxEmail.Text;
                cliente.Endereco = endereco;

                mensagem = _clienteController.IncluirClienteComEndereco(cliente);

                if (mensagem != "")
                    MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Cliente inserido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            else
            {
                Endereco enderecoEditado = new Endereco();
                enderecoEditado.Logradouro = textBoxLogradouro.Text;
                enderecoEditado.Numero = textBoxNumero.Text;
                enderecoEditado.Bairro = textBoxBairro.Text;
                enderecoEditado.Cidade = textBoxCidade.Text;
                enderecoEditado.Estado = comboBoxEstados.Text;
                enderecoEditado.CEP = maskedTextBoxCEP.Text;
                enderecoEditado.Complemento = textBoxComplemento.Text;

                Cliente clienteEditado = new Cliente();
                clienteEditado.Nome = textBoxNomeCompleto.Text;
                clienteEditado.CPF = maskedTextBoxCPF.Text;
                clienteEditado.Telefone = maskedTextBoxTelefone.Text;
                clienteEditado.Email = textBoxEmail.Text;
                clienteEditado.Endereco = enderecoEditado;
              
                string mensagem = _clienteController.Editar(_idClienteEditando.Value, clienteEditado);

                if (mensagem != "")
                    MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Dados do cliente editados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            _idClienteEditando = null;
            _editando = false;
            buttonEditar.Enabled = true;
            buttonExcluir.Enabled = true;
            AtualizarGrid();

        }

        private void CadastroClienteForm_Shown(object sender, EventArgs e)
        {
            AtualizarGrid();
        }


        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Deseja realmente editar esse registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cliente clienteSelecionado = (Cliente)dataGridViewDados.SelectedRows[0].DataBoundItem;

                PreencherCampos(clienteSelecionado);
                _idClienteEditando = clienteSelecionado.Id;
                _editando = true;
                buttonEditar.Enabled = false;
                buttonExcluir.Enabled = false;
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

            if (dataGridViewDados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecine uma linha para ser excluida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                var clienteExcluir = (Cliente)dataGridViewDados.SelectedRows[0].DataBoundItem;
                _clienteController.Excluir(clienteExcluir.Id);
                AtualizarGrid();
            }
        }

        private void AtualizarGrid()
        {
            var lista = _clienteController.Listar();
            dataGridViewDados.DataSource = lista;  
        }
        private void LimparCampos()
        {
            textBoxNomeCompleto.Clear();
            maskedTextBoxCPF.Clear();
            maskedTextBoxTelefone.Clear();
            textBoxEmail.Clear();
            textBoxLogradouro.Clear();
            textBoxNumero.Clear();
            textBoxBairro.Clear();
            textBoxComplemento.Clear();
            textBoxCidade.Clear();
            comboBoxEstados.ResetText();
            maskedTextBoxCEP.Clear();
        }
        private void PreencherCampos(Cliente cliente)
        {
            textBoxNomeCompleto.Text = cliente.Nome;
            maskedTextBoxCPF.Text = cliente.CPF;
            maskedTextBoxTelefone.Text = cliente.Telefone;
            textBoxEmail.Text = cliente.Email;
            textBoxLogradouro.Text = cliente.Endereco.Logradouro;
            textBoxNumero.Text = cliente.Endereco.Numero;
            textBoxComplemento.Text = cliente.Endereco.Complemento;
            textBoxBairro.Text = cliente.Endereco.Bairro;
            textBoxCidade.Text = cliente.Endereco.Cidade;
            comboBoxEstados.Text = cliente.Endereco.Estado;
            maskedTextBoxCEP.Text = cliente.Endereco.CEP;
        }
    }
}
