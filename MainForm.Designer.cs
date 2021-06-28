
namespace BobNaeNwa
{
    partial class BobNaeNwa
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.breakfastWrap = new System.Windows.Forms.GroupBox();
            this.breakfastList = new System.Windows.Forms.ListBox();
            this.dinnerWrap = new System.Windows.Forms.GroupBox();
            this.dinnerList = new System.Windows.Forms.ListBox();
            this.LunchWrap = new System.Windows.Forms.GroupBox();
            this.lunchList = new System.Windows.Forms.ListBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonDate = new System.Windows.Forms.Button();
            this.buttonRank = new System.Windows.Forms.Button();
            this.buttonLike = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.breakfastWrap.SuspendLayout();
            this.dinnerWrap.SuspendLayout();
            this.LunchWrap.SuspendLayout();
            this.SuspendLayout();
            // 
            // breakfastWrap
            // 
            this.breakfastWrap.BackColor = System.Drawing.Color.Transparent;
            this.breakfastWrap.Controls.Add(this.breakfastList);
            this.breakfastWrap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.breakfastWrap.Location = new System.Drawing.Point(12, 62);
            this.breakfastWrap.Name = "breakfastWrap";
            this.breakfastWrap.Size = new System.Drawing.Size(241, 377);
            this.breakfastWrap.TabIndex = 0;
            this.breakfastWrap.TabStop = false;
            this.breakfastWrap.Text = "조식";
            // 
            // breakfastList
            // 
            this.breakfastList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.breakfastList.FormattingEnabled = true;
            this.breakfastList.ItemHeight = 25;
            this.breakfastList.Location = new System.Drawing.Point(6, 36);
            this.breakfastList.Name = "breakfastList";
            this.breakfastList.Size = new System.Drawing.Size(229, 329);
            this.breakfastList.TabIndex = 0;
            this.breakfastList.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChanged);
            // 
            // dinnerWrap
            // 
            this.dinnerWrap.BackColor = System.Drawing.Color.Transparent;
            this.dinnerWrap.Controls.Add(this.dinnerList);
            this.dinnerWrap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dinnerWrap.Location = new System.Drawing.Point(547, 62);
            this.dinnerWrap.Name = "dinnerWrap";
            this.dinnerWrap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dinnerWrap.Size = new System.Drawing.Size(241, 377);
            this.dinnerWrap.TabIndex = 0;
            this.dinnerWrap.TabStop = false;
            this.dinnerWrap.Text = "석식";
            // 
            // dinnerList
            // 
            this.dinnerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dinnerList.FormattingEnabled = true;
            this.dinnerList.ItemHeight = 25;
            this.dinnerList.Location = new System.Drawing.Point(6, 36);
            this.dinnerList.Name = "dinnerList";
            this.dinnerList.Size = new System.Drawing.Size(229, 329);
            this.dinnerList.TabIndex = 0;
            this.dinnerList.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChanged);
            // 
            // LunchWrap
            // 
            this.LunchWrap.BackColor = System.Drawing.Color.Transparent;
            this.LunchWrap.Controls.Add(this.lunchList);
            this.LunchWrap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LunchWrap.Location = new System.Drawing.Point(279, 62);
            this.LunchWrap.Name = "LunchWrap";
            this.LunchWrap.Size = new System.Drawing.Size(241, 377);
            this.LunchWrap.TabIndex = 0;
            this.LunchWrap.TabStop = false;
            this.LunchWrap.Text = "중식";
            // 
            // lunchList
            // 
            this.lunchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lunchList.FormattingEnabled = true;
            this.lunchList.ItemHeight = 25;
            this.lunchList.Location = new System.Drawing.Point(6, 36);
            this.lunchList.Name = "lunchList";
            this.lunchList.Size = new System.Drawing.Size(229, 329);
            this.lunchList.TabIndex = 0;
            this.lunchList.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChanged);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonPrev.Location = new System.Drawing.Point(12, 12);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(104, 29);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = "어제 급식";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonNext.Location = new System.Drawing.Point(684, 12);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(104, 29);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "내일 급식";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonDate
            // 
            this.buttonDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonDate.Location = new System.Drawing.Point(279, 12);
            this.buttonDate.Name = "buttonDate";
            this.buttonDate.Size = new System.Drawing.Size(241, 29);
            this.buttonDate.TabIndex = 4;
            this.buttonDate.Text = "yyyy년 MM월 dd일 n요일";
            this.buttonDate.UseVisualStyleBackColor = true;
            this.buttonDate.Click += new System.EventHandler(this.buttonDate_Click);
            // 
            // buttonRank
            // 
            this.buttonRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonRank.Location = new System.Drawing.Point(637, 445);
            this.buttonRank.Name = "buttonRank";
            this.buttonRank.Size = new System.Drawing.Size(151, 29);
            this.buttonRank.TabIndex = 1;
            this.buttonRank.Text = "맛있었던 급식";
            this.buttonRank.UseVisualStyleBackColor = true;
            this.buttonRank.Click += new System.EventHandler(this.buttonRank_Click);
            // 
            // buttonLike
            // 
            this.buttonLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonLike.Location = new System.Drawing.Point(456, 443);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(64, 29);
            this.buttonLike.TabIndex = 1;
            this.buttonLike.Text = "맛있다!";
            this.buttonLike.UseVisualStyleBackColor = true;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(279, 445);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BobNaeNwa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDate);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.buttonRank);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.LunchWrap);
            this.Controls.Add(this.dinnerWrap);
            this.Controls.Add(this.breakfastWrap);
            this.Name = "BobNaeNwa";
            this.Text = "밥내놔";
            this.breakfastWrap.ResumeLayout(false);
            this.dinnerWrap.ResumeLayout(false);
            this.LunchWrap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox breakfastWrap;
        private System.Windows.Forms.GroupBox dinnerWrap;
        private System.Windows.Forms.GroupBox LunchWrap;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonDate;
        private System.Windows.Forms.ListBox breakfastList;
        private System.Windows.Forms.ListBox dinnerList;
        private System.Windows.Forms.ListBox lunchList;
        private System.Windows.Forms.Button buttonRank;
        private System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.TextBox textBox1;
    }
}

