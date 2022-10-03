using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple
{
    class Operaciones
    {
        private Nodo head;

        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }

        public void Agregar(Nodo n)
        {
            //Primero
            if (head == null)
            {
                head = n;
                return;
            }
            //Antes
            if (n.Dato < head.Dato)
            {
                n.Siguiente = head;
                head = n;
                return;
            }

            //En medio
            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Dato > n.Dato)
                {
                    break;
                }
                h = h.Siguiente;
            }

            if (h.Siguiente != null)
            {
                n.Siguiente = h.Siguiente;
                h.Siguiente = n;
                return;
            }
            h.Siguiente = n;
        }

        public override string ToString()
        {
            string lista = "";
            Nodo h = head;
            if (h != null)
            {
                lista += h.ToString();
                h = h.Siguiente;
                while (h != null)
                {
                    lista += "," + h.ToString();
                    h = h.Siguiente;
                }
                return lista;
            }
            else
            {
                return "La lista esta vacia";
            }
        }

        public void Borrar(int dato)
        {
            if (head != null)
            {
                if (head.Dato == dato)
                {
                    head = head.Siguiente;
                    return;
                }
                Nodo h = head;
                while (h.Siguiente != null)
                {
                    if (h.Siguiente.Dato == dato)
                    {
                        h.Siguiente = h.Siguiente.Siguiente;
                        return;
                    }
                    h = h.Siguiente;
                }
            }
        }
    }
}
