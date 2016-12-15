namespace DelegatesExercise
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
            this.tmr_Main = new System.Windows.Forms.Timer(this.components);
            this.btn_Red = new System.Windows.Forms.Button();
            this.btn_Green = new System.Windows.Forms.Button();
            this.btn_Blue = new System.Windows.Forms.Button();
            this.btn_Random = new System.Windows.Forms.Button();
            this.scb_Maximum = new System.Windows.Forms.VScrollBar();
            this.scb_Minimum = new System.Windows.Forms.VScrollBar();
            this.scb_Interval = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmr_Main
            // 
            this.tmr_Main.Tick += new System.EventHandler(this.tmr_Main_Tick);
            // 
            // btn_Red
            // 
            this.btn_Red.BackColor = System.Drawing.Color.Transparent;
            this.btn_Red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Red.Location = new System.Drawing.Point(13, 13);
            this.btn_Red.Name = "btn_Red";
            this.btn_Red.Size = new System.Drawing.Size(80, 23);
            this.btn_Red.TabIndex = 0;
            this.btn_Red.Text = "Red";
            this.btn_Red.UseVisualStyleBackColor = false;
            this.btn_Red.Click += new System.EventHandler(this.btn_Red_Click);
            // 
            // btn_Green
            // 
            this.btn_Green.BackColor = System.Drawing.Color.Transparent;
            this.btn_Green.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Green.Location = new System.Drawing.Point(13, 42);
            this.btn_Green.Name = "btn_Green";
            this.btn_Green.Size = new System.Drawing.Size(80, 23);
            this.btn_Green.TabIndex = 1;
            this.btn_Green.Text = "Green";
            this.btn_Green.UseVisualStyleBackColor = false;
            this.btn_Green.Click += new System.EventHandler(this.btn_Green_Click);
            // 
            // btn_Blue
            // 
            this.btn_Blue.BackColor = System.Drawing.Color.Transparent;
            this.btn_Blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Blue.Location = new System.Drawing.Point(12, 71);
            this.btn_Blue.Name = "btn_Blue";
            this.btn_Blue.Size = new System.Drawing.Size(80, 23);
            this.btn_Blue.TabIndex = 2;
            this.btn_Blue.Text = "Blue";
            this.btn_Blue.UseVisualStyleBackColor = false;
            this.btn_Blue.Click += new System.EventHandler(this.btn_Blue_Click);
            // 
            // btn_Random
            // 
            this.btn_Random.BackColor = System.Drawing.Color.Transparent;
            this.btn_Random.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Random.Location = new System.Drawing.Point(12, 100);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(80, 23);
            this.btn_Random.TabIndex = 3;
            this.btn_Random.Text = "Surprise Me!";
            this.btn_Random.UseVisualStyleBackColor = false;
            this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);
            // 
            // scb_Maximum
            // 
            this.scb_Maximum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scb_Maximum.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.scb_Maximum.Location = new System.Drawing.Point(397, 13);
            this.scb_Maximum.Maximum = 255;
            this.scb_Maximum.Minimum = 128;
            this.scb_Maximum.Name = "scb_Maximum";
            this.scb_Maximum.Size = new System.Drawing.Size(17, 98);
            this.scb_Maximum.TabIndex = 2;
            this.scb_Maximum.Value = 255;
            this.scb_Maximum.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scb_Maximum_Scroll);
            // 
            // scb_Minimum
            // 
            this.scb_Minimum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scb_Minimum.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.scb_Minimum.Location = new System.Drawing.Point(360, 13);
            this.scb_Minimum.Maximum = 127;
            this.scb_Minimum.Name = "scb_Minimum";
            this.scb_Minimum.Size = new System.Drawing.Size(17, 98);
            this.scb_Minimum.TabIndex = 2;
            this.scb_Minimum.ValueChanged += new System.EventHandler(this.scb_Minimum_ValueChanged);
            // 
            // scb_Interval
            // 
            this.scb_Interval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scb_Interval.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.scb_Interval.Location = new System.Drawing.Point(326, 13);
            this.scb_Interval.Minimum = 50;
            this.scb_Interval.Name = "scb_Interval";
            this.scb_Interval.Size = new System.Drawing.Size(17, 98);
            this.scb_Interval.TabIndex = 2;
            this.scb_Interval.Value = 50;
            this.scb_Interval.ValueChanged += new System.EventHandler(this.scb_Interval_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(309, 116);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Delay";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(353, 116);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Min";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(387, 116);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Max";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 138);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scb_Interval);
            this.Controls.Add(this.scb_Minimum);
            this.Controls.Add(this.scb_Maximum);
            this.Controls.Add(this.btn_Random);
            this.Controls.Add(this.btn_Blue);
            this.Controls.Add(this.btn_Green);
            this.Controls.Add(this.btn_Red);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr_Main;
        private System.Windows.Forms.Button btn_Red;
        private System.Windows.Forms.Button btn_Green;
        private System.Windows.Forms.Button btn_Blue;
        private System.Windows.Forms.Button btn_Random;
        private System.Windows.Forms.VScrollBar scb_Maximum;
        private System.Windows.Forms.VScrollBar scb_Minimum;
        private System.Windows.Forms.VScrollBar scb_Interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

