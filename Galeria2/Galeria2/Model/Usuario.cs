using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeria
{
    class Usuario : Persona
    {
        //private int usuarioID;
        private string nombreUsuario, avatar;
        private List<Album> albumlist;
        private Imagen imagenref;


        public List<Album> Albumlist
        {
            set { albumlist = value; }
            get { return albumlist; }
        }

        public Usuario(string nombreUsuario, string avatar, string cedula, string nombre)
            : base(cedula, nombre)
        {
            this.NombreUsuario = nombreUsuario;
            this.Avatar = avatar;

        }
    
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        internal Imagen Imagenref { get => imagenref; set => imagenref = value; }
    }
}
