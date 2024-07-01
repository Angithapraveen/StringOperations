using System;
using System.Text.RegularExpressions;

using System.Text;
namespace StringOpera
{
    class StringOpera
    {
        public  static void  Main(string[] args)
        {
            string str1 = "This is sample";
            string str2 = "Programming";
            Console.WriteLine("printing str1 value: "+str1);
            Console.WriteLine("printing str2 val  : "+str2);

            //concat
            string joining=str1 + str2;
            Console.WriteLine("joining example1   : "+joining);
            string joining1=str1 +" "+ str2;
            Console.WriteLine("joining example2   : "+joining1);
            string joining2=string.Concat(str1,str2);
            Console.WriteLine("joining example3   : "+joining2);
            
            //Interpolation
            string interpolationsample = $"this ia interpoation sample {str1}";
            Console.WriteLine("interpolation ex   : "+interpolationsample);
            
            //length
            Console.WriteLine("length of str1     : " + str1.Length);
            Console.WriteLine("TO UPPER\t: "+str1.ToUpper());
            Console.WriteLine("to lower\t: "+str1.ToLower());
            
            //Access 
            Console.WriteLine("get data in index 3: " + str1[3]);
            Console.WriteLine("get data in index 7: " + str1[5]);
            Console.WriteLine("in last index\t: " + str1[str1.Length - 1]);

            //starts&end with
            bool startexample = str1.StartsWith("This"); 
            Console.WriteLine("Start\t: "+startexample);
            bool endexample = str1.EndsWith("e");
            Console.WriteLine("ends\t: "+endexample);
            bool startexample2 = str1.StartsWith("example");
            Console.WriteLine("Starts ex2\t: "+startexample2);
            bool endexample2 = str1.EndsWith("not");
            Console.WriteLine("ends ex2\t: "+endexample2);

            //Index
            Console.WriteLine("Index of s\t: "+ str1.IndexOf("s"));
            
            //fornmat
            string formatexample = String.Format("Hello {0} string operations in C# {1}", str1, str2);
            Console.WriteLine("formate example: "+formatexample);
            
            //split &array
            string splitsample = "apple,orange,grapes";
            string[] fruits=splitsample.Split(',');
            foreach(string fruit in fruits) Console.WriteLine("array example: "+fruit);
           
            //substring
            Console.WriteLine(str1.Substring(0,7));
            
            //trim
            string trimsample = "        sample-trim           ";
            Console.WriteLine("trim start: "+trimsample.TrimStart());
            Console.WriteLine("trim at end: "+trimsample.TrimEnd());
            Console.WriteLine("trim: "+trimsample.Trim());
            
            //Replace
            String replaceexample = "this is a sample for repalace function";
            Console.Write("1st sentance: "+replaceexample);
            replaceexample = replaceexample.Replace("sample", "example");
            Console.WriteLine("\nreplaces sentance: "+replaceexample);
            
            //compare
            string str3 = "Programming";
            Boolean result1 = str1.Equals(str2);
            Console.WriteLine("string str1 and str2 are equal: " + result1);
            Boolean result2 = str2.Equals(str3);
            Console.WriteLine("string str2 and str3 are equal: " + result2);
           
            // using "" 
            string str4 = "This is the \"Sample\"";
            Console.WriteLine(str4);
           
            //array
            string[] students = { "Aaa", "Bbb", "Ccc" };
            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            
            //table
            string columns = "1\t2\t3";
            Console.WriteLine(columns);
            string rows = " 1\n 2\n 3";
            Console.WriteLine(rows);
            
            //Empty&null
            string str5 = "hello";
            string nullString = null;
            string emptyString = String.Empty;
            string emptyString2 = " ";
            string result3 = str5 + nullString;
            Console.WriteLine(result3);

            bool result4 = (emptyString == nullString);
            Console.WriteLine(result4);
            string newStr = emptyString + nullString;
            Console.WriteLine(emptyString.Length);
            Console.WriteLine(newStr.Length);

            bool Null1= String.IsNullOrEmpty(nullString);
            Console.WriteLine(Null1);
            bool empty1 = String.IsNullOrEmpty(emptyString);
            Console.WriteLine(empty1);
            bool WhiteSpace2 = String.IsNullOrWhiteSpace(emptyString2);
            Console.WriteLine(WhiteSpace2);
            
            //if user enter null value 
            //print default value
            Console.WriteLine("enter a string value:");
            //getting input from user 
            string Input1 = Console.ReadLine();
            if (String.IsNullOrEmpty(Input1))
            {
                string defaultValue = "no input was entered";
                Console.WriteLine(defaultValue);
            }
            else
            {
                Console.WriteLine("Entered input: " + Input1);
            }

            //clone
             string str6=(string)str1.Clone();
            Console.WriteLine(str6);

            //insert
            string strinsert = str1.Insert(7, "a");
            Console.WriteLine(strinsert);

            //remove
            string str10 = "Hello world example";
            string strremove= str10.Remove(5,9);
            Console.WriteLine(strremove);

            //padLeft
            Console.WriteLine(str1.PadLeft(7));
            
            //padright
            Console.WriteLine(str1.PadRight(7));
            string leftPadded = "42".PadLeft(5, '0');
            Console.WriteLine(leftPadded);
            string rightPadded = "42".PadRight(5, ' ');
            Console.WriteLine(rightPadded);


            //digits and leetters
            string str7 = "hello123";
            string lettersalone=new string(str7.Where(char.IsLetter).ToArray());
            Console.WriteLine(lettersalone);
            string digitsalone=new string(str7.Where(char.IsDigit).ToArray());
            Console.WriteLine(digitsalone);


            //reverse 
            string reversexample=new string(str6.Reverse().ToArray());
            Console.WriteLine(reversexample);

            //join
            List<string> names = new List<string> { "aaa", "bbb", "cccc" };
            string result5 = string.Join(", ", names);

            //append

            StringBuilder sample = new StringBuilder();
            sample.Append("sample");
            sample.Append("Example!");
            string result6 = sample.ToString();
            Console.WriteLine(result6);

            //append formate
            sample.AppendFormat(" This is {0}.",str2);
            string formattedResult = sample.ToString(); 
            Console.WriteLine(formattedResult);

            //append line
            sample.AppendLine("First line.");
            sample.AppendLine("Second line.");
            string linesResult = sample.ToString();
            Console.WriteLine(linesResult);








            /// Using StringBuilder for large concatenations
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 10000; i++)
                {
                    sb.Append("Hello");
                }
                string result = sb.ToString(); // Efficient concatenation

                // Avoiding excessive string allocations
                string str = "Hello";
                for (int i = 0; i < 10000; i++)
                {
                    str += "World"; // Inefficient, creates new strings every iteration
                }

        
            string str11 = "apple;banana|orange,grape";
            string[] fruits2 = Regex.Split(str11, @"[;|,]"); // ["apple", "banana", "orange", "grape"]




        }
    }
}

