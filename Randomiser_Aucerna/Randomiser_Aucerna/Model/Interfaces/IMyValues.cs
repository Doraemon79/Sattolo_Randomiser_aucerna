using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomiser_Aucerna.Model.Interfaces
{
   public interface IMyValues
    {
        int[] CreateStartArray();
        int[] GetMyArrayValue();
        void SetMyArrayValue(int[] input);
    }
}
