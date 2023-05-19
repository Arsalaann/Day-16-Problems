using System;
using System.IO;
namespace Day16Problems{
    class program{
        public static void Main(string [] args){
            //PermutationOfString.PermutationOfStringIterative("abcd");
            //Console.WriteLine("Permutation of String Recursively");
            //PermutationOfString.PermutationOfStringRecursively("\nabcd","");
            string textFile="dummy.txt";
            string[] words=File.ReadAllText(textFile).Split(' ');
            Console.Write("Enter word to search: ");
            string inp=Console.ReadLine();
            if(words.Contains(inp)==true)
            	Console.WriteLine("It Exists");
            else 
            	Console.WriteLine("Not exists");
        }
    }
}
