
namespace ShiftOS_TheRevival_CS
{
    partial class ShiftOSMenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_FreeRoam = new System.Windows.Forms.Button();
            this.btn_StoryMode = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Aboot = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(264, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 441);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_FreeRoam
            // 
            this.btn_FreeRoam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FreeRoam.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_FreeRoam.ForeColor = System.Drawing.Color.White;
            this.btn_FreeRoam.Location = new System.Drawing.Point(22, 137);
            this.btn_FreeRoam.Name = "btn_FreeRoam";
            this.btn_FreeRoam.Size = new System.Drawing.Size(224, 23);
            this.btn_FreeRoam.TabIndex = 8;
            this.btn_FreeRoam.Text = "Free Roam Mode";
            this.btn_FreeRoam.UseVisualStyleBackColor = true;
            this.btn_FreeRoam.Click += new System.EventHandler(this.btn_FreeRoam_Click);
            // 
            // btn_StoryMode
            // 
            this.btn_StoryMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StoryMode.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_StoryMode.ForeColor = System.Drawing.Color.White;
            this.btn_StoryMode.Location = new System.Drawing.Point(22, 108);
            this.btn_StoryMode.Name = "btn_StoryMode";
            this.btn_StoryMode.Size = new System.Drawing.Size(224, 23);
            this.btn_StoryMode.TabIndex = 6;
            this.btn_StoryMode.Text = "Story Mode";
            this.btn_StoryMode.UseVisualStyleBackColor = true;
            this.btn_StoryMode.Click += new System.EventHandler(this.btn_StoryMode_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(22, 195);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(224, 23);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Aboot
            // 
            this.btn_Aboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aboot.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_Aboot.ForeColor = System.Drawing.Color.White;
            this.btn_Aboot.Location = new System.Drawing.Point(22, 166);
            this.btn_Aboot.Name = "btn_Aboot";
            this.btn_Aboot.Size = new System.Drawing.Size(224, 23);
            this.btn_Aboot.TabIndex = 9;
            this.btn_Aboot.Text = "About";
            this.btn_Aboot.UseVisualStyleBackColor = true;
            this.btn_Aboot.Click += new System.EventHandler(this.btn_Aboot_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(18, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(162, 19);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Shift it your way";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Consolas", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(206, 56);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "ShiftOS";
            // 
            // ShiftOSMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btn_FreeRoam);
            this.Controls.Add(this.btn_StoryMode);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Aboot);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShiftOSMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShiftOS Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button btn_FreeRoam;
        internal System.Windows.Forms.Button btn_StoryMode;
        internal System.Windows.Forms.Button btn_Exit;
        internal System.Windows.Forms.Button btn_Aboot;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

