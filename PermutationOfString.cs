namespace Day16Problems{
    public class PermutationOfString{
        public static int fact(int n){
            int ans=n;
            for(int i=n-1;i>=1;i--)
                ans*=i;
            return ans;
        }
        public static void PermutationOfStringIterative(string s){
            Console.WriteLine("Permutation of String Iteratively");
            int n=s.Length;
            int upto=fact(n);
            for(int i=0; i<upto; i++){
                string s1=s;
                int temp=i;
                for(int j=n;j>0;j--){
                    int q=temp/j;
                    int m=temp%j;
                    Console.Write(s1[m]);
                    s1=s1.Remove(m,1);
                    temp=q;
                }
                Console.WriteLine();
            }
        }

        public static void PermutationOfStringRecursively(string s,string tmp){
            if(s.Length==1){
                Console.WriteLine(tmp+s[0]);
                return;
            }
            for(int i=0;i<s.Length;i++){
                string tmp1=tmp+s[i];
                PermutationOfStringRecursively(s.Substring(0,i)+s.Substring(i+1),tmp1);
            }
        }
    }
}