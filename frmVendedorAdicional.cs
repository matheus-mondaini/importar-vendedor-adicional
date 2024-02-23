namespace ImportarVendedorAdicional
{
    public partial class frmVendedorAdicional : Form
    {
        public frmVendedorAdicional()
        {
            InitializeComponent();
            txtPlanilha.Enabled = false;
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            txtPlanilha.Text = "C:Sistemas\\Planilhas\\Planilha1";
        }

        private void btnEscolherPlanilha_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}