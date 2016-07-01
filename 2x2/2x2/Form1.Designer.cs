namespace _2x2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextOut = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.TextInp = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextOut
            // 
            this.TextOut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TextOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextOut.ForeColor = System.Drawing.Color.Black;
            this.TextOut.Location = new System.Drawing.Point(3, 98);
            this.TextOut.Multiline = true;
            this.TextOut.Name = "TextOut";
            this.TextOut.Size = new System.Drawing.Size(138, 49);
            this.TextOut.TabIndex = 0;
            this.TextOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextOut.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TextOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(3, 188);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(189, 38);
            this.OK.TabIndex = 1;
            this.OK.Text = "Հաստատել";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextInp
            // 
            this.TextInp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TextInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextInp.ForeColor = System.Drawing.Color.Black;
            this.TextInp.Location = new System.Drawing.Point(147, 98);
            this.TextInp.Multiline = true;
            this.TextInp.Name = "TextInp";
            this.TextInp.Size = new System.Drawing.Size(45, 48);
            this.TextInp.TabIndex = 2;
            this.TextInp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextInp.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.TextInp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(196, 283);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TextInp);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.TextOut);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2*2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextOut;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox TextInp;
        private System.Windows.Forms.TextBox textBox1;
    }
}

