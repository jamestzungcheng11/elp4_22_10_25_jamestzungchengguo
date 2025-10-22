using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaisesEstadosCidades
{
    public partial class Frm: Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        protected virtual void Sair()
        {
            Close();
           
           
        }

        public virtual void ConhecaObj(Object Obj,Object Ctrl)
        {

        }

        private void Frm_Load(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {

            Sair();
        }
    }
}
