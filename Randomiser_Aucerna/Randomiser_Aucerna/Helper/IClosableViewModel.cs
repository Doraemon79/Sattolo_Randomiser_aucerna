using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomiser_Aucerna.Helper
{
    interface IClosableViewModel
    {
        event EventHandler CloseWindowEvent;
    }
}