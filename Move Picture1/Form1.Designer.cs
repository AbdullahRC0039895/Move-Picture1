namespace Move_Picture1
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
            this.PB = new System.Windows.Forms.PictureBox();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // PB
            // 
            this.PB.Image = global::Move_Picture1.Properties.Resources.download;
            this.PB.Location = new System.Drawing.Point(522, 230);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(257, 198);
            this.PB.TabIndex = 0;
            this.PB.TabStop = false;
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(964, 100);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(75, 72);
            this.btn_left.TabIndex = 1;
            this.btn_left.Text = "LEFT";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.Btn_left_Click);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(1036, 178);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 72);
            this.btn_down.TabIndex = 2;
            this.btn_down.Text = "DOWN";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.Btn_down_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(1106, 100);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(75, 72);
            this.btn_right.TabIndex = 3;
            this.btn_right.Text = "RIGHT";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.Btn_right_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(1036, 22);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 72);
            this.btn_up.TabIndex = 4;
            this.btn_up.Text = "UP";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.Btn_up_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 807);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.PB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_up;
    }
}

