using Capa_Modelo.Nodo;

namespace Capa_Logica.Cola
{
    public class Orquestador_Cola
    {
        public NodoInt cabeza;
        public NodoInt cola;
        public NodoInt cabeza2;
        public NodoInt cola2;

        public void Enqueue(int _valor) {
            
            if (Cabeza_No_Nula())
            {
                NodoInt nodoNuevo = new NodoInt(_valor);

                NodoInt nodoActual = cola;

                nodoActual.Siguiente = nodoNuevo;

                cola = nodoNuevo;

            }
            else
            {
                NodoInt nodoNuevo = new NodoInt(_valor);
                cabeza = nodoNuevo;
                cola = nodoNuevo;
            }

        }

        public bool Cabeza_No_Nula()
        {
            return cabeza != null;
        }
        /// <summary>
        /// Desencolar no es eliminar, solo no se incluyen en la lista.
        /// </summary>
        /// <returns></returns>
        public NodoInt Dequeue() {
            NodoInt nodoRetorno = null;
            if (Cabeza_No_Nula())
            {
                NodoInt nodoActual = cabeza;
                nodoRetorno = nodoActual;
                nodoActual = nodoActual.Siguiente;
                cabeza = nodoActual;

            }
            return nodoRetorno;
        }

        public void Imprimir_Lista() {
            Console.WriteLine("+-+-+Empieza cola-+-+");
            if (Cabeza_No_Nula())
            {
                NodoInt nodoActual = cabeza;
                
                while(nodoActual != null)
                {
                    Console.Write(nodoActual.Valor.ToString() + " <- ");
                    nodoActual = nodoActual.Siguiente;
                }
            }
            Console.WriteLine("\n+-+-+Termina cola-+-+");
        }

        public void Enqueue_Pares(int _valor) {
            if (_valor % 2 == 0)
            {
                Enqueue(_valor);
            }
        }
        public void Elimine_Valor_En_Cola(int _valorBorrar) {
            if (Cabeza_No_Nula())
            {
                NodoInt nodoActual = cabeza;
                while(nodoActual.Valor != _valorBorrar)
                {
                    Enqueue(Dequeue().Valor);
                    nodoActual = nodoActual.Siguiente;
                }
                Dequeue();
                
            }
        }

        public void Enqueue_Cola_Diferente(int _valor) {
            
            if(cabeza2 != null)
            {
                NodoInt nodoNuevo = new NodoInt(_valor);

                NodoInt nodoActual = cola2;

                nodoActual.Siguiente = nodoNuevo;

                cola2 = nodoNuevo;
            }
            else
            {
                NodoInt nodoNuevo = new NodoInt(_valor);
                cabeza2 = nodoNuevo;
                cola2 = nodoNuevo;
            }

        }

        public void Imprimir_Cola2()
        {
            Console.WriteLine("+-+-+Empieza cola2-+-+");
            if (Cabeza_No_Nula())
            {
                NodoInt nodoActual = cabeza2;

                while (nodoActual != null)
                {
                    Console.Write(nodoActual.Valor.ToString() + " <- ");
                    nodoActual = nodoActual.Siguiente;
                }
            }
            Console.WriteLine("\n+-+-+Termina cola2-+-+");
        }

    }
}
