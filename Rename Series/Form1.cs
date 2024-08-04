using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rename_Series
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = dialog.SelectedPath;
                }
            }
        }

        private bool Updating = false;

        public class FileItem
        {
            public int FileID { get; set; }

            public string Extension { get; set; }
            public string OriginalExt { get; set; }
            public string OriginalName { get; set; }
            public string RenamedName { get; set; }

            public bool Enabled { get; set; }
        }

        public class ExtensionCheckChanged : EventArgs
        {
            public int ExtId { get; set; }
            public String Ext { get; set; }
            public bool Checked { get; set; }
        }

        public class Extension
        {
            public Extension(int id, string ext, bool chked)
            {
                ExtId = id;
                Ext = ext;
                Checked = chked;
            }
            public int ExtId { get; set; }
            public string Ext { get; set; }

            public bool Checked { get; set; }

            public override string ToString()
            {
                return Ext;
            }
        }
        
        private List<Extension> Extensions = new List<Extension>();
        public List<FileItem> Files = new List<FileItem>();

        private void Clear()
        {
            Updating = true;
            Extensions.Clear();
            Files.Clear();
            lstCurrent.Items.Clear();
            lstPreview.Items.Clear();
            ((ListBox)lstTypes).DataSource = null;
            lstTypes.Items.Clear();
            Updating = false;
        }

        private void LoadFiles()
        {
            HashSet<string> seenExts = new HashSet<string>();
            List<string> dirFiles = System.IO.Directory.GetFiles(txtPath.Text).ToList();
            dirFiles.Sort();
            string[] files = dirFiles.ToArray();
            int extId = 0;
            int fileId = 0;
            foreach (string file in files)
            {
                string OriginalExt = System.IO.Path.GetExtension(file);
                string name = System.IO.Path.GetFileNameWithoutExtension(file);
                string ext = OriginalExt.ToLower();
                if (!seenExts.Contains(ext))
                {
                    seenExts.Add(ext);
                    Extension newExt = new Extension(extId, ext, false);
                    Extensions.Add(newExt);
                    extId++;
                }
                Files.Add(new FileItem()
                {
                    FileID = fileId,
                    Extension = ext,
                    OriginalExt = OriginalExt,
                    OriginalName = name,
                    RenamedName = name
                });
                fileId++;
            }
        }

        private void UpdateSourceFileList(HashSet<string> allowedExtensions)
        {
            lstCurrent.Items.Clear();
            lstPreview.Items.Clear();
            foreach (var file in Files)
            {
                if (allowedExtensions.Contains(file.Extension))
                {
                    file.Enabled = true;
                    lstCurrent.Items.Add(file.OriginalName);
                    lstPreview.Items.Add(file.RenamedName);
                }
                else
                {
                    file.Enabled = false;
                }
            }
        }

        private void PopulateExts()
        {
            ((ListBox)lstTypes).DataSource = Extensions;
            ((ListBox)lstTypes).DisplayMember = "Ext";
            ((ListBox)lstTypes).ValueMember = "Checked";
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            if (Updating)
            {
                return;
            }
            if (string.IsNullOrEmpty(txtPath.Text) || !System.IO.Directory.Exists(txtPath.Text))
            {
                Clear();
            }
            Clear();
            if (System.IO.Directory.Exists(txtPath.Text))
            {
                Updating = true;
                LoadFiles();
                PopulateExts();
                Updating = false;
            }
        }

        private void lstTypes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Extensions[e.Index].Checked = !Extensions[e.Index].Checked;
            HashSet<string> allowedExts = new HashSet<string>();
            for (int i = 0; i < Extensions.Count; i++)
            {
                if (Extensions[i].Checked)
                {
                    allowedExts.Add(Extensions[i].Ext);
                }
            }
            UpdateSourceFileList(allowedExts);
        }

        private void cmdPreview_Click(object sender, EventArgs e)
        {
            lstPreview.Items.Clear();
            foreach (var file in Files)
            {
                if (file.Enabled)
                {
                    String name = file.OriginalName;
                    if (chkCleanSE.Checked)
                    {
                        name = CleanSeasonEpisode(name);
                    }
                    if (txtMatch1.Text.Length > 0)
                    {
                        name = name.Replace(txtMatch1.Text, txtReplace1.Text);
                    }
                    if (txtMatch2.Text.Length > 0)
                    {
                        name = name.Replace(txtMatch2.Text, txtReplace2.Text);
                    }
                    if (txtMatch3.Text.Length > 0)
                    {
                        name = name.Replace(txtMatch3.Text, txtReplace3.Text);
                    }
                    file.RenamedName = name;
                    lstPreview.Items.Add(file.RenamedName);
                }
            }
        }

        private string CleanSeasonEpisode(string str)
        {
            // look for a leading _
            int Lead_;
            int Tail_;
            int pos = 0;
            string newStr;
            while (pos  < str.Length - 4)
            {
                Lead_ = -1;
                Tail_ = -1;
                newStr = "";
                //look for this to start with an _
                if (str[pos] == '_')
                {
                    Lead_ = pos;
                    newStr = " - ";
                    pos++;
                    // Is it a S season mark? 
                    if (str[pos] == 'S' || str[pos] == 's')
                    {
                        newStr += "S";
                        pos++;
                        // maybe a false start. Look for a number to know we are on the right track.
                        if (str[pos] >= '0' && str[pos] <= '9')
                        {
                            newStr += str[pos];
                            pos++;
                            // allow 1, 2, 3, or 4 digit numbers
                            if (str[pos] >= '0' && str[pos] <= '9')
                            {
                                newStr += str[pos];
                                pos++;
                            }
                            if (str[pos] >= '0' && str[pos] <= '9')
                            {
                                newStr += str[pos];
                                pos++;
                            }
                            if (str[pos] >= '0' && str[pos] <= '9')
                            {
                                newStr += str[pos];
                                pos++;
                            }
                            // now look for the E episode marker
                            if (str[pos] == 'E' || str[pos] == 'e')
                            {
                                newStr += "e";
                                pos++;
                                // need an episode number now
                                if (str[pos] >= '0' && str[pos] <= '9')
                                {
                                    newStr += str[pos];
                                    pos++;
                                    // allow 1, 2, 3, or 4 digit numbers
                                    if (str[pos] >= '0' && str[pos] <= '9')
                                    {
                                        newStr += str[pos];
                                        pos++;
                                    }
                                    if (str[pos] >= '0' && str[pos] <= '9')
                                    {
                                        newStr += str[pos];
                                        pos++;
                                    }
                                    if (str[pos] >= '0' && str[pos] <= '9')
                                    {
                                        newStr += str[pos];
                                        pos++;
                                    }
                                    // now look for an optional _ at the end. If we don't have a tailing _, then we may end up cutting off the episode number if it's longer than 4 digits. 
                                    if (str[pos] == '_')
                                    {
                                        Tail_ = pos + 1;
                                    }
                                    else
                                    {
                                        Tail_ = pos ;
                                    }
                                    newStr += " - ";
                                    string newName = str.Substring(0, Lead_);
                                    newName += newStr;
                                    newName += str.Substring(Tail_);
                                    return newName;
                                }
                            }
                        }
                    }
                }
                // if we made it to this point, something didn't match and we need to advance once character and try again.
                pos++;
            }
            // ran out of characters for seaspon and episode parsing. return unmodified string.
            return str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmdUndo.Enabled = true;
            int total = Files.Where(x => x.Enabled).Count();
            int position = 0;
            progressBar1.Value = 0;
            progressBar1.Maximum = total;
            foreach (var file in Files)
            {
                if (file.Enabled)
                {
                    bool done = false;
                    while (!done)
                    {
                        try
                        {
                            string source = System.IO.Path.Combine(txtPath.Text, file.OriginalName + file.OriginalExt);
                            string destination = System.IO.Path.Combine(txtPath.Text, file.RenamedName + file.OriginalExt);
                            System.IO.File.Move(source, destination);
                            done = true;
                        }
                        catch (Exception ex)
                        {
                            DialogResult result = MessageBox.Show(String.Format(
                            "An error occurred.\n{0}\nYes = Retry, No = Skip, Cancel = Stop Processing.",
                                ex.Message), "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                            if (result == DialogResult.No)
                            {
                                done = true;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                return;
                            }
                        }
                    }
                    position++;
                    progressBar1.Value = position;
                    Application.DoEvents();
                    //System.Diagnostics.Debug.WriteLine(string.Format("Renaming \"{0}\" to \"{1}\".", source, destination));
                }
            }
        }

        private void cmdUndo_Click(object sender, EventArgs e)
        {
            int total = Files.Where(x => x.Enabled).Count();
            int position = 0;
            progressBar1.Value = 0;
            progressBar1.Maximum = total;
            foreach (var file in Files)
            {
                if (file.Enabled)
                {
                    bool done = false;
                    while (!done)
                    {
                        try
                        {
                            string destination = System.IO.Path.Combine(txtPath.Text, file.OriginalName + file.OriginalExt);
                            string source = System.IO.Path.Combine(txtPath.Text, file.RenamedName + file.OriginalExt);
                            System.IO.File.Move(source, destination);
                        }
                        catch (Exception ex)
                        {
                            DialogResult result = MessageBox.Show(String.Format(
                            "An error occurred.\n{0}\nYes = Retry, No = Skip, Cancel = Stop Processing.",
                                ex.Message), "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                            if (result == DialogResult.No)
                            {
                                done = true;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                return;
                            }
                        }
                    }
                    position++;
                    progressBar1.Value = position;
                    Application.DoEvents();
                    //System.Diagnostics.Debug.WriteLine(string.Format("Renaming \"{0}\" to \"{1}\".", source, destination));
                }
            }
        }
    }
}
