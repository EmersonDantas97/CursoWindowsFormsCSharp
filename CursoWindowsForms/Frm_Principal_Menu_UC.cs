using CursoWindowsFormsBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal_Menu_UC : Form
    {
        int ControleHelloWord = 0;
        int ControleDemonstracaoKey = 0;
        int ControleMascara = 0;
        int ControleValidaCPF = 0;
        int ControleValidaCPF2 = 0;
        int ControleValidaSenha = 0;
        int ControleArquivoImagem = 0;
        int ControleCadastroClientes = 0;

        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();

            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            açõesToolStripMenuItem.Enabled = false;
            windowsToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
            cadastrosToolStripMenuItem.Enabled = false;

        }
        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemonstracaoKey += 1;

            Frm_DemonstracaoKey_UC U = new Frm_DemonstracaoKey_UC();
            TabPage TB = new TabPage();
            TB.Name = "Demonstração Key " + ControleDemonstracaoKey;
            TB.Text = "Demonstração Key " + ControleDemonstracaoKey;
            TB.ImageIndex = 0;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWord += 1;

            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();
            TabPage TB = new TabPage();
            TB.Name = "Hello World " + ControleHelloWord;
            TB.Text = "Hello World " + ControleHelloWord;
            TB.ImageIndex = 1;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara += 1;

            Frm_Mascara_UC U = new Frm_Mascara_UC();
            TabPage TB = new TabPage();
            TB.Name = "Máscara " + ControleMascara;
            TB.Text = "Máscara " + ControleMascara;
            TB.ImageIndex = 2;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF += 1;

            Frm_ValidaCPF_UC U = new Frm_ValidaCPF_UC();
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF " + ControleValidaCPF;
            TB.Text = "Valida CPF " + ControleValidaCPF;
            TB.ImageIndex = 3;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF2 += 1;

            Frm_ValidaCPF2_UC U = new Frm_ValidaCPF2_UC();
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF2 " + ControleValidaCPF2;
            TB.Text = "Valida CPF2 " + ControleValidaCPF2;
            TB.ImageIndex = 4;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaSenha += 1;

            Frm_ValidaSenha_UC U = new Frm_ValidaSenha_UC();
            TabPage TB = new TabPage();
            TB.Name = "Valida Senha " + ControleValidaSenha;
            TB.Text = "Valida Senha " + ControleValidaSenha;
            TB.ImageIndex = 5;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaAba(Tbc_Aplicacoes.SelectedTab);
            }
        }

        private void abrirImagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Db = new OpenFileDialog();
            Db.InitialDirectory = "D:\\EMERSON\\Programacao\\CursoWindowsForms\\CursoWindowsForms\\Imagens";
            Db.Filter = "PNG|*.PNG";
            Db.Title = "Escolha a imagem";

            if (Db.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivo = Db.FileName;

                ControleArquivoImagem += 1;

                Frm_ArquivoImagem_UC U = new Frm_ArquivoImagem_UC(nomeArquivo);
                TabPage TB = new TabPage();
                TB.Name = "Arquivo Imagem " + ControleArquivoImagem;
                TB.Text = "Arquivo Imagem " + ControleArquivoImagem;
                TB.ImageIndex = 6;
                TB.Controls.Add(U);
                Tbc_Aplicacoes.TabPages.Add(TB);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login f = new Frm_Login();
            f.ShowDialog();

            if (CursoWindowsFormsBiblioteca.Cls_Uteis.validaSenhaLogin(f.senha) && f.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Seja bem vindo " + f.usuario + "!", "Boas Vindas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                novoToolStripMenuItem.Enabled = true;
                apagarAbaToolStripMenuItem.Enabled = true;
                açõesToolStripMenuItem.Enabled = true;
                windowsToolStripMenuItem.Enabled = true;
                conectarToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = true;
                cadastrosToolStripMenuItem.Enabled = true;

                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                MessageBox.Show("Senha inválida", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao f = new Frm_Questao("interrogation_mark", "Deseja desconectar?");
            f.ShowDialog();

            if (f.DialogResult == DialogResult.Yes)
            {
                novoToolStripMenuItem.Enabled = false;
                apagarAbaToolStripMenuItem.Enabled = false;
                açõesToolStripMenuItem.Enabled = false;
                windowsToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
                desconectarToolStripMenuItem.Enabled = false;
                cadastrosToolStripMenuItem.Enabled = false;

                for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i += -1)
                {
                    ApagaAba(Tbc_Aplicacoes.TabPages[i]);
                }

            }

        }

        private void Tbc_Aplicacoes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenuStrip contextMenu = new ContextMenuStrip();

                var ContextMenu = new ContextMenuStrip();

                var vToolTip001 = DesenhaItensMenu("Apagar a aba", "DeleteTab");
                var vToolTip002 = DesenhaItensMenu("Apagar todas à esquerda", "DeleteLeft");
                var vToolTip003 = DesenhaItensMenu("Apagar todas à direita", "DeleteRight");
                var vToolTip004 = DesenhaItensMenu("Apagar todas menos esta", "DeleteAll");

                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Items.Add(vToolTip003);
                ContextMenu.Items.Add(vToolTip004);

                ContextMenu.Show(this, new Point(e.X, e.Y));

                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
                vToolTip003.Click += new System.EventHandler(vToolTip003_Click);
                vToolTip004.Click += new System.EventHandler(vToolTip004_Click);
            }
        }

        // Apagar aba
        void vToolTip001_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
                ApagaAba(Tbc_Aplicacoes.SelectedTab);
        }

        // Apagar a Esquerda
        void vToolTip002_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
                apagarEsquerda(Tbc_Aplicacoes.SelectedIndex);
        }

        // Apagar a Direita
        void vToolTip003_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
                apagarDireita(Tbc_Aplicacoes.SelectedIndex);
        }

        // Apagar todas menos esta
        void vToolTip004_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                apagarEsquerda(Tbc_Aplicacoes.SelectedIndex);
                apagarDireita(Tbc_Aplicacoes.SelectedIndex);
            }
        }

        void apagarDireita(int abaSelecionada)
        {
            for (int i = Tbc_Aplicacoes.TabCount - 1; i > abaSelecionada; i += -1)
                ApagaAba(Tbc_Aplicacoes.TabPages[i]);
        }
        void apagarEsquerda(int abaSelecionada)
        {
            for (int i = abaSelecionada - 1; i >= 0; i += -1)
                ApagaAba(Tbc_Aplicacoes.TabPages[i]);
        }

        ToolStripMenuItem DesenhaItensMenu(string text, string nomeImagem)
        {
            var vToolTip = new ToolStripMenuItem();
            Image MyImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);

            vToolTip.Text = text;
            vToolTip.Image = MyImage;

            return vToolTip;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ControleCadastroClientes == 0)
            {
                ControleCadastroClientes += 1;
                Frm_CadastroCliente_UC U = new Frm_CadastroCliente_UC();
                U.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Cadastro de Clientes";
                TB.Text = "Cadastro de Clientes";
                TB.ImageIndex = 7;
                TB.Controls.Add(U);
                Tbc_Aplicacoes.TabPages.Add(TB);
            }
            else
            {
                MessageBox.Show("Não posso abrir o Cadastro de Clientes, porque ele já está aberto.",
                    "Banco ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ApagaAba(TabPage TB)
        {
            if (TB.Name == "Cadastro de Clientes")
            {
                ControleCadastroClientes = 0;
            }
            Tbc_Aplicacoes.TabPages.Remove(TB);
        }
    }
}
