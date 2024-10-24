namespace ListaLigada.Logica
{
    public class SingleNode <T>
    {
        //propiedad
        public T? Data { get; set; }

        public SingleNode<T>? Next { get; set; }

        //constructor
        public SingleNode(T data)
        {
            Data = data;
            Next = null;
        }
    }
}
