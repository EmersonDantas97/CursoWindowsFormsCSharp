using CursoWindowsFormsBiblioteca;
using CursoWindowsFormsBiblioteca.Classes;
using CursoWindowsFormsBiblioteca.Databases;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;


namespace CursoWindowsForms
{
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public Frm_CadastroCliente_UC()
        {
            InitializeComponent();

            Grp_Codigo.Text = "Código";
            Grp_DadosPessoais.Text = "Dados Pessoais";
            Grp_Endereco.Text = "Endereço";
            Grp_Outros.Text = "Outros";
            Grp_Genero.Text = "Genero";

            Lbl_Bairro.Text = "Bairro";
            Lbl_CEP.Text = "CEP";
            Lbl_Complemento.Text = "Complemento";
            Lbl_CPF.Text = "CPF";
            Lbl_Estado.Text = "Estado";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_NomeCliente.Text = "Nome";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Lbl_NomePai.Text = "Nome do Pai";
            Lbl_Profissao.Text = "Profissão";
            Lbl_RendaFamiliar.Text = "Renda Familiar";
            Lbl_Telefone.Text = "Telefone";
            Lbl_Cidade.Text = "Cidade";

            Chk_TemPai.Text = "Pai desconhecido";

            Rdb_Masculino.Text = "Masculino";
            Rdb_Feminino.Text = "Feminino";
            Rdb_Indefinido.Text = "Indefinido";

            Cmb_Estados.Items.Clear();
            Cmb_Estados.Items.Add("Acre (AC)");
            Cmb_Estados.Items.Add("Alagoas(AL)");
            Cmb_Estados.Items.Add("Amapá(AP)");
            Cmb_Estados.Items.Add("Amazonas(AM)");
            Cmb_Estados.Items.Add("Bahia(BA)");
            Cmb_Estados.Items.Add("Ceará(CE)");
            Cmb_Estados.Items.Add("Distrito Federal(DF)");
            Cmb_Estados.Items.Add("Espírito Santo(ES)");
            Cmb_Estados.Items.Add("Goiás(GO)");
            Cmb_Estados.Items.Add("Maranhão(MA)");
            Cmb_Estados.Items.Add("Mato Grosso(MT)");
            Cmb_Estados.Items.Add("Mato Grosso do Sul(MS)");
            Cmb_Estados.Items.Add("Minas Gerais(MG)");
            Cmb_Estados.Items.Add("Pará(PA)");
            Cmb_Estados.Items.Add("Paraíba(PB)");
            Cmb_Estados.Items.Add("Paraná(PR)");
            Cmb_Estados.Items.Add("Pernambuco(PE)");
            Cmb_Estados.Items.Add("Piauí(PI)");
            Cmb_Estados.Items.Add("Rio de Janeiro(RJ)");
            Cmb_Estados.Items.Add("Rio Grande do Norte(RN)");
            Cmb_Estados.Items.Add("Rio Grande do Sul(RS)");
            Cmb_Estados.Items.Add("Rondônia(RO)");
            Cmb_Estados.Items.Add("Roraima(RR)");
            Cmb_Estados.Items.Add("Santa Catarina(SC)");
            Cmb_Estados.Items.Add("São Paulo(SP)");
            Cmb_Estados.Items.Add("Sergipe(SE)");
            Cmb_Estados.Items.Add("Tocantins(TO)");

            Tls_Principal.Items[0].ToolTipText = "Incluir na base de dados um novo cliente";
            Tls_Principal.Items[1].ToolTipText = "Capturar um cliente já cadastrado na base";
            Tls_Principal.Items[2].ToolTipText = "Atualize um cliente já existente";
            Tls_Principal.Items[3].ToolTipText = "Apaga o cliente selecionado";
            Tls_Principal.Items[4].ToolTipText = "Limpa dados da tela de entrada de dados";

            Btn_Buscar.Text = "Buscar";



            LimparFormulario();
        }

        private void Chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_TemPai.Checked)
                Txt_NomePai.Enabled = false;
            else
                Txt_NomePai.Enabled = true;
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();
                C = LeituraFormulario();
                C.ValidaClasse();
                C.ValidaComplemento();
                C.IncluirFicharioDB("Cliente");
                //C.IncluirFichario("C:\\WindowsForms\\Curso\\CursoWindowsForms\\Fichario");
                MessageBox.Show("OK: Indentificador incluido com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do Cliente vazio.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = C.BuscarFicharioDB(Txt_Codigo.Text, "Cliente");
                    if (C == null)
                    {
                        MessageBox.Show("Identificador não encontrado.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(C);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do Cliente vazio.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = LeituraFormulario();
                    C.ValidaClasse();
                    C.ValidaComplemento();
                    C.AlterarFicharioDB("Cliente");
                    MessageBox.Show("OK: Indentificador alterado com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ValidationException Ex)
                {
                    MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ApagatoolStripButton1_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do Cliente vazio.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = C.BuscarFicharioDB(Txt_Codigo.Text, "Cliente");
                    //C = C.BuscarFichario(Txt_Codigo.Text, "C:\\WindowsForms\\Curso\\CursoWindowsForms\\Fichario");
                    if (C == null)
                    {
                        MessageBox.Show("Identificador não encontrado.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(C);
                        Frm_Questao Db = new Frm_Questao("icons8_question_mark_961", "Você quer excluir o cliente?");
                        Db.ShowDialog();
                        if (Db.DialogResult == DialogResult.Yes)
                        {
                            C.ApagarFicharioDB("Cliente");
                            MessageBox.Show("OK: Indentificador apagado com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparFormulario();
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LimpartoolStrpButton1_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }
        private void LimparFormulario()
        {
            Txt_Codigo.Text = "";
            Txt_Bairro.Text = "";
            Txt_CEP.Text = "";
            Txt_Complemento.Text = "";
            Txt_CPF.Text = "";
            Txt_Logradouro.Text = "";
            Txt_NomeCliente.Text = "";
            Txt_NomeMae.Text = "";
            Txt_NomePai.Text = "";
            Txt_Profissao.Text = "";
            Txt_RendaFamiliar.Text = "";
            Txt_Telefone.Text = "";
            Txt_Cidade.Text = "";
            Cmb_Estados.SelectedIndex = -1;
            Chk_TemPai.Checked = false;
            Rdb_Masculino.Checked = true;
        }
        Cliente.Unit LeituraFormulario()
        {
            Cliente.Unit c = new Cliente.Unit();
            c.Id = Txt_Codigo.Text;
            c.Nome = Txt_NomeCliente.Text;
            c.NomeMae = Txt_NomeMae.Text;
            c.NomePai = Txt_NomePai.Text;

            if (Chk_TemPai.Checked)
                c.NaoTemPai = true;
            else
                c.NaoTemPai = false;

            if (Rdb_Feminino.Checked)
                c.Genero = 1;
            if (Rdb_Masculino.Checked)
                c.Genero = 0;
            if (Rdb_Indefinido.Checked)
                c.Genero = 2;

            c.CPF = Txt_CPF.Text;
            c.CEP = Txt_CEP.Text;
            c.Logradouro = Txt_Logradouro.Text;
            c.Cidade = Txt_Cidade.Text;
            c.Bairro = Txt_Bairro.Text;
            c.Complemento = Txt_Complemento.Text;

            if (Cmb_Estados.SelectedIndex < 0)
                c.Estado = "";
            else
                c.Estado = Cmb_Estados.Items[Cmb_Estados.SelectedIndex].ToString();

            c.Telefone = Txt_Telefone.Text;
            c.Profissao = Txt_Profissao.Text;

            if (Information.IsNumeric(Txt_RendaFamiliar.Text))
            {
                double vRenda = Convert.ToDouble(Txt_RendaFamiliar.Text);

                if (vRenda < 0)
                {
                    c.RendaFamiliar = 0;
                }
                else
                {
                    c.RendaFamiliar = vRenda;
                }
            }
            return c;
        }
        void EscreveFormulario(Cliente.Unit c)
        {
            Txt_Codigo.Text = c.Id;
            Txt_NomeCliente.Text = c.Nome;
            Txt_NomeMae.Text = c.NomeMae;

            if (c.NaoTemPai == true)
            {
                Chk_TemPai.Checked = true;
                Txt_NomePai.Text = c.NomePai;
            }
            else
            {
                Chk_TemPai.Checked = false;
                Txt_NomePai.Text = "";
            }

            if (c.Genero == 0)
                Rdb_Masculino.Checked = true;

            if (c.Genero == 1)
                Rdb_Feminino.Checked = true;

            if (c.Genero == 2)
                Rdb_Indefinido.Checked = true;

            Txt_CPF.Text = c.CPF;
            Txt_CEP.Text = c.CEP;
            Txt_Logradouro.Text = c.Logradouro;
            Txt_Cidade.Text = c.Cidade;
            Txt_Bairro.Text = c.Bairro;
            Txt_Telefone.Text = c.Telefone;
            Txt_Profissao.Text = c.Profissao;
            Txt_Complemento.Text = c.Complemento;

            if (c.Estado == "")
            {
                Cmb_Estados.SelectedIndex = -1;
            }
            else
            {
                for (int i = 0; i < Cmb_Estados.Items.Count - 1; i++)
                {
                    if (c.Estado == Cmb_Estados.Items[i].ToString())
                        Cmb_Estados.SelectedIndex = i;
                }
            }

            Txt_RendaFamiliar.Text = c.RendaFamiliar.ToString();
        }


        private void Txt_CEP_Leave(object sender, EventArgs e)
        {
            string stringcep = Txt_CEP.Text;

            if (stringcep.Length == 8 && Information.IsNumeric(stringcep))
            {
                var vJson = Cls_Uteis.GeraJSONCEP(stringcep);
                Cep.Unit CEP = new Cep.Unit();
                CEP = Cep.DesSerializedClassUnit(vJson);

                Txt_Logradouro.Text = CEP.logradouro;
                Txt_Bairro.Text = CEP.bairro;
                Txt_Cidade.Text = CEP.localidade;

                Cmb_Estados.SelectedIndex = -1;

                for (int i = 0; i < Cmb_Estados.Items.Count - 1; i++)
                {
                    var vlrPosicao = Strings.InStr(Cmb_Estados.Items[i].ToString(), "(" + CEP.uf + ")");

                    if (vlrPosicao > 0)
                    {
                        Cmb_Estados.SelectedIndex = i;
                    }
                }
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            FicharioDB f = new FicharioDB("Cliente");

            if (f.status)
            {
                List<string> Lista = new List<string>();
                Lista = f.BuscarTodos();

                // Fazendo validação, pois pode dar erro
                if (f.status)
                {
                    List<List<string>> ListaBusca = new List<List<string>>();

                    foreach (var dds in Lista)
                    {
                        Cliente.Unit c = Cliente.Unit.DesSerializedClassUnit(dds);
                        ListaBusca.Add(new List<string> { c.Id, c.Nome });
                    }
                    Frm_Busca F = new Frm_Busca(ListaBusca);
                    F.ShowDialog();
                    if (F.DialogResult == DialogResult.OK)
                    {
                        string clienteJson = f.Buscar(F.IdSelecionado);
                        Cliente.Unit c = new Cliente.Unit();
                        c = Cliente.Unit.DesSerializedClassUnit(clienteJson);
                        EscreveFormulario(c);
                    }
                }
                else
                {
                    MessageBox.Show("Erro: " + f.mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Erro: " + f.mensagem, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
