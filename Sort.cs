namespace Day16Problems{
	class Sort{
		public void InsertionSort(string []arr){
			int n=arr.Length;
			for(int i=1;i<n;i++){
				string temp=arr[i];
				int j;
				for(j=i-1;j>=0 && temp.CompareTo(arr[j])==-1;j--)
					arr[j+1]=arr[j];
				arr[j+1]=temp;
			}
			foreach(var word in arr)
				Console.WriteLine(word);
		}
		public void BubbleSort(string []arr){
			int n=arr.Length;
			for(int i=0;i<n-1;i++){
				for(int j=0;j<n-i-1;j++)
					if(arr[j].CompareTo(arr[j+1])==1){
						string temp=arr[j];
						arr[j]=arr[j+1];
						arr[j+1]=temp;
					}
			}
			foreach(var word in arr)
				Console.WriteLine(word);
		}
	}
}
