using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RS.FileManager
{
    public class FMCreateCommand : IFMCommand
    {
        public FMCreateCommand(string name, string path, bool isFile )
        {
            Name = name;
            Path = path;
            _isFile = isFile;
        }

        public string Name { get; set; }
        public string Path { get; set; }
        private bool _isFile;

        public bool Execute()
        {

            if(_isFile)
            {
                if (File.Exists(Path + Name))
                {
                    return false;
                }
                File.Create(Path + Name);
                return true;
            } 
            else
            {
                if (Directory.Exists(Path + Name))
                {
                    return false;
                }
                Directory.CreateDirectory(Path + Name);
                return true;
            }
        }
    }
}
