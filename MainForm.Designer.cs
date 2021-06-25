
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
            this.BreakfastBox = new System.Windows.Forms.GroupBox();
            this.labelBreakfast = new System.Windows.Forms.Label();
            this.DinnerBox = new System.Windows.Forms.GroupBox();
            this.labelDinner = new System.Windows.Forms.Label();
            this.LunchBox = new System.Windows.Forms.GroupBox();
            this.labelLunch = new System.Windows.Forms.Label();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelMaker = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonDate = new System.Windows.Forms.Button();
            this.BreakfastBox.SuspendLayout();
            this.DinnerBox.SuspendLayout();
            this.LunchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BreakfastBox
            // 
            this.BreakfastBox.BackColor = System.Drawing.Color.Transparent;
            this.BreakfastBox.Controls.Add(this.labelBreakfast);
            this.BreakfastBox.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BreakfastBox.Location = new System.Drawing.Point(12, 62);
            this.BreakfastBox.Name = "BreakfastBox";
            this.BreakfastBox.Size = new System.Drawing.Size(241, 361);
            this.BreakfastBox.TabIndex = 0;
            this.BreakfastBox.TabStop = false;
            this.BreakfastBox.Text = "조식";
            // 
            // labelBreakfast
            // 
            this.labelBreakfast.Font = new System.Drawing.Font("AppleSDGothicNeoUL00", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelBreakfast.Location = new System.Drawing.Point(6, 33);
            this.labelBreakfast.Name = "labelBreakfast";
            this.labelBreakfast.Size = new System.Drawing.Size(229, 325);
            this.labelBreakfast.TabIndex = 0;
            this.labelBreakfast.Text = "조식";
            this.labelBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DinnerBox
            // 
            this.DinnerBox.BackColor = System.Drawing.Color.Transparent;
            this.DinnerBox.Controls.Add(this.labelDinner);
            this.DinnerBox.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DinnerBox.Location = new System.Drawing.Point(547, 62);
            this.DinnerBox.Name = "DinnerBox";
            this.DinnerBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DinnerBox.Size = new System.Drawing.Size(241, 361);
            this.DinnerBox.TabIndex = 0;
            this.DinnerBox.TabStop = false;
            this.DinnerBox.Text = "석식";
            // 
            // labelDinner
            // 
            this.labelDinner.Font = new System.Drawing.Font("AppleSDGothicNeoUL00", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDinner.Location = new System.Drawing.Point(6, 33);
            this.labelDinner.Name = "labelDinner";
            this.labelDinner.Size = new System.Drawing.Size(229, 325);
            this.labelDinner.TabIndex = 0;
            this.labelDinner.Text = "석식";
            this.labelDinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LunchBox
            // 
            this.LunchBox.BackColor = System.Drawing.Color.Transparent;
            this.LunchBox.Controls.Add(this.labelLunch);
            this.LunchBox.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LunchBox.Location = new System.Drawing.Point(279, 62);
            this.LunchBox.Name = "LunchBox";
            this.LunchBox.Size = new System.Drawing.Size(241, 361);
            this.LunchBox.TabIndex = 0;
            this.LunchBox.TabStop = false;
            this.LunchBox.Text = "중식";
            // 
            // labelLunch
            // 
            this.labelLunch.Font = new System.Drawing.Font("AppleSDGothicNeoUL00", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelLunch.Location = new System.Drawing.Point(6, 33);
            this.labelLunch.Name = "labelLunch";
            this.labelLunch.Size = new System.Drawing.Size(229, 325);
            this.labelLunch.TabIndex = 0;
            this.labelLunch.Text = "중식";
            this.labelLunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.labelMaker.Location = new System.Drawing.Point(695, 437);
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
            // BobNaeNwa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.buttonDate);
            this.Controls.Add(this.labelMaker);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.LunchBox);
            this.Controls.Add(this.DinnerBox);
            this.Controls.Add(this.BreakfastBox);
            this.Name = "BobNaeNwa";
            this.Text = "밥내놔";
            this.BreakfastBox.ResumeLayout(false);
            this.DinnerBox.ResumeLayout(false);
            this.LunchBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox BreakfastBox;
        private System.Windows.Forms.GroupBox DinnerBox;
        private System.Windows.Forms.GroupBox LunchBox;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelMaker;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelBreakfast;
        private System.Windows.Forms.Label labelDinner;
        private System.Windows.Forms.Label labelLunch;
        private System.Windows.Forms.Button buttonDate;
    }
}

