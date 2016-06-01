using System.Drawing;

namespace Notepad.ViewLayer.Forms
{
    partial class NotepadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.blaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNewFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveCurrent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripCloseCurrent = new System.Windows.Forms.ToolStripButton();
            this.toolStripCloseAll = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blaToolStripMenuItem,
            this.editToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // blaToolStripMenuItem
            // 
            this.blaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.blaToolStripMenuItem.Name = "blaToolStripMenuItem";
            this.blaToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.blaToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNewFile,
            this.toolStripOpenFile,
            this.toolStripSaveCurrent,
            this.toolStripSaveAll,
            this.toolStripCloseCurrent,
            this.toolStripCloseAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(484, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNewFile
            // 
            this.toolStripNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNewFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNewFile.Image")));
            this.toolStripNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNewFile.Name = "toolStripNewFile";
            this.toolStripNewFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripNewFile.Text = "toolStripNewFIle";
            // 
            // toolStripOpenFile
            // 
            this.toolStripOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpenFile.Image")));
            this.toolStripOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpenFile.Name = "toolStripOpenFile";
            this.toolStripOpenFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripOpenFile.Text = "toolStripButton2";
            // 
            // toolStripSaveCurrent
            // 
            this.toolStripSaveCurrent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveCurrent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveCurrent.Image")));
            this.toolStripSaveCurrent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveCurrent.Name = "toolStripSaveCurrent";
            this.toolStripSaveCurrent.Size = new System.Drawing.Size(23, 22);
            this.toolStripSaveCurrent.Text = "toolStripButton3";
            // 
            // toolStripSaveAll
            // 
            this.toolStripSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveAll.Image")));
            this.toolStripSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveAll.Name = "toolStripSaveAll";
            this.toolStripSaveAll.Size = new System.Drawing.Size(23, 22);
            this.toolStripSaveAll.Text = "toolStripButton4";
            // 
            // toolStripCloseCurrent
            // 
            this.toolStripCloseCurrent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCloseCurrent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCloseCurrent.Image")));
            this.toolStripCloseCurrent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCloseCurrent.Name = "toolStripCloseCurrent";
            this.toolStripCloseCurrent.Size = new System.Drawing.Size(23, 22);
            this.toolStripCloseCurrent.Text = "toolStripButton5";
            // 
            // toolStripCloseAll
            // 
            this.toolStripCloseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCloseAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCloseAll.Image")));
            this.toolStripCloseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCloseAll.Name = "toolStripCloseAll";
            this.toolStripCloseAll.Size = new System.Drawing.Size(23, 22);
            this.toolStripCloseAll.Text = "toolStripButton6";
            // 
            // NotepadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NotepadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem blaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripNewFile;
        private System.Windows.Forms.ToolStripButton toolStripOpenFile;
        private System.Windows.Forms.ToolStripButton toolStripSaveCurrent;
        private System.Windows.Forms.ToolStripButton toolStripSaveAll;
        private System.Windows.Forms.ToolStripButton toolStripCloseCurrent;
        private System.Windows.Forms.ToolStripButton toolStripCloseAll;
    }
}

