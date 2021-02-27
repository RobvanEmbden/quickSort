using System;



namespace myLibrary
{
    class Program

    {
        static void Main(string[] args)
        {
            // The Quick sort algorithm
            int[] SortList = new int[100];
            byte i = 0;
            Random random = new Random();
            bool addToArray = true;
            while (i < 100)
            {
                int randomNumber = random.Next(1, 101);
                addToArray = true;
                for (int j = 0; j < i; j++)
                {
                    if (SortList[j] == randomNumber)
                    {
                        addToArray = false;
                        break;
                    }
                }
                if (addToArray == true)
                {
                    SortList[i] = randomNumber;
                    i++;
                }
            }
            Console.WriteLine(Environment.NewLine + "Unsorted: " + Environment.NewLine);
            foreach (int k in SortList)
            {
                Console.Write("{0} ", k);
            }
            Console.WriteLine(Environment.NewLine + Environment.NewLine + "Press Enter");
            Console.ReadLine();
            QuickSort(SortList, 0, SortList.Length - 1); 
            Console.WriteLine("Sorted: " + Environment.NewLine);
            foreach (int m in SortList)
            {
                Console.Write("{0} ", m);
            }
            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }

        public static void QuickSort(int[] SortList, int left, int right)// right and left never change
        { //placing a pivot 
            int l = left;
            int r = right;
            int Pivot = SortList[(l + r) / 2]; 

            while (l <= r) // loop until l is equal to r
            {
                while (SortList[l] < Pivot) // move the l up one
                {
                    l++;
                }
                while (Pivot < SortList[r])// move the r down one
                {
                    r--;
                }

                if (l <= r) // swapping numbers
                {
                    int temp = SortList[l];
                    SortList[l] = SortList[r];
                    SortList[r] = temp;
                    l++;
                    r--;
                }
                if (left < r)
                {
                    QuickSort(SortList, left, r);// call quickSort (r changes so does l)
                }
                if (l < right)
                {
                    QuickSort(SortList, l, right);
                }
            }
        }
    }
}