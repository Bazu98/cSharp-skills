using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace My_first_project

{
    class Program
    {
        static void Main(string[] args)
        {



            FileCreator(args);
            Fibonacci(7);
            int[] arr = { 55, 33, 10, 15 };
            isStrict(arr);
            SortList(arr);
            Console.WriteLine(ConvertBinary(3));
            int[] arr1 = { 1, 2, 3, 4, 2, 3 };
            int[] arr3 = { 88, 129, 33, 45, 1, 2, 33, 88, 2 };
            Dictionary<int,int> dict = Counter(arr1);
            foreach(int key in dict.Keys)
            {
                Console.WriteLine("" + key + " - " + dict[key]);
            }


            Console.WriteLine(string.Join(" ", NoDuplicates(arr3)));

        }






        public static void FileCreator (string [] args)
        {

            TextReader tr = File.OpenText(args[0]);
            string fileData = tr.ReadToEnd();
            Console.WriteLine("Succesfully read  file " + args[0]);
            Console.WriteLine("file is located  .\\tmp_dir\\"+args[0]);
            tr.Close();

            if (!Directory.Exists("tmp_dir"))
            {
                Directory.CreateDirectory("tmp_dir");
            }
            File.Move(args[0], "tmp_dir\\" + args[0]);

            StreamWriter sw = File.CreateText(args[1]);
            sw.WriteLine(fileData);
            sw.Close();

        }


        public static bool isStrict(int[] arr, bool asc = true)
        {
            bool res = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((asc && (arr[i] >= arr[i + 1])) || (!asc && (arr[i] <= arr[i + 1])))
                {
                    res = false;
                    break;
                }
            }
            Console.WriteLine("The sequence " + (res ? "is" : "is not") + " " + (asc ? "ascending" : "descending"));
            return res;
        }

    

        public static void SortList(int [] array)
        {
            IEnumerable<int> it = from number in array orderby number select number;
            foreach(int x in it)
            {
            Console.WriteLine(x);
            }
             
        }

        public static string ConvertBinary(int N)
        {
            return Convert.ToString(N, 2);
        }


        public static Dictionary<int,int> Counter(int[] array)
        {

            Dictionary<int,int> count = new Dictionary<int, int>();
            foreach(int x in array)
            {
                if (count.Keys.Contains(x))
                {
                    count[x]++;
                }
                else
                {
                    count[x] = 1;
                }
            }
            return count;
            
        }


        public static List<int> NoDuplicates(int [] arr)
        {
            List<int> array2 = new List<int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if (!array2.Contains(arr[i]))
                {
                    array2.Add(arr[i]);
                }
            }
            return array2;

        }

        public static int Fibonacci(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }

        }

    }


}


    


    




   









