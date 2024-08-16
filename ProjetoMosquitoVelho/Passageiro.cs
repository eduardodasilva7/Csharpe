using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMosquitoVelho
{
    class Passageiro
    {
        private string documento;
        private string numCartao;

        //criando metodo de acesso 
        public string Documento { get => documento; set => documento = value; }
        public string NumCartao { get => numCartao; set => numCartao = value; }


    }
}
