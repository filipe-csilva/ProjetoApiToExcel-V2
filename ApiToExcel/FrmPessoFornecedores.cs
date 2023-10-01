using ApiToExcel.Clients;
using ApiToExcel.Models;
using ApiToExcel.Services;

namespace ApiToExcel
{
    public partial class FrmPessoFornecedores : Form
    {
        public FrmPessoFornecedores()
        {
            InitializeComponent();
        }

        private async void BtnExecutar_Click(object sender, EventArgs e)
        {
            string urlEntrada = TxUrlAPI.Text;
            string url = $"https://{urlEntrada}";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                await UpdateTxtJson("Iniciando");

                var credential = new PasswordCredential(
                    Username: TxUser.Text,
                    Password: TxPass.Text);

                await UpdateTxtJson("Solicitado o acesso.");

                using var varejoFacil = new VarejoFacilClient(
                    baseAddress: url,
                    passwordCredential: credential);

                await UpdateTxtJson("Acessando a o caminho da API.");

                dynamic fornecedores = varejoFacil.GetFromRoute(TxRouter.Text);

                await UpdateTxtJson("Criando Arquivo Excel.");

                var io = new IOService();
                io.WriteXlFile(fornecedores, saveFileDialog1.FileName);
                await UpdateTxtJson("Arquivo Excel criado com sucesso.");
            }
        }

        public void TxtJson_TextChanged(object sender, EventArgs e)
        {

        }

        async Task UpdateTxtJson(string message)
        {
            TxtJson.Text = message;
            await Task.Delay(1000); // Pausa de 1 segundo
        }
    }
}