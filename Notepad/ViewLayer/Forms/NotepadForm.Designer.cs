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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.blaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripNewFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveCurrent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripCloseCurrent = new System.Windows.Forms.ToolStripButton();
            this.toolStripCloseAll = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage = new System.Windows.Forms.TabPage();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blaToolStripMenuItem,
            this.editToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(484, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Menu";
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
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNewFile,
            this.toolStripOpenFile,
            this.toolStripSaveCurrent,
            this.toolStripSaveAll,
            this.toolStripCloseCurrent,
            this.toolStripCloseAll});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(484, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "Tools menu";
            // 
            // toolStripNewFile
            // 
            this.toolStripNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNewFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNewFile.Image")));
            this.toolStripNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNewFile.Name = "toolStripNewFile";
            this.toolStripNewFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripNewFile.Text = "New file";
            // 
            // toolStripOpenFile
            // 
            this.toolStripOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpenFile.Image")));
            this.toolStripOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpenFile.Name = "toolStripOpenFile";
            this.toolStripOpenFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripOpenFile.Text = "Open file";
            // 
            // toolStripSaveCurrent
            // 
            this.toolStripSaveCurrent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveCurrent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveCurrent.Image")));
            this.toolStripSaveCurrent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveCurrent.Name = "toolStripSaveCurrent";
            this.toolStripSaveCurrent.Size = new System.Drawing.Size(23, 22);
            this.toolStripSaveCurrent.Text = "Save file";
            // 
            // toolStripSaveAll
            // 
            this.toolStripSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveAll.Image")));
            this.toolStripSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveAll.Name = "toolStripSaveAll";
            this.toolStripSaveAll.Size = new System.Drawing.Size(23, 22);
            this.toolStripSaveAll.Text = "Save all";
            // 
            // toolStripCloseCurrent
            // 
            this.toolStripCloseCurrent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCloseCurrent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCloseCurrent.Image")));
            this.toolStripCloseCurrent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCloseCurrent.Name = "toolStripCloseCurrent";
            this.toolStripCloseCurrent.Size = new System.Drawing.Size(23, 22);
            this.toolStripCloseCurrent.Text = "Close file";
            // 
            // toolStripCloseAll
            // 
            this.toolStripCloseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCloseAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCloseAll.Image")));
            this.toolStripCloseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCloseAll.Name = "toolStripCloseAll";
            this.toolStripCloseAll.Size = new System.Drawing.Size(23, 22);
            this.toolStripCloseAll.Text = "Close all";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 408);
            this.tabControl1.TabIndex = 2;
            // 
            // TabPage
            // 
            this.TabPage.Location = new System.Drawing.Point(4, 22);
            this.TabPage.Name = "TabPage";
            this.TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage.Size = new System.Drawing.Size(476, 382);
            this.TabPage.TabIndex = 0;
            this.TabPage.Text = "new1";
            this.TabPage.UseVisualStyleBackColor = true;
            // 
            // NotepadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "NotepadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad";
            this.TopMost = true;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem blaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripNewFile;
        private System.Windows.Forms.ToolStripButton toolStripOpenFile;
        private System.Windows.Forms.ToolStripButton toolStripSaveCurrent;
        private System.Windows.Forms.ToolStripButton toolStripSaveAll;
        private System.Windows.Forms.ToolStripButton toolStripCloseCurrent;
        private System.Windows.Forms.ToolStripButton toolStripCloseAll;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPage;
    }
}

