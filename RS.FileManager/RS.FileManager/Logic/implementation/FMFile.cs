using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RS.FileManager
{
    public class FMFile : IFMEntity
    {
        public FMFile(string path,string name)
        {
            Path = path;
            Name = name;
        }

        public string Path { get; }

        public string Name { get; }

        public bool Copy(string destination)
        {
            try
            {
                File.Copy(Path+Name, destination);
                return true;
        }catch
            {
                return false;
            }
            
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Move(string destination)
        {
            throw new NotImplementedException();
        }

        public void Rename(string newName)
        {
            throw new NotImplementedException();
        }
        public override string  ToString()
        {
            return Path + Name;
        }
    }
}
