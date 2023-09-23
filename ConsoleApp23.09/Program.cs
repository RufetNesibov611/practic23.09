


//static string UpperStringFirstChar(string str)
//{

//    string name= char.ToUpper(str[0])+ str.Substring(1); 
//    return name;
//}
//Console.WriteLine(UpperStringFirstChar("ali"));




//using System.Text;

//StringBuilder stringBuilder= new StringBuilder("Azer");

//stringBuilder.Append("baycan");

//Console.WriteLine(stringBuilder);




//static string FirstElementToUpper(string str)
//{
//    char[] charArray= str.ToCharArray();

//    string firstChar= charArray[0].ToString().ToUpper();

//    charArray[0] = Convert.ToChar( firstChar );

//    string result= string.Empty;
//    foreach( char item in charArray)
//    {
//        result = result + item;

//    }
//    return result;
//}
//Console.WriteLine(FirstElementToUpper("rufet"));



//int[] ages = { 12, 13, 15 };

//int[] ages2 = new int[5];

//int[] ints = new int[5] { 1, 2, 3, 4, 5 };



//int[] nums = { 2, 4, 5, 6, 8, 3, 7 };

//Console.WriteLine(nums.Length);


//foreach(var item in nums)
//{

//    Console.WriteLine(item);
//}


//var result=nums.Sum(x=>x);

//Console.WriteLine(result);


//var result = nums.Rank;

//Array.Sort(nums);

//var newArr=nums.Clone() as int[];


//using System.ComponentModel.DataAnnotations;
//using System.Linq.Expressions;

//int[] nums = { 2, 4, 5, 6, 8, 3, 7 };


//int[] newArr = { 1, 2, 3 };

//int arrayCount = newArr.Length;

//Array.Resize(ref newArr, nums.Length+ newArr.Length);


//nums.CopyTo(newArr, arrayCount);

//foreach (int item in nums)
//{

//    Console.WriteLine(item);
//}




//int[] numbers = { 1, 2, 3, 4, 6, 1, 9, 10 };


//var result= Array.Exists(numbers, x => x == 1);


//var result = Array.Find(numbers, x => x == 1);


//var result = Array.FindAll(numbers, x => x == 1);


//var result = Array.FindIndex(numbers, x => x == 1);

//int[] arr = new int[2];

//Array.Fill(arr, 2);


//foreach (int item in numbers)
//{
//    Console.WriteLine(item);
//}




using ConsoleApp23._09;

Calculate calculate = new();

int sum = calculate.Sum(10, 20);

Console.WriteLine(sum);