namespace Day16Problems{
    class program{
        public static void Main(string [] args){
            PermutationOfString.PermutationOfStringIterative("abcd");
            Console.WriteLine("Permutation of String Recursively");
            PermutationOfString.PermutationOfStringRecursively("\nabcd","");
        }
    }
}