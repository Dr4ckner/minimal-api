using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mininal_api.Dominio.ModelViews
{
    public struct Home
    {
        public string Mensagem { get => "Bem vindo a API do leozinho!"; }

        public string Doc { get => "/swagger"; }
    }
}