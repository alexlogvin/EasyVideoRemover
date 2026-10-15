
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
            btnFolderChooser = new System.Windows.Forms.Button();
            lblChoosenFolder = new System.Windows.Forms.Label();
            btnDelete = new System.Windows.Forms.Button();
            folderChooser = new System.Windows.Forms.FolderBrowserDialog();
            panelVideos = new System.Windows.Forms.FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnFolderChooser
            // 
            btnFolderChooser.Location = new System.Drawing.Point(9, 8);
            btnFolderChooser.Margin = new System.Windows.Forms.Padding(2);
            btnFolderChooser.Name = "btnFolderChooser";
            btnFolderChooser.Size = new System.Drawing.Size(105, 31);
            btnFolderChooser.TabIndex = 0;
            btnFolderChooser.Text = "Chose folder...";
            btnFolderChooser.UseVisualStyleBackColor = true;
            btnFolderChooser.Click += btnFolderChooser_Click;
            // 
            // lblChoosenFolder
            // 
            lblChoosenFolder.AutoSize = true;
            lblChoosenFolder.Location = new System.Drawing.Point(118, 16);
            lblChoosenFolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblChoosenFolder.Name = "lblChoosenFolder";
            lblChoosenFolder.Size = new System.Drawing.Size(109, 15);
            lblChoosenFolder.TabIndex = 1;
            lblChoosenFolder.Text = "Folder not choosen";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(861, 761);
            btnDelete.Margin = new System.Windows.Forms.Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(181, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete marked videos";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // panelVideos
            // 
            panelVideos.AutoScroll = true;
            panelVideos.Location = new System.Drawing.Point(0, 43);
            panelVideos.Margin = new System.Windows.Forms.Padding(2);
            panelVideos.Name = "panelVideos";
            panelVideos.Size = new System.Drawing.Size(1050, 714);
            panelVideos.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1051, 806);
            Controls.Add(panelVideos);
            Controls.Add(btnDelete);
            Controls.Add(lblChoosenFolder);
            Controls.Add(btnFolderChooser);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "MainForm";
            Text = "Easy Video Remover";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFolderChooser;
        private System.Windows.Forms.Label lblChoosenFolder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.FolderBrowserDialog folderChooser;
        private System.Windows.Forms.FlowLayoutPanel panelVideos;
    }
}

