namespace SpellingTest
{
    partial class IncorrectQuestionShowForm
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
            this._incorrectQuestionList = new System.Windows.Forms.ListBox();
            this._resultLabel = new System.Windows.Forms.Label();
            this._noticeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _incorrectQuestionList
            // 
            this._incorrectQuestionList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._incorrectQuestionList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._incorrectQuestionList.FormattingEnabled = true;
            this._incorrectQuestionList.HorizontalScrollbar = true;
            this._incorrectQuestionList.ItemHeight = 16;
            this._incorrectQuestionList.Location = new System.Drawing.Point(0, 57);
            this._incorrectQuestionList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._incorrectQuestionList.Name = "_incorrectQuestionList";
            this._incorrectQuestionList.Size = new System.Drawing.Size(332, 116);
            this._incorrectQuestionList.TabIndex = 0;
            // 
            // _resultLabel
            // 
            this._resultLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._resultLabel.AutoSize = true;
            this._resultLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._resultLabel.Location = new System.Drawing.Point(9, 7);
            this._resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._resultLabel.Name = "_resultLabel";
            this._resultLabel.Size = new System.Drawing.Size(224, 16);
            this._resultLabel.TabIndex = 1;
            this._resultLabel.Text = "You pass 0 of 0 questions!!";
            // 
            // _noticeLabel
            // 
            this._noticeLabel.AutoSize = true;
            this._noticeLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._noticeLabel.Location = new System.Drawing.Point(9, 31);
            this._noticeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._noticeLabel.Name = "_noticeLabel";
            this._noticeLabel.Size = new System.Drawing.Size(312, 16);
            this._noticeLabel.TabIndex = 2;
            this._noticeLabel.Text = "The following is your wrong questions:";
            // 
            // IncorrectQuestionShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 173);
            this.Controls.Add(this._noticeLabel);
            this.Controls.Add(this._resultLabel);
            this.Controls.Add(this._incorrectQuestionList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IncorrectQuestionShowForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Incorrect Questions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _incorrectQuestionList;
        private System.Windows.Forms.Label _resultLabel;
        private System.Windows.Forms.Label _noticeLabel;
    }
}