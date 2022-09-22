class Challange1 {
    // Project Euler Challanges \\
    // C# Challange 1 - Find the sum of Multiplies of 3 or 5 below 100

    // Creating list to store all the values
    List<int> multiplies = new List<int>();

    // Creating the method
    public int GetMultiples(int n) {
    for (int i = 0; i < n; i++) {
        if (i % 5 == 0 && i % 3 == 0) {
            multiplies.Add(i);
        } else if (i % 5 == 0) {
            multiplies.Add(i);
        } else if (i % 3 == 0) {
            multiplies.Add(i);
        }
    }

    // Initializing the variable that will hold the sum of 
    int sum = 0;

    // Looping through each value in the list to find their sum
    foreach (var item in multiplies) {
         sum = sum + item;
    }
    return sum;
    }
}
