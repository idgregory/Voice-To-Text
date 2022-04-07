
namespace Voice_To_Text
{
    partial class VoiceToTextWindow
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
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.SpeakBtn = new System.Windows.Forms.Button();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.StopBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageBox
            // 
            this.MessageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.MessageBox, 2);
            this.MessageBox.Location = new System.Drawing.Point(3, 3);
            this.MessageBox.Multiline = true;
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageBox.Size = new System.Drawing.Size(969, 471);
            this.MessageBox.TabIndex = 0;
            // 
            // SpeakBtn
            // 
            this.SpeakBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeakBtn.Location = new System.Drawing.Point(3, 3);
            this.SpeakBtn.Name = "SpeakBtn";
            this.SpeakBtn.Size = new System.Drawing.Size(75, 23);
            this.SpeakBtn.TabIndex = 1;
            this.SpeakBtn.Text = "Speak";
            this.SpeakBtn.UseVisualStyleBackColor = true;
            this.SpeakBtn.Click += new System.EventHandler(this.SpeakBtn_Click_1);
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(490, 480);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(75, 23);
            this.ReadBtn.TabIndex = 2;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ReadBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.MessageBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.07706F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.922935F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(975, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.SpeakBtn);
            this.flowLayoutPanel1.Controls.Add(this.StopBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 480);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(162, 29);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(84, 3);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 23);
            this.StopBtn.TabIndex = 1;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // VoiceToTextWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 537);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VoiceToTextWindow";
            this.Text = "Voice To Text";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.Button SpeakBtn;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button StopBtn;
    }
}

