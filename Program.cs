using System;
using System.Transactions;
namespace DisplayHello
{
    class Program
    {
        static void Main(string[] args)
        {
          int size;
          int[] array;
            Console.WriteLine("Enter a size: ");
            size = Int32.Parse(Console.ReadLine());
            array = new int[size];
            int i=0;
            while (i<array.Length){
                Console.WriteLine("Enter Element "+ (i+1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine ("List: ");
            for (int j=0; j<array.Length; j++){
                Console.Write(array[j] + ", ");

            }
            int max = array[0];
            int index =1;
            for(int j=0; j<array.Length; j++){
                if(array[j]>max){
                    max= array[j];
                    index= j+1;
                }
            }
            Console.WriteLine("\nThe largest property value in the list is " + max + " ,at position " + index);
      

        }
    }
}

