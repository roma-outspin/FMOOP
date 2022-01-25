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
        private MyFileManager _fm;
        private ImageList imgs;

        public Form1()
        {
            InitializeComponent();
            imgs = new ImageList();
            imgs.ImageSize = new Size(32, 32);
            FMListView.LargeImageList = imgs;
            Icon folderIcon = IconExtractor.Extract(@"%SYSTEMROOT%\System32\Shell32.dll",4,true);
            imgs.Images.Add(folderIcon);

            _disksBtn = new List<Button>();
            UpdateDisks();
            _fm = new MyFileManager(_disks.FirstOrDefault());
            UpdateFileIerarchy();

        }




        private void CopyBtn_Click(object sender, EventArgs e)
        {
            IFMEntity entity;
            string selected = FMTree.SelectedNode.Text;
            if (File.Exists(_fm.Path+selected))
            {
                entity = new FMFile(_fm.Path, selected);
            } else
            {
                entity = new FMFolder(_fm.Path, selected);
            }

            _fm.Execute(new FMCopyCommand(entity, _fm.Path, "Копия " + selected));
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
            _fm.Path = ((Button)sender).Text;
            UpdateFileIerarchy();
        }

        private void DeleteDiskButton(Button diskBtn)
        {
            if (Controls.Contains(diskBtn))
            {
                Controls.Remove(diskBtn);
            }  
        }

        private void UpdateFileIerarchy()
        {
            FMTree.Nodes.Clear();
            FMListView.Items.Clear();
            textBoxPath.Text = _fm.Path;
            FMTree.Nodes.Add(_fm.Path);
            foreach (var entity in _fm.FilesAndFolders)
            {
                FMTree.Nodes[0].Nodes.Add(entity.Name);
                if(entity is FMFile)
                {
                    imgs.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(entity.Path));
                    FMListView.Items.Add(entity.Name, imgs.Images.Count - 1);
                } else
                {
                    FMListView.Items.Add(entity.Name, 0);
                }
                
                

            }
        }


        private void UpdateDisksBtn_Click(object sender, EventArgs e)
        {
            UpdateDisks();
        }

        private void searchMask_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                var test = _fm.Search(_fm.Path, searchMask.Text);
                foreach(var item in test)
                {
                    searchResult.Items.Add(new ListViewItem(item));
                }
            }
        }

        private void FMTree_DoubleClick(object sender, EventArgs e)
        {
            var clickedPath = FMTree.Nodes[0].Text + FMTree.SelectedNode.Text+"\\";
            if (Directory.Exists(clickedPath))
            {
                _fm = new MyFileManager(clickedPath);
                UpdateFileIerarchy();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Directory.Exists(textBoxPath.Text))
                {
                    _fm.Path = textBoxPath.Text;
                    UpdateFileIerarchy();
                }else
                {
                    MessageBox.Show("Путь не найден");
                }
                
            }
        }
    }
}
