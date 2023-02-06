using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Busca : Form
    {
        List<List<string>> _ListaBusca = new List<List<string>>();

        public string IdSelecionado;

        public Frm_Busca(List<List<string>> ListaBusca)
        {
            _ListaBusca = ListaBusca;

            InitializeComponent();

            this.Text = "Buscar";

            Tls_Principal.Items[0].ToolTipText = "Abrir";
            Tls_Principal.Items[1].ToolTipText = "Fechar";

            PreencherLista();

            Lst_Busca.Sorted = true;
        }

        private void PreencherLista()
        {
            Lst_Busca.Items.Clear();

            for (int i = 0; i <= _ListaBusca.Count - 1; i++)
            {
                ItemBox X = new ItemBox();
                X.Id = _ListaBusca[i][0];
                X.Nome = _ListaBusca[i][1];

                Lst_Busca.Items.Add(X);
            }
        }

        private void ApagatoolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            ItemBox itemSelecionado = (ItemBox)Lst_Busca.Items[Lst_Busca.SelectedIndex];

            IdSelecionado = itemSelecionado.Id;

            this.Close();
        }

        class ItemBox
        {
            public string Id { get; set; }
            public string Nome { get; set; }

            public override string ToString()
            {
                return Nome.ToString();
            }
        }
    }
}
