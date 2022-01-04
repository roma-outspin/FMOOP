using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS.FileManager
{
    public partial class Form1 : Form
    {
        private List<string> _disks;
        private List<Button> _disksBtn;

        public Form1()
        {
            InitializeComponent();
            _disksBtn = new List<Button>();
            UpdateDisks();
            //UpdateFileIerarchy(_disks.FirstOrDefault());
        }


        private void CopyBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateDisks()
        {
            if(_disksBtn.Count>0)
            {
                for(int i = 0; i < _disksBtn.Count;i++)
                {
                    DeleteDiskButton(_disksBtn[i]);
                }
            }

            _disksBtn.Clear();

            _disks = GetDisks().ToList();

            for (int i = 0; i < _disks.Count; i++)
            {
                AddDiskButton(_disks[i], i);
            }

        }

        private IEnumerable<string> GetDisks()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach(var drive in allDrives)
            {
                yield return drive.Name;
            }
        }

        private void AddDiskButton(string name, int number)
        {
            int btnWidth = 80;
            var result = new Button();
            result.Name = "myDISKBTN" + number;
            result.Text = name;
            result.Click += Result_Click;

            Point position = new Point();
            position.X = 12 + number * btnWidth;
            position.Y = 10;
            result.Location=position;

            _disksBtn.Add(result);
            Controls.Add(result);
        }

        private void Result_Click(object sender, EventArgs e)
        {
            UpdateFileIerarchy(((Button)sender).Text);
        }

        private void DeleteDiskButton(Button diskBtn)
        {
            if (Controls.Contains(diskBtn))
            {
                Controls.Remove(diskBtn);
            }  
        }

        private void UpdateFileIerarchy(string rootPath)
        {
            FMTree.Nodes.Clear();
            var entries = Directory.GetFileSystemEntries(rootPath);


            FMTree.Nodes.Add(rootPath);

            foreach (var entry in entries)
            {
                FMTree.Nodes[0].Nodes.Add(entry.Substring(rootPath.Length-1));
            }
           
        }

        private void UpdateDisksBtn_Click(object sender, EventArgs e)
        {
            UpdateDisks();
        }
    }
}
