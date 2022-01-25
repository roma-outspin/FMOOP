using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.FileManager
{
    public interface IFMCommand
    {
        public bool Execute();
    }
}
