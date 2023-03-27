namespace lab_4_2_OOP
{
    partial class Form1
    {
        Model model = new Model();
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
            this.A = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarC = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).BeginInit();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A.Location = new System.Drawing.Point(119, 82);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(55, 59);
            this.A.TabIndex = 0;
            this.A.Text = "A";
            // 
            // B
            // 
            this.B.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B.Location = new System.Drawing.Point(323, 82);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(55, 59);
            this.B.TabIndex = 1;
            this.B.Text = "B";
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C.Location = new System.Drawing.Point(535, 82);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(55, 59);
            this.C.TabIndex = 2;
            this.C.Text = "C";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(201, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "<=";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(413, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 59);
            this.label2.TabIndex = 4;
            this.label2.Text = "<=";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(81, 160);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(132, 23);
            this.textBoxA.TabIndex = 5;
            this.textBoxA.Text = "0";
            this.textBoxA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxA_KeyDown);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(288, 160);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(132, 23);
            this.textBoxB.TabIndex = 6;
            this.textBoxB.Text = "0";
            this.textBoxB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxB_KeyDown);
            this.textBoxB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxB_MouseDown);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(494, 160);
            this.textBoxC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(132, 23);
            this.textBoxC.TabIndex = 7;
            this.textBoxC.Text = "0";
            this.textBoxC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxC_KeyDown);
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(81, 194);
            this.numericUpDownA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(131, 23);
            this.numericUpDownA.TabIndex = 8;
            this.numericUpDownA.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(288, 194);
            this.numericUpDownB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(131, 23);
            this.numericUpDownB.TabIndex = 9;
            this.numericUpDownB.ValueChanged += new System.EventHandler(this.numericUpDownB_ValueChanged);
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.Location = new System.Drawing.Point(494, 194);
            this.numericUpDownC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(131, 23);
            this.numericUpDownC.TabIndex = 10;
            this.numericUpDownC.ValueChanged += new System.EventHandler(this.numericUpDownC_ValueChanged);
            // 
            // trackBarA
            // 
            this.trackBarA.Location = new System.Drawing.Point(81, 233);
            this.trackBarA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarA.Maximum = 100;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(131, 45);
            this.trackBarA.TabIndex = 11;
            this.trackBarA.ValueChanged += new System.EventHandler(this.trackBarA_ValueChanged);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(288, 233);
            this.trackBarB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarB.Maximum = 100;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(131, 45);
            this.trackBarB.TabIndex = 12;
            this.trackBarB.ValueChanged += new System.EventHandler(this.trackBarB_ValueChanged);
            // 
            // trackBarC
            // 
            this.trackBarC.Location = new System.Drawing.Point(494, 233);
            this.trackBarC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarC.Maximum = 100;
            this.trackBarC.Name = "trackBarC";
            this.trackBarC.Size = new System.Drawing.Size(131, 45);
            this.trackBarC.TabIndex = 13;
            this.trackBarC.ValueChanged += new System.EventHandler(this.trackBarC_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.trackBarC);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarA);
            this.Controls.Add(this.numericUpDownC);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.numericUpDownA);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label A;
        private Label B;
        private Label C;
        private Label label1;
        private Label label2;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private NumericUpDown numericUpDownA;
        private NumericUpDown numericUpDownB;
        private NumericUpDown numericUpDownC;
        private TrackBar trackBarA;
        private TrackBar trackBarB;
        private TrackBar trackBarC;
    }
}