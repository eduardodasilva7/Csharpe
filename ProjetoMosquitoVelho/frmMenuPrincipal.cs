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
    public partial class frmMenuPrincipal : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnfuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionarios func = new frmFuncionarios();
            func.Show();
            this.Hide();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin();
            abrir.Show();
            this.Hide();
        }


        private void btnTarefas_Click(object sender, EventArgs e)
        {
            frmTarefas tarf = new frmTarefas();
            tarf.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes cli = new frmClientes();
            cli.Show();
            this.Hide();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos prod = new frmProdutos();
            prod.Show();
            this.Hide();
        }
    }
}
