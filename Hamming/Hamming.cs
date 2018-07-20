using System;

namespace Hamming
{
    public class Hamming
    {
        public static int Distance(string original, string current)
        {
            int hammingDistance = 0;


            if (original == null)
            {
                throw new ArgumentNullException("original");
            }
            else if (current == null)
            {
                throw new ArgumentNullException("current");
            }
            else if (original == "" || current == "")
            {
                Console.WriteLine(hammingDistance);
                Console.ReadLine();
            }
            else if (original.Length != current.Length)
            {
                throw new ArgumentException("Hamming Distance can only be calculated over strings of equal length");
            }
            else
            {
                char [] OriginalArray = original.ToCharArray();
                char [] CurrentArray = current.ToCharArray();

                for(int i = 0; i < OriginalArray.Length; i++) {

                    if (OriginalArray[i] == CurrentArray[i])
                    {
                        hammingDistance += 0;
                    }
                    else
                    {
                        hammingDistance += 1;
                    }
                }
            }  
            return hammingDistance;
        }
    }
}
