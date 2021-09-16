
namespace AsyncAwaitExample
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
            this.btnSync = new System.Windows.Forms.Button();
            this.btnAsync = new System.Windows.Forms.Button();
            this.textBoxContent = new System.Windows.Forms.RichTextBox();
            this.textBoxRepeat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSync
            // 
            this.btnSync.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSync.Location = new System.Drawing.Point(72, 22);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(150, 50);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "Synchron";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnAsync
            // 
            this.btnAsync.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAsync.Location = new System.Drawing.Point(436, 22);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(150, 50);
            this.btnAsync.TabIndex = 1;
            this.btnAsync.Text = "Asynchron";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // textBoxContent
            // 
            this.textBoxContent.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxContent.Location = new System.Drawing.Point(12, 95);
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.ReadOnly = true;
            this.textBoxContent.Size = new System.Drawing.Size(641, 96);
            this.textBoxContent.TabIndex = 2;
            this.textBoxContent.Text = "";
            this.textBoxContent.WordWrap = false;
            // 
            // textBoxRepeat
            // 
            this.textBoxRepeat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRepeat.Location = new System.Drawing.Point(295, 32);
            this.textBoxRepeat.Name = "textBoxRepeat";
            this.textBoxRepeat.Size = new System.Drawing.Size(71, 33);
            this.textBoxRepeat.TabIndex = 3;
            this.textBoxRepeat.Text = "10";
            this.textBoxRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(664, 205);
            this.Controls.Add(this.textBoxRepeat);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.btnSync);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Async & Await";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.RichTextBox textBoxContent;
        private System.Windows.Forms.TextBox textBoxRepeat;
    }
}

