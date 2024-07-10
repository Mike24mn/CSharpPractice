// See https://aka.ms/new-console-template for more information

using System;

Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);

/* ONE:

public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    { 
     int x = flower1 + flower2;
      bool inlove;
        if (x % 2 == 1) {
          inlove = true;
          }
          else
            {
            inlove = false;
            }
      return inlove;
      }
}
*/

/* TWO:

public class Kata
{
  public static bool Check(object[] a, object x)
  {
    foreach (var val in a) {
      if (val.Equals(x))
        {
        return true;
      }
    }
    return false;
  }
}

*/

/* THREE:

using System;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    int start = 0;
    foreach (int num in arr) {
      if (num > 0)
        {
     start += num;
        
      }
    }
    // Your code here
    return start;
  }
}

*/

string myString = "Hello, world!";

int theBestInt = 24;

double myDub = 6.66;

decimal myDec = 424.19m;

bool theBestBool = true;

int number = 22;

if (number > 10)
{
    Console.WriteLine("number over 10");
}

else if (number < 10)
{
    Console.WriteLine("number less than 10");
}
else
{
    Console.WriteLine("number is 10");
}

int switchySwitch = 1;

switch (switchySwitch)
{
    case 1:
        Console.WriteLine("this is switch option one");
        break;
    case 2:
        Console.WriteLine("this is switch option two");
        break;
    default:
        Console.WriteLine("no bueno, switch defualt");
        break;
}

string[] familyNames = { "Chris", "Katie", "Michael" };

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Index: " + i);
}

foreach (string name in familyNames)
{
    Console.WriteLine(name);
}

using System.Collections.Generic;

List<string> namesList = new List<string>() { "Chris", "Katie", "Michael" };

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

Person person1 = new Person();
person1.Name = "Joe Schmoe";
person1.Age = 300;

class Calculate
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

Calculate calc = new Calculate();
int result = calc.Add(5, 3);
// call from instance of class below
Console.WriteLine(result);

object[] objects = { "Hello peoples", 12345, true };

foreach (object obj in objects)
{
    Console.WriteLine(obj);
}