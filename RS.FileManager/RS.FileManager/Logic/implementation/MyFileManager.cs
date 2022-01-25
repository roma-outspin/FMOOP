using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RS.FileManager
{
    public class MyFileManager
    {
        public MyFileManager(string path)
        {
            Path = path;

        }

        public IEnumerable<IFMEntity> FilesAndFolders { get {

                var allEntries = Directory.GetFileSystemEntries(Path);
                foreach (var entry in allEntries)
                {
                    if(File.Exists(entry))
                    {
                        yield return new FMFile(entry, entry.Split('\\').Last());
                    } else
                    {
                        yield return new FMFolder(entry, entry.Split('\\').Last());
                    }
                }
            } 
        }
        public string Path { get; set; }

        public bool Execute(IFMCommand cmd)
        {
            return cmd.Execute();
        }

        public IEnumerable<string> Search(string where, string mask)
        {
            var result = new List<string>();

            string[] dirsToOpen = Directory.GetDirectories(where);
            string[] dirs = Directory.GetDirectories(where, mask);
            string[] files = Directory.GetFiles(where, mask);

            result.AddRange(dirs);
            result.AddRange(files);

            foreach (var dir in dirsToOpen)
            {
                result.AddRange(Search(dir, mask));
            }
            

            return result;
        }

    }
}
