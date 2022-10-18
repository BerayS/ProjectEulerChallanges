class Challange4 {

void Run() {
    // Creating the variables
    List<int> results = new List<int>();
    List<int> palindromes = new List<int>();
    int result = 0;
    string reverse = "";
    int n;

// Collecting the results from multiplications 900 - 999
for (int i = 900; i <= 1000; i++) {
    for (int j = 900; j <= 1000; j++) {
        result = i* j;
    // Adding all the results to the reults list
    results.Add(result);
    }
}

// Checking for palindrome numbers inside the results list
for (int i = 0; i < results.Count; i++) {
    n = results[i];
    // Reversing the num to check if it's palindrome
    reverse = Reverse(n);

    // Checking if it's palindrome (in string format to not mislead 0's)
    if (n.ToString() == reverse) {
        palindromes.Add(n);
    }
}

}

// Custom method to convert integers to reversed string
static string Reverse(int s) {
    char[] charArray = s.ToString().ToCharArray();
    Array.Reverse(charArray);
    string res = string.Join("", charArray);
    return res;
}

}
