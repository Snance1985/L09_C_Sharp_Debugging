//DEBUGGING
// Console.WriteLine("";

// int num = "string";

// if ()
// {
//     Console.WriteLine("This is a Test");
// }


//_______________________________________________________
//RUNTIME ERROR: INDEX OUT OF BOUNDS
// int[] arr = { 1,2,3,4,5,6 };
//TRY CATCH FIX
// try
// {
//     Console.WriteLine(arr[9]);
// }
// catch (IndexOutOfRangeException) {
//     Console.WriteLine("Index is out of bounds");
// }   

//IF STATEMENT FIX
// if (arr.Length > 9) {
//     Console.WriteLine(arr[9]);
// }


//_______________________________________________________
//RUNTIME ERROR: DIVIDING BY ZERO
// int num = 20;
// int num2 = 0;

// int num3 = num / num2;

//TRY CATCH FIX
// try
// {
//     int num3 = num / num2;
// } catch (DivideByZeroException){
//     Console.WriteLine("Do not divide by zero");
// }

//IF STATEMENT FIX
// int num = 20;
// int num2 = 0;

// if (num2 != 0) {
//     int num3 = num / num2;
// }


//_______________________________________________________
//RUNTIME ERROR: NULL REFERENCE EXCEPTION
// String test;
// test.Contains("xyz");


//_______________________________________________________
//BREAKPOINTS
int num = 20;
int num2 = 120;

int num3 = num * num2;

string str = "Hello";
string str2 = "World";

string str3 = str + " " + str2;

Console.WriteLine(str3);
