using System;

public class CNumeroRacional
{
    public int Numerador { get; private set; }
    public int Denominador { get; private set; }

    public CNumeroRacional(int numerador, int denominador)
    {
        if (denominador == 0)
            throw new ArgumentException("El denominador no puede ser 0.");

        if (denominador < 0)
        {
            numerador = -numerador;
            denominador = -denominador;
        }

        Numerador = numerador;
        Denominador = denominador;

        Simplificar();
    }

    private void Simplificar()
    {
        if (Numerador == 0)
        {
            Denominador = 1;  // Si el numerador es 0, la fracción se simplifica a 0/1
        }
        else
        {
            int gcd = CalcularMCD(Math.Abs(Numerador), Denominador);
            Numerador /= gcd;
            Denominador /= gcd;
        }
    }

    private int CalcularMCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public CNumeroRacional Sumar(CNumeroRacional otro)
    {
        int nuevoNumerador = Numerador * otro.Denominador + otro.Numerador * Denominador;
        int nuevoDenominador = Denominador * otro.Denominador;
        return new CNumeroRacional(nuevoNumerador, nuevoDenominador);
    }

    public CNumeroRacional Restar(CNumeroRacional otro)
    {
        int nuevoNumerador = Numerador * otro.Denominador - otro.Numerador * Denominador;
        int nuevoDenominador = Denominador * otro.Denominador;
        return new CNumeroRacional(nuevoNumerador, nuevoDenominador);
    }

    public CNumeroRacional Multiplicar(CNumeroRacional otro)
    {
        // Si cualquiera de los dos numeradores es 0, el resultado es 0/1
        if (Numerador == 0 || otro.Numerador == 0)
        {
            return new CNumeroRacional(0, 1);
        }

        int nuevoNumerador = Numerador * otro.Numerador;
        int nuevoDenominador = Denominador * otro.Denominador;
        return new CNumeroRacional(nuevoNumerador, nuevoDenominador);
    }

    public CNumeroRacional Dividir(CNumeroRacional otro)
    {
        if (otro.Numerador == 0)
            throw new DivideByZeroException("No se puede dividir por un número racional con numerador 0.");

        int nuevoNumerador = Numerador * otro.Denominador;
        int nuevoDenominador = Denominador * otro.Numerador;
        return new CNumeroRacional(nuevoNumerador, nuevoDenominador);
    }

    public bool EsEntero()
    {
        // Si el denominador es 1, entonces el número racional es un entero
        return Denominador == 1;
    }

    public override string ToString()
    {
        // Si el denominador es 1, devolver solo el numerador
        if (EsEntero())
        {
            return Numerador.ToString();
        }
        return $"{Numerador}/{Denominador}";
    }

    public static CNumeroRacional LeerNumeroRacionalDesdeTeclado()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Ingrese un número racional en formato 'numerador/denominador':");
                string entrada = Console.ReadLine();

                string[] partes = entrada.Split('/');
                if (partes.Length != 2)
                {
                    throw new FormatException("Formato incorrecto. Debe ingresar el número en formato 'numerador/denominador'.");
                }

                int numerador = int.Parse(partes[0].Trim());
                int denominador = int.Parse(partes[1].Trim());

                return new CNumeroRacional(numerador, denominador);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Por favor, intente nuevamente con el formato 'numerador/denominador'.");
            }
        }
    }
}
