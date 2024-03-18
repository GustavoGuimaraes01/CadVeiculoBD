using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System.Drawing;
using static System.Windows.Forms.LinkLabel;

namespace CadVeiculo_turmaB

{

    public partial class frmPrincipal : Form
    {
        List<Veiculo> carros = new List<Veiculo>();
        MySqlConnection conexao = new MySqlConnection("Server=localhost ;Database=veiculos;User id = root; Password=Gsg2005/08");

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Habilitar os campos
            txtPlaca.Enabled = true;
            txtModelo.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;

            //focar na placa
            txtPlaca.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                conexao.Open();

                //executar comandos no BD
                MySqlCommand qry = new MySqlCommand(
                "INSERT INTO carros VALUES ('" + txtPlaca.Text + "','" + txtModelo.Text + "')", conexao);
                //Insere dados ao BD
                qry.Connection = conexao;
                qry.ExecuteNonQuery();

                //fechar a conexão com o banco
                conexao.Close();

                Veiculo v = new Veiculo(txtPlaca.Text, txtModelo.Text);
                carros.Add(v);

                //limpar os campos depois de salvo
                txtPlaca.Clear();
                txtModelo.Clear();

                //habilitar e desabilitar os campos
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;
                txtPlaca.Enabled = false;
                txtModelo.Enabled = false;

                conexao.Close();

            }
            catch
            {
                MessageBox.Show("Ocorreu um erro");
            }


        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {//Limpa a lista antes de adiciona mais uma
                lstVeiculos.Items.Clear();
                //Abre conexao
                conexao.Open();
                //Selecina placa e modelo de carro no BD
                MySqlCommand qry = new MySqlCommand("SELECT placa,modelo FROM carros", conexao);
                MySqlDataReader leitor = qry.ExecuteReader();//Executa comando sem retornar nada

                while (leitor.Read())// Enquanto tiver linha esta lendo
                {
                    ListViewItem linha = new ListViewItem();

                    //Pega e adiciona as linha do BD na ListView
                    linha.Text = leitor.GetString(0);
                    linha.SubItems.Add(leitor.GetString(1));
                    lstVeiculos.Items.Add(linha);

                }
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Errou ao Listar");
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Ve se foi selecionado um item para remover
                if (lstVeiculos.SelectedItems.Count > 0)
                {
                    //Conecta ao BD
                    conexao.Open();

                    //Laço para percorrer toda a lista de carros e seus items 
                    foreach (ListViewItem item in lstVeiculos.SelectedItems)
                    {
                        //Pega a placa do item selecionado
                        string placa = item.Text;

                        //Metodo para deletar do BD
                        string query = "DELETE FROM carros WHERE placa = @placa"; //@Placa serve como parametro para consulta ao BD
                        using (MySqlCommand comando = new MySqlCommand(query, conexao))
                        {
                            comando.Parameters.AddWithValue("@placa", placa);
                            comando.ExecuteNonQuery();
                        }

                        lstVeiculos.Items.Remove(item);
                    }

                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Selecione oq deseja excluir.");
                }
            }
            catch
            {
                MessageBox.Show("Erro ao deletar");
            }
           
        }
        private void bntSair_Click(object sender, EventArgs e)
        {
            //Fecha o programa
            Close();
        }
    }
}
