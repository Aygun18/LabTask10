namespace C_IntroLab
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region
			//Task 1
			//Console.WriteLine("Ededi daxil edin: ");
			//check:
			//         bool num = int.TryParse(Console.ReadLine(), out int n);
			//if (!num)
			//{
			//             Console.WriteLine("Duzgun daxil edin:");
			//	goto check;
			//         }
			//int sum = 0;
			//for (int i = 1; i <= 10; i++)
			//{
			//	sum= n * i;
			//	Console.WriteLine(sum);
			//}
			#endregion

			#region Task2 0  1  2  3  4  5  6  
			int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

			int[] arr1 = new int[(arr.Length+2)/3];
			int[] arr2 = new int[(arr.Length+2)/3];
			int[] arr3 = new int[(arr.Length+2)/3];

			int count1 = 0;
			int count2 = 0;
			int count3 = 0;

			for (int i = 0; i < arr.Length; i ++)
			{
				if (i % 3 == 0)
				{
					arr1[count1] = arr[i];
					count1++;
				}
				else if (i % 3 == 1)
				{
					arr2[count2] = arr[i];
					count2++;
				}
				else if(i % 3 == 2)
				{
					arr3[count3] = arr[i];
					count3++;
				}
			}
			Console.WriteLine("1ci array");
			foreach (var array in arr1)
			{
				Console.WriteLine(array);
			}

			Console.WriteLine("2ci array");
			foreach (var array in arr2)
			{
				Console.WriteLine(array);
			}

			Console.WriteLine("3cu array");
			foreach (var array in arr3)
			{
				Console.WriteLine(array);
			}


			#endregion
			#region

			//string[] names = { "Vahid","Nicat","Gülər","Gözəl","Ulduz","Famil","Dadaş","Vaqif","Ümid","Durna" };

			//string[] names1 =new string[names.Length];



			//for(int i=0; i<names.Length; i++)
			//{
			//	foreach (char name1 in names[i])
			//	{
			//		if (name1 == 'u')
			//		{
			//			Console.WriteLine(names[i]);
			//			names1[i] = names[i];
			//			string Newname=names1[i].Replace('u', 'e');
			//			Console.WriteLine(Newname);
			//                 }
			//	}
			//}
			#endregion

		}
	}
}