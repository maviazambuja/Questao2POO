using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questao2POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gerarGradeListViewOnibus(); // Insere as Grades no listviewPf
            gerarGradelistViewCaminhao();// Insere as Grades no listviewPj
        }

        private void rbOnibus(object sender, EventArgs e)
        {
            mbtCPFCNPJ.Mask = "000,000,000-00"; // Cria a maskara para CPF


            // Altera os labels para receber os textos de CPF
            lblCPFCNPJ.Text = "CPF";
            lblQtdFilhosFuncionarios.Text = "Qtd Filhos";
            lblSalarioFaturamento.Text = "Salario";

            //altera a visibilidade do componente para false
            lblNomeFantasia.Visible = false;
            tbNomeFantasia.Visible = false;
        }

        private void rbPj_CheckedChanged(object sender, EventArgs e)
        {
            mtbCpfCnpj.Mask = "00,000,000/0000-00"; // Cria a maskara para CPF

            // Altera os labels para receber os textos de CNPJ
            lblCpfCnpj.Text = "CNPJ";
            lblQtdFilhosFuncionarios.Text = "Qtd Funcionarios";
            lblSalarioFaturamento.Text = "Faturamento";

            //altera a visibilidade do componente para True
            lblNomeFantasia.Visible = true;
            tbNomeFantasia.Visible = true;
        }

        // Implementação Botões
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            bool recebeValidacao = validaInformacao();// variavel boleana que recebe true ou false referente ao método de validação
            if (rbPf.Checked == true && recebeValidacao == true) //verifica se o rbPf esta marcado
            {
                //Instanciar objeto
                PessoaFisica pessoaFisica = new PessoaFisica(mtbCpfCnpj.Text, tbNome.Text, tbCidade.Text, Convert.ToInt32(tbQtdFilhosFuncionarios.Text),
                                                             Convert.ToDouble(tbSalarioFaturamento.Text));

                string[] clientePf = new string[6]; // Cria um vetor de Strings com 6 posicoes 
                // Insere cada atributo do objeto instanciado em uma posição determinada no vetor
                clientePf[0] = pessoaFisica.Cpf;
                clientePf[1] = pessoaFisica.Nome;
                clientePf[2] = pessoaFisica.Cidade;
                clientePf[3] = Convert.ToString(pessoaFisica.QtdFilhos);
                clientePf[4] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pessoaFisica.Salario);
                clientePf[5] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pessoaFisica.CalcCredito());

                //Insere o vetor criado com os dados do objeto em uma linha do ListView
                lvPf.Items.Add(new ListViewItem(clientePf));

                //Mensagem na tela de "Dados Cadastrados com Sucesso!"
                MensagemBotao();
                Limpar();
            }
            else if (rbPj.Checked == true && recebeValidacao == true)// verifica se o rbPj esta marcado
            {
                //Instanciar objeto, a ordem importa
                PessoaJuridica pessoaJuridica = new PessoaJuridica(mtbCpfCnpj.Text, tbNome.Text, tbCidade.Text, Convert.ToInt32(tbQtdFilhosFuncionarios.Text),
                                                                    Convert.ToDouble(tbSalarioFaturamento.Text), Convert.ToString(tbNomeFantasia.Text));

                string[] clientePj = new string[7];// // Cria um vetor de Strings com 7 posicoes 

                // Insere cada atributo do objeto instanciado em uma posição determinada no vetor
                clientePj[0] = pessoaJuridica.Cnpj; //pegando o vetor, opul o vet, joga no vetor da classe, gera a lista
                clientePj[1] = pessoaJuridica.Nome;
                clientePj[2] = pessoaJuridica.Cidade;
                clientePj[3] = Convert.ToString(pessoaJuridica.QtdFuncionarios);
                clientePj[4] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pessoaJuridica.Faturamento);
                clientePj[5] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pessoaJuridica.CalcCredito());
                clientePj[6] = pessoaJuridica.NomeFantasia;

                //Insere o vetor criado com os dados do objeto em uma linha do ListView
                lvPj.Items.Add(new ListViewItem(clientePj));

                //Mensagem na tela de "Dados Cadastrados com Sucesso!"
                MensagemBotao();
                Limpar();
            }

        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpar();       //todos os elementos do forms = string.Empty
        }

        private void Limpar()
        {
            mtbCpfCnpj.Text = string.Empty;
            tbNome.Text = string.Empty;
            tbCidade.Text = string.Empty;
            tbQtdFilhosFuncionarios.Text = string.Empty;
            tbSalarioFaturamento.Text = string.Empty;
            tbNomeFantasia.Text = string.Empty;
        }

        //Validação que faz o textBox só aceitar Números inteiros (Evento Keypess)
        private void tbQtdFilhosFuncionarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 202)
            {
                e.Handled = true;
            }
        }

        //Validação que faz o textBox só aceitar Números e vírgula (Evento Keypess)
        private void tbSalarioFaturamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != 8 && e.KeyChar != 202)
            {
                e.Handled = true;
            }

        }

        // Métodos responsáveis por enviarem a mensagem para o usuario
        private void MensagemBotao()
        {
            MessageBox.Show("Dados Cadastrados com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensagemBotao(string nomelabel)
        {
            MessageBox.Show("Voce deve Informar o " + nomelabel + "!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        // Validações TextBox e MaskTextBox
        public bool validaInformacao()
        {

            bool validaInfo = true;

            if (mtbCpfCnpj.MaskCompleted == false) // Verifica se a mascara foi digitada completamente
            {
                MensagemBotao(lblCpfCnpj.Text);
                validaInfo = false;
            }
            else if (tbNome.Text.Trim() == string.Empty) // Verifica se a mascara foi 
            {
                MensagemBotao(lblNome.Text);
                validaInfo = false;
            }
            else if (tbCidade.Text.Trim() == string.Empty)
            {
                MensagemBotao(lblCidade.Text);
                validaInfo = false;
            }
            else if (tbQtdFilhosFuncionarios.Text.Trim() == string.Empty)
            {
                MensagemBotao(lblQtdFilhosFuncionarios.Text);
                validaInfo = false;
            }
            else if (tbSalarioFaturamento.Text.Trim() == string.Empty)
            {
                MensagemBotao(lblSalarioFaturamento.Text);
                validaInfo = false;
            }

            if (rbPj.Checked == true && validaInfo != false)
            {
                if (tbNomeFantasia.Text.Trim() == string.Empty)
                {
                    MensagemBotao(lblNomeFantasia.Text);
                    validaInfo = false;
                }
            }
            return validaInfo;
        }

        // Geração de Grades do List View
        public void gerarGradeListViewPf()// Gera as grades do List View PF
        {
            lvPf.Columns.Add("CPF", 150).TextAlign = HorizontalAlignment.Center;    //transforma o elemento da lista em uma coluna horizontal, com o nome CPF emcima alinhada no centro
            lvPf.Columns.Add("Nome", 150).TextAlign = HorizontalAlignment.Center;
            lvPf.Columns.Add("Cidade", 100).TextAlign = HorizontalAlignment.Center;
            lvPf.Columns.Add("Qtd Filhos", 80).TextAlign = HorizontalAlignment.Center;
            lvPf.Columns.Add("Salario M", 150).TextAlign = HorizontalAlignment.Center;
            lvPf.Columns.Add("Credito", 150).TextAlign = HorizontalAlignment.Center;
            lvPf.View = View.Details;
        }

        public void gerarGradelistViewPj()//Gera as grades do List View PJ
        {
            lvPj.Columns.Add("CNPJ", 150).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("Nome", 150).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("Cidade", 100).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("Qtd Funcionarios", 80).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("Faturamento", 150).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("Credito", 150).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("Nome Fantasia", 150).TextAlign = HorizontalAlignment.Center;
            lvPj.View = View.Details;
        }
    }



}
