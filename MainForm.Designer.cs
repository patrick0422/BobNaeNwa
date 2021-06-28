
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
            this.components = new System.ComponentModel.Container();
            this.breakfastWrap = new System.Windows.Forms.GroupBox();
            this.dinnerWrap = new System.Windows.Forms.GroupBox();
            this.LunchWrap = new System.Windows.Forms.GroupBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelMaker = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonDate = new System.Windows.Forms.Button();
            this.breakfastList = new System.Windows.Forms.ListBox();
            this.lunchList = new System.Windows.Forms.ListBox();
            this.dinnerList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRank = new System.Windows.Forms.Button();
            this.breakfastWrap.SuspendLayout();
            this.dinnerWrap.SuspendLayout();
            this.LunchWrap.SuspendLayout();
            this.SuspendLayout();
            // 
            // breakfastWrap
            // 
            this.breakfastWrap.BackColor = System.Drawing.Color.Transparent;
            this.breakfastWrap.Controls.Add(this.breakfastList);
            this.breakfastWrap.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.breakfastWrap.Location = new System.Drawing.Point(12, 62);
            this.breakfastWrap.Name = "breakfastWrap";
            this.breakfastWrap.Size = new System.Drawing.Size(241, 377);
            this.breakfastWrap.TabIndex = 0;
            this.breakfastWrap.TabStop = false;
            this.breakfastWrap.Text = "조식";
            // 
            // dinnerWrap
            // 
            this.dinnerWrap.BackColor = System.Drawing.Color.Transparent;
            this.dinnerWrap.Controls.Add(this.dinnerList);
            this.dinnerWrap.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dinnerWrap.Location = new System.Drawing.Point(547, 62);
            this.dinnerWrap.Name = "dinnerWrap";
            this.dinnerWrap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dinnerWrap.Size = new System.Drawing.Size(241, 377);
            this.dinnerWrap.TabIndex = 0;
            this.dinnerWrap.TabStop = false;
            this.dinnerWrap.Text = "석식";
            // 
            // LunchWrap
            // 
            this.LunchWrap.BackColor = System.Drawing.Color.Transparent;
            this.LunchWrap.Controls.Add(this.lunchList);
            this.LunchWrap.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LunchWrap.Location = new System.Drawing.Point(279, 62);
            this.LunchWrap.Name = "LunchWrap";
            this.LunchWrap.Size = new System.Drawing.Size(241, 377);
            this.LunchWrap.TabIndex = 0;
            this.LunchWrap.TabStop = false;
            this.LunchWrap.Text = "중식";
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("AppleSDGothicNeoUL00", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.buttonNext.Font = new System.Drawing.Font("AppleSDGothicNeoUL00", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonNext.Location = new System.Drawing.Point(684, 12);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(104, 29);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "내일 급식";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelMaker
            // 
            this.labelMaker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaker.AutoSize = true;
            this.labelMaker.Font = new System.Drawing.Font("AppleSDGothicNeoUL00", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMaker.Location = new System.Drawing.Point(695, 442);
            this.labelMaker.Name = "labelMaker";
            this.labelMaker.Size = new System.Drawing.Size(93, 17);
            this.labelMaker.TabIndex = 2;
            this.labelMaker.Text = "양태웅, 오병진";
            this.labelMaker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonDate
            // 
            this.buttonDate.Font = new System.Drawing.Font("AppleSDGothicNeoUL00", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonDate.Location = new System.Drawing.Point(279, 12);
            this.buttonDate.Name = "buttonDate";
            this.buttonDate.Size = new System.Drawing.Size(241, 29);
            this.buttonDate.TabIndex = 4;
            this.buttonDate.Text = "yyyy년 MM월 dd일 n요일";
            this.buttonDate.UseVisualStyleBackColor = true;
            this.buttonDate.Click += new System.EventHandler(this.buttonDate_Click);
            // 
            // breakfastList
            // 
            this.breakfastList.FormattingEnabled = true;
            this.breakfastList.ItemHeight = 25;
            this.breakfastList.Location = new System.Drawing.Point(6, 36);
            this.breakfastList.Name = "breakfastList";
            this.breakfastList.Size = new System.Drawing.Size(229, 329);
            this.breakfastList.TabIndex = 0;
            this.breakfastList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnMealDoubleClick);
            // 
            // lunchList
            // 
            this.lunchList.FormattingEnabled = true;
            this.lunchList.ItemHeight = 25;
            this.lunchList.Location = new System.Drawing.Point(6, 36);
            this.lunchList.Name = "lunchList";
            this.lunchList.Size = new System.Drawing.Size(229, 329);
            this.lunchList.TabIndex = 0;
            this.lunchList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnMealDoubleClick);
            // 
            // dinnerList
            // 
            this.dinnerList.FormattingEnabled = true;
            this.dinnerList.ItemHeight = 25;
            this.dinnerList.Location = new System.Drawing.Point(6, 36);
            this.dinnerList.Name = "dinnerList";
            this.dinnerList.Size = new System.Drawing.Size(229, 329);
            this.dinnerList.TabIndex = 0;
            this.dinnerList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnMealDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // buttonRank
            // 
            this.buttonRank.Font = new System.Drawing.Font("AppleSDGothicNeoUL00", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonRank.Location = new System.Drawing.Point(122, 12);
            this.buttonRank.Name = "buttonRank";
            this.buttonRank.Size = new System.Drawing.Size(151, 29);
            this.buttonRank.TabIndex = 1;
            this.buttonRank.Text = "맛있었던 급식";
            this.buttonRank.UseVisualStyleBackColor = true;
            this.buttonRank.Click += new System.EventHandler(this.button1_Click);
            // 
            // BobNaeNwa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDate);
            this.Controls.Add(this.labelMaker);
            this.Controls.Add(this.buttonNext);
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
        private System.Windows.Forms.Label labelMaker;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonDate;
        private System.Windows.Forms.ListBox breakfastList;
        private System.Windows.Forms.ListBox dinnerList;
        private System.Windows.Forms.ListBox lunchList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRank;
    }
}

