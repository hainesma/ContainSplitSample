using System;

namespace ContainSplitSample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string sample = "some words here";

            string[] splitSamples = sample.Split('w');

            // Print out the elements of splitSample array
            foreach (string element in splitSamples) {
                Console.WriteLine(element);
            }

            string s1 = "The quick brown fox jumps over the lazy dog";
            string s2 = "fox";

            bool hasInIt = s1.Contains(s2);
            Console.WriteLine(hasInIt);
        

        }

        
    }
}
