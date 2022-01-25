using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.FileManager
{
    public interface IFMEntity
    {
        public string Path { get; }
        public string Name { get; }
        public bool Copy(string destination);
        public void Delete();
        public void Move(string destination);
        public void Rename(string newName);
        public string ToString();
    }
}
