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
    partial class ImportForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlTiles = new GoldenAxeEditor.Controls.ImageControl();
            this.grpIndexAdjustment = new System.Windows.Forms.GroupBox();
            this.pnlColorIndexes = new GoldenAxeEditor.Controls.ColorEditControl();
            this.chkIgnoreEmpty = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.grpIndexAdjustment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(152, 400);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlTiles);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(12, 8, 12, 12);
            this.groupBox1.Size = new System.Drawing.Size(296, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tileset";
            // 
            // pnlTiles
            // 
            this.pnlTiles.AutoScroll = true;
            this.pnlTiles.AutoScrollMinSize = new System.Drawing.Size(272, 261);
            this.pnlTiles.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTiles.Centered = true;
            this.pnlTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTiles.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTiles.HatchForeColor = System.Drawing.Color.White;
            this.pnlTiles.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTiles.Image = null;
            this.pnlTiles.ImageAlpha = 1F;
            this.pnlTiles.ImageScale = 1;
            this.pnlTiles.Location = new System.Drawing.Point(12, 23);
            this.pnlTiles.MinimumScale = 1;
            this.pnlTiles.Name = "pnlTiles";
            this.pnlTiles.Size = new System.Drawing.Size(272, 261);
            this.pnlTiles.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTiles.TabIndex = 0;
            this.pnlTiles.UseCanvas = false;
            this.pnlTiles.UseHatch = true;
            this.pnlTiles.UseMouseWheelScaling = true;
            // 
            // grpIndexAdjustment
            // 
            this.grpIndexAdjustment.Controls.Add(this.pnlColorIndexes);
            this.grpIndexAdjustment.Location = new System.Drawing.Point(8, 312);
            this.grpIndexAdjustment.Name = "grpIndexAdjustment";
            this.grpIndexAdjustment.Size = new System.Drawing.Size(296, 80);
            this.grpIndexAdjustment.TabIndex = 1;
            this.grpIndexAdjustment.TabStop = false;
            this.grpIndexAdjustment.Text = "Import Color Edit";
            // 
            // pnlColorIndexes
            // 
            this.pnlColorIndexes.Location = new System.Drawing.Point(12, 24);
            this.pnlColorIndexes.Name = "pnlColorIndexes";
            this.pnlColorIndexes.Size = new System.Drawing.Size(274, 47);
            this.pnlColorIndexes.TabIndex = 0;
            this.pnlColorIndexes.ColorShifted += new GoldenAxeEditor.Controls.ColorEditControl.ColorShiftedHandler(this.pnlColorIndexes_ColorShifted);
            // 
            // chkIgnoreEmpty
            // 
            this.chkIgnoreEmpty.AutoSize = true;
            this.chkIgnoreEmpty.Location = new System.Drawing.Point(8, 403);
            this.chkIgnoreEmpty.Name = "chkIgnoreEmpty";
            this.chkIgnoreEmpty.Size = new System.Drawing.Size(120, 17);
            this.chkIgnoreEmpty.TabIndex = 3;
            this.chkIgnoreEmpty.Text = "Ignore Empty Tiles";
            this.chkIgnoreEmpty.UseVisualStyleBackColor = true;
            this.chkIgnoreEmpty.CheckedChanged += new System.EventHandler(this.chkIgnoreEmpty_CheckedChanged);
            // 
            // ImportSpriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 431);
            this.Controls.Add(this.chkIgnoreEmpty);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpIndexAdjustment);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportSpriteForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import";
            this.groupBox1.ResumeLayout(false);
            this.grpIndexAdjustment.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.ImageControl pnlTiles;
        private System.Windows.Forms.GroupBox grpIndexAdjustment;
        private Controls.ColorEditControl pnlColorIndexes;
        private System.Windows.Forms.CheckBox chkIgnoreEmpty;
    }
}