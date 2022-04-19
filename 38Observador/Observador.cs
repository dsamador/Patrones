namespace _38Observador
{
    public class Observador: IObservador
    {
        private string _nombre;
        private Sujeto _sujeto;
        public Observador(string nombre, Sujeto sujeto)
        {
            _nombre = nombre;
            _sujeto = sujeto;
            sujeto.Suscribir(this);
        }
        //Este metodo es usado por el sujeto en el push
        public void Update(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Push, {_nombre}-{mensaje}");
        }
        //Aqui es para el caso pull
        public void UpdatePull()
        {
            //Obtenemos el sujeto 
            //puede ir mas logica para decidir cuando hacerlo
            int n = _sujeto.N;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Push, {_nombre}-{n}");
        }
    }
}
