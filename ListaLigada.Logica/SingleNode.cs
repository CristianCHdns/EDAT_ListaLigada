namespace ListaLigada.Logica
{
    public class SingleNode <T> //clase generica, al agregar <T> esta indicando que es asi para no tener conflictos con los tipos de datos
    {
        //propiedad
        public T? Data { get; set; }

        public SingleNode<T>? Next { get; set; } //Se crea un apuntador a memoria

        //constructor
        public SingleNode(T data)
        {
            Data = data;
            Next = null;
        }
    }
}
