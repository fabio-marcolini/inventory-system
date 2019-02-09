using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public interface IAction<TParameters>
    {
        void Execute(TParameters parameters);
    }
}
