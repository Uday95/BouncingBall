namespace BouncingBall
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frame = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelang = new System.Windows.Forms.Label();
            this.labe5 = new System.Windows.Forms.Label();
            this.trackBarang = new System.Windows.Forms.TrackBar();
            this.labely = new System.Windows.Forms.Label();
            this.labelx = new System.Windows.Forms.Label();
            this.labelv = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar_y = new System.Windows.Forms.TrackBar();
            this.trackBar_x = new System.Windows.Forms.TrackBar();
            this.reset = new System.Windows.Forms.Button();
            this.through = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.velocity = new System.Windows.Forms.TrackBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frame);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frame";
            // 
            // frame
            // 
            this.frame.BackColor = System.Drawing.Color.Black;
            this.frame.Location = new System.Drawing.Point(6, 26);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(520, 280);
            this.frame.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelang);
            this.groupBox2.Controls.Add(this.labe5);
            this.groupBox2.Controls.Add(this.trackBarang);
            this.groupBox2.Controls.Add(this.labely);
            this.groupBox2.Controls.Add(this.labelx);
            this.groupBox2.Controls.Add(this.labelv);
            this.groupBox2.Controls.Add(this.show);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.trackBar_y);
            this.groupBox2.Controls.Add(this.trackBar_x);
            this.groupBox2.Controls.Add(this.reset);
            this.groupBox2.Controls.Add(this.through);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.velocity);
            this.groupBox2.Location = new System.Drawing.Point(555, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 319);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // labelang
            // 
            this.labelang.AutoSize = true;
            this.labelang.Location = new System.Drawing.Point(184, 220);
            this.labelang.Name = "labelang";
            this.labelang.Size = new System.Drawing.Size(19, 13);
            this.labelang.TabIndex = 14;
            this.labelang.Text = "10";
            // 
            // labe5
            // 
            this.labe5.AutoSize = true;
            this.labe5.Location = new System.Drawing.Point(178, 250);
            this.labe5.Name = "labe5";
            this.labe5.Size = new System.Drawing.Size(34, 13);
            this.labe5.TabIndex = 13;
            this.labe5.Text = "Angle";
            // 
            // trackBarang
            // 
            this.trackBarang.Location = new System.Drawing.Point(181, 30);
            this.trackBarang.Maximum = 360;
            this.trackBarang.Name = "trackBarang";
            this.trackBarang.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarang.Size = new System.Drawing.Size(45, 176);
            this.trackBarang.TabIndex = 12;
            this.trackBarang.Scroll += new System.EventHandler(this.trackBarang_Scroll);
            // 
            // labely
            // 
            this.labely.AutoSize = true;
            this.labely.Location = new System.Drawing.Point(84, 220);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(25, 13);
            this.labely.TabIndex = 11;
            this.labely.Text = "100";
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Location = new System.Drawing.Point(32, 220);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(25, 13);
            this.labelx.TabIndex = 10;
            this.labelx.Text = "100";
            // 
            // labelv
            // 
            this.labelv.AutoSize = true;
            this.labelv.Location = new System.Drawing.Point(133, 220);
            this.labelv.Name = "labelv";
            this.labelv.Size = new System.Drawing.Size(19, 13);
            this.labelv.TabIndex = 9;
            this.labelv.Text = "10";
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(2, 285);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(70, 23);
            this.show.TabIndex = 8;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            // 
            // trackBar_y
            // 
            this.trackBar_y.Location = new System.Drawing.Point(80, 30);
            this.trackBar_y.Maximum = 270;
            this.trackBar_y.Minimum = 20;
            this.trackBar_y.Name = "trackBar_y";
            this.trackBar_y.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_y.Size = new System.Drawing.Size(45, 176);
            this.trackBar_y.TabIndex = 5;
            this.trackBar_y.Value = 20;
            this.trackBar_y.Scroll += new System.EventHandler(this.trackBar_y_Scroll);
            // 
            // trackBar_x
            // 
            this.trackBar_x.Location = new System.Drawing.Point(29, 30);
            this.trackBar_x.Maximum = 510;
            this.trackBar_x.Minimum = 20;
            this.trackBar_x.Name = "trackBar_x";
            this.trackBar_x.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_x.Size = new System.Drawing.Size(45, 176);
            this.trackBar_x.TabIndex = 4;
            this.trackBar_x.Value = 20;
            this.trackBar_x.Scroll += new System.EventHandler(this.trackBar_x_Scroll);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(149, 285);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(70, 23);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // through
            // 
            this.through.Location = new System.Drawing.Point(75, 285);
            this.through.Name = "through";
            this.through.Size = new System.Drawing.Size(70, 23);
            this.through.TabIndex = 2;
            this.through.Text = "Through";
            this.through.UseVisualStyleBackColor = true;
            this.through.Click += new System.EventHandler(this.through_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Velocity";
            // 
            // velocity
            // 
            this.velocity.Location = new System.Drawing.Point(130, 30);
            this.velocity.Maximum = 50;
            this.velocity.Name = "velocity";
            this.velocity.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.velocity.Size = new System.Drawing.Size(45, 176);
            this.velocity.TabIndex = 0;
            this.velocity.Scroll += new System.EventHandler(this.velocity_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(15, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 395);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel frame;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar_y;
        private System.Windows.Forms.TrackBar trackBar_x;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button through;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar velocity;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label labelv;
        private System.Windows.Forms.Label labelang;
        private System.Windows.Forms.Label labe5;
        private System.Windows.Forms.TrackBar trackBarang;
        private System.Windows.Forms.Label label4;
    }
}

