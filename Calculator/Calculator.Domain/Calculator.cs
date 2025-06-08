namespace Calculator.Domain
{
    /// <summary>
    /// Proporciona métodos para realizar operaciones aritméticas básicas.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Suma dos números enteros.
        /// </summary>
        /// <param name="x">El primer número entero.</param>
        /// <param name="y">El segundo número entero.</param>
        /// <returns>La suma de <paramref name="x"/> y <paramref name="y"/>.</returns>
        public int Add(int x, int y) => x + y;

        /// <summary>
        /// Resta un número entero de otro.
        /// </summary>
        /// <param name="x">El número entero del cual se resta.</param>
        /// <param name="y">El número entero que se resta.</param>
        /// <returns>La diferencia entre <paramref name="x"/> y <paramref name="y"/>.</returns>
        public int Subtract(int x, int y) => x - y;

        /// <summary>
        /// Multiplica dos números enteros.
        /// </summary>
        /// <param name="x">El primer número entero.</param>
        /// <param name="y">El segundo número entero.</param>
        /// <returns>El producto de <paramref name="x"/> y <paramref name="y"/>.</returns>
        public int Multiply(int x, int y) => x * y;

        /// <summary>
        /// Divide un número entero entre otro.
        /// </summary>
        /// <param name="x">El dividendo.</param>
        /// <param name="y">El divisor. Debe ser distinto de cero.</param>
        /// <returns>El cociente de <paramref name="x"/> dividido por <paramref name="y"/>.</returns>
        /// <exception cref="DivideByZeroException">Se lanza si <paramref name="y"/> es cero.</exception>
        public int Divide(int x, int y) => x / y;
    }
}
