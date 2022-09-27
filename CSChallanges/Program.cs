
//// First Challange
//// Refference to the class
//Challange1 firstCode = new Challange1();
//// Getting the value
//int sum = firstCode.GetMultiples(100);
////Console.WriteLine(sum);

//// Second Challange
//// Refference to the class
//Challange2 secondCode = new Challange2();
//secondCode.FindTheSum(0,1);
//Console.WriteLine(secondCode.numbers);



// Third Challange
// Refference to the class
// Challange3 primeFactors = new Challange3();
// Console.WriteLine(primeFactors.GetPrimeFactors());

List<int> numbers = new List<int>();
List<int> palindromes = new List<int>();

for (int i = 1; i < 10; i++) {
    for (int j = 0; j < i; j++) {
        int a = j * i;

        numbers.Add(a);
    }
}


Console.WriteLine("Enter a Number : ");

foreach (var item in numbers) {
    if(item == Reverse(item)) {
        palindromes.Add(item);
    }
}

palindromes.ForEach(Console.WriteLine);


int Reverse(int num) {
    int reverse = 0;

    while (num != 0) {
        reverse = reverse * 10;
        reverse = reverse + num % 10;
        num = num / 10;
    }

    return reverse;
}