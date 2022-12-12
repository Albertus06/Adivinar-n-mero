// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenido jugador a Adivinar el número");
Console.WriteLine("Te explico la reglas:");
Console.WriteLine("1. Tienes que adivinar el número del 1 al 15.");
Console.WriteLine("2. Solo tienes 3 vidas.");
var generadorAleatorio = new Random();
int numeroParaAdivinar = generadorAleatorio.Next(1,15); 
int i = 0;


while (i < 3){
    Console.WriteLine("Ingresa un número");
    int respuesta = Convert.ToInt32(Console.ReadLine());
    if (respuesta == numeroParaAdivinar){
        Console.WriteLine($"Felicidades, acertaste el número en {i} intentos.");
        break;
    }
    else{
        Console.WriteLine($"Has fallado. Te quedan {2-i} intentos.");
    i = i+1;
        if (respuesta < numeroParaAdivinar){
           Console.WriteLine("Tu número es más bajo") 
        }
    }
    
}
