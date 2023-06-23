using Capa_Logica.Cola;
using Capa_Logica.Pila;

Orquestador_Cola cola = new Orquestador_Cola();
Orquestador_Pila pila = new Orquestador_Pila();

cola.Enqueue(1);
cola.Enqueue(2);
cola.Enqueue(3);
cola.Enqueue(4);
//cola.Imprimir_Lista();
//cola.Dequeue();
cola.Imprimir_Lista();
cola.Elimine_Valor_En_Cola(3);
cola.Imprimir_Lista();
cola.Enqueue_Cola_Diferente(5);
cola.Enqueue_Cola_Diferente(6);
cola.Enqueue_Cola_Diferente(7);
cola.Enqueue_Cola_Diferente(8);
cola.Imprimir_Cola2();