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
    partial class PaletteEditForm
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
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.lblSelectedPaletteColorValues = new System.Windows.Forms.Label();
            this.grpEditPalette = new System.Windows.Forms.GroupBox();
            this.pnlPaletteEdit = new GoldenAxeEditor.Controls.PaletteEditControl();
            this.lblSelectedColorValues = new System.Windows.Forms.Label();
            this.pnlSelectedColor = new GoldenAxeEditor.Controls.ColorControl();
            this.pnlColorPicker = new GoldenAxeEditor.Controls.ImageControl();
            this.lblSelectedColor = new System.Windows.Forms.Label();
            this.grpPalettes = new System.Windows.Forms.GroupBox();
            this.pnlPaletteListBorder = new System.Windows.Forms.Panel();
            this.lstPalettes = new System.Windows.Forms.ListBox();
            this.grpEdit.SuspendLayout();
            this.grpEditPalette.SuspendLayout();
            this.grpPalettes.SuspendLayout();
            this.pnlPaletteListBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEdit
            // 
            this.grpEdit.Controls.Add(this.lblSelectedPaletteColorValues);
            this.grpEdit.Controls.Add(this.grpEditPalette);
            this.grpEdit.Controls.Add(this.lblSelectedColorValues);
            this.grpEdit.Controls.Add(this.pnlSelectedColor);
            this.grpEdit.Controls.Add(this.pnlColorPicker);
            this.grpEdit.Controls.Add(this.lblSelectedColor);
            this.grpEdit.Location = new System.Drawing.Point(184, 8);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(168, 368);
            this.grpEdit.TabIndex = 1;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "Edit";
            // 
            // lblSelectedPaletteColorValues
            // 
            this.lblSelectedPaletteColorValues.Location = new System.Drawing.Point(6, 346);
            this.lblSelectedPaletteColorValues.Name = "lblSelectedPaletteColorValues";
            this.lblSelectedPaletteColorValues.Size = new System.Drawing.Size(158, 13);
            this.lblSelectedPaletteColorValues.TabIndex = 5;
            this.lblSelectedPaletteColorValues.Text = "Red: 0 Green: 0 Blue: 0";
            this.lblSelectedPaletteColorValues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpEditPalette
            // 
            this.grpEditPalette.Controls.Add(this.pnlPaletteEdit);
            this.grpEditPalette.Location = new System.Drawing.Point(8, 218);
            this.grpEditPalette.Name = "grpEditPalette";
            this.grpEditPalette.Size = new System.Drawing.Size(152, 128);
            this.grpEditPalette.TabIndex = 4;
            this.grpEditPalette.TabStop = false;
            this.grpEditPalette.Text = "Edit Palette";
            // 
            // pnlPaletteEdit
            // 
            this.pnlPaletteEdit.Location = new System.Drawing.Point(14, 24);
            this.pnlPaletteEdit.Name = "pnlPaletteEdit";
            this.pnlPaletteEdit.Size = new System.Drawing.Size(127, 94);
            this.pnlPaletteEdit.TabIndex = 0;
            this.pnlPaletteEdit.SelectedColorChanged += new GoldenAxeEditor.Controls.PaletteEditControl.SelectedColorChangedHandler(this.pnlPaletteEdit_SelectedColorChanged);
            // 
            // lblSelectedColorValues
            // 
            this.lblSelectedColorValues.Location = new System.Drawing.Point(6, 58);
            this.lblSelectedColorValues.Name = "lblSelectedColorValues";
            this.lblSelectedColorValues.Size = new System.Drawing.Size(158, 13);
            this.lblSelectedColorValues.TabIndex = 2;
            this.lblSelectedColorValues.Text = "Red: 255 Green: 255 Blue: 255";
            this.lblSelectedColorValues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlSelectedColor.Location = new System.Drawing.Point(8, 42);
            this.pnlSelectedColor.MinimumScale = 1;
            this.pnlSelectedColor.Name = "pnlSelectedColor";
            this.pnlSelectedColor.Selected = false;
            this.pnlSelectedColor.Size = new System.Drawing.Size(152, 14);
            this.pnlSelectedColor.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlSelectedColor.TabIndex = 1;
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
            this.pnlColorPicker.Location = new System.Drawing.Point(3, 74);
            this.pnlColorPicker.MinimumScale = 1;
            this.pnlColorPicker.Name = "pnlColorPicker";
            this.pnlColorPicker.Size = new System.Drawing.Size(165, 144);
            this.pnlColorPicker.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColorPicker.TabIndex = 3;
            this.pnlColorPicker.UseCanvas = false;
            this.pnlColorPicker.UseHatch = false;
            this.pnlColorPicker.UseMouseWheelScaling = false;
            this.pnlColorPicker.Click += new System.EventHandler(this.pnlColorPicker_Click);
            // 
            // lblSelectedColor
            // 
            this.lblSelectedColor.AutoSize = true;
            this.lblSelectedColor.Location = new System.Drawing.Point(8, 24);
            this.lblSelectedColor.Name = "lblSelectedColor";
            this.lblSelectedColor.Size = new System.Drawing.Size(84, 13);
            this.lblSelectedColor.TabIndex = 0;
            this.lblSelectedColor.Text = "Selected Color:";
            // 
            // grpPalettes
            // 
            this.grpPalettes.Controls.Add(this.pnlPaletteListBorder);
            this.grpPalettes.Location = new System.Drawing.Point(8, 8);
            this.grpPalettes.Name = "grpPalettes";
            this.grpPalettes.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpPalettes.Size = new System.Drawing.Size(168, 368);
            this.grpPalettes.TabIndex = 0;
            this.grpPalettes.TabStop = false;
            this.grpPalettes.Text = "Palettes";
            // 
            // pnlPaletteListBorder
            // 
            this.pnlPaletteListBorder.BackColor = System.Drawing.Color.DarkGray;
            this.pnlPaletteListBorder.Controls.Add(this.lstPalettes);
            this.pnlPaletteListBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaletteListBorder.Location = new System.Drawing.Point(12, 19);
            this.pnlPaletteListBorder.Name = "pnlPaletteListBorder";
            this.pnlPaletteListBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlPaletteListBorder.Size = new System.Drawing.Size(144, 337);
            this.pnlPaletteListBorder.TabIndex = 2;
            // 
            // lstPalettes
            // 
            this.lstPalettes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPalettes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPalettes.FormattingEnabled = true;
            this.lstPalettes.IntegralHeight = false;
            this.lstPalettes.Location = new System.Drawing.Point(1, 1);
            this.lstPalettes.Name = "lstPalettes";
            this.lstPalettes.Size = new System.Drawing.Size(142, 335);
            this.lstPalettes.TabIndex = 0;
            this.lstPalettes.SelectedIndexChanged += new System.EventHandler(this.lstPalettes_SelectedIndexChanged);
            // 
            // PaletteEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 385);
            this.Controls.Add(this.grpPalettes);
            this.Controls.Add(this.grpEdit);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaletteEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Palette Edit";
            this.grpEdit.ResumeLayout(false);
            this.grpEdit.PerformLayout();
            this.grpEditPalette.ResumeLayout(false);
            this.grpPalettes.ResumeLayout(false);
            this.pnlPaletteListBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.Label lblSelectedPaletteColorValues;
        private System.Windows.Forms.GroupBox grpEditPalette;
        private Controls.PaletteEditControl pnlPaletteEdit;
        private System.Windows.Forms.Label lblSelectedColorValues;
        private Controls.ColorControl pnlSelectedColor;
        private Controls.ImageControl pnlColorPicker;
        private System.Windows.Forms.Label lblSelectedColor;
        private System.Windows.Forms.GroupBox grpPalettes;
        private System.Windows.Forms.Panel pnlPaletteListBorder;
        private System.Windows.Forms.ListBox lstPalettes;
    }
}