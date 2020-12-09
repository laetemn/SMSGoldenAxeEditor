// 
// SMS Golden Axe Editor
// Copyright (C) 2020 xfixium | xfixium@yahoo.com
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

namespace GoldenAxeEditor.Forms
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenROM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportBinarySMS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportSpriteImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportTilesetImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportTilesetHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportTilemapHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataInjection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaletteEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.textEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSpriteEditor = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSprite = new System.Windows.Forms.TabPage();
            this.pnlSpriteTools = new System.Windows.Forms.Panel();
            this.btnRevertPalette = new System.Windows.Forms.Button();
            this.btnRevertSprite = new System.Windows.Forms.Button();
            this.btnImportSprite = new System.Windows.Forms.Button();
            this.lblSelectedPaletteColorValues = new System.Windows.Forms.Label();
            this.grpEditPalette = new System.Windows.Forms.GroupBox();
            this.lblSelectedColorValues = new System.Windows.Forms.Label();
            this.lblSelectedColor = new System.Windows.Forms.Label();
            this.tabTileset = new System.Windows.Forms.TabPage();
            this.pnlTilesetDataEdit = new System.Windows.Forms.Panel();
            this.chkTilesetOverride = new System.Windows.Forms.CheckBox();
            this.btnTilesetUpdate = new System.Windows.Forms.Button();
            this.lblTilesetLength = new System.Windows.Forms.Label();
            this.lblTilesetPosition = new System.Windows.Forms.Label();
            this.txtTilesetLength = new System.Windows.Forms.TextBox();
            this.txtTilesetPosition = new System.Windows.Forms.TextBox();
            this.pnlTilesetTools = new System.Windows.Forms.Panel();
            this.btnImportTileset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkTilesetUseGrid = new System.Windows.Forms.CheckBox();
            this.btnDeselectTile = new System.Windows.Forms.Button();
            this.btnDeleteTile = new System.Windows.Forms.Button();
            this.chkTilesetIndexed = new System.Windows.Forms.CheckBox();
            this.btnRevertTileset = new System.Windows.Forms.Button();
            this.tabTilemap = new System.Windows.Forms.TabPage();
            this.pnlTilemapDataEdit = new System.Windows.Forms.Panel();
            this.btnTilemapUpdate = new System.Windows.Forms.Button();
            this.nudTilemapRows = new System.Windows.Forms.NumericUpDown();
            this.lblTilemapRows = new System.Windows.Forms.Label();
            this.nudTilemapColumns = new System.Windows.Forms.NumericUpDown();
            this.lblTilemapColumns = new System.Windows.Forms.Label();
            this.lblTilemapPosition = new System.Windows.Forms.Label();
            this.txtTilemapPosition = new System.Windows.Forms.TextBox();
            this.pnlTilemapTools = new System.Windows.Forms.Panel();
            this.pnlTilemapToolsContainer = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTileXFlip = new System.Windows.Forms.CheckBox();
            this.chkTileYFlip = new System.Windows.Forms.CheckBox();
            this.chkTilePalette = new System.Windows.Forms.CheckBox();
            this.chkTilePriority = new System.Windows.Forms.CheckBox();
            this.lblSelectedTileIDValue = new System.Windows.Forms.Label();
            this.btnReplaceTiles = new System.Windows.Forms.Button();
            this.lblSelectedTileID = new System.Windows.Forms.Label();
            this.chkTilesUseGrid = new System.Windows.Forms.CheckBox();
            this.chkTilemapIndexed = new System.Windows.Forms.CheckBox();
            this.btnRevertTilemap = new System.Windows.Forms.Button();
            this.pnlSpriteList = new System.Windows.Forms.Panel();
            this.grpSpriteList = new System.Windows.Forms.GroupBox();
            this.pnlSpriteListBorder = new System.Windows.Forms.Panel();
            this.lstSprites = new System.Windows.Forms.ListBox();
            this.pnlSpriteListTools = new System.Windows.Forms.Panel();
            this.chkViewUneditedSprite = new System.Windows.Forms.CheckBox();
            this.lblSpriteTilemap = new System.Windows.Forms.Label();
            this.btnPreviousFrame = new System.Windows.Forms.Button();
            this.btnNextFrame = new System.Windows.Forms.Button();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslObjectType = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.nudTilemapOffsetY = new System.Windows.Forms.NumericUpDown();
            this.lblTilemapOffsetY = new System.Windows.Forms.Label();
            this.nudTilemapOffsetX = new System.Windows.Forms.NumericUpDown();
            this.lblTilemapOffsetX = new System.Windows.Forms.Label();
            this.pnlSprite = new GoldenAxeEditor.Controls.ImageControl();
            this.pnlPaletteEdit = new GoldenAxeEditor.Controls.PaletteEditControl();
            this.pnlSelectedColor = new GoldenAxeEditor.Controls.ColorControl();
            this.pnlColorPicker = new GoldenAxeEditor.Controls.ImageControl();
            this.pnlTileset = new GoldenAxeEditor.Controls.TilesetEditControl();
            this.pnlTile = new GoldenAxeEditor.Controls.TileControl();
            this.pnlTilemap = new GoldenAxeEditor.Controls.TilemapEditControl();
            this.pnlTiles = new GoldenAxeEditor.Controls.TilesControl();
            this.mnuMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlSpriteEditor.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabSprite.SuspendLayout();
            this.pnlSpriteTools.SuspendLayout();
            this.grpEditPalette.SuspendLayout();
            this.tabTileset.SuspendLayout();
            this.pnlTilesetDataEdit.SuspendLayout();
            this.pnlTilesetTools.SuspendLayout();
            this.tabTilemap.SuspendLayout();
            this.pnlTilemapDataEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapColumns)).BeginInit();
            this.pnlTilemapTools.SuspendLayout();
            this.pnlTilemapToolsContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlSpriteList.SuspendLayout();
            this.grpSpriteList.SuspendLayout();
            this.pnlSpriteListBorder.SuspendLayout();
            this.pnlSpriteListTools.SuspendLayout();
            this.ssMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapOffsetX)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTools,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(784, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenProject,
            this.mnuOpenROM,
            this.mnuSave,
            this.mnuSeparator1,
            this.mnuExport,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuOpenProject
            // 
            this.mnuOpenProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuOpenProject.Name = "mnuOpenProject";
            this.mnuOpenProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpenProject.Size = new System.Drawing.Size(186, 22);
            this.mnuOpenProject.Text = "&Open Project";
            this.mnuOpenProject.Click += new System.EventHandler(this.mnuOpenProject_Click);
            // 
            // mnuOpenROM
            // 
            this.mnuOpenROM.Image = global::GoldenAxeEditor.Properties.Resources.open;
            this.mnuOpenROM.Name = "mnuOpenROM";
            this.mnuOpenROM.Size = new System.Drawing.Size(186, 22);
            this.mnuOpenROM.Text = "Open ROM";
            this.mnuOpenROM.Click += new System.EventHandler(this.mnuOpenROM_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Image = global::GoldenAxeEditor.Properties.Resources.save;
            this.mnuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(186, 22);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSeparator1
            // 
            this.mnuSeparator1.Name = "mnuSeparator1";
            this.mnuSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // mnuExport
            // 
            this.mnuExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportBinarySMS,
            this.mnuExportSpriteImage,
            this.mnuExportTilesetImage,
            this.mnuExportTilesetHex,
            this.mnuExportTilemapHex});
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new System.Drawing.Size(186, 22);
            this.mnuExport.Text = "Export";
            // 
            // mnuExportBinarySMS
            // 
            this.mnuExportBinarySMS.Image = global::GoldenAxeEditor.Properties.Resources.export_bin;
            this.mnuExportBinarySMS.Name = "mnuExportBinarySMS";
            this.mnuExportBinarySMS.Size = new System.Drawing.Size(178, 22);
            this.mnuExportBinarySMS.Text = "Binary (.sms)";
            this.mnuExportBinarySMS.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // mnuExportSpriteImage
            // 
            this.mnuExportSpriteImage.Image = ((System.Drawing.Image)(resources.GetObject("mnuExportSpriteImage.Image")));
            this.mnuExportSpriteImage.Name = "mnuExportSpriteImage";
            this.mnuExportSpriteImage.Size = new System.Drawing.Size(178, 22);
            this.mnuExportSpriteImage.Text = "Sprite Image (.png)";
            this.mnuExportSpriteImage.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // mnuExportTilesetImage
            // 
            this.mnuExportTilesetImage.Image = ((System.Drawing.Image)(resources.GetObject("mnuExportTilesetImage.Image")));
            this.mnuExportTilesetImage.Name = "mnuExportTilesetImage";
            this.mnuExportTilesetImage.Size = new System.Drawing.Size(178, 22);
            this.mnuExportTilesetImage.Text = "Tileset Image (.png)";
            this.mnuExportTilesetImage.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // mnuExportTilesetHex
            // 
            this.mnuExportTilesetHex.Name = "mnuExportTilesetHex";
            this.mnuExportTilesetHex.Size = new System.Drawing.Size(178, 22);
            this.mnuExportTilesetHex.Text = "Tileset Hex (.txt)";
            this.mnuExportTilesetHex.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // mnuExportTilemapHex
            // 
            this.mnuExportTilemapHex.Name = "mnuExportTilemapHex";
            this.mnuExportTilemapHex.Size = new System.Drawing.Size(178, 22);
            this.mnuExportTilemapHex.Text = "Tilemap Hex (.txt)";
            this.mnuExportTilemapHex.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = global::GoldenAxeEditor.Properties.Resources.exit;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(186, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDataInjection,
            this.mnuPaletteEdit,
            this.textEditToolStripMenuItem});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(46, 20);
            this.mnuTools.Text = "&Tools";
            // 
            // mnuDataInjection
            // 
            this.mnuDataInjection.Name = "mnuDataInjection";
            this.mnuDataInjection.Size = new System.Drawing.Size(147, 22);
            this.mnuDataInjection.Text = "Data Injection";
            this.mnuDataInjection.Click += new System.EventHandler(this.mnuDataInjection_Click);
            // 
            // mnuPaletteEdit
            // 
            this.mnuPaletteEdit.Name = "mnuPaletteEdit";
            this.mnuPaletteEdit.Size = new System.Drawing.Size(147, 22);
            this.mnuPaletteEdit.Text = "Palette Edit";
            this.mnuPaletteEdit.Click += new System.EventHandler(this.mnuPaletteEdit_Click);
            // 
            // textEditToolStripMenuItem
            // 
            this.textEditToolStripMenuItem.Name = "textEditToolStripMenuItem";
            this.textEditToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.textEditToolStripMenuItem.Text = "Text Edit";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(116, 22);
            this.mnuAbout.Text = "&About...";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlSpriteEditor);
            this.pnlMain.Controls.Add(this.pnlSpriteList);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.pnlMain.Size = new System.Drawing.Size(784, 515);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlSpriteEditor
            // 
            this.pnlSpriteEditor.Controls.Add(this.tabMain);
            this.pnlSpriteEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpriteEditor.Location = new System.Drawing.Point(192, 4);
            this.pnlSpriteEditor.Name = "pnlSpriteEditor";
            this.pnlSpriteEditor.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlSpriteEditor.Size = new System.Drawing.Size(584, 507);
            this.pnlSpriteEditor.TabIndex = 2;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabSprite);
            this.tabMain.Controls.Add(this.tabTileset);
            this.tabMain.Controls.Add(this.tabTilemap);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 6);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(584, 501);
            this.tabMain.TabIndex = 1;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabSpriteMain_SelectedIndexChanged);
            // 
            // tabSprite
            // 
            this.tabSprite.BackColor = System.Drawing.SystemColors.Control;
            this.tabSprite.Controls.Add(this.pnlSprite);
            this.tabSprite.Controls.Add(this.pnlSpriteTools);
            this.tabSprite.Location = new System.Drawing.Point(4, 22);
            this.tabSprite.Name = "tabSprite";
            this.tabSprite.Padding = new System.Windows.Forms.Padding(3);
            this.tabSprite.Size = new System.Drawing.Size(576, 475);
            this.tabSprite.TabIndex = 0;
            this.tabSprite.Text = "Sprite";
            // 
            // pnlSpriteTools
            // 
            this.pnlSpriteTools.Controls.Add(this.btnRevertPalette);
            this.pnlSpriteTools.Controls.Add(this.btnRevertSprite);
            this.pnlSpriteTools.Controls.Add(this.btnImportSprite);
            this.pnlSpriteTools.Controls.Add(this.lblSelectedPaletteColorValues);
            this.pnlSpriteTools.Controls.Add(this.grpEditPalette);
            this.pnlSpriteTools.Controls.Add(this.lblSelectedColorValues);
            this.pnlSpriteTools.Controls.Add(this.pnlSelectedColor);
            this.pnlSpriteTools.Controls.Add(this.pnlColorPicker);
            this.pnlSpriteTools.Controls.Add(this.lblSelectedColor);
            this.pnlSpriteTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpriteTools.Location = new System.Drawing.Point(408, 3);
            this.pnlSpriteTools.Name = "pnlSpriteTools";
            this.pnlSpriteTools.Size = new System.Drawing.Size(165, 469);
            this.pnlSpriteTools.TabIndex = 1;
            // 
            // btnRevertPalette
            // 
            this.btnRevertPalette.Location = new System.Drawing.Point(8, 48);
            this.btnRevertPalette.Name = "btnRevertPalette";
            this.btnRevertPalette.Size = new System.Drawing.Size(152, 23);
            this.btnRevertPalette.TabIndex = 2;
            this.btnRevertPalette.Text = "Revert Palette";
            this.btnRevertPalette.UseVisualStyleBackColor = true;
            this.btnRevertPalette.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnRevertSprite
            // 
            this.btnRevertSprite.Location = new System.Drawing.Point(8, 24);
            this.btnRevertSprite.Name = "btnRevertSprite";
            this.btnRevertSprite.Size = new System.Drawing.Size(152, 23);
            this.btnRevertSprite.TabIndex = 1;
            this.btnRevertSprite.Text = "Revert Sprite";
            this.btnRevertSprite.UseVisualStyleBackColor = true;
            this.btnRevertSprite.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnImportSprite
            // 
            this.btnImportSprite.Location = new System.Drawing.Point(8, 0);
            this.btnImportSprite.Name = "btnImportSprite";
            this.btnImportSprite.Size = new System.Drawing.Size(152, 23);
            this.btnImportSprite.TabIndex = 0;
            this.btnImportSprite.Text = "Import Sprite";
            this.btnImportSprite.UseVisualStyleBackColor = true;
            this.btnImportSprite.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblSelectedPaletteColorValues
            // 
            this.lblSelectedPaletteColorValues.Location = new System.Drawing.Point(6, 400);
            this.lblSelectedPaletteColorValues.Name = "lblSelectedPaletteColorValues";
            this.lblSelectedPaletteColorValues.Size = new System.Drawing.Size(158, 13);
            this.lblSelectedPaletteColorValues.TabIndex = 8;
            this.lblSelectedPaletteColorValues.Text = "Red: 0 Green: 0 Blue: 0";
            this.lblSelectedPaletteColorValues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpEditPalette
            // 
            this.grpEditPalette.Controls.Add(this.pnlPaletteEdit);
            this.grpEditPalette.Location = new System.Drawing.Point(8, 272);
            this.grpEditPalette.Name = "grpEditPalette";
            this.grpEditPalette.Size = new System.Drawing.Size(152, 128);
            this.grpEditPalette.TabIndex = 7;
            this.grpEditPalette.TabStop = false;
            this.grpEditPalette.Text = "Edit Palette";
            // 
            // lblSelectedColorValues
            // 
            this.lblSelectedColorValues.Location = new System.Drawing.Point(6, 112);
            this.lblSelectedColorValues.Name = "lblSelectedColorValues";
            this.lblSelectedColorValues.Size = new System.Drawing.Size(158, 13);
            this.lblSelectedColorValues.TabIndex = 5;
            this.lblSelectedColorValues.Text = "Red: 255 Green: 255 Blue: 255";
            this.lblSelectedColorValues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedColor
            // 
            this.lblSelectedColor.AutoSize = true;
            this.lblSelectedColor.Location = new System.Drawing.Point(8, 78);
            this.lblSelectedColor.Name = "lblSelectedColor";
            this.lblSelectedColor.Size = new System.Drawing.Size(84, 13);
            this.lblSelectedColor.TabIndex = 3;
            this.lblSelectedColor.Text = "Selected Color:";
            // 
            // tabTileset
            // 
            this.tabTileset.BackColor = System.Drawing.SystemColors.Control;
            this.tabTileset.Controls.Add(this.pnlTileset);
            this.tabTileset.Controls.Add(this.pnlTilesetDataEdit);
            this.tabTileset.Controls.Add(this.pnlTilesetTools);
            this.tabTileset.Location = new System.Drawing.Point(4, 22);
            this.tabTileset.Name = "tabTileset";
            this.tabTileset.Padding = new System.Windows.Forms.Padding(3);
            this.tabTileset.Size = new System.Drawing.Size(576, 475);
            this.tabTileset.TabIndex = 1;
            this.tabTileset.Text = "Tileset";
            // 
            // pnlTilesetDataEdit
            // 
            this.pnlTilesetDataEdit.Controls.Add(this.chkTilesetOverride);
            this.pnlTilesetDataEdit.Controls.Add(this.btnTilesetUpdate);
            this.pnlTilesetDataEdit.Controls.Add(this.lblTilesetLength);
            this.pnlTilesetDataEdit.Controls.Add(this.lblTilesetPosition);
            this.pnlTilesetDataEdit.Controls.Add(this.txtTilesetLength);
            this.pnlTilesetDataEdit.Controls.Add(this.txtTilesetPosition);
            this.pnlTilesetDataEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTilesetDataEdit.Location = new System.Drawing.Point(3, 3);
            this.pnlTilesetDataEdit.Name = "pnlTilesetDataEdit";
            this.pnlTilesetDataEdit.Size = new System.Drawing.Size(405, 29);
            this.pnlTilesetDataEdit.TabIndex = 2;
            // 
            // chkTilesetOverride
            // 
            this.chkTilesetOverride.AutoSize = true;
            this.chkTilesetOverride.Location = new System.Drawing.Point(208, 6);
            this.chkTilesetOverride.Name = "chkTilesetOverride";
            this.chkTilesetOverride.Size = new System.Drawing.Size(70, 17);
            this.chkTilesetOverride.TabIndex = 4;
            this.chkTilesetOverride.Text = "Override";
            this.chkTilesetOverride.UseVisualStyleBackColor = true;
            // 
            // btnTilesetUpdate
            // 
            this.btnTilesetUpdate.Location = new System.Drawing.Point(280, 3);
            this.btnTilesetUpdate.Name = "btnTilesetUpdate";
            this.btnTilesetUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnTilesetUpdate.TabIndex = 5;
            this.btnTilesetUpdate.Text = "Update";
            this.btnTilesetUpdate.UseVisualStyleBackColor = true;
            this.btnTilesetUpdate.Click += new System.EventHandler(this.btnTilesetDataUpdate_Click);
            // 
            // lblTilesetLength
            // 
            this.lblTilesetLength.AutoSize = true;
            this.lblTilesetLength.Location = new System.Drawing.Point(104, 8);
            this.lblTilesetLength.Name = "lblTilesetLength";
            this.lblTilesetLength.Size = new System.Drawing.Size(46, 13);
            this.lblTilesetLength.TabIndex = 2;
            this.lblTilesetLength.Text = "Length:";
            // 
            // lblTilesetPosition
            // 
            this.lblTilesetPosition.AutoSize = true;
            this.lblTilesetPosition.Location = new System.Drawing.Point(0, 8);
            this.lblTilesetPosition.Name = "lblTilesetPosition";
            this.lblTilesetPosition.Size = new System.Drawing.Size(52, 13);
            this.lblTilesetPosition.TabIndex = 0;
            this.lblTilesetPosition.Text = "Position:";
            // 
            // txtTilesetLength
            // 
            this.txtTilesetLength.Location = new System.Drawing.Point(152, 3);
            this.txtTilesetLength.Name = "txtTilesetLength";
            this.txtTilesetLength.Size = new System.Drawing.Size(48, 22);
            this.txtTilesetLength.TabIndex = 3;
            // 
            // txtTilesetPosition
            // 
            this.txtTilesetPosition.Location = new System.Drawing.Point(56, 3);
            this.txtTilesetPosition.Name = "txtTilesetPosition";
            this.txtTilesetPosition.Size = new System.Drawing.Size(48, 22);
            this.txtTilesetPosition.TabIndex = 1;
            // 
            // pnlTilesetTools
            // 
            this.pnlTilesetTools.Controls.Add(this.btnImportTileset);
            this.pnlTilesetTools.Controls.Add(this.label1);
            this.pnlTilesetTools.Controls.Add(this.pnlTile);
            this.pnlTilesetTools.Controls.Add(this.chkTilesetUseGrid);
            this.pnlTilesetTools.Controls.Add(this.btnDeselectTile);
            this.pnlTilesetTools.Controls.Add(this.btnDeleteTile);
            this.pnlTilesetTools.Controls.Add(this.chkTilesetIndexed);
            this.pnlTilesetTools.Controls.Add(this.btnRevertTileset);
            this.pnlTilesetTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTilesetTools.Location = new System.Drawing.Point(408, 3);
            this.pnlTilesetTools.Name = "pnlTilesetTools";
            this.pnlTilesetTools.Size = new System.Drawing.Size(165, 469);
            this.pnlTilesetTools.TabIndex = 0;
            // 
            // btnImportTileset
            // 
            this.btnImportTileset.Location = new System.Drawing.Point(8, 0);
            this.btnImportTileset.Name = "btnImportTileset";
            this.btnImportTileset.Size = new System.Drawing.Size(152, 23);
            this.btnImportTileset.TabIndex = 0;
            this.btnImportTileset.Text = "Import Tileset";
            this.btnImportTileset.UseVisualStyleBackColor = true;
            this.btnImportTileset.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selected Tile:";
            // 
            // chkTilesetUseGrid
            // 
            this.chkTilesetUseGrid.AutoSize = true;
            this.chkTilesetUseGrid.Checked = true;
            this.chkTilesetUseGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTilesetUseGrid.Location = new System.Drawing.Point(16, 100);
            this.chkTilesetUseGrid.Name = "chkTilesetUseGrid";
            this.chkTilesetUseGrid.Size = new System.Drawing.Size(48, 17);
            this.chkTilesetUseGrid.TabIndex = 4;
            this.chkTilesetUseGrid.Text = "Grid";
            this.chkTilesetUseGrid.UseVisualStyleBackColor = true;
            this.chkTilesetUseGrid.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // btnDeselectTile
            // 
            this.btnDeselectTile.Location = new System.Drawing.Point(8, 72);
            this.btnDeselectTile.Name = "btnDeselectTile";
            this.btnDeselectTile.Size = new System.Drawing.Size(152, 23);
            this.btnDeselectTile.TabIndex = 3;
            this.btnDeselectTile.Text = "Deselect Tile";
            this.btnDeselectTile.UseVisualStyleBackColor = true;
            this.btnDeselectTile.Click += new System.EventHandler(this.btnDeselectTile_Click);
            // 
            // btnDeleteTile
            // 
            this.btnDeleteTile.Location = new System.Drawing.Point(8, 48);
            this.btnDeleteTile.Name = "btnDeleteTile";
            this.btnDeleteTile.Size = new System.Drawing.Size(152, 23);
            this.btnDeleteTile.TabIndex = 2;
            this.btnDeleteTile.Text = "Delete Tile";
            this.btnDeleteTile.UseVisualStyleBackColor = true;
            this.btnDeleteTile.Click += new System.EventHandler(this.btnDeleteTile_Click);
            // 
            // chkTilesetIndexed
            // 
            this.chkTilesetIndexed.AutoSize = true;
            this.chkTilesetIndexed.Location = new System.Drawing.Point(64, 100);
            this.chkTilesetIndexed.Name = "chkTilesetIndexed";
            this.chkTilesetIndexed.Size = new System.Drawing.Size(67, 17);
            this.chkTilesetIndexed.TabIndex = 5;
            this.chkTilesetIndexed.Text = "Indexed";
            this.chkTilesetIndexed.UseVisualStyleBackColor = true;
            this.chkTilesetIndexed.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // btnRevertTileset
            // 
            this.btnRevertTileset.Location = new System.Drawing.Point(8, 24);
            this.btnRevertTileset.Name = "btnRevertTileset";
            this.btnRevertTileset.Size = new System.Drawing.Size(152, 23);
            this.btnRevertTileset.TabIndex = 1;
            this.btnRevertTileset.Text = "Revert Tileset";
            this.btnRevertTileset.UseVisualStyleBackColor = true;
            this.btnRevertTileset.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // tabTilemap
            // 
            this.tabTilemap.BackColor = System.Drawing.SystemColors.Control;
            this.tabTilemap.Controls.Add(this.pnlTilemap);
            this.tabTilemap.Controls.Add(this.pnlTilemapDataEdit);
            this.tabTilemap.Controls.Add(this.pnlTilemapTools);
            this.tabTilemap.Location = new System.Drawing.Point(4, 22);
            this.tabTilemap.Name = "tabTilemap";
            this.tabTilemap.Padding = new System.Windows.Forms.Padding(3);
            this.tabTilemap.Size = new System.Drawing.Size(576, 475);
            this.tabTilemap.TabIndex = 2;
            this.tabTilemap.Text = "Tilemap";
            // 
            // pnlTilemapDataEdit
            // 
            this.pnlTilemapDataEdit.Controls.Add(this.nudTilemapOffsetY);
            this.pnlTilemapDataEdit.Controls.Add(this.lblTilemapOffsetY);
            this.pnlTilemapDataEdit.Controls.Add(this.nudTilemapOffsetX);
            this.pnlTilemapDataEdit.Controls.Add(this.lblTilemapOffsetX);
            this.pnlTilemapDataEdit.Controls.Add(this.btnTilemapUpdate);
            this.pnlTilemapDataEdit.Controls.Add(this.nudTilemapRows);
            this.pnlTilemapDataEdit.Controls.Add(this.lblTilemapRows);
            this.pnlTilemapDataEdit.Controls.Add(this.nudTilemapColumns);
            this.pnlTilemapDataEdit.Controls.Add(this.lblTilemapColumns);
            this.pnlTilemapDataEdit.Controls.Add(this.lblTilemapPosition);
            this.pnlTilemapDataEdit.Controls.Add(this.txtTilemapPosition);
            this.pnlTilemapDataEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTilemapDataEdit.Location = new System.Drawing.Point(3, 3);
            this.pnlTilemapDataEdit.Name = "pnlTilemapDataEdit";
            this.pnlTilemapDataEdit.Size = new System.Drawing.Size(405, 29);
            this.pnlTilemapDataEdit.TabIndex = 0;
            // 
            // btnTilemapUpdate
            // 
            this.btnTilemapUpdate.Location = new System.Drawing.Point(346, 3);
            this.btnTilemapUpdate.Name = "btnTilemapUpdate";
            this.btnTilemapUpdate.Size = new System.Drawing.Size(56, 23);
            this.btnTilemapUpdate.TabIndex = 7;
            this.btnTilemapUpdate.Text = "Update";
            this.btnTilemapUpdate.UseVisualStyleBackColor = true;
            this.btnTilemapUpdate.Click += new System.EventHandler(this.btnTilemapUpdate_Click);
            // 
            // nudTilemapRows
            // 
            this.nudTilemapRows.Location = new System.Drawing.Point(192, 3);
            this.nudTilemapRows.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTilemapRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTilemapRows.Name = "nudTilemapRows";
            this.nudTilemapRows.Size = new System.Drawing.Size(40, 22);
            this.nudTilemapRows.TabIndex = 5;
            this.nudTilemapRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTilemapRows
            // 
            this.lblTilemapRows.AutoSize = true;
            this.lblTilemapRows.Location = new System.Drawing.Point(152, 8);
            this.lblTilemapRows.Name = "lblTilemapRows";
            this.lblTilemapRows.Size = new System.Drawing.Size(38, 13);
            this.lblTilemapRows.TabIndex = 4;
            this.lblTilemapRows.Text = "Rows:";
            // 
            // nudTilemapColumns
            // 
            this.nudTilemapColumns.Location = new System.Drawing.Point(112, 3);
            this.nudTilemapColumns.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTilemapColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTilemapColumns.Name = "nudTilemapColumns";
            this.nudTilemapColumns.Size = new System.Drawing.Size(40, 22);
            this.nudTilemapColumns.TabIndex = 3;
            this.nudTilemapColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTilemapColumns
            // 
            this.lblTilemapColumns.AutoSize = true;
            this.lblTilemapColumns.Location = new System.Drawing.Point(80, 8);
            this.lblTilemapColumns.Name = "lblTilemapColumns";
            this.lblTilemapColumns.Size = new System.Drawing.Size(32, 13);
            this.lblTilemapColumns.TabIndex = 2;
            this.lblTilemapColumns.Text = "Cols:";
            // 
            // lblTilemapPosition
            // 
            this.lblTilemapPosition.AutoSize = true;
            this.lblTilemapPosition.Location = new System.Drawing.Point(0, 8);
            this.lblTilemapPosition.Name = "lblTilemapPosition";
            this.lblTilemapPosition.Size = new System.Drawing.Size(28, 13);
            this.lblTilemapPosition.TabIndex = 0;
            this.lblTilemapPosition.Text = "Pos:";
            // 
            // txtTilemapPosition
            // 
            this.txtTilemapPosition.Location = new System.Drawing.Point(32, 3);
            this.txtTilemapPosition.Name = "txtTilemapPosition";
            this.txtTilemapPosition.Size = new System.Drawing.Size(48, 22);
            this.txtTilemapPosition.TabIndex = 1;
            // 
            // pnlTilemapTools
            // 
            this.pnlTilemapTools.Controls.Add(this.pnlTiles);
            this.pnlTilemapTools.Controls.Add(this.pnlTilemapToolsContainer);
            this.pnlTilemapTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTilemapTools.Location = new System.Drawing.Point(408, 3);
            this.pnlTilemapTools.Name = "pnlTilemapTools";
            this.pnlTilemapTools.Size = new System.Drawing.Size(165, 469);
            this.pnlTilemapTools.TabIndex = 2;
            // 
            // pnlTilemapToolsContainer
            // 
            this.pnlTilemapToolsContainer.Controls.Add(this.groupBox2);
            this.pnlTilemapToolsContainer.Controls.Add(this.lblSelectedTileIDValue);
            this.pnlTilemapToolsContainer.Controls.Add(this.btnReplaceTiles);
            this.pnlTilemapToolsContainer.Controls.Add(this.lblSelectedTileID);
            this.pnlTilemapToolsContainer.Controls.Add(this.chkTilesUseGrid);
            this.pnlTilemapToolsContainer.Controls.Add(this.chkTilemapIndexed);
            this.pnlTilemapToolsContainer.Controls.Add(this.btnRevertTilemap);
            this.pnlTilemapToolsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTilemapToolsContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlTilemapToolsContainer.Name = "pnlTilemapToolsContainer";
            this.pnlTilemapToolsContainer.Size = new System.Drawing.Size(165, 160);
            this.pnlTilemapToolsContainer.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTileXFlip);
            this.groupBox2.Controls.Add(this.chkTileYFlip);
            this.groupBox2.Controls.Add(this.chkTilePalette);
            this.groupBox2.Controls.Add(this.chkTilePriority);
            this.groupBox2.Location = new System.Drawing.Point(8, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 64);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tile Attributes";
            // 
            // chkTileXFlip
            // 
            this.chkTileXFlip.AutoSize = true;
            this.chkTileXFlip.Location = new System.Drawing.Point(8, 24);
            this.chkTileXFlip.Name = "chkTileXFlip";
            this.chkTileXFlip.Size = new System.Drawing.Size(54, 17);
            this.chkTileXFlip.TabIndex = 0;
            this.chkTileXFlip.Text = "X Flip";
            this.chkTileXFlip.UseVisualStyleBackColor = true;
            // 
            // chkTileYFlip
            // 
            this.chkTileYFlip.AutoSize = true;
            this.chkTileYFlip.Location = new System.Drawing.Point(8, 40);
            this.chkTileYFlip.Name = "chkTileYFlip";
            this.chkTileYFlip.Size = new System.Drawing.Size(53, 17);
            this.chkTileYFlip.TabIndex = 1;
            this.chkTileYFlip.Text = "Y Flip";
            this.chkTileYFlip.UseVisualStyleBackColor = true;
            // 
            // chkTilePalette
            // 
            this.chkTilePalette.AutoSize = true;
            this.chkTilePalette.Location = new System.Drawing.Point(64, 24);
            this.chkTilePalette.Name = "chkTilePalette";
            this.chkTilePalette.Size = new System.Drawing.Size(83, 17);
            this.chkTilePalette.TabIndex = 2;
            this.chkTilePalette.Text = "SPR Palette";
            this.chkTilePalette.UseVisualStyleBackColor = true;
            // 
            // chkTilePriority
            // 
            this.chkTilePriority.AutoSize = true;
            this.chkTilePriority.Location = new System.Drawing.Point(64, 40);
            this.chkTilePriority.Name = "chkTilePriority";
            this.chkTilePriority.Size = new System.Drawing.Size(62, 17);
            this.chkTilePriority.TabIndex = 3;
            this.chkTilePriority.Text = "Priority";
            this.chkTilePriority.UseVisualStyleBackColor = true;
            // 
            // lblSelectedTileIDValue
            // 
            this.lblSelectedTileIDValue.AutoSize = true;
            this.lblSelectedTileIDValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTileIDValue.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblSelectedTileIDValue.Location = new System.Drawing.Point(99, 140);
            this.lblSelectedTileIDValue.Name = "lblSelectedTileIDValue";
            this.lblSelectedTileIDValue.Size = new System.Drawing.Size(13, 13);
            this.lblSelectedTileIDValue.TabIndex = 3;
            this.lblSelectedTileIDValue.Text = "0";
            // 
            // btnReplaceTiles
            // 
            this.btnReplaceTiles.Location = new System.Drawing.Point(8, 24);
            this.btnReplaceTiles.Name = "btnReplaceTiles";
            this.btnReplaceTiles.Size = new System.Drawing.Size(152, 23);
            this.btnReplaceTiles.TabIndex = 1;
            this.btnReplaceTiles.Text = "Replace Tiles";
            this.btnReplaceTiles.UseVisualStyleBackColor = true;
            this.btnReplaceTiles.Click += new System.EventHandler(this.btnReplaceTiles_Click);
            // 
            // lblSelectedTileID
            // 
            this.lblSelectedTileID.AutoSize = true;
            this.lblSelectedTileID.Location = new System.Drawing.Point(11, 140);
            this.lblSelectedTileID.Name = "lblSelectedTileID";
            this.lblSelectedTileID.Size = new System.Drawing.Size(88, 13);
            this.lblSelectedTileID.TabIndex = 2;
            this.lblSelectedTileID.Text = "Selected Tile ID:";
            // 
            // chkTilesUseGrid
            // 
            this.chkTilesUseGrid.AutoSize = true;
            this.chkTilesUseGrid.Checked = true;
            this.chkTilesUseGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTilesUseGrid.Location = new System.Drawing.Point(16, 52);
            this.chkTilesUseGrid.Name = "chkTilesUseGrid";
            this.chkTilesUseGrid.Size = new System.Drawing.Size(48, 17);
            this.chkTilesUseGrid.TabIndex = 4;
            this.chkTilesUseGrid.Text = "Grid";
            this.chkTilesUseGrid.UseVisualStyleBackColor = true;
            this.chkTilesUseGrid.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // chkTilemapIndexed
            // 
            this.chkTilemapIndexed.AutoSize = true;
            this.chkTilemapIndexed.Location = new System.Drawing.Point(64, 52);
            this.chkTilemapIndexed.Name = "chkTilemapIndexed";
            this.chkTilemapIndexed.Size = new System.Drawing.Size(67, 17);
            this.chkTilemapIndexed.TabIndex = 5;
            this.chkTilemapIndexed.Text = "Indexed";
            this.chkTilemapIndexed.UseVisualStyleBackColor = true;
            this.chkTilemapIndexed.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // btnRevertTilemap
            // 
            this.btnRevertTilemap.Location = new System.Drawing.Point(8, 0);
            this.btnRevertTilemap.Name = "btnRevertTilemap";
            this.btnRevertTilemap.Size = new System.Drawing.Size(152, 23);
            this.btnRevertTilemap.TabIndex = 0;
            this.btnRevertTilemap.Text = "Revert Tilemap";
            this.btnRevertTilemap.UseVisualStyleBackColor = true;
            this.btnRevertTilemap.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // pnlSpriteList
            // 
            this.pnlSpriteList.Controls.Add(this.grpSpriteList);
            this.pnlSpriteList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpriteList.Location = new System.Drawing.Point(8, 4);
            this.pnlSpriteList.Name = "pnlSpriteList";
            this.pnlSpriteList.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.pnlSpriteList.Size = new System.Drawing.Size(184, 507);
            this.pnlSpriteList.TabIndex = 14;
            // 
            // grpSpriteList
            // 
            this.grpSpriteList.Controls.Add(this.pnlSpriteListBorder);
            this.grpSpriteList.Controls.Add(this.pnlSpriteListTools);
            this.grpSpriteList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSpriteList.Location = new System.Drawing.Point(0, 0);
            this.grpSpriteList.Name = "grpSpriteList";
            this.grpSpriteList.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpSpriteList.Size = new System.Drawing.Size(180, 507);
            this.grpSpriteList.TabIndex = 0;
            this.grpSpriteList.TabStop = false;
            this.grpSpriteList.Text = "Select Sprite To Edit";
            // 
            // pnlSpriteListBorder
            // 
            this.pnlSpriteListBorder.BackColor = System.Drawing.Color.DarkGray;
            this.pnlSpriteListBorder.Controls.Add(this.lstSprites);
            this.pnlSpriteListBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpriteListBorder.Location = new System.Drawing.Point(12, 72);
            this.pnlSpriteListBorder.Name = "pnlSpriteListBorder";
            this.pnlSpriteListBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlSpriteListBorder.Size = new System.Drawing.Size(156, 423);
            this.pnlSpriteListBorder.TabIndex = 1;
            // 
            // lstSprites
            // 
            this.lstSprites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSprites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSprites.FormattingEnabled = true;
            this.lstSprites.IntegralHeight = false;
            this.lstSprites.Location = new System.Drawing.Point(1, 1);
            this.lstSprites.Name = "lstSprites";
            this.lstSprites.Size = new System.Drawing.Size(154, 421);
            this.lstSprites.TabIndex = 0;
            this.lstSprites.SelectedIndexChanged += new System.EventHandler(this.lstSprites_SelectedIndexChanged);
            // 
            // pnlSpriteListTools
            // 
            this.pnlSpriteListTools.Controls.Add(this.chkViewUneditedSprite);
            this.pnlSpriteListTools.Controls.Add(this.lblSpriteTilemap);
            this.pnlSpriteListTools.Controls.Add(this.btnPreviousFrame);
            this.pnlSpriteListTools.Controls.Add(this.btnNextFrame);
            this.pnlSpriteListTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpriteListTools.Location = new System.Drawing.Point(12, 19);
            this.pnlSpriteListTools.Name = "pnlSpriteListTools";
            this.pnlSpriteListTools.Size = new System.Drawing.Size(156, 53);
            this.pnlSpriteListTools.TabIndex = 0;
            // 
            // chkViewUneditedSprite
            // 
            this.chkViewUneditedSprite.AutoSize = true;
            this.chkViewUneditedSprite.Location = new System.Drawing.Point(0, 32);
            this.chkViewUneditedSprite.Name = "chkViewUneditedSprite";
            this.chkViewUneditedSprite.Size = new System.Drawing.Size(135, 17);
            this.chkViewUneditedSprite.TabIndex = 3;
            this.chkViewUneditedSprite.Text = "View Unedited Sprite";
            this.chkViewUneditedSprite.UseVisualStyleBackColor = true;
            this.chkViewUneditedSprite.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // lblSpriteTilemap
            // 
            this.lblSpriteTilemap.AutoSize = true;
            this.lblSpriteTilemap.Location = new System.Drawing.Point(36, 8);
            this.lblSpriteTilemap.Name = "lblSpriteTilemap";
            this.lblSpriteTilemap.Size = new System.Drawing.Size(80, 13);
            this.lblSpriteTilemap.TabIndex = 1;
            this.lblSpriteTilemap.Text = "Sprite Tilemap";
            // 
            // btnPreviousFrame
            // 
            this.btnPreviousFrame.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousFrame.Location = new System.Drawing.Point(0, 3);
            this.btnPreviousFrame.Name = "btnPreviousFrame";
            this.btnPreviousFrame.Size = new System.Drawing.Size(25, 23);
            this.btnPreviousFrame.TabIndex = 0;
            this.btnPreviousFrame.Text = "<<";
            this.btnPreviousFrame.UseVisualStyleBackColor = true;
            this.btnPreviousFrame.Click += new System.EventHandler(this.btnFrame_Click);
            // 
            // btnNextFrame
            // 
            this.btnNextFrame.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextFrame.Location = new System.Drawing.Point(131, 3);
            this.btnNextFrame.Name = "btnNextFrame";
            this.btnNextFrame.Size = new System.Drawing.Size(25, 23);
            this.btnNextFrame.TabIndex = 2;
            this.btnNextFrame.Text = ">>";
            this.btnNextFrame.UseVisualStyleBackColor = true;
            this.btnNextFrame.Click += new System.EventHandler(this.btnFrame_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslObjectType,
            this.tsslInfo});
            this.ssMain.Location = new System.Drawing.Point(0, 539);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(784, 22);
            this.ssMain.TabIndex = 5;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsslObjectType
            // 
            this.tsslObjectType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslObjectType.Name = "tsslObjectType";
            this.tsslObjectType.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslInfo
            // 
            this.tsslInfo.Name = "tsslInfo";
            this.tsslInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // nudTilemapOffsetY
            // 
            this.nudTilemapOffsetY.Location = new System.Drawing.Point(304, 3);
            this.nudTilemapOffsetY.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTilemapOffsetY.Name = "nudTilemapOffsetY";
            this.nudTilemapOffsetY.Size = new System.Drawing.Size(40, 22);
            this.nudTilemapOffsetY.TabIndex = 11;
            // 
            // lblTilemapOffsetY
            // 
            this.lblTilemapOffsetY.AutoSize = true;
            this.lblTilemapOffsetY.Location = new System.Drawing.Point(288, 8);
            this.lblTilemapOffsetY.Name = "lblTilemapOffsetY";
            this.lblTilemapOffsetY.Size = new System.Drawing.Size(15, 13);
            this.lblTilemapOffsetY.TabIndex = 10;
            this.lblTilemapOffsetY.Text = "Y:";
            // 
            // nudTilemapOffsetX
            // 
            this.nudTilemapOffsetX.Location = new System.Drawing.Point(248, 3);
            this.nudTilemapOffsetX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTilemapOffsetX.Name = "nudTilemapOffsetX";
            this.nudTilemapOffsetX.Size = new System.Drawing.Size(40, 22);
            this.nudTilemapOffsetX.TabIndex = 9;
            // 
            // lblTilemapOffsetX
            // 
            this.lblTilemapOffsetX.AutoSize = true;
            this.lblTilemapOffsetX.Location = new System.Drawing.Point(232, 8);
            this.lblTilemapOffsetX.Name = "lblTilemapOffsetX";
            this.lblTilemapOffsetX.Size = new System.Drawing.Size(16, 13);
            this.lblTilemapOffsetX.TabIndex = 8;
            this.lblTilemapOffsetX.Text = "X:";
            // 
            // pnlSprite
            // 
            this.pnlSprite.AutoScroll = true;
            this.pnlSprite.AutoScrollMinSize = new System.Drawing.Size(405, 469);
            this.pnlSprite.BackColor = System.Drawing.Color.Black;
            this.pnlSprite.Canvas = new System.Drawing.Size(8, 8);
            this.pnlSprite.Centered = true;
            this.pnlSprite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSprite.HatchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.pnlSprite.HatchForeColor = System.Drawing.Color.White;
            this.pnlSprite.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlSprite.Image = null;
            this.pnlSprite.ImageAlpha = 1F;
            this.pnlSprite.ImageScale = 1;
            this.pnlSprite.Location = new System.Drawing.Point(3, 3);
            this.pnlSprite.MinimumScale = 1;
            this.pnlSprite.Name = "pnlSprite";
            this.pnlSprite.Size = new System.Drawing.Size(405, 469);
            this.pnlSprite.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlSprite.TabIndex = 0;
            this.pnlSprite.UseCanvas = false;
            this.pnlSprite.UseHatch = true;
            this.pnlSprite.UseMouseWheelScaling = true;
            this.pnlSprite.Click += new System.EventHandler(this.pnlColorPicker_Click);
            // 
            // pnlPaletteEdit
            // 
            this.pnlPaletteEdit.Location = new System.Drawing.Point(14, 24);
            this.pnlPaletteEdit.Name = "pnlPaletteEdit";
            this.pnlPaletteEdit.Size = new System.Drawing.Size(127, 94);
            this.pnlPaletteEdit.TabIndex = 0;
            this.pnlPaletteEdit.SelectedColorChanged += new GoldenAxeEditor.Controls.PaletteEditControl.SelectedColorChangedHandler(this.pnlPaletteEdit_SelectedColorChanged);
            // 
            // pnlSelectedColor
            // 
            this.pnlSelectedColor.AutoScroll = true;
            this.pnlSelectedColor.AutoScrollMinSize = new System.Drawing.Size(152, 14);
            this.pnlSelectedColor.BackColor = System.Drawing.Color.White;
            this.pnlSelectedColor.Canvas = new System.Drawing.Size(8, 8);
            this.pnlSelectedColor.Centered = false;
            this.pnlSelectedColor.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlSelectedColor.HatchForeColor = System.Drawing.Color.White;
            this.pnlSelectedColor.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlSelectedColor.Image = null;
            this.pnlSelectedColor.ImageAlpha = 1F;
            this.pnlSelectedColor.ImageScale = 1;
            this.pnlSelectedColor.Location = new System.Drawing.Point(8, 96);
            this.pnlSelectedColor.MinimumScale = 1;
            this.pnlSelectedColor.Name = "pnlSelectedColor";
            this.pnlSelectedColor.Selected = false;
            this.pnlSelectedColor.Size = new System.Drawing.Size(152, 14);
            this.pnlSelectedColor.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlSelectedColor.TabIndex = 4;
            this.pnlSelectedColor.UseCanvas = false;
            this.pnlSelectedColor.UseHatch = false;
            this.pnlSelectedColor.UseMouseWheelScaling = false;
            // 
            // pnlColorPicker
            // 
            this.pnlColorPicker.AutoScroll = true;
            this.pnlColorPicker.AutoScrollMinSize = new System.Drawing.Size(162, 139);
            this.pnlColorPicker.Canvas = new System.Drawing.Size(162, 139);
            this.pnlColorPicker.Centered = false;
            this.pnlColorPicker.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColorPicker.HatchForeColor = System.Drawing.Color.White;
            this.pnlColorPicker.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColorPicker.Image = global::GoldenAxeEditor.Properties.Resources.color_wheel;
            this.pnlColorPicker.ImageAlpha = 1F;
            this.pnlColorPicker.ImageScale = 1;
            this.pnlColorPicker.Location = new System.Drawing.Point(3, 128);
            this.pnlColorPicker.MinimumScale = 1;
            this.pnlColorPicker.Name = "pnlColorPicker";
            this.pnlColorPicker.Size = new System.Drawing.Size(165, 144);
            this.pnlColorPicker.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColorPicker.TabIndex = 6;
            this.pnlColorPicker.UseCanvas = false;
            this.pnlColorPicker.UseHatch = false;
            this.pnlColorPicker.UseMouseWheelScaling = false;
            this.pnlColorPicker.Click += new System.EventHandler(this.pnlColorPicker_Click);
            // 
            // pnlTileset
            // 
            this.pnlTileset.AutoScroll = true;
            this.pnlTileset.AutoScrollMinSize = new System.Drawing.Size(8, 8);
            this.pnlTileset.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTileset.Centered = true;
            this.pnlTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTileset.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTileset.HatchForeColor = System.Drawing.Color.White;
            this.pnlTileset.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTileset.Image = null;
            this.pnlTileset.ImageAlpha = 1F;
            this.pnlTileset.ImageScale = 1;
            this.pnlTileset.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pnlTileset.Indexed = false;
            this.pnlTileset.Location = new System.Drawing.Point(3, 32);
            this.pnlTileset.MinimumScale = 1;
            this.pnlTileset.Name = "pnlTileset";
            this.pnlTileset.Size = new System.Drawing.Size(405, 440);
            this.pnlTileset.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTileset.TabIndex = 1;
            this.pnlTileset.UseCanvas = true;
            this.pnlTileset.UseGrid = true;
            this.pnlTileset.UseHatch = true;
            this.pnlTileset.UseMouseWheelScaling = true;
            this.pnlTileset.TileSelectionChanged += new GoldenAxeEditor.Controls.TilesetEditControl.TileSelectionHandler(this.pnlTileset_TileSelectionChanged);
            this.pnlTileset.TilesChanged += new GoldenAxeEditor.Controls.TilesetEditControl.TilesChangedHandler(this.pnlTileset_TileChanged);
            // 
            // pnlTile
            // 
            this.pnlTile.AutoScroll = true;
            this.pnlTile.AutoScrollMinSize = new System.Drawing.Size(144, 144);
            this.pnlTile.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTile.Centered = false;
            this.pnlTile.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTile.HatchForeColor = System.Drawing.Color.White;
            this.pnlTile.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTile.Image = null;
            this.pnlTile.ImageAlpha = 1F;
            this.pnlTile.ImageScale = 1;
            this.pnlTile.Location = new System.Drawing.Point(12, 138);
            this.pnlTile.MinimumScale = 1;
            this.pnlTile.Name = "pnlTile";
            this.pnlTile.Palette = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("pnlTile.Palette")));
            this.pnlTile.Pixels = ((System.Collections.Generic.List<byte>)(resources.GetObject("pnlTile.Pixels")));
            this.pnlTile.Size = new System.Drawing.Size(144, 144);
            this.pnlTile.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTile.TabIndex = 7;
            this.pnlTile.UseCanvas = false;
            this.pnlTile.UseHatch = true;
            this.pnlTile.UseMouseWheelScaling = false;
            // 
            // pnlTilemap
            // 
            this.pnlTilemap.AutoScroll = true;
            this.pnlTilemap.AutoScrollMinSize = new System.Drawing.Size(405, 440);
            this.pnlTilemap.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTilemap.Centered = true;
            this.pnlTilemap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilemap.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTilemap.HatchForeColor = System.Drawing.Color.White;
            this.pnlTilemap.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTilemap.Image = null;
            this.pnlTilemap.ImageAlpha = 1F;
            this.pnlTilemap.ImageScale = 1;
            this.pnlTilemap.Indexed = false;
            this.pnlTilemap.Location = new System.Drawing.Point(3, 32);
            this.pnlTilemap.MinimumScale = 1;
            this.pnlTilemap.Name = "pnlTilemap";
            this.pnlTilemap.Size = new System.Drawing.Size(405, 440);
            this.pnlTilemap.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTilemap.TabIndex = 1;
            this.pnlTilemap.UseCanvas = false;
            this.pnlTilemap.UseGrid = true;
            this.pnlTilemap.UseHatch = true;
            this.pnlTilemap.UseMouseWheelScaling = true;
            this.pnlTilemap.TileChanged += new GoldenAxeEditor.Controls.TilemapEditControl.TileChangedHandler(this.pnlTilemap_TileChanged);
            // 
            // pnlTiles
            // 
            this.pnlTiles.AllowSelection = true;
            this.pnlTiles.AutoScroll = true;
            this.pnlTiles.AutoScrollMinSize = new System.Drawing.Size(444, 876);
            this.pnlTiles.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTiles.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTiles.Centered = false;
            this.pnlTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTiles.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTiles.HatchForeColor = System.Drawing.Color.White;
            this.pnlTiles.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTiles.Image = null;
            this.pnlTiles.ImageAlpha = 1F;
            this.pnlTiles.ImageScale = 3;
            this.pnlTiles.Indexed = false;
            this.pnlTiles.Location = new System.Drawing.Point(0, 160);
            this.pnlTiles.MinimumScale = 1;
            this.pnlTiles.Name = "pnlTiles";
            this.pnlTiles.Offset = 0;
            this.pnlTiles.Size = new System.Drawing.Size(165, 309);
            this.pnlTiles.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTiles.TabIndex = 1;
            this.pnlTiles.TileCount = 0;
            this.pnlTiles.TileID = 0;
            this.pnlTiles.UseCanvas = false;
            this.pnlTiles.UseGrid = true;
            this.pnlTiles.UseHatch = false;
            this.pnlTiles.UseMouseWheelScaling = false;
            this.pnlTiles.TileSelectionChanged += new GoldenAxeEditor.Controls.TilesControl.TileSelectionHandler(this.pnlTiles_TileSelectionChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.ssMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS Golden Axe Editor";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlSpriteEditor.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabSprite.ResumeLayout(false);
            this.pnlSpriteTools.ResumeLayout(false);
            this.pnlSpriteTools.PerformLayout();
            this.grpEditPalette.ResumeLayout(false);
            this.tabTileset.ResumeLayout(false);
            this.pnlTilesetDataEdit.ResumeLayout(false);
            this.pnlTilesetDataEdit.PerformLayout();
            this.pnlTilesetTools.ResumeLayout(false);
            this.pnlTilesetTools.PerformLayout();
            this.tabTilemap.ResumeLayout(false);
            this.pnlTilemapDataEdit.ResumeLayout(false);
            this.pnlTilemapDataEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapColumns)).EndInit();
            this.pnlTilemapTools.ResumeLayout(false);
            this.pnlTilemapToolsContainer.ResumeLayout(false);
            this.pnlTilemapToolsContainer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlSpriteList.ResumeLayout(false);
            this.grpSpriteList.ResumeLayout(false);
            this.pnlSpriteListBorder.ResumeLayout(false);
            this.pnlSpriteListTools.ResumeLayout(false);
            this.pnlSpriteListTools.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapOffsetX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenProject;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuDataInjection;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslObjectType;
        private System.Windows.Forms.ToolStripStatusLabel tsslInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuExport;
        private System.Windows.Forms.ToolStripMenuItem mnuExportBinarySMS;
        private System.Windows.Forms.ToolStripMenuItem mnuExportSpriteImage;
        private System.Windows.Forms.ToolStripMenuItem mnuExportTilesetImage;
        private System.Windows.Forms.ToolStripMenuItem mnuExportTilesetHex;
        private System.Windows.Forms.ToolStripMenuItem mnuExportTilemapHex;
        private System.Windows.Forms.Button btnNextFrame;
        private System.Windows.Forms.Button btnPreviousFrame;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenROM;
        private System.Windows.Forms.Panel pnlSpriteList;
        private System.Windows.Forms.GroupBox grpSpriteList;
        private System.Windows.Forms.ListBox lstSprites;
        private System.Windows.Forms.Panel pnlSpriteListTools;
        private System.Windows.Forms.Label lblSpriteTilemap;
        private System.Windows.Forms.Panel pnlSpriteEditor;
        private System.Windows.Forms.Panel pnlSpriteListBorder;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSprite;
        private Controls.ImageControl pnlSprite;
        private System.Windows.Forms.TabPage tabTileset;
        private System.Windows.Forms.Panel pnlTilesetTools;
        private System.Windows.Forms.CheckBox chkTilesetIndexed;
        private System.Windows.Forms.Button btnRevertTileset;
        private System.Windows.Forms.TabPage tabTilemap;
        private System.Windows.Forms.CheckBox chkTilemapIndexed;
        private System.Windows.Forms.Button btnRevertTilemap;
        private Controls.TilesControl pnlTiles;
        private System.Windows.Forms.CheckBox chkTilesUseGrid;
        private Controls.TilesetEditControl pnlTileset;
        private System.Windows.Forms.Button btnDeselectTile;
        private System.Windows.Forms.Button btnDeleteTile;
        private System.Windows.Forms.CheckBox chkTilesetUseGrid;
        private Controls.TilemapEditControl pnlTilemap;
        private System.Windows.Forms.Panel pnlSpriteTools;
        private System.Windows.Forms.Button btnRevertSprite;
        private System.Windows.Forms.Button btnImportSprite;
        private Controls.ImageControl pnlColorPicker;
        private System.Windows.Forms.Button btnRevertPalette;
        private System.Windows.Forms.Label lblSelectedColorValues;
        private System.Windows.Forms.Label lblSelectedColor;
        private Controls.ColorControl pnlSelectedColor;
        private System.Windows.Forms.CheckBox chkViewUneditedSprite;
        private System.Windows.Forms.Label lblSelectedTileIDValue;
        private System.Windows.Forms.Label lblSelectedTileID;
        private System.Windows.Forms.GroupBox grpEditPalette;
        private Controls.PaletteEditControl pnlPaletteEdit;
        private System.Windows.Forms.Label lblSelectedPaletteColorValues;
        private System.Windows.Forms.Button btnReplaceTiles;
        private System.Windows.Forms.Panel pnlTilemapTools;
        private System.Windows.Forms.Panel pnlTilemapToolsContainer;
        private System.Windows.Forms.CheckBox chkTilePriority;
        private System.Windows.Forms.CheckBox chkTilePalette;
        private System.Windows.Forms.CheckBox chkTileYFlip;
        private System.Windows.Forms.CheckBox chkTileXFlip;
        private System.Windows.Forms.Label label1;
        private Controls.TileControl pnlTile;
        private System.Windows.Forms.Label lblTilesetPosition;
        private System.Windows.Forms.Label lblTilesetLength;
        private System.Windows.Forms.TextBox txtTilesetPosition;
        private System.Windows.Forms.TextBox txtTilesetLength;
        private System.Windows.Forms.Button btnTilesetUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnImportTileset;
        private System.Windows.Forms.Panel pnlTilemapDataEdit;
        private System.Windows.Forms.NumericUpDown nudTilemapRows;
        private System.Windows.Forms.Label lblTilemapRows;
        private System.Windows.Forms.NumericUpDown nudTilemapColumns;
        private System.Windows.Forms.Label lblTilemapColumns;
        private System.Windows.Forms.Label lblTilemapPosition;
        private System.Windows.Forms.TextBox txtTilemapPosition;
        private System.Windows.Forms.Button btnTilemapUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuPaletteEdit;
        private System.Windows.Forms.ToolStripMenuItem textEditToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTilesetDataEdit;
        private System.Windows.Forms.CheckBox chkTilesetOverride;
        private System.Windows.Forms.NumericUpDown nudTilemapOffsetY;
        private System.Windows.Forms.Label lblTilemapOffsetY;
        private System.Windows.Forms.NumericUpDown nudTilemapOffsetX;
        private System.Windows.Forms.Label lblTilemapOffsetX;
    }
}

