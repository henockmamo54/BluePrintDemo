namespace Demo_app
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
            this.rb_line = new System.Windows.Forms.RadioButton();
            this.rb_oval = new System.Windows.Forms.RadioButton();
            this.rb_fill = new System.Windows.Forms.RadioButton();
            this.rb_group = new System.Windows.Forms.RadioButton();
            this.rb_move = new System.Windows.Forms.RadioButton();
            this.rb_remove = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_line
            // 
            this.rb_line.AutoSize = true;
            this.rb_line.Location = new System.Drawing.Point(70, 19);
            this.rb_line.Name = "rb_line";
            this.rb_line.Size = new System.Drawing.Size(45, 17);
            this.rb_line.TabIndex = 0;
            this.rb_line.TabStop = true;
            this.rb_line.Text = "Line";
            this.rb_line.UseVisualStyleBackColor = true;
            // 
            // rb_oval
            // 
            this.rb_oval.AutoSize = true;
            this.rb_oval.Location = new System.Drawing.Point(17, 19);
            this.rb_oval.Name = "rb_oval";
            this.rb_oval.Size = new System.Drawing.Size(47, 17);
            this.rb_oval.TabIndex = 1;
            this.rb_oval.TabStop = true;
            this.rb_oval.Text = "Oval";
            this.rb_oval.UseVisualStyleBackColor = true;
            // 
            // rb_fill
            // 
            this.rb_fill.AutoSize = true;
            this.rb_fill.Location = new System.Drawing.Point(310, 19);
            this.rb_fill.Name = "rb_fill";
            this.rb_fill.Size = new System.Drawing.Size(37, 17);
            this.rb_fill.TabIndex = 2;
            this.rb_fill.TabStop = true;
            this.rb_fill.Text = "Fill";
            this.rb_fill.UseVisualStyleBackColor = true;
            // 
            // rb_group
            // 
            this.rb_group.AutoSize = true;
            this.rb_group.Location = new System.Drawing.Point(250, 19);
            this.rb_group.Name = "rb_group";
            this.rb_group.Size = new System.Drawing.Size(54, 17);
            this.rb_group.TabIndex = 3;
            this.rb_group.TabStop = true;
            this.rb_group.Text = "Group";
            this.rb_group.UseVisualStyleBackColor = true;
            // 
            // rb_move
            // 
            this.rb_move.AutoSize = true;
            this.rb_move.Location = new System.Drawing.Point(192, 19);
            this.rb_move.Name = "rb_move";
            this.rb_move.Size = new System.Drawing.Size(52, 17);
            this.rb_move.TabIndex = 4;
            this.rb_move.TabStop = true;
            this.rb_move.Text = "Move";
            this.rb_move.UseVisualStyleBackColor = true;
            // 
            // rb_remove
            // 
            this.rb_remove.AutoSize = true;
            this.rb_remove.Location = new System.Drawing.Point(121, 19);
            this.rb_remove.Name = "rb_remove";
            this.rb_remove.Size = new System.Drawing.Size(65, 17);
            this.rb_remove.TabIndex = 5;
            this.rb_remove.TabStop = true;
            this.rb_remove.Text = "Remove";
            this.rb_remove.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.rb_remove);
            this.groupBox1.Controls.Add(this.rb_line);
            this.groupBox1.Controls.Add(this.rb_move);
            this.groupBox1.Controls.Add(this.rb_oval);
            this.groupBox1.Controls.Add(this.rb_group);
            this.groupBox1.Controls.Add(this.rb_fill);
            this.groupBox1.Location = new System.Drawing.Point(489, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 51);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 334);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 432);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_line;
        private System.Windows.Forms.RadioButton rb_oval;
        private System.Windows.Forms.RadioButton rb_fill;
        private System.Windows.Forms.RadioButton rb_group;
        private System.Windows.Forms.RadioButton rb_move;
        private System.Windows.Forms.RadioButton rb_remove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

