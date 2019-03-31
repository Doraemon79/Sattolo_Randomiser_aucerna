using Randomiser_Aucerna.ViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomiser_Aucerna.ViewModel
{
    public class Randomiser : IRandomiser
    {
        private Random rnd = new Random();



        public Randomiser()
        {
        }

        #region Methods
        // Custom Shuffle function 
        // I am using a personal implementation of Sattolo´s algorithm, on the contrary
        //of the most common FIsher-Yates algorithm it uses only a cycle of walking 
        //array plus it is not on stackoverflow, it makes me somehow proud.
        public int[] Shuffle(int[] inputArray)
        {
            // set rnd to new Random value
            rnd = new Random();
            // get size of array
            int arrayLength = inputArray.Length;

            // loop until size of array is greater than 1
            while (arrayLength > 1)
            {
                // get some index inside array
                int k = rnd.Next(arrayLength);
                // decrease array size by 1
                arrayLength--;
                // swap last element of array with chosen random element
                int temp = inputArray[arrayLength];
                inputArray[arrayLength] = inputArray[k];
                inputArray[k] = temp;
            }
            return inputArray;

        }
        #endregion
    }
}
