
namespace MMS_Darko_Stosic_16413
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossLaplacianToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectHomogenityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yUVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.shannonFanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.downsampleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.downsampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.view1Slika = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view1Slika)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.yUVToolStripMenuItem,
            this.shannonFanoToolStripMenuItem,
            this.downsampleToolStripMenuItem1,
            this.downsampleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pixelateToolStripMenuItem,
            this.gammaToolStripMenuItem,
            this.embossLaplacianToolStripMenuItem1,
            this.edgeDetectHomogenityToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // pixelateToolStripMenuItem
            // 
            this.pixelateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridToolStripMenuItem,
            this.noGridToolStripMenuItem});
            this.pixelateToolStripMenuItem.Name = "pixelateToolStripMenuItem";
            this.pixelateToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.pixelateToolStripMenuItem.Text = "Pixelate";
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.gridToolStripMenuItem.Text = "Grid";
            this.gridToolStripMenuItem.Click += new System.EventHandler(this.gridToolStripMenuItem_Click);
            // 
            // noGridToolStripMenuItem
            // 
            this.noGridToolStripMenuItem.Name = "noGridToolStripMenuItem";
            this.noGridToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.noGridToolStripMenuItem.Text = "NoGrid";
            this.noGridToolStripMenuItem.Click += new System.EventHandler(this.noGridToolStripMenuItem_Click);
            // 
            // gammaToolStripMenuItem
            // 
            this.gammaToolStripMenuItem.Name = "gammaToolStripMenuItem";
            this.gammaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.gammaToolStripMenuItem.Text = "Gamma";
            this.gammaToolStripMenuItem.Click += new System.EventHandler(this.gammaToolStripMenuItem_Click);
            // 
            // embossLaplacianToolStripMenuItem1
            // 
            this.embossLaplacianToolStripMenuItem1.Name = "embossLaplacianToolStripMenuItem1";
            this.embossLaplacianToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.embossLaplacianToolStripMenuItem1.Text = "Emboss Laplacian";
            this.embossLaplacianToolStripMenuItem1.Click += new System.EventHandler(this.embossLaplacianToolStripMenuItem1_Click);
            // 
            // edgeDetectHomogenityToolStripMenuItem
            // 
            this.edgeDetectHomogenityToolStripMenuItem.Name = "edgeDetectHomogenityToolStripMenuItem";
            this.edgeDetectHomogenityToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.edgeDetectHomogenityToolStripMenuItem.Text = "Edge Detect Homogenity";
            this.edgeDetectHomogenityToolStripMenuItem.Click += new System.EventHandler(this.edgeDetectHomogenityToolStripMenuItem_Click);
            // 
            // yUVToolStripMenuItem
            // 
            this.yUVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem3,
            this.loadToolStripMenuItem3});
            this.yUVToolStripMenuItem.Name = "yUVToolStripMenuItem";
            this.yUVToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.yUVToolStripMenuItem.Text = "YUV";
            // 
            // saveToolStripMenuItem3
            // 
            this.saveToolStripMenuItem3.Name = "saveToolStripMenuItem3";
            this.saveToolStripMenuItem3.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem3.Text = "Save";
            this.saveToolStripMenuItem3.Click += new System.EventHandler(this.saveToolStripMenuItem3_Click);
            // 
            // loadToolStripMenuItem3
            // 
            this.loadToolStripMenuItem3.Name = "loadToolStripMenuItem3";
            this.loadToolStripMenuItem3.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem3.Text = "Load";
            this.loadToolStripMenuItem3.Click += new System.EventHandler(this.loadToolStripMenuItem3_Click);
            // 
            // shannonFanoToolStripMenuItem
            // 
            this.shannonFanoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.loadToolStripMenuItem1});
            this.shannonFanoToolStripMenuItem.Name = "shannonFanoToolStripMenuItem";
            this.shannonFanoToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.shannonFanoToolStripMenuItem.Text = "Shannon-Fano";
            this.shannonFanoToolStripMenuItem.Click += new System.EventHandler(this.shannonFanoToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem1.Text = "Load";
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.loadToolStripMenuItem1_Click);
            // 
            // downsampleToolStripMenuItem1
            // 
            this.downsampleToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem4,
            this.loadToolStripMenuItem4});
            this.downsampleToolStripMenuItem1.Name = "downsampleToolStripMenuItem1";
            this.downsampleToolStripMenuItem1.Size = new System.Drawing.Size(88, 20);
            this.downsampleToolStripMenuItem1.Text = "Downsample";
            // 
            // saveToolStripMenuItem4
            // 
            this.saveToolStripMenuItem4.Name = "saveToolStripMenuItem4";
            this.saveToolStripMenuItem4.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem4.Text = "Save";
            this.saveToolStripMenuItem4.Click += new System.EventHandler(this.saveToolStripMenuItem4_Click);
            // 
            // loadToolStripMenuItem4
            // 
            this.loadToolStripMenuItem4.Name = "loadToolStripMenuItem4";
            this.loadToolStripMenuItem4.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem4.Text = "Load";
            this.loadToolStripMenuItem4.Click += new System.EventHandler(this.loadToolStripMenuItem4_Click);
            // 
            // downsampleToolStripMenuItem
            // 
            this.downsampleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem2,
            this.loadToolStripMenuItem2});
            this.downsampleToolStripMenuItem.Name = "downsampleToolStripMenuItem";
            this.downsampleToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.downsampleToolStripMenuItem.Text = "Downsample + Shannon";
            // 
            // saveToolStripMenuItem2
            // 
            this.saveToolStripMenuItem2.Name = "saveToolStripMenuItem2";
            this.saveToolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem2.Text = "Save";
            this.saveToolStripMenuItem2.Click += new System.EventHandler(this.saveToolStripMenuItem2_Click);
            // 
            // loadToolStripMenuItem2
            // 
            this.loadToolStripMenuItem2.Name = "loadToolStripMenuItem2";
            this.loadToolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem2.Text = "Load";
            this.loadToolStripMenuItem2.Click += new System.EventHandler(this.loadToolStripMenuItem2_Click);
            // 
            // view1Slika
            // 
            this.view1Slika.Location = new System.Drawing.Point(140, 43);
            this.view1Slika.Margin = new System.Windows.Forms.Padding(2);
            this.view1Slika.Name = "view1Slika";
            this.view1Slika.Size = new System.Drawing.Size(476, 270);
            this.view1Slika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.view1Slika.TabIndex = 2;
            this.view1Slika.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.view1Slika);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MMS ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view1Slika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox view1Slika;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossLaplacianToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectHomogenityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shannonFanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem downsampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem yUVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem downsampleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    }
}

