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

namespace EasyVideoRemover
{
    public partial class MainForm : Form
    {
        private string SourceFolder;
        private readonly List<string> AllowedExtentions = new List<string> { ".mp4", ".mov", ".avi", ".webm", ".flv" };

        private List<VideoControl> Images
        {
            get => _images; set
            {
                _images = value;
            }
        }
        private List<VideoControl> _images = new List<VideoControl>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFolderChooser_Click(object sender, EventArgs e)
        {
            DialogResult result = folderChooser.ShowDialog();
            if (result == DialogResult.OK)
                UpdateImagesList(folderChooser.SelectedPath);
        }


        private void UpdateImagesList(string folderPath)
        {
            lblChoosenFolder.Text = SourceFolder = folderPath;

            var paths = Directory.GetFiles(SourceFolder).Where(x => AllowedExtentions.Contains(new FileInfo(x).Extension));

            foreach (var path in paths.Skip(1).Take(1))
            {
                VideoControl control = new VideoControl(path);
                panelVideos.Controls.Add(control);

                //Images.Add(control);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FFMediaToolkit.FFmpegLoader.FFmpegPath = @"F:\Work\Repositories\EasyVideoRemover\";
        }
    }
}
