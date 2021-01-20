
namespace comp3304_week1
{
    partial class FishyNote
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.CloseNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(494, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Enter your note text here...";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Maroon;
            this.Delete.ForeColor = System.Drawing.Color.FloralWhite;
            this.Delete.Location = new System.Drawing.Point(519, 14);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(21, 23);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "x";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // CloseNote
            // 
            this.CloseNote.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CloseNote.Location = new System.Drawing.Point(33, 14);
            this.CloseNote.Name = "CloseNote";
            this.CloseNote.Size = new System.Drawing.Size(75, 23);
            this.CloseNote.TabIndex = 2;
            this.CloseNote.Text = "Close Note";
            this.CloseNote.UseVisualStyleBackColor = false;
            this.CloseNote.Click += new System.EventHandler(this.CloseNote_Click);
            // 
            // FishyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.ControlBox = false;
            this.Controls.Add(this.CloseNote);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FishyNote";
            this.Text = "FishyNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button CloseNote;
    }
}