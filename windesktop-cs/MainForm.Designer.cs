/*
 * Created by SharpDevelop.
 * User: nat
 * Date: 04/11/2011
 * Time: 15:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace scansort
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.treeFolders = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.gridFiles = new System.Windows.Forms.DataGridView();
			this.Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.picPreview = new System.Windows.Forms.PictureBox();
			this.dateFile = new System.Windows.Forms.DateTimePicker();
			this.txtFilename = new System.Windows.Forms.TextBox();
			this.txtSuffix = new System.Windows.Forms.TextBox();
			this.btnMove = new System.Windows.Forms.Button();
			this.lstPreview = new System.Windows.Forms.ListBox();
			this.lblFiles = new System.Windows.Forms.Label();
			this.lblOverYear = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gridFiles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
			this.SuspendLayout();
			// 
			// treeFolders
			// 
			this.treeFolders.ImageKey = "folder";
			this.treeFolders.ImageList = this.imageList1;
			this.treeFolders.Location = new System.Drawing.Point(12, 296);
			this.treeFolders.Name = "treeFolders";
			this.treeFolders.SelectedImageIndex = 0;
			this.treeFolders.Size = new System.Drawing.Size(342, 308);
			this.treeFolders.TabIndex = 0;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "folder");
			// 
			// gridFiles
			// 
			this.gridFiles.AllowUserToAddRows = false;
			this.gridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Filename,
									this.Date});
			this.gridFiles.Location = new System.Drawing.Point(12, 29);
			this.gridFiles.Name = "gridFiles";
			this.gridFiles.ReadOnly = true;
			this.gridFiles.RowHeadersVisible = false;
			this.gridFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridFiles.Size = new System.Drawing.Size(342, 261);
			this.gridFiles.TabIndex = 1;
			this.gridFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridFilesCellContentClick);
			this.gridFiles.SelectionChanged += new System.EventHandler(this.GridFilesSelectionChanged);
			// 
			// Filename
			// 
			this.Filename.HeaderText = "Filename";
			this.Filename.Name = "Filename";
			this.Filename.ReadOnly = true;
			// 
			// Date
			// 
			this.Date.HeaderText = "Date";
			this.Date.Name = "Date";
			this.Date.ReadOnly = true;
			// 
			// picPreview
			// 
			this.picPreview.Location = new System.Drawing.Point(374, 12);
			this.picPreview.Name = "picPreview";
			this.picPreview.Size = new System.Drawing.Size(699, 842);
			this.picPreview.TabIndex = 2;
			this.picPreview.TabStop = false;
			this.picPreview.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// dateFile
			// 
			this.dateFile.Location = new System.Drawing.Point(12, 610);
			this.dateFile.Name = "dateFile";
			this.dateFile.Size = new System.Drawing.Size(200, 20);
			this.dateFile.TabIndex = 4;
			this.dateFile.ValueChanged += new System.EventHandler(this.DateTimePicker1ValueChanged);
			// 
			// txtFilename
			// 
			this.txtFilename.Location = new System.Drawing.Point(12, 695);
			this.txtFilename.Name = "txtFilename";
			this.txtFilename.Size = new System.Drawing.Size(217, 20);
			this.txtFilename.TabIndex = 5;
			this.txtFilename.TextChanged += new System.EventHandler(this.TxtFilenameTextChanged);
			// 
			// txtSuffix
			// 
			this.txtSuffix.Location = new System.Drawing.Point(12, 650);
			this.txtSuffix.Name = "txtSuffix";
			this.txtSuffix.Size = new System.Drawing.Size(189, 20);
			this.txtSuffix.TabIndex = 6;
			this.txtSuffix.TextChanged += new System.EventHandler(this.TxtSuffixTextChanged);
			// 
			// btnMove
			// 
			this.btnMove.Location = new System.Drawing.Point(252, 692);
			this.btnMove.Name = "btnMove";
			this.btnMove.Size = new System.Drawing.Size(75, 23);
			this.btnMove.TabIndex = 7;
			this.btnMove.Text = "Move";
			this.btnMove.UseVisualStyleBackColor = true;
			this.btnMove.Click += new System.EventHandler(this.BtnMoveClick);
			// 
			// lstPreview
			// 
			this.lstPreview.FormattingEnabled = true;
			this.lstPreview.Location = new System.Drawing.Point(12, 736);
			this.lstPreview.Name = "lstPreview";
			this.lstPreview.Size = new System.Drawing.Size(342, 108);
			this.lstPreview.TabIndex = 8;
			// 
			// lblFiles
			// 
			this.lblFiles.Location = new System.Drawing.Point(12, 12);
			this.lblFiles.Name = "lblFiles";
			this.lblFiles.Size = new System.Drawing.Size(342, 14);
			this.lblFiles.TabIndex = 9;
			this.lblFiles.Text = "label1";
			// 
			// lblOverYear
			// 
			this.lblOverYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOverYear.ForeColor = System.Drawing.Color.Red;
			this.lblOverYear.Location = new System.Drawing.Point(218, 610);
			this.lblOverYear.Name = "lblOverYear";
			this.lblOverYear.Size = new System.Drawing.Size(100, 23);
			this.lblOverYear.TabIndex = 10;
			this.lblOverYear.Text = "> 1yr";
			this.lblOverYear.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1085, 866);
			this.Controls.Add(this.lblOverYear);
			this.Controls.Add(this.lblFiles);
			this.Controls.Add(this.lstPreview);
			this.Controls.Add(this.btnMove);
			this.Controls.Add(this.txtSuffix);
			this.Controls.Add(this.txtFilename);
			this.Controls.Add(this.dateFile);
			this.Controls.Add(this.picPreview);
			this.Controls.Add(this.gridFiles);
			this.Controls.Add(this.treeFolders);
			this.Name = "MainForm";
			this.Text = "scansort";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.gridFiles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblOverYear;
		private System.Windows.Forms.Label lblFiles;
		private System.Windows.Forms.ListBox lstPreview;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button btnMove;
		private System.Windows.Forms.TextBox txtSuffix;
		private System.Windows.Forms.TextBox txtFilename;
		private System.Windows.Forms.DateTimePicker dateFile;
		private System.Windows.Forms.PictureBox picPreview;
		private System.Windows.Forms.DataGridView gridFiles;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DataGridViewTextBoxColumn Filename;
		private System.Windows.Forms.TreeView treeFolders;
	}
}
