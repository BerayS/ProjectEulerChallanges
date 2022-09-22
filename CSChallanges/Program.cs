
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

int param = 13195;
int primeFactor = 0;
int temporaryNum = 0;

for (int i = 2; i < 13195; i++) {
    if (param % i == 0) {
        temporaryNum = param / i;
        primeFactor = i;
        
        break;
    }

}

Console.WriteLine(temporaryNum);
Console.WriteLine(primeFactor); 
