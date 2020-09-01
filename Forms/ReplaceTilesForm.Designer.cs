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
    partial class ReplaceTilesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlTiles = new GoldenAxeEditor.Controls.TilesControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tilesControl1 = new GoldenAxeEditor.Controls.TilesControl();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlTiles);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(12, 8, 12, 12);
            this.groupBox1.Size = new System.Drawing.Size(184, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target";
            // 
            // pnlTiles
            // 
            this.pnlTiles.AllowSelection = true;
            this.pnlTiles.AutoScroll = true;
            this.pnlTiles.AutoScrollMinSize = new System.Drawing.Size(435, 762);
            this.pnlTiles.BackColor = System.Drawing.Color.White;
            this.pnlTiles.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTiles.Centered = false;
            this.pnlTiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTiles.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTiles.HatchForeColor = System.Drawing.Color.White;
            this.pnlTiles.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTiles.Image = null;
            this.pnlTiles.ImageAlpha = 1F;
            this.pnlTiles.ImageScale = 3;
            this.pnlTiles.Indexed = false;
            this.pnlTiles.Location = new System.Drawing.Point(12, 21);
            this.pnlTiles.MinimumScale = 1;
            this.pnlTiles.Name = "pnlTiles";
            this.pnlTiles.Offset = 0;
            this.pnlTiles.Size = new System.Drawing.Size(162, 271);
            this.pnlTiles.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTiles.TabIndex = 2;
            this.pnlTiles.TileCount = 0;
            this.pnlTiles.TileID = 0;
            this.pnlTiles.UseCanvas = false;
            this.pnlTiles.UseGrid = true;
            this.pnlTiles.UseHatch = true;
            this.pnlTiles.UseMouseWheelScaling = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tilesControl1);
            this.groupBox2.Location = new System.Drawing.Point(200, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(12, 8, 12, 12);
            this.groupBox2.Size = new System.Drawing.Size(184, 304);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Replacement";
            // 
            // tilesControl1
            // 
            this.tilesControl1.AllowSelection = true;
            this.tilesControl1.AutoScroll = true;
            this.tilesControl1.AutoScrollMinSize = new System.Drawing.Size(435, 762);
            this.tilesControl1.BackColor = System.Drawing.Color.White;
            this.tilesControl1.Canvas = new System.Drawing.Size(8, 8);
            this.tilesControl1.Centered = false;
            this.tilesControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tilesControl1.HatchBackColor = System.Drawing.Color.DarkGray;
            this.tilesControl1.HatchForeColor = System.Drawing.Color.White;
            this.tilesControl1.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.tilesControl1.Image = null;
            this.tilesControl1.ImageAlpha = 1F;
            this.tilesControl1.ImageScale = 3;
            this.tilesControl1.Indexed = false;
            this.tilesControl1.Location = new System.Drawing.Point(12, 21);
            this.tilesControl1.MinimumScale = 1;
            this.tilesControl1.Name = "tilesControl1";
            this.tilesControl1.Offset = 0;
            this.tilesControl1.Size = new System.Drawing.Size(162, 271);
            this.tilesControl1.SnapSize = new System.Drawing.Size(8, 8);
            this.tilesControl1.TabIndex = 2;
            this.tilesControl1.TileCount = 0;
            this.tilesControl1.TileID = 0;
            this.tilesControl1.UseCanvas = false;
            this.tilesControl1.UseGrid = true;
            this.tilesControl1.UseHatch = true;
            this.tilesControl1.UseMouseWheelScaling = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(308, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(228, 320);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // ReplaceTilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 350);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceTilesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Replace Tiles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.TilesControl pnlTiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controls.TilesControl tilesControl1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}