using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisesEstadosCidades
{
    internal class Interfaces
    {
        FrmConsultaPaises ofrmConsultaPaises;
        FrmConsultasEstados ofrmConsultaEstados;
        FrmConsultasCidades ofrmConsultaCidades;


        FrmCadastrosPaises ofrmCadastroPaises;

        FrmCadastrosEstados ofrmCadastroEstados;
        FrmCadastrosCidades ofrmCadastroCidades;





        public Interfaces()
        {
            ofrmConsultaPaises=new FrmConsultaPaises();
            ofrmConsultaEstados = new FrmConsultasEstados();
            ofrmConsultaCidades = new FrmConsultasCidades();


            ofrmCadastroPaises = new FrmCadastrosPaises();
            ofrmCadastroEstados = new FrmCadastrosEstados();
            ofrmCadastroCidades=new FrmCadastrosCidades();

            ofrmConsultaPaises.setFrmCadastros(ofrmCadastroPaises);

            ofrmConsultaEstados.setFrmCadastros(ofrmCadastroEstados);
            ofrmConsultaCidades.setFrmCadastros(ofrmCadastroCidades);

            ofrmCadastroEstados.SetFrmConsultaPaises(ofrmConsultaPaises);
            ofrmCadastroCidades.SetFrmConsultaEstados(ofrmConsultaEstados);


        }

        public void PecaPaises(Object Obj,Object Ctrl)
        {
            ofrmConsultaPaises.ConhecaObj(Obj, Ctrl);
            ofrmConsultaPaises.ShowDialog();
        }

        public void PecaEstados(Object Obj,Object Ctrl)
        {
            ofrmConsultaEstados.ConhecaObj(Obj, Ctrl);
            ofrmConsultaEstados.ShowDialog(); 
        }

        public void PecaCidades(Object Obj,Object Ctrl)
        {
            ofrmConsultaCidades.ConhecaObj(Obj, Ctrl);
            ofrmConsultaCidades.ShowDialog();
        }
    }
}
