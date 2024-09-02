using System;

class Program
{
    static void Main(string[] args)
    {
        // Leer los dos números racionales desde el teclado
        CNumeroRacional racional1 = CNumeroRacional.LeerNumeroRacionalDesdeTeclado();
        CNumeroRacional racional2 = CNumeroRacional.LeerNumeroRacionalDesdeTeclado();

        // Realizar las operaciones y mostrar los resultados
        CNumeroRacional suma = racional1.Sumar(racional2);
        Console.WriteLine($"Suma: {racional1} + {racional2} = {suma}");

        CNumeroRacional resta = racional1.Restar(racional2);
        Console.WriteLine($"Resta: {racional1} - {racional2} = {resta}");

        CNumeroRacional multiplicacion = racional1.Multiplicar(racional2);
        Console.WriteLine($"Multiplicación: {racional1} * {racional2} = {multiplicacion}");

        try
        {
            CNumeroRacional division = racional1.Dividir(racional2);
            Console.WriteLine($"División: {racional1} / {racional2} = {division}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error en la división: {ex.Message}");
        }

        // Pausar la consola para que no se cierre inmediatamente
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();  // Espera a que el usuario presione una tecla
    }
}
