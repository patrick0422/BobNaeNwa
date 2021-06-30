
namespace BobNaeNwa
{
    partial class RankingForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonYear = new System.Windows.Forms.Button();
            this.buttonMonth = new System.Windows.Forms.Button();
            this.buttonWeek = new System.Windows.Forms.Button();
            this.labelMaker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(449, 504);
            this.listBox1.TabIndex = 0;
            // 
            // buttonYear
            // 
            this.buttonYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonYear.Location = new System.Drawing.Point(208, 12);
            this.buttonYear.Name = "buttonYear";
            this.buttonYear.Size = new System.Drawing.Size(92, 34);
            this.buttonYear.TabIndex = 1;
            this.buttonYear.Text = "연간";
            this.buttonYear.UseVisualStyleBackColor = true;
            this.buttonYear.Click += new System.EventHandler(this.buttonYear_Click);
            // 
            // buttonMonth
            // 
            this.buttonMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonMonth.Location = new System.Drawing.Point(110, 12);
            this.buttonMonth.Name = "buttonMonth";
            this.buttonMonth.Size = new System.Drawing.Size(92, 34);
            this.buttonMonth.TabIndex = 1;
            this.buttonMonth.Text = "월간";
            this.buttonMonth.UseVisualStyleBackColor = true;
            this.buttonMonth.Click += new System.EventHandler(this.buttonMonth_Click);
            // 
            // buttonWeek
            // 
            this.buttonWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonWeek.Location = new System.Drawing.Point(12, 12);
            this.buttonWeek.Name = "buttonWeek";
            this.buttonWeek.Size = new System.Drawing.Size(92, 34);
            this.buttonWeek.TabIndex = 1;
            this.buttonWeek.Text = "주간";
            this.buttonWeek.UseVisualStyleBackColor = true;
            this.buttonWeek.Click += new System.EventHandler(this.buttonWeek_Click);
            // 
            // labelMaker
            // 
            this.labelMaker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaker.AutoSize = true;
            this.labelMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMaker.Location = new System.Drawing.Point(368, 568);
            this.labelMaker.Name = "labelMaker";
            this.labelMaker.Size = new System.Drawing.Size(94, 18);
            this.labelMaker.TabIndex = 3;
            this.labelMaker.Text = "양태웅, 오병진";
            this.labelMaker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 594);
            this.Controls.Add(this.labelMaker);
            this.Controls.Add(this.buttonWeek);
            this.Controls.Add(this.buttonMonth);
            this.Controls.Add(this.buttonYear);
            this.Controls.Add(this.listBox1);
            this.Name = "RankingForm";
            this.Text = "맛있었던 급식들";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonYear;
        private System.Windows.Forms.Button buttonMonth;
        private System.Windows.Forms.Button buttonWeek;
        private System.Windows.Forms.Label labelMaker;
    }
}