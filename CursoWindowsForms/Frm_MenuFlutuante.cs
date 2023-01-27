using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;

namespace CursoWindowsForms
{
    public partial class Frm_MenuFlutuante : Form
    {
        public Frm_MenuFlutuante()
        {
            InitializeComponent();
        }

        private void Frm_MenuFlutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var ContextMenu = new ContextMenuStrip();

                var vToolTip001 = DesenhaItensMenu("Item 1", "Frm_ValidaSenha");
                var vToolTip002 = DesenhaItensMenu("Item 2", "Frm_ValidaCPF");
                
                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);

                ContextMenu.Show(this, new Point(e.X, e.Y));

                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
            }
        }

        void vToolTip001_Click(object sender1, EventArgs e1)
        {
            MessageBox.Show("Opcao 1 selecionada!");
        }

        void vToolTip002_Click(object sender1, EventArgs e1)
        {
            MessageBox.Show("Opcao 2 selecionada!");
        }

        ToolStripMenuItem DesenhaItensMenu(string text, string nomeImagem)
        {
            var vToolTip = new ToolStripMenuItem();
            Image MyImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);

            vToolTip.Text = text;
            vToolTip.Image = MyImage;

            return vToolTip;
        }
    }
}
