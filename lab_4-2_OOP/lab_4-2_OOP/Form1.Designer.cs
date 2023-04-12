namespace lab_4_2_OOP
{
    partial class Form1
    {
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
            this.A.Location = new System.Drawing.Point(136, 109);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(63, 79);
            this.A.TabIndex = 0;
            this.A.Text = "A";
            // 
            // B
            // 
            this.B.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B.Location = new System.Drawing.Point(369, 109);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(63, 79);
            this.B.TabIndex = 1;
            this.B.Text = "B";
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C.Location = new System.Drawing.Point(611, 109);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(63, 79);
            this.C.TabIndex = 2;
            this.C.Text = "C";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(230, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 79);
            this.label1.TabIndex = 3;
            this.label1.Text = "<=";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(472, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 79);
            this.label2.TabIndex = 4;
            this.label2.Text = "<=";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(93, 213);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(150, 27);
            this.textBoxA.TabIndex = 5;
            this.textBoxA.Text = "0";
            this.textBoxA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxA_KeyDown);
            this.textBoxA.Leave += new System.EventHandler(this.textBoxA_Leave);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(329, 213);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(150, 27);
            this.textBoxB.TabIndex = 6;
            this.textBoxB.Text = "0";
            this.textBoxB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxB_KeyDown);
            this.textBoxB.Leave += new System.EventHandler(this.textBoxB_Leave);
            this.textBoxB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxB_MouseDown);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(565, 213);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(150, 27);
            this.textBoxC.TabIndex = 7;
            this.textBoxC.Text = "0";
            this.textBoxC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxC_KeyDown);
            this.textBoxC.Leave += new System.EventHandler(this.textBoxC_Leave);
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(93, 259);
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownA.TabIndex = 8;
            this.numericUpDownA.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDownA.Leave += new System.EventHandler(this.numericUpDownA_Leave);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(329, 259);
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownB.TabIndex = 9;
            this.numericUpDownB.ValueChanged += new System.EventHandler(this.numericUpDownB_ValueChanged);
            this.numericUpDownB.Leave += new System.EventHandler(this.numericUpDownB_Leave);
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.Location = new System.Drawing.Point(565, 259);
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownC.TabIndex = 10;
            this.numericUpDownC.ValueChanged += new System.EventHandler(this.numericUpDownC_ValueChanged);
            this.numericUpDownC.Leave += new System.EventHandler(this.numericUpDownC_Leave);
            // 
            // trackBarA
            // 
            this.trackBarA.Location = new System.Drawing.Point(93, 311);
            this.trackBarA.Maximum = 100;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(150, 56);
            this.trackBarA.TabIndex = 11;
            this.trackBarA.ValueChanged += new System.EventHandler(this.trackBarA_ValueChanged);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(329, 311);
            this.trackBarB.Maximum = 100;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(150, 56);
            this.trackBarB.TabIndex = 12;
            this.trackBarB.ValueChanged += new System.EventHandler(this.trackBarB_ValueChanged);
            // 
            // trackBarC
            // 
            this.trackBarC.Location = new System.Drawing.Point(565, 311);
            this.trackBarC.Maximum = 100;
            this.trackBarC.Name = "trackBarC";
            this.trackBarC.Size = new System.Drawing.Size(150, 56);
            this.trackBarC.TabIndex = 13;
            this.trackBarC.ValueChanged += new System.EventHandler(this.trackBarC_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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