namespace Day16Problems{
	public class Anagram{
		public bool IsAnagram(string a,string b){
			Dictionary<char,int> arr1=new Dictionary<char,int>(),arr2=new Dictionary<char,int>();
			foreach(char i in a){
				if(arr1.ContainsKey(i))
					arr1[i]++;
				else
					arr1[i]=1;
			}foreach(char i in b){
				if(arr2.ContainsKey(i))
					arr2[i]++;
				else
					arr2[i]=1;
			}
			foreach(var kvp in arr1){
				if(kvp.Value!=arr2[kvp.Key])
					return false;
			}
			return true;
		}
	}
}
