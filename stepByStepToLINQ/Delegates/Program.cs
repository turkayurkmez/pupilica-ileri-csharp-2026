using Delegates;

Console.WriteLine("Hello, World!");

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



bool isEven(int n) =>
     n % 2 == 0;





//var output = FilterProcess.FilteredNumbers(numbers,isEven);
var output2 = FilterProcess.FilteredNumbers(numbers, delegate (int x) { return x % 2 == 1; });
var output3 = FilterProcess.FilteredNumbers(numbers, n => n % 3 == 0);



//showNumbers(output);
showNumbers(output3);

output3.ToList().ForEach(x=>Console.WriteLine(x));

void showNumbers(int[] array) =>
    Console.WriteLine(string.Join(",", array));

var test1 = numbers.ToList().Where(x => x > 5 );
