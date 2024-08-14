using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjetoMosquitoVelho
{
    public partial class frmListarProdutos : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmListarProdutos()
        {
            InitializeComponent();
            carregaCombo();
        }

        public void carregaCombo()
        {
            produtos[0] = "Banana";
            produtos[1] = "Morango";
            produtos[2] = "Melao";
            produtos[3] = "Manga";
            produtos[4] = "Uva";
            produtos[5] = "Pera";
            produtos[6] = "Amora";
            produtos[7] = "Jabuticaba";
            produtos[8] = "Jaca";
            produtos[9] = "Laranja";

            for (int i = 0; i < produtos.Length; i++)
            {
                cmbProdutos.Items.Add(produtos[i]);
            }
        }

        private void frmListarProdutos_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
            //criar um vetor 
            string[] produtos = new string[10];

        private void btnCarregar_Click(object sender, EventArgs e)
        {

            //inserindo valores no vetor
            produtos[0] = "Banana";
            produtos[1] = "Morango";
            produtos[2] = "Melao";
            produtos[3] = "Manga";
            produtos[4] = "Uva";
            produtos[5] = "Pera";
            produtos[6] = "Amora";
            produtos[7] = "Jabuticaba";
            produtos[8] = "Jaca";
            produtos[9] = "Laranja";

            //MessageBox.Show("Produto "+ produtos[0]);
            //MessageBox.Show("Produto "+ produtos[5]);
            ltbListaProdutos.Items.Clear();
            for (int i = 0; i < produtos.Length; i++)
            {
                ltbListaProdutos.Items.Add(produtos[i]);
            }
            
        }
    }
}
