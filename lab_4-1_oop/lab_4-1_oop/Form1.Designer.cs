namespace lab_4_1_oop
{
    partial class Form1
    {
        List <Circle> circles= new List <Circle> ();
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
            this.sevCircles = new System.Windows.Forms.CheckBox();
            this.ctrl = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // sevCircles
            // 
            this.sevCircles.AutoSize = true;
            this.sevCircles.Location = new System.Drawing.Point(319, 4);
            this.sevCircles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sevCircles.Name = "sevCircles";
            this.sevCircles.Size = new System.Drawing.Size(140, 19);
            this.sevCircles.TabIndex = 0;
            this.sevCircles.Text = "Несколько объектов";
            this.sevCircles.UseVisualStyleBackColor = true;
            // 
            // ctrl
            // 
            this.ctrl.AutoSize = true;
            this.ctrl.Location = new System.Drawing.Point(215, 4);
            this.ctrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrl.Name = "ctrl";
            this.ctrl.Size = new System.Drawing.Size(89, 19);
            this.ctrl.TabIndex = 1;
            this.ctrl.Text = "Turn on Ctrl";
            this.ctrl.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.ctrl);
            this.Controls.Add(this.sevCircles);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox sevCircles;
        private CheckBox ctrl;
    }
}