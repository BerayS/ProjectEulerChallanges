using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Challange2 {
    // Second Challange:
    // Find the sum of all the even-valued terms in the Fibonacci sequence
    // which do not exceed four million.

    // Declaring the variables
    int n3;
    int i;
    int sumOfEven = 0; // Sum of all the even elements in fibonacci till 4m

    // Declaring lists which will contain the fibonacci sequence and all the even ones till no greater than 4m
    public List<int> numbers = new List<int>();
    List<int> evenNumbers = new List<int>();

    public int FindTheSum(int n1, int n2) {
        for (i = 0; i < 34; ++i) // Starts from 2 because 0 and 1 are declared as parameters when calling the function  
        {
            n3 = n1 + n2;
            Console.Write(n3 + " ");
            n1 = n2;
            n2 = n3;
            numbers.Add(n3);

        }
        
        // Finds all the even numbers in the sequence
        foreach (var item in numbers) {
            if (item % 2 == 0) {
                evenNumbers.Add(item);
            }
        }

        // Gets the sum of the even numbers and adds it to the global variable
        for (int j = 0; j < evenNumbers.Count; j++) {
            sumOfEven = sumOfEven + evenNumbers[j];
        }
        return sumOfEven;
    }
}

// TODO: 
// Make the fibonacci sequence go till the last one isn't greater than 4m (using while loop?) and not set manually
