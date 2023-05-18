using lab_6.Figures;

namespace lab_6
{
    partial class Form1
    {
        Mycontainer<Figure> container = new Mycontainer<Figure>();
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
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeBar
            // 
            this.sizeBar.Location = new System.Drawing.Point(162, 0);
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
            this.label1.Location = new System.Drawing.Point(201, 30);
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
            this.chColor});
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
            this.chColor.Size = new System.Drawing.Size(83, 24);
            this.chColor.Text = "choseCol";
            this.chColor.Click += new System.EventHandler(this.chColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeBar);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}