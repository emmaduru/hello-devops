namespace FactorialLibrary;

public class FactorialService
{
    public static int Factorial(int n) {
        if (n < 0) {
            throw new InvalidOperationException("Negative numnbers don't have a factorial.");
        }

        if (n == 0 || n == 1) {
            return 1;
        }

        return n * Factorial(n - 1);
    }
}
