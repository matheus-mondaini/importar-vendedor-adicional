using OfficeOpenXml;
using System.ComponentModel;

namespace ImportarVendedorAdicional
{
    public partial class frmVendedorAdicional : Form
    {
        public frmVendedorAdicional()
        {
            InitializeComponent();
            txtPlanilha.Enabled = false;
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }


        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos do Excel|*.xls;*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPlanilha.Text = ofd.FileName;
                FileInfo caminho = new FileInfo(ofd.FileName);

                var planilhasNome = new List<string>();

                try
                {
                    using (ExcelPackage pacote = new ExcelPackage(caminho))
                    {
                        foreach (var planilha in pacote.Workbook.Worksheets)
                        {
                            planilhasNome.Add(planilha.Name);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
                cmbEscolherPlanilha.DataSource = planilhasNome;
            }
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