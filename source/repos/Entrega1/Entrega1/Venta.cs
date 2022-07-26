using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega1
{
    public class Venta
    {
        protected int id;
        protected string coment;

        public Venta(int id, string coment)
        {
            this.id = id;
            this.coment = coment;
        }

        public int getId()
        {
            return id;
        }
        public void setId(int unId)
        {
            this.id = unId;
        }

        public string getComentarios()
        {
            return coment;
        }
        public void setComentario(string unComentario)
        {
            this.coment = unComentario;
        }
    }
}
