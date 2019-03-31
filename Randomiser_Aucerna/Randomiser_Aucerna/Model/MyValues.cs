using Randomiser_Aucerna.Model.Interfaces;
using Randomiser_Aucerna.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomiser_Aucerna.Model
{
  public class MyValues : IMyValues
    {
        int[] MyArray = new int[1000];

        #region Methods
        public int[] GetMyArrayValue()
        { return MyArray; }
        public void SetMyArrayValue(int[] input)
        { MyArray = input; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int[] CreateStartArray()
        {
            for (int i = 0; i <= 999; i++)
                MyArray[i] = i + 1;
            ArrayKeeper.StartArray = MyArray;
            return MyArray;
        }

        #endregion
    }
}
