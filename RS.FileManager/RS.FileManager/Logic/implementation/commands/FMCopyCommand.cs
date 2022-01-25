using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.FileManager
{
    public class FMCopyCommand : IFMCommand
    {
        public FMCopyCommand(IFMEntity entity, string destination, string newName)
        {
            Entity = entity;
            Destination = destination;
            NewName = newName;
        }

        public IFMEntity Entity { get; set; }
        public string Destination { get; set; }
        public string NewName { get; set; }
        public bool Execute()
        {
            return Entity.Copy(Destination+NewName);
        }
    }
}
