using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mininal_api.Dominio.Enuns;

namespace mininal_api.Dominio.ModelViews
{
    public class AdministradorModelView
    {
        public int Id { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Perfil { get; set; } = default!;
    }
}