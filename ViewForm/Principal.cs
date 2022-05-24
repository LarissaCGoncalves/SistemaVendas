using System.Windows.Forms;
using ViewForm.Cadastros;

namespace ViewForm
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void buttonClientes_Click(object sender, System.EventArgs e)
        {
            CadastroClienteForm form = new CadastroClienteForm();
            form.ShowDialog();
        }
    }
}
