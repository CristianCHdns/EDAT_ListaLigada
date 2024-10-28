namespace ListaLigada.Logica
{
    public class SingleList <T> 
    {
        public SingleNode<T>? _first;

        public SingleList()
        {
            _first = null; //si es null es porque no tiene un nodo
        }

        public bool isEmpty() => _first == null; // si esto es asi es porque no tiene nada ni un nodo

        public void Add(T item) {

            var node = new SingleNode<T>(item);
            if (isEmpty())
            {
                _first = null;
            }
            else
            {
                var pointer = _first;
                while (pointer != null)// el pointer se va ir moviendo, compara la propiedad con null
                {
                    pointer = pointer.Next; //verifica que exista otro nodo aputando guarda la direccion del nuevo nodo que se esta insertando
                }

                pointer!.Next = node;
            }

        }

        public override string ToString()
        {
            var cadenaLista = string.Empty;
            var pointer = _first;

            while (pointer != null)
            {
                cadenaLista += $"{pointer.Data}\n";
                pointer = pointer.Next;

            }
            return cadenaLista;
        }
    }
}
