namespace ListaLigada.Logica
{
    internal class SingleList <T>
    {
        private SingleNode<T>? _first;

        public SingleList()
        {
            _first = null;//llddooooooopoofdsfsdd
        }

        public bool isEmpty() => _first == null;

        public void Add(T item) {

            var node = new SingleNode<T>(item);
            if (isEmpty())
            {
                _first = null;
            }
            else
            {
                var pointer = _first;
            }
        }
    }
}
