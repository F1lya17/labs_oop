using lab_6.Figures;

namespace lab_6
{
    partial class Form1
    {
        figureContainer container = new figureContainer();
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.sizeBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.figures = new System.Windows.Forms.ToolStripMenuItem();
            this.circleItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chColor = new System.Windows.Forms.ToolStripMenuItem();
            this.group = new System.Windows.Forms.ToolStripMenuItem();
            this.ungroup = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.load = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeBar
            // 
            this.sizeBar.Location = new System.Drawing.Point(360, 0);
            this.sizeBar.Maximum = 200;
            this.sizeBar.Minimum = 20;
            this.sizeBar.Name = "sizeBar";
            this.sizeBar.Size = new System.Drawing.Size(113, 56);
            this.sizeBar.TabIndex = 4;
            this.sizeBar.Value = 50;
            this.sizeBar.ValueChanged += new System.EventHandler(this.sizeBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Size";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figures,
            this.chColor,
            this.group,
            this.ungroup,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // figures
            // 
            this.figures.Checked = true;
            this.figures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.figures.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circleItem,
            this.triangleItem,
            this.squareItem});
            this.figures.Name = "figures";
            this.figures.Size = new System.Drawing.Size(64, 24);
            this.figures.Text = "Figure";
            // 
            // circleItem
            // 
            this.circleItem.Name = "circleItem";
            this.circleItem.Size = new System.Drawing.Size(180, 26);
            this.circleItem.Text = "Круг";
            this.circleItem.Click += new System.EventHandler(this.circleItem_Click);
            // 
            // triangleItem
            // 
            this.triangleItem.Name = "triangleItem";
            this.triangleItem.Size = new System.Drawing.Size(180, 26);
            this.triangleItem.Text = "Треугольник";
            this.triangleItem.Click += new System.EventHandler(this.triangleItem_Click);
            // 
            // squareItem
            // 
            this.squareItem.Name = "squareItem";
            this.squareItem.Size = new System.Drawing.Size(180, 26);
            this.squareItem.Text = "Квадрат";
            this.squareItem.Click += new System.EventHandler(this.squareItem_Click);
            // 
            // chColor
            // 
            this.chColor.Name = "chColor";
            this.chColor.Size = new System.Drawing.Size(97, 24);
            this.chColor.Text = "choseColor";
            this.chColor.Click += new System.EventHandler(this.chColor_Click);
            // 
            // group
            // 
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(63, 24);
            this.group.Text = "group";
            this.group.Click += new System.EventHandler(this.group_Click);
            // 
            // ungroup
            // 
            this.ungroup.Name = "ungroup";
            this.ungroup.Size = new System.Drawing.Size(79, 24);
            this.ungroup.Text = "ungroup";
            this.ungroup.Click += new System.EventHandler(this.ungroup_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.load,
            this.save});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // load
            // 
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(122, 26);
            this.load.Text = "load";
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(122, 26);
            this.save.Text = "save";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(0, 29);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(195, 420);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeBar);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ColorDialog colorDialog1;
        private TrackBar sizeBar;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem figures;
        private ToolStripMenuItem circleItem;
        private ToolStripMenuItem triangleItem;
        private ToolStripMenuItem squareItem;
        private ToolStripMenuItem chColor;
        private ToolStripMenuItem group;
        private ToolStripMenuItem ungroup;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem load;
        private ToolStripMenuItem save;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private TreeView treeView1;
    }
}