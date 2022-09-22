using System;

public class Class1
{
	public Class1()
	{

        // Creating list to store all the values
        List<int> multiplies = new List<int>();

        // Initializing the variable that will hold the sum of all the numbers
        int sum = 0;

        // Looping through each value in the list to find their sum
        foreach (var item in multiplies) {
            // Assigning them to the sum variable
            sum = sum + item;
        }

        Console.WriteLine(sum.ToString());

        // Creating the method
        void GetMultiples(int n) {
            for (int i = 0; i < n; i++) {
                if (i % 5 == 0 && i % 3 == 0) {
                    multiplies.Add(i);
                } else if (i % 5 == 0) {
                    multiplies.Add(i);
                } else if (i % 3 == 0) {
                    multiplies.Add(i);
                }
            }
        }
    }
}
