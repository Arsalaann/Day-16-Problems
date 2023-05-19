using System;
using System.IO;
namespace Day16Problems{
    class program{
        public static void Main(string [] args){
            //PermutationOfString.PermutationOfStringIterative("abcd");
            //Console.WriteLine("Permutation of String Recursively");
            //PermutationOfString.PermutationOfStringRecursively("\nabcd","");
            //string textFile="dummy.txt";
            //string[] words=File.ReadAllText(textFile).Split(' ');
            //Console.Write("Enter word to search: ");
            //string inp=Console.ReadLine();
            //if(words.Contains(inp)==true)
            	//Console.WriteLine("It Exists");
            //else 
            	//Console.WriteLine("Not exists");
            Console.Write("Enter number of Words you going to enter: ");
            int n=Convert.ToInt32(Console.ReadLine());
            string[] arr=new string[n];
            for(int i=0;i<n;i++)
            	arr[i]=Console.ReadLine();
            Sort sort=new Sort();
            sort.InsertionSort(arr);
        }
    }
}
