# CNumeroRacional - Manejo de Números Racionales en C#

## Descripción

`CNumeroRacional` es una clase en C# diseñada para representar y manipular números racionales (fracciones) de manera segura y eficiente. Esta clase soporta operaciones básicas como suma, resta, multiplicación y división, y asegura que los resultados se simplifiquen automáticamente. Además, se maneja de manera adecuada la división por cero y otros errores comunes.

## Características

- **Representación de Números Racionales:** Los números racionales se representan con un numerador y un denominador.
- **Operaciones Básicas:** Soporte para suma, resta, multiplicación y división.
- **Simplificación Automática:** Los resultados de las operaciones se simplifican automáticamente.
- **Manejo de Excepciones:** Se maneja adecuadamente la división por cero y el formato incorrecto en la entrada.
- **Conversión a Entero:** Si el resultado de una operación es un número entero (denominador igual a 1), se muestra solo el numerador.

## Explicación Matemática

### 1. **Representación de Números Racionales**

Un número racional se define como un número que puede expresarse como el cociente de dos enteros, donde el denominador no es cero. Matemáticamente, un número racional \( r \) se representa como:

                             r=a/b

donde \( a \) es el numerador y \( b \) es el denominador, con \( b \neq 0 \).

### 2. **Operaciones Básicas**

#### a) **Suma**

Para sumar dos números racionales `a1/b1 y a2/b2`, primero se encuentran un denominador común, que generalmente es el producto de los denominadores, y luego se suman los numeradores:

                               a1/b1 + a2/b2 =(a1*b2)+(a2*b2)/(b1*b2)

Después de realizar la operación, se simplifica la fracción resultante.

#### b) **Resta**

La resta de dos números racionales sigue un proceso similar a la suma, pero restando los numeradores:

                              a1/b1 - a2/b2 =(a1*b2)-(a2*b2)/(b1*b2)

Nuevamente, se simplifica la fracción resultante.

#### c) **Multiplicación**

La multiplicación de dos números racionales es más directa: se multiplican los numeradores entre sí y los denominadores entre sí:

                               a1/b1 * a2/b2 =a1*a2/(b1*b2)

El resultado se simplifica automáticamente.

#### d) **División**

Para dividir dos números racionales, se multiplica el primer número racional por el inverso del segundo:

                      (a1/b1) / ( a2/b2) =(a1/a2)/(b1/b2)

La fracción resultante se simplifica como en los otros casos.

### 3. **Simplificación Automática**

La simplificación de una fracción consiste en dividir el numerador y el denominador por su máximo común divisor (MCD). Matemáticamente, si \( \text{MCD}(a, b) \) es el máximo común divisor de \( a \) y \( b \), entonces:

                       (a/b)=(a/MCD(a,b))/(b/MCD(a,b))

Esto garantiza que la fracción esté en su forma más simple.

### 4. **Manejo de Excepciones**

- **División por Cero:** Se genera una excepción si se intenta realizar una operación que cause que el denominador sea cero, lo cual no está definido en matemáticas.
- **Formato Incorrecto:** Si los datos de entrada no cumplen con la forma de un número racional válido, se maneja el error de forma que el programa no falle inesperadamente.

### 5. **Conversión a Entero**

Si al simplificar una fracción el denominador resulta ser 1, el número racional es en realidad un número entero. En este caso, solo se muestra el numerador. Matemáticamente:

                           a/1=a

Esto es manejado internamente por la clase para ofrecer una representación más limpia y natural de los resultados.
