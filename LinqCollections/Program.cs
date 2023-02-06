// Jeff Santucci    
//02/05/2023

/* LINQ  
Objective: LINQ and Collections

Task: Use Linq to search the following collection.

Build Specifications:
Create the following array
int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

Write code using Linq to answer the following questions: 

Find the Minimum value 
Find the Maximum value
Find the Maximum value less than 10000
Find all the values between 10 and 100
Find all the Values between 100000 and 999999 inclusive 
Count all the even numbers 
*/
using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;

int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };
int number = nums[0];
List<int> numlist = new List<int>();
List<int> inclusivelist = new List<int>();
string numbersfun = "";
int i;

// 1. Find the Minimum value
foreach (int num in nums)
{
    if (num < number)
    {  
        number = num;
    }
}
Console.WriteLine("The minimum value in the Array is: " + number);

// 2. Find the Maximum value
foreach (int num in nums)
{
    // 1. Find the Minimum value
    if (num > number)
    {
        number = num;
    }
}
Console.WriteLine("The maximum value in the Array is: " + number);

// 3. Find the Maximum value - 10000
foreach (int num in nums)
{
    // 1. Find the Minimum value
    if (num > number)
    {
        number = num;
    }
}
number = number - 10000;
Console.WriteLine("The maximum value in the Array - 10000 is: " + number);

// 4. Find all the values between 10 and 100
foreach (int num in nums)
{
    if (num > 10 && num < 100)
    {
        numlist.Add(num);
    }
}
i = 1;
foreach (int num in numlist)
{
    if (i == 1)
    {
        numbersfun = num.ToString();
        i++;
    }
    else
    {
        numbersfun = numbersfun + ", " + num.ToString();
    }
}
Console.WriteLine("All the values between 10 and 100 are: " + numbersfun);

// 5. Find all the Values between 100000 and 999999 inclusive 
foreach (int num in nums)
{
    if (num >= 100000 && num <= 999999)
    {
        inclusivelist.Add(num);
    }
}
i = 1;
numbersfun = "";
foreach (int num in inclusivelist)
{
    
    if (i == 1)
    {
        numbersfun = num.ToString();
        i++;
    }
    else
    {
        numbersfun = numbersfun +  ", " + num.ToString();
    }
}
Console.WriteLine("All the values between 100000 and 999999 are: " + numbersfun);

// Count all the even numbers
i = 0;
foreach (int num in nums)
{
    if (num % 2 == 0)
    {
        i++;
    }
}
Console.WriteLine("There are " + i + " even numbers in the list of numbers!");