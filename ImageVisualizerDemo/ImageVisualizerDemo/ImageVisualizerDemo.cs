using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageVisualizerDemo
{
	public partial class ImageVisualizerDemo : Form
	{
		public ImageVisualizerDemo()
		{
			InitializeComponent();
		}

		private void buttonLoadPicture_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Title = "Choose a picture file";
			dlg.InitialDirectory =
				Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				if (dlg.FileName != string.Empty)
				{
					Image image = Image.FromFile(dlg.FileName);
					pictureBox.Image = image;
				}
			}
		}
	}
}