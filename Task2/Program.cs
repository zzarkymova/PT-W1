using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] a)
        {
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            int[] numb=int.Parse(numbers[]);
            int counter=0;
            for (int i=0; i<numb.Length; ++i){
                for (int j=2; j<numb[j]-1; ++j){
                    if (numb[]%j==0){
                        counter=counter+1;
                    }
                }
            }
            if (counter==0){
                Console.WriteLine("+++++");
            }
            else {
                Console.WriteLine("-----");
            
            }

        }
    }
}
