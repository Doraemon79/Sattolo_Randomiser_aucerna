using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomiser_Aucerna.ViewModel.Interfaces
{
   public  interface IRandomiser
    {
        int[] Shuffle(int[] inputArray);

        //int[] Resetter(int[] inputArray)
    }
}
