using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Busca : Form
    {
        List<List<string>> _ListaBusca = new List<List<string>>();

        public Frm_Busca(List<List<string>> ListaBusca)
        {
            _ListaBusca = ListaBusca;

            InitializeComponent();

            this.Text = "Buscar";

            Tls_Principal.Items[0].ToolTipText = "Abrir";
            Tls_Principal.Items[1].ToolTipText = "Fechar";

            PreencherLista();
        }

        private void PreencherLista()
        {
            Lst_Busca.Items.Clear();

            for (int i = 0; i < _ListaBusca.Count - 1; i++)
            {
                Lst_Busca.Items.Add(_ListaBusca[i][1]);
            }
        }

        private void ApagatoolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
