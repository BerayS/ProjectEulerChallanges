using DocumentFormat.OpenXml.Presentation;
using System.Data.SqlClient;
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
//Challange3 primeFactors = new Challange3();
//Console.WriteLine(primeFactors.GetPrimeFactors());

		int num;
		Console.WriteLine("Enter a number :");
		num = int.Parse(Console.ReadLine());

		if (isPalindrome(num)) {
			Console.WriteLine("Entered number is a palindrome number");
		} else {
			Console.WriteLine("Entered number is not a palindrome number");
		}

static bool isPalindrome(int num) {
		int tempValue = num;
		int reverse = 0;
		while (tempValue > 0) {
			reverse = reverse * 10 + tempValue % 10;
			tempValue = tempValue / 10;
		}

		return reverse == num;
	}