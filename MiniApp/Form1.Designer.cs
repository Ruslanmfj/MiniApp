
namespace MiniApp
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
            this.Loadandrun = new System.Windows.Forms.Button();
            this.Returned = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Loadandrun
            // 
            this.Loadandrun.Location = new System.Drawing.Point(12, 12);
            this.Loadandrun.Name = "Loadandrun";
            this.Loadandrun.Size = new System.Drawing.Size(181, 61);
            this.Loadandrun.TabIndex = 0;
            this.Loadandrun.Text = "Загруить и выполнить";
            this.Loadandrun.UseVisualStyleBackColor = true;
            this.Loadandrun.Click += new System.EventHandler(this.Loadandrun_Click);
            // 
            // Returned
            // 
            this.Returned.Location = new System.Drawing.Point(12, 79);
            this.Returned.Name = "Returned";
            this.Returned.Size = new System.Drawing.Size(181, 209);
            this.Returned.TabIndex = 1;
            this.Returned.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 300);
            this.Controls.Add(this.Returned);
            this.Controls.Add(this.Loadandrun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Loadandrun;
        private System.Windows.Forms.RichTextBox Returned;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

