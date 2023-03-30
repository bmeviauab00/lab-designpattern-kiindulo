namespace DesignPatternApp;

partial class MainForm
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        menuStrip1 = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        newDocumentToolStripMenuItem = new ToolStripMenuItem();
        openDocumentToolStripMenuItem = new ToolStripMenuItem();
        closeDocumentToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator = new ToolStripSeparator();
        saveToolStripMenuItem = new ToolStripMenuItem();
        saveAsToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        clearToolStripMenuItem = new ToolStripMenuItem();
        editToolStripMenuItem = new ToolStripMenuItem();
        undoToolStripMenuItem = new ToolStripMenuItem();
        redoToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator4 = new ToolStripSeparator();
        selectAllToolStripMenuItem = new ToolStripMenuItem();
        toolsToolStripMenuItem = new ToolStripMenuItem();
        selectToolStripMenuItem = new ToolStripMenuItem();
        toolStripMenuItem1 = new ToolStripSeparator();
        newRectToolStripMenuItem = new ToolStripMenuItem();
        newEllipseToolStripMenuItem = new ToolStripMenuItem();
        toolStrip1 = new ToolStrip();
        newDocumentToolStripButton = new ToolStripButton();
        openDocumentToolStripButton = new ToolStripButton();
        closeDocumentToolStripButton = new ToolStripButton();
        saveToolStripButton = new ToolStripButton();
        toolStripSeparator5 = new ToolStripSeparator();
        undoStripButton = new ToolStripButton();
        toolStripSeparator6 = new ToolStripSeparator();
        selectToolStripButton = new ToolStripButton();
        toolStripSeparator7 = new ToolStripSeparator();
        newRectStripButton = new ToolStripButton();
        newEllipseToolStripButton = new ToolStripButton();
        splitContainer1 = new SplitContainer();
        infoPanel1 = new InfoPanel();
        menuStrip1.SuspendLayout();
        toolStrip1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new Padding(7, 2, 0, 2);
        menuStrip1.Size = new Size(922, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newDocumentToolStripMenuItem, openDocumentToolStripMenuItem, closeDocumentToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, clearToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(37, 20);
        fileToolStripMenuItem.Text = "&File";
        // 
        // newDocumentToolStripMenuItem
        // 
        newDocumentToolStripMenuItem.Image = (Image)resources.GetObject("newDocumentToolStripMenuItem.Image");
        newDocumentToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        newDocumentToolStripMenuItem.Name = "newDocumentToolStripMenuItem";
        newDocumentToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
        newDocumentToolStripMenuItem.Size = new Size(146, 22);
        newDocumentToolStripMenuItem.Text = "&New";
        // 
        // openDocumentToolStripMenuItem
        // 
        openDocumentToolStripMenuItem.Image = (Image)resources.GetObject("openDocumentToolStripMenuItem.Image");
        openDocumentToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        openDocumentToolStripMenuItem.Name = "openDocumentToolStripMenuItem";
        openDocumentToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
        openDocumentToolStripMenuItem.Size = new Size(146, 22);
        openDocumentToolStripMenuItem.Text = "&Open";
        // 
        // closeDocumentToolStripMenuItem
        // 
        closeDocumentToolStripMenuItem.Image = (Image)resources.GetObject("closeDocumentToolStripMenuItem.Image");
        closeDocumentToolStripMenuItem.Name = "closeDocumentToolStripMenuItem";
        closeDocumentToolStripMenuItem.Size = new Size(146, 22);
        closeDocumentToolStripMenuItem.Text = "Close";
        // 
        // toolStripSeparator
        // 
        toolStripSeparator.Name = "toolStripSeparator";
        toolStripSeparator.Size = new Size(143, 6);
        // 
        // saveToolStripMenuItem
        // 
        saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
        saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
        saveToolStripMenuItem.Size = new Size(146, 22);
        saveToolStripMenuItem.Text = "&Save";
        // 
        // saveAsToolStripMenuItem
        // 
        saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        saveAsToolStripMenuItem.Size = new Size(146, 22);
        saveAsToolStripMenuItem.Text = "Save &As";
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(143, 6);
        // 
        // clearToolStripMenuItem
        // 
        clearToolStripMenuItem.Name = "clearToolStripMenuItem";
        clearToolStripMenuItem.Size = new Size(146, 22);
        clearToolStripMenuItem.Text = "Clear";
        // 
        // editToolStripMenuItem
        // 
        editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
        editToolStripMenuItem.Name = "editToolStripMenuItem";
        editToolStripMenuItem.Size = new Size(39, 20);
        editToolStripMenuItem.Text = "&Edit";
        // 
        // undoToolStripMenuItem
        // 
        undoToolStripMenuItem.Image = (Image)resources.GetObject("undoToolStripMenuItem.Image");
        undoToolStripMenuItem.Name = "undoToolStripMenuItem";
        undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
        undoToolStripMenuItem.Size = new Size(144, 22);
        undoToolStripMenuItem.Text = "&Undo";
        // 
        // redoToolStripMenuItem
        // 
        redoToolStripMenuItem.Name = "redoToolStripMenuItem";
        redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
        redoToolStripMenuItem.Size = new Size(144, 22);
        redoToolStripMenuItem.Text = "&Redo";
        // 
        // toolStripSeparator4
        // 
        toolStripSeparator4.Name = "toolStripSeparator4";
        toolStripSeparator4.Size = new Size(141, 6);
        // 
        // selectAllToolStripMenuItem
        // 
        selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
        selectAllToolStripMenuItem.Size = new Size(144, 22);
        selectAllToolStripMenuItem.Text = "Select &All";
        // 
        // toolsToolStripMenuItem
        // 
        toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectToolStripMenuItem, toolStripMenuItem1, newRectToolStripMenuItem, newEllipseToolStripMenuItem });
        toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
        toolsToolStripMenuItem.Size = new Size(46, 20);
        toolsToolStripMenuItem.Text = "&Tools";
        // 
        // selectToolStripMenuItem
        // 
        selectToolStripMenuItem.Name = "selectToolStripMenuItem";
        selectToolStripMenuItem.Size = new Size(134, 22);
        selectToolStripMenuItem.Text = "Select";
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new Size(131, 6);
        // 
        // newRectToolStripMenuItem
        // 
        newRectToolStripMenuItem.Name = "newRectToolStripMenuItem";
        newRectToolStripMenuItem.Size = new Size(134, 22);
        newRectToolStripMenuItem.Text = "New Rect";
        // 
        // newEllipseToolStripMenuItem
        // 
        newEllipseToolStripMenuItem.Name = "newEllipseToolStripMenuItem";
        newEllipseToolStripMenuItem.Size = new Size(134, 22);
        newEllipseToolStripMenuItem.Text = "New Ellipse";
        // 
        // toolStrip1
        // 
        toolStrip1.Items.AddRange(new ToolStripItem[] { newDocumentToolStripButton, openDocumentToolStripButton, closeDocumentToolStripButton, saveToolStripButton, toolStripSeparator5, undoStripButton, toolStripSeparator6, selectToolStripButton, toolStripSeparator7, newRectStripButton, newEllipseToolStripButton });
        toolStrip1.Location = new Point(0, 24);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new Size(922, 25);
        toolStrip1.TabIndex = 1;
        toolStrip1.Text = "toolStrip1";
        // 
        // newDocumentToolStripButton
        // 
        newDocumentToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        newDocumentToolStripButton.Image = (Image)resources.GetObject("newDocumentToolStripButton.Image");
        newDocumentToolStripButton.ImageTransparentColor = Color.Magenta;
        newDocumentToolStripButton.Name = "newDocumentToolStripButton";
        newDocumentToolStripButton.Size = new Size(23, 22);
        newDocumentToolStripButton.Text = "&New";
        // 
        // openDocumentToolStripButton
        // 
        openDocumentToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        openDocumentToolStripButton.Image = (Image)resources.GetObject("openDocumentToolStripButton.Image");
        openDocumentToolStripButton.ImageTransparentColor = Color.Magenta;
        openDocumentToolStripButton.Name = "openDocumentToolStripButton";
        openDocumentToolStripButton.Size = new Size(23, 22);
        openDocumentToolStripButton.Text = "&Open";
        // 
        // closeDocumentToolStripButton
        // 
        closeDocumentToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        closeDocumentToolStripButton.Image = (Image)resources.GetObject("closeDocumentToolStripButton.Image");
        closeDocumentToolStripButton.ImageTransparentColor = Color.Magenta;
        closeDocumentToolStripButton.Name = "closeDocumentToolStripButton";
        closeDocumentToolStripButton.Size = new Size(23, 22);
        closeDocumentToolStripButton.Text = "Close";
        // 
        // saveToolStripButton
        // 
        saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
        saveToolStripButton.ImageTransparentColor = Color.Magenta;
        saveToolStripButton.Name = "saveToolStripButton";
        saveToolStripButton.Size = new Size(23, 22);
        saveToolStripButton.Text = "&Save";
        // 
        // toolStripSeparator5
        // 
        toolStripSeparator5.Name = "toolStripSeparator5";
        toolStripSeparator5.Size = new Size(6, 25);
        // 
        // undoStripButton
        // 
        undoStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        undoStripButton.Image = (Image)resources.GetObject("undoStripButton.Image");
        undoStripButton.ImageTransparentColor = Color.Magenta;
        undoStripButton.Name = "undoStripButton";
        undoStripButton.Size = new Size(23, 22);
        undoStripButton.Text = "Undo";
        // 
        // toolStripSeparator6
        // 
        toolStripSeparator6.Name = "toolStripSeparator6";
        toolStripSeparator6.Size = new Size(6, 25);
        // 
        // selectToolStripButton
        // 
        selectToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        selectToolStripButton.Image = (Image)resources.GetObject("selectToolStripButton.Image");
        selectToolStripButton.ImageTransparentColor = Color.Magenta;
        selectToolStripButton.Name = "selectToolStripButton";
        selectToolStripButton.Size = new Size(42, 22);
        selectToolStripButton.Text = "Select";
        // 
        // toolStripSeparator7
        // 
        toolStripSeparator7.Name = "toolStripSeparator7";
        toolStripSeparator7.Size = new Size(6, 25);
        // 
        // newRectStripButton
        // 
        newRectStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        newRectStripButton.Image = (Image)resources.GetObject("newRectStripButton.Image");
        newRectStripButton.ImageTransparentColor = Color.Magenta;
        newRectStripButton.Name = "newRectStripButton";
        newRectStripButton.Size = new Size(58, 22);
        newRectStripButton.Text = "New rect";
        // 
        // newEllipseToolStripButton
        // 
        newEllipseToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        newEllipseToolStripButton.Image = (Image)resources.GetObject("newEllipseToolStripButton.Image");
        newEllipseToolStripButton.ImageTransparentColor = Color.Magenta;
        newEllipseToolStripButton.Name = "newEllipseToolStripButton";
        newEllipseToolStripButton.Size = new Size(71, 22);
        newEllipseToolStripButton.Text = "New ellipse";
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 49);
        splitContainer1.Margin = new Padding(4, 3, 4, 3);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.BackColor = SystemColors.ControlDark;
        splitContainer1.Panel2.Controls.Add(infoPanel1);
        splitContainer1.Size = new Size(922, 561);
        splitContainer1.SplitterDistance = 650;
        splitContainer1.SplitterWidth = 5;
        splitContainer1.TabIndex = 2;
        // 
        // infoPanel1
        // 
        infoPanel1.Dock = DockStyle.Fill;
        infoPanel1.Location = new Point(0, 0);
        infoPanel1.Margin = new Padding(5, 3, 5, 3);
        infoPanel1.Name = "infoPanel1";
        infoPanel1.Size = new Size(267, 561);
        infoPanel1.TabIndex = 0;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(922, 610);
        Controls.Add(splitContainer1);
        Controls.Add(toolStrip1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Margin = new Padding(4, 3, 4, 3);
        Name = "MainForm";
        Text = "Shapeítő";
        Load += MainForm_Load;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newDocumentToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openDocumentToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem newRectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newEllipseToolStripMenuItem;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton newDocumentToolStripButton;
    private System.Windows.Forms.ToolStripButton openDocumentToolStripButton;
    private System.Windows.Forms.ToolStripButton saveToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripButton undoStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripButton selectToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.ToolStripButton newRectStripButton;
    private System.Windows.Forms.ToolStripButton newEllipseToolStripButton;
    private System.Windows.Forms.ToolStripMenuItem closeDocumentToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton closeDocumentToolStripButton;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private InfoPanel infoPanel1;
}

