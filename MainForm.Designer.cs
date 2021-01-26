
namespace EasyVideoRemover
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFolderChooser = new System.Windows.Forms.Button();
            this.lblChoosenFolder = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.folderChooser = new System.Windows.Forms.FolderBrowserDialog();
            this.panelVideos = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnFolderChooser
            // 
            this.btnFolderChooser.Location = new System.Drawing.Point(13, 13);
            this.btnFolderChooser.Name = "btnFolderChooser";
            this.btnFolderChooser.Size = new System.Drawing.Size(150, 34);
            this.btnFolderChooser.TabIndex = 0;
            this.btnFolderChooser.Text = "Chose folder...";
            this.btnFolderChooser.UseVisualStyleBackColor = true;
            this.btnFolderChooser.Click += new System.EventHandler(this.btnFolderChooser_Click);
            // 
            // lblChoosenFolder
            // 
            this.lblChoosenFolder.AutoSize = true;
            this.lblChoosenFolder.Location = new System.Drawing.Point(169, 18);
            this.lblChoosenFolder.Name = "lblChoosenFolder";
            this.lblChoosenFolder.Size = new System.Drawing.Size(166, 25);
            this.lblChoosenFolder.TabIndex = 1;
            this.lblChoosenFolder.Text = "Folder not choosen";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1230, 1268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(259, 64);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete marked videos";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // panelVideos
            // 
            this.panelVideos.AutoScroll = true;
            this.panelVideos.Location = new System.Drawing.Point(0, 53);
            this.panelVideos.Name = "panelVideos";
            this.panelVideos.Size = new System.Drawing.Size(1500, 1209);
            this.panelVideos.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 1344);
            this.Controls.Add(this.panelVideos);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblChoosenFolder);
            this.Controls.Add(this.btnFolderChooser);
            this.Name = "MainForm";
            this.Text = "Easy Video Remover";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFolderChooser;
        private System.Windows.Forms.Label lblChoosenFolder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.FolderBrowserDialog folderChooser;
        private System.Windows.Forms.FlowLayoutPanel panelVideos;
    }
}

