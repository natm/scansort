using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace scansort
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private DirectoryInfo mDest;
		private DirectoryInfo mSrc;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			mDest = new DirectoryInfo(@"C:\Users\nat\Dropbox\Household");
			mSrc = new DirectoryInfo(@"C:\Users\nat\Dropbox\Household\unsorted june 2011");
			PopulateFilelist();
			PopulateDestinationTree();
		}
		
		private void PopulateDestinationTree(	)
		{
			treeFolders.Nodes.Clear();
			
			TreeNode root = new TreeNode(mDest.Name);
			
			root.Tag = mDest.FullName;
			
			treeFolders.Nodes.Add(root);
			
			foreach (DirectoryInfo d in mDest.GetDirectories())
			{
				TreeNode n = new TreeNode(d.Name);
				n.Tag = d.FullName;
				root.Nodes.Add(n);
			}
			root.ExpandAll();
		}
		
		private void PopulateFilelist()
		{
			gridFiles.Rows.Clear();
			int files = 0 ;
			foreach (FileInfo f in mSrc.GetFiles())
			{
				if (f.Name.ToLower().EndsWith(".jpg")) {
					DataGridViewRow r = new DataGridViewRow();
					r.Tag = f.FullName;
					
					r.Cells.Add(NewTextCell(f.Name));
					r.Cells.Add(NewTextCell(f.CreationTime.ToShortDateString()));
					gridFiles.Rows.Add(r);
				}
				files++;
			}
			lblFiles.Text = String.Format("{0} unsorted files",files);
		}
		
		private DataGridViewTextBoxCell NewTextCell(string text)
		{
			DataGridViewTextBoxCell c = new DataGridViewTextBoxCell();
			c.Value = text;
			return c;
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
		
		void GridFilesCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void GridFilesSelectionChanged(object sender, EventArgs e)
		{
			if (gridFiles.SelectedRows.Count > 0)
			{
				
				string tag = gridFiles.SelectedRows[0].Tag.ToString();
				Image imgToResize = new Bitmap(tag);
				
				
				
				Size size = new Size(picPreview.Width,1024);
				
				
				
				
				
				int sourceWidth = imgToResize.Width;
  				 int sourceHeight = imgToResize.Height;
				
  				float nPercent = 0;
			   float nPercentW = 0;
			   float nPercentH = 0;
			 nPercentW = ((float)size.Width / (float)sourceWidth);
			   nPercentH = ((float)size.Height / (float)sourceHeight);
			
			   if (nPercentH < nPercentW)
			      nPercent = nPercentH;
			   else
			      nPercent = nPercentW;
   
				int destWidth = (int)(sourceWidth * nPercent);
			   int destHeight = (int)(sourceHeight * nPercent);
			
			   Bitmap b = new Bitmap(destWidth, destHeight);
			   Graphics g = Graphics.FromImage((Image)b);
			   //g.InterpolationMode = InterpolationMode.HighQualityBicubic;
			
			   g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
			   g.Dispose();
				picPreview.Image = (Image)b;;
				ResetFilename();
				imgToResize.Dispose();
			}
			UpdateFilename();
		}
		
		private void RefreshSourceFile()
		{
			
		}
		
		private void ResetFilename()
		{
			txtSuffix.Text = "";
		}
		
		void DateTimePicker1ValueChanged(object sender, EventArgs e)
		{
			UpdateFilename();
			TimeSpan ts = DateTime.Now - dateFile.Value;
			if (ts.TotalDays > 365)
			{
				lblOverYear.Visible = true;
			} else {
				lblOverYear.Visible = false;
			}
		}
		
		private void UpdateFilename()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(dateFile.Value.ToString("yyyy-MM-dd"));
			if (txtSuffix.Text.Length > 0)
			{
				sb.Append(" ");
				sb.Append(txtSuffix.Text);
			}
			txtFilename.Text = sb.ToString();
			
			List<string> dstfiles = GetDestFilenames(txtFilename.Text);
			lstPreview.Items.Clear();
			foreach (string d in dstfiles)
			{
				lstPreview.Items.Add(d);
			}
		}
		
		void TxtSuffixTextChanged(object sender, EventArgs e)
		{
			UpdateFilename();
		}
		
		void BtnMoveClick(object sender, EventArgs e)
		{
			if (treeFolders.SelectedNode != null)
			{
				string dstfolder = treeFolders.SelectedNode.Tag.ToString();
				bool success = MoveFiles(dstfolder,txtFilename.Text);
				
				if (success)
				{
					PopulateFilelist();
					ResetFilename();
					txtFilename.Text = "";
				}
			}
		}
		
		
		
		private bool MoveFiles( string dstfolder, string dstpattern)
		{
			List<string> dstfiles = GetDestFilenames(dstpattern);
			bool allok = true;
			foreach (string d in dstfiles)
			{
				string full = String.Format("{0}\\{1}",dstfolder,d);
				if (FileExists(full))
				{
					allok = false;
				}
			}
			
			if (allok)
			{
				List<string> src = GetSrcFiles();	
				for (int i = 0; i < src.Count; i++) {
					string srcfile = src[i];
					
					string dstfile = String.Format("{0}\\{1}",dstfolder, dstfiles[i]);
					FileInfo fi = new FileInfo(srcfile);
					fi.MoveTo(dstfile);
				}
				return true;	
			} else {
				MessageBox.Show("File already exists");
				return false;
			}
		}
		
		private List<string> GetSrcFiles()
		{
			List<string> src = new List<string>();
			if (gridFiles.SelectedRows.Count > 1)
			{
				// multiple files	
				for (int s = 0; s < gridFiles.SelectedRows.Count; s++) {
					src.Add(gridFiles.SelectedRows[s].Tag.ToString());
				}
			}
			if (gridFiles.SelectedRows.Count == 1) {
				// single file
				src.Add(gridFiles.SelectedRows[0].Tag.ToString());
			}
			src.Sort();
			return src;			
		}
		
		private List<string> GetDestFilenames(string dstfile)
		{
			List<string> src = GetSrcFiles();
			List<string> dstfiles = new List<string>();
			if (src.Count == 1)
			{
				// single
				dstfiles.Add(dstfile + ".jpg");
			} else {
				// multi
				for (int p = 0; p < src.Count; p++) {
					string filename = String.Format("{0} pg{1}.jpg",dstfile,(p + 1));
					dstfiles.Add(filename);
				}
			}
			
			return dstfiles;
		}
		
		private bool FileExists(string filename)
		{
			FileInfo f = new FileInfo(filename);
			return f.Exists;
		}
		
		void TxtFilenameTextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
