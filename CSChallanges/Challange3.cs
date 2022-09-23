using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Challange3 {

    public string GetPrimeFactors() {
        Console.WriteLine("Please enter a number: ");
        long input = long.Parse(Console.ReadLine());

        long param = input;
        List<long> primeFactors = new List<long>();
        long temporaryNum = 0;

        for (long i = 2; i < input; i++) {
            if (param % i == 0) {
                param = param / i;
                primeFactors.Add(i);
            }
            if (param / i == 1) {
                temporaryNum = param;
                primeFactors.Add(temporaryNum);
                break;
            }
        }

        string primeFactorsString = $"Prime Factors: {String.Join(", ", primeFactors)}";
        return primeFactorsString;

    }
}