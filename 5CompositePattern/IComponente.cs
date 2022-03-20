namespace _5CompositePattern
{
    public interface IComponente<T>
    {
        //Dato a guardar en los elementos
        T Nombre { get; set; }

        //  Comportamientos comunes

        void Adicionar(IComponente<T> elemento);
        IComponente<T> Borrar(T elemento);
        IComponente<T> Buscar(T elemento);
        string Mostrar(int profundidad);
    }
}
