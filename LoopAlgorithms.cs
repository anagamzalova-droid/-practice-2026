csharp
public static class LoopAlgorithms
{
    // Итеративный метод
    public static long Factorial(int n)
    {
        if (n < 0) throw new ArgumentException("n >= 0");
        long result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }
    
    // Сумма ряда: 1 + 1/2 + 1/3 + ... + 1/n
    public static double HarmonicSum(int n)
    {
        double sum = 0;
        int i = 1;
        while (i <= n)
        {
            sum += 1.0 / i;
            i++;
        }
        return sum;
    }
    
    // Поиск простых чисел (решето Эратосфена)
    public static List<int> SieveOfEratosthenes(int limit)
    {
        bool[] isPrime = new bool[limit + 1];
        for (int i = 2; i <= limit; i++)
            isPrime[i] = true;
            
        for (int p = 2; p * p <= limit; p++)
        {
            if (isPrime[p])
            {
                for (int multiple = p * p; multiple <= limit; multiple += p)
                    isPrime[multiple] = false;
            }
        }
        
        List<int> primes = new List<int>();
        for (int i = 2; i <= limit; i++)
            if (isPrime[i]) primes.Add(i);
            
        return primes;
    }
}
