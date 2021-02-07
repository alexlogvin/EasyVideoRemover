using FFMediaToolkit.Decoding;
using FFMediaToolkit.Graphics;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace EasyVideoRemover
{
    public partial class VideoControl : UserControl
    {
        public VideoControl()
        {
            InitializeComponent();
        }

        private List<PictureBox> PictureBoxes { get; set; } = new List<PictureBox>();

        public VideoControl(string videoFile) : this()
        {
            FilePath = videoFile;

            if (DesignMode)
                return;

            PictureBoxes.AddRange(new List<PictureBox>()
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5,
                pictureBox6,
                pictureBox7,
                pictureBox8,
                pictureBox9,
            });

            PictureBoxes.ForEach(x => x.SizeMode = PictureBoxSizeMode.Zoom);

            try
            {
                using (var file = MediaFile.Open(FilePath))
                {
                    int framesNumber = file.Video.Info.NumberOfFrames ?? -1;
                    if (framesNumber > 0)
                    {
                        for (int section = 0, currentFrame = 0; section < PictureBoxes.Count; section++, currentFrame++)
                        {
                            for (; currentFrame < framesNumber / (PictureBoxes.Count + 1) * (section + 1); currentFrame++)
                                file.Video.TryReadNextFrame(out _);

                            if (file.Video.TryReadNextFrame(out var imageData))
                                try
                                {
                                    PictureBoxes[section].Image = ToBitmap(imageData);
                                }
                                catch { }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        // ImageData -> Bitmap (unsafe)
        public static unsafe Bitmap ToBitmap(ImageData bitmap)
        {
            fixed (byte* p = bitmap.Data)
            {
                return new Bitmap(bitmap.ImageSize.Width, bitmap.ImageSize.Height, bitmap.Stride, PixelFormat.Format24bppRgb, new IntPtr(p));
            }
        }

        public bool IsChecked => checkBox.Checked;
        public string FilePath { get; private set; }
    }
}
