using _38Observador;

//Creamos al sujeto
Sujeto sujeto = new Sujeto();

//Creamos a los observadores
Observador a = new Observador("A", sujeto);
Observador b = new Observador("B", sujeto);
Observador c = new Observador("C", sujeto);

//Trabajamos
for (int i = 0; i < 5; i++)
    sujeto.Trabajo();

//Alguien se sale de la lista
Console.WriteLine("--------Desuscribir--------");
sujeto.Desuscribir(b);

//Trabajamos
for (int i = 0; i < 5; i++)
    sujeto.Trabajo();