namespace SpellingTest
{
    partial class TestForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this._mainMenu = new System.Windows.Forms.MenuStrip();
            this._fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._examinationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._startMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._nextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._stopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._examinationMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._numberOfQuestionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._tenQuestionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._twentyQuestionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._fiftyQuestionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._questionTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._allFillInTheBlankMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._allMultipleChoiceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._pickUpRandomlyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutDictionaryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutSpellingCheckerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._statusDisplayBar = new System.Windows.Forms.StatusStrip();
            this._statusDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this._startButton = new System.Windows.Forms.Button();
            this._nextButton = new System.Windows.Forms.Button();
            this._testWindow = new System.Windows.Forms.GroupBox();
            this._customizationLayout = new System.Windows.Forms.TableLayoutPanel();
            this._numberOfQuestionBox = new System.Windows.Forms.NumericUpDown();
            this._numberOfQuestionsLabel = new System.Windows.Forms.Label();
            this._questionTypeLabel = new System.Windows.Forms.Label();
            this._questionTypeBox = new System.Windows.Forms.ComboBox();
            this._fillTheBlankLayout = new System.Windows.Forms.TableLayoutPanel();
            this._chineseLabel = new System.Windows.Forms.Label();
            this._englishLabel = new System.Windows.Forms.Label();
            this._inputEnglish = new System.Windows.Forms.TextBox();
            this._outputChinese = new System.Windows.Forms.TextBox();
            this._multipleChoiceLayout = new System.Windows.Forms.TableLayoutPanel();
            this._outputEnglish = new System.Windows.Forms.TextBox();
            this._firstOption = new System.Windows.Forms.RadioButton();
            this._secondOption = new System.Windows.Forms.RadioButton();
            this._thirdOption = new System.Windows.Forms.RadioButton();
            this._fourthOption = new System.Windows.Forms.RadioButton();
            this._stopButton = new System.Windows.Forms.Button();
            this._deadlineProgressBar = new System.Windows.Forms.ProgressBar();
            this._elapsedTimeLabel = new System.Windows.Forms.Label();
            this._scoreLabel = new System.Windows.Forms.Label();
            this._timerForQuestion = new System.Windows.Forms.Timer(this.components);
            this._mainLayout.SuspendLayout();
            this._mainMenu.SuspendLayout();
            this._statusDisplayBar.SuspendLayout();
            this._testWindow.SuspendLayout();
            this._customizationLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numberOfQuestionBox)).BeginInit();
            this._fillTheBlankLayout.SuspendLayout();
            this._multipleChoiceLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainLayout
            // 
            this._mainLayout.ColumnCount = 3;
            this._mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this._mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this._mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this._mainLayout.Controls.Add(this._mainMenu, 0, 0);
            this._mainLayout.Controls.Add(this._statusDisplayBar, 0, 4);
            this._mainLayout.Controls.Add(this._startButton, 0, 2);
            this._mainLayout.Controls.Add(this._nextButton, 1, 2);
            this._mainLayout.Controls.Add(this._testWindow, 0, 1);
            this._mainLayout.Controls.Add(this._stopButton, 2, 2);
            this._mainLayout.Controls.Add(this._deadlineProgressBar, 1, 3);
            this._mainLayout.Controls.Add(this._elapsedTimeLabel, 0, 3);
            this._mainLayout.Controls.Add(this._scoreLabel, 2, 3);
            this._mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainLayout.Location = new System.Drawing.Point(0, 0);
            this._mainLayout.Margin = new System.Windows.Forms.Padding(2);
            this._mainLayout.Name = "_mainLayout";
            this._mainLayout.RowCount = 5;
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this._mainLayout.Size = new System.Drawing.Size(310, 202);
            this._mainLayout.TabIndex = 0;
            // 
            // _mainMenu
            // 
            this._mainLayout.SetColumnSpan(this._mainMenu, 3);
            this._mainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileMenu,
            this._examinationMenu,
            this._helpMenu});
            this._mainMenu.Location = new System.Drawing.Point(0, 0);
            this._mainMenu.Name = "_mainMenu";
            this._mainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this._mainMenu.Size = new System.Drawing.Size(310, 24);
            this._mainMenu.TabIndex = 0;
            this._mainMenu.Text = "menuStrip1";
            // 
            // _fileMenu
            // 
            this._fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._exitMenuItem});
            this._fileMenu.Name = "_fileMenu";
            this._fileMenu.Size = new System.Drawing.Size(39, 20);
            this._fileMenu.Text = "File";
            // 
            // _exitMenuItem
            // 
            this._exitMenuItem.Name = "_exitMenuItem";
            this._exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this._exitMenuItem.Size = new System.Drawing.Size(138, 22);
            this._exitMenuItem.Text = "Exit";
            this._exitMenuItem.Click += new System.EventHandler(this.ClickExitMenuItem);
            // 
            // _examinationMenu
            // 
            this._examinationMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._startMenuItem,
            this._nextMenuItem,
            this._stopMenuItem,
            this._examinationMenuSeparator,
            this._numberOfQuestionsMenuItem,
            this._questionTypeMenuItem});
            this._examinationMenu.Name = "_examinationMenu";
            this._examinationMenu.Size = new System.Drawing.Size(90, 20);
            this._examinationMenu.Text = "Examination";
            // 
            // _startMenuItem
            // 
            this._startMenuItem.Name = "_startMenuItem";
            this._startMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this._startMenuItem.Size = new System.Drawing.Size(202, 22);
            this._startMenuItem.Text = "Start";
            this._startMenuItem.Click += new System.EventHandler(this.ClickStartButton);
            // 
            // _nextMenuItem
            // 
            this._nextMenuItem.Enabled = false;
            this._nextMenuItem.Name = "_nextMenuItem";
            this._nextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this._nextMenuItem.Size = new System.Drawing.Size(202, 22);
            this._nextMenuItem.Text = "Next";
            this._nextMenuItem.Click += new System.EventHandler(this.ClickNextButton);
            // 
            // _stopMenuItem
            // 
            this._stopMenuItem.Enabled = false;
            this._stopMenuItem.Name = "_stopMenuItem";
            this._stopMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this._stopMenuItem.Size = new System.Drawing.Size(202, 22);
            this._stopMenuItem.Text = "Stop";
            this._stopMenuItem.Click += new System.EventHandler(this.ClickStopButton);
            // 
            // _examinationMenuSeparator
            // 
            this._examinationMenuSeparator.Name = "_examinationMenuSeparator";
            this._examinationMenuSeparator.Size = new System.Drawing.Size(199, 6);
            // 
            // _numberOfQuestionsMenuItem
            // 
            this._numberOfQuestionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tenQuestionsMenuItem,
            this._twentyQuestionsMenuItem,
            this._fiftyQuestionsMenuItem});
            this._numberOfQuestionsMenuItem.Name = "_numberOfQuestionsMenuItem";
            this._numberOfQuestionsMenuItem.Size = new System.Drawing.Size(202, 22);
            this._numberOfQuestionsMenuItem.Text = "Number of Questions";
            // 
            // _tenQuestionsMenuItem
            // 
            this._tenQuestionsMenuItem.Name = "_tenQuestionsMenuItem";
            this._tenQuestionsMenuItem.Size = new System.Drawing.Size(152, 22);
            this._tenQuestionsMenuItem.Text = "10 Questions";
            this._tenQuestionsMenuItem.Click += new System.EventHandler(this.ClickTenQuestionMenuItem);
            this._tenQuestionsMenuItem.Click += this.ClickStartButton;
            // 
            // _twentyQuestionsMenuItem
            // 
            this._twentyQuestionsMenuItem.Name = "_twentyQuestionsMenuItem";
            this._twentyQuestionsMenuItem.Size = new System.Drawing.Size(152, 22);
            this._twentyQuestionsMenuItem.Text = "20 Questions";
            this._twentyQuestionsMenuItem.Click += new System.EventHandler(this.ClickTwentyQuestionMenuItem);
            this._twentyQuestionsMenuItem.Click += this.ClickStartButton;
            // 
            // _fiftyQuestionsMenuItem
            // 
            this._fiftyQuestionsMenuItem.Name = "_fiftyQuestionsMenuItem";
            this._fiftyQuestionsMenuItem.Size = new System.Drawing.Size(152, 22);
            this._fiftyQuestionsMenuItem.Text = "50 Questions";
            this._fiftyQuestionsMenuItem.Click += new System.EventHandler(this.ClickFiftyQuestionMenuItem);
            this._fiftyQuestionsMenuItem.Click += this.ClickStartButton;
            // 
            // _questionTypeMenuItem
            // 
            this._questionTypeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._allFillInTheBlankMenuItem,
            this._allMultipleChoiceMenuItem,
            this._pickUpRandomlyMenuItem});
            this._questionTypeMenuItem.Name = "_questionTypeMenuItem";
            this._questionTypeMenuItem.Size = new System.Drawing.Size(202, 22);
            this._questionTypeMenuItem.Text = "Question Type";
            // 
            // _allFillInTheBlankMenuItem
            // 
            this._allFillInTheBlankMenuItem.Checked = true;
            this._allFillInTheBlankMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this._allFillInTheBlankMenuItem.Enabled = false;
            this._allFillInTheBlankMenuItem.Name = "_allFillInTheBlankMenuItem";
            this._allFillInTheBlankMenuItem.Size = new System.Drawing.Size(242, 22);
            this._allFillInTheBlankMenuItem.Text = "All fill in the blank questions";
            this._allFillInTheBlankMenuItem.Click += new System.EventHandler(this.ClickAllFillInBlankQuestionsMenuItem);
            // 
            // _allMultipleChoiceMenuItem
            // 
            this._allMultipleChoiceMenuItem.Name = "_allMultipleChoiceMenuItem";
            this._allMultipleChoiceMenuItem.Size = new System.Drawing.Size(242, 22);
            this._allMultipleChoiceMenuItem.Text = "All multiple-choice questions";
            this._allMultipleChoiceMenuItem.Click += new System.EventHandler(this.ClickAllMultipleChoiceQuestionsMenuItem);
            // 
            // _pickUpRandomlyMenuItem
            // 
            this._pickUpRandomlyMenuItem.Name = "_pickUpRandomlyMenuItem";
            this._pickUpRandomlyMenuItem.Size = new System.Drawing.Size(242, 22);
            this._pickUpRandomlyMenuItem.Text = "Pick up questions randomly";
            this._pickUpRandomlyMenuItem.Click += new System.EventHandler(this.ClickPickUpQuestionRandomlyMenuItem);
            // 
            // _helpMenu
            // 
            this._helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutDictionaryMenuItem,
            this._aboutSpellingCheckerMenuItem});
            this._helpMenu.Name = "_helpMenu";
            this._helpMenu.Size = new System.Drawing.Size(47, 20);
            this._helpMenu.Text = "Help";
            // 
            // _aboutDictionaryMenuItem
            // 
            this._aboutDictionaryMenuItem.Name = "_aboutDictionaryMenuItem";
            this._aboutDictionaryMenuItem.Size = new System.Drawing.Size(212, 22);
            this._aboutDictionaryMenuItem.Text = "About Dictionary";
            this._aboutDictionaryMenuItem.Click += new System.EventHandler(this.ClickAboutDictionaryMenuItem);
            // 
            // _aboutSpellingCheckerMenuItem
            // 
            this._aboutSpellingCheckerMenuItem.Name = "_aboutSpellingCheckerMenuItem";
            this._aboutSpellingCheckerMenuItem.Size = new System.Drawing.Size(212, 22);
            this._aboutSpellingCheckerMenuItem.Text = "About Spelling Checker";
            this._aboutSpellingCheckerMenuItem.Click += new System.EventHandler(this.ClickAboutSpellingCheckerMenuItem);
            // 
            // _statusDisplayBar
            // 
            this._mainLayout.SetColumnSpan(this._statusDisplayBar, 3);
            this._statusDisplayBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._statusDisplayBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._statusDisplayBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._statusDisplay});
            this._statusDisplayBar.Location = new System.Drawing.Point(0, 178);
            this._statusDisplayBar.Name = "_statusDisplayBar";
            this._statusDisplayBar.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this._statusDisplayBar.Size = new System.Drawing.Size(310, 24);
            this._statusDisplayBar.TabIndex = 1;
            this._statusDisplayBar.Text = "statusStrip1";
            // 
            // _statusDisplay
            // 
            this._statusDisplay.Name = "_statusDisplay";
            this._statusDisplay.Size = new System.Drawing.Size(0, 19);
            // 
            // _startButton
            // 
            this._startButton.AccessibleName = "StartButton";
            this._startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._startButton.Location = new System.Drawing.Point(16, 124);
            this._startButton.Margin = new System.Windows.Forms.Padding(2);
            this._startButton.Name = "_startButton";
            this._startButton.Size = new System.Drawing.Size(71, 27);
            this._startButton.TabIndex = 0;
            this._startButton.Text = "Start";
            this._startButton.UseVisualStyleBackColor = true;
            this._startButton.Click += new System.EventHandler(this.ClickStartButton);
            // 
            // _nextButton
            // 
            this._nextButton.AccessibleName = "NextButton";
            this._nextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._nextButton.Enabled = false;
            this._nextButton.Location = new System.Drawing.Point(119, 124);
            this._nextButton.Margin = new System.Windows.Forms.Padding(2);
            this._nextButton.Name = "_nextButton";
            this._nextButton.Size = new System.Drawing.Size(71, 27);
            this._nextButton.TabIndex = 1;
            this._nextButton.Text = "Next";
            this._nextButton.UseVisualStyleBackColor = true;
            this._nextButton.Click += new System.EventHandler(this.ClickNextButton);
            // 
            // _testWindow
            // 
            this._mainLayout.SetColumnSpan(this._testWindow, 3);
            this._testWindow.Controls.Add(this._customizationLayout);
            this._testWindow.Controls.Add(this._fillTheBlankLayout);
            this._testWindow.Controls.Add(this._multipleChoiceLayout);
            this._testWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this._testWindow.Location = new System.Drawing.Point(2, 26);
            this._testWindow.Margin = new System.Windows.Forms.Padding(2);
            this._testWindow.Name = "_testWindow";
            this._testWindow.Padding = new System.Windows.Forms.Padding(2);
            this._testWindow.Size = new System.Drawing.Size(306, 94);
            this._testWindow.TabIndex = 2;
            this._testWindow.TabStop = false;
            this._testWindow.Text = "Customize Your Examination";
            // 
            // _customizationLayout
            // 
            this._customizationLayout.ColumnCount = 2;
            this._customizationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.74809F));
            this._customizationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.25191F));
            this._customizationLayout.Controls.Add(this._numberOfQuestionBox, 1, 0);
            this._customizationLayout.Controls.Add(this._numberOfQuestionsLabel, 0, 0);
            this._customizationLayout.Controls.Add(this._questionTypeLabel, 0, 1);
            this._customizationLayout.Controls.Add(this._questionTypeBox, 1, 1);
            this._customizationLayout.Location = new System.Drawing.Point(4, 10);
            this._customizationLayout.Margin = new System.Windows.Forms.Padding(2);
            this._customizationLayout.Name = "_customizationLayout";
            this._customizationLayout.RowCount = 2;
            this._customizationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._customizationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._customizationLayout.Size = new System.Drawing.Size(295, 77);
            this._customizationLayout.TabIndex = 0;
            // 
            // _numberOfQuestionBox
            // 
            this._numberOfQuestionBox.AccessibleName = "NumberOfQuestion";
            this._numberOfQuestionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._numberOfQuestionBox.Location = new System.Drawing.Point(128, 8);
            this._numberOfQuestionBox.Margin = new System.Windows.Forms.Padding(2);
            this._numberOfQuestionBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this._numberOfQuestionBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numberOfQuestionBox.Name = "_numberOfQuestionBox";
            this._numberOfQuestionBox.Size = new System.Drawing.Size(164, 21);
            this._numberOfQuestionBox.TabIndex = 0;
            this._numberOfQuestionBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // _numberOfQuestionsLabel
            // 
            this._numberOfQuestionsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._numberOfQuestionsLabel.AutoSize = true;
            this._numberOfQuestionsLabel.Location = new System.Drawing.Point(5, 13);
            this._numberOfQuestionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._numberOfQuestionsLabel.Name = "_numberOfQuestionsLabel";
            this._numberOfQuestionsLabel.Size = new System.Drawing.Size(119, 12);
            this._numberOfQuestionsLabel.TabIndex = 1;
            this._numberOfQuestionsLabel.Text = "Number of Questions";
            // 
            // _questionTypeLabel
            // 
            this._questionTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._questionTypeLabel.AutoSize = true;
            this._questionTypeLabel.Location = new System.Drawing.Point(41, 51);
            this._questionTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._questionTypeLabel.Name = "_questionTypeLabel";
            this._questionTypeLabel.Size = new System.Drawing.Size(83, 12);
            this._questionTypeLabel.TabIndex = 2;
            this._questionTypeLabel.Text = "Question Type";
            // 
            // _questionTypeBox
            // 
            this._questionTypeBox.AccessibleName = "QuestionType";
            this._questionTypeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._questionTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._questionTypeBox.FormattingEnabled = true;
            this._questionTypeBox.Items.AddRange(new object[] {
            "All fill in the blank questions",
            "All multiple-choice questions",
            "Pick up questions randomly"});
            this._questionTypeBox.SelectedIndex = 0;
            this._questionTypeBox.Location = new System.Drawing.Point(128, 47);
            this._questionTypeBox.Margin = new System.Windows.Forms.Padding(2);
            this._questionTypeBox.Name = "_questionTypeBox";
            this._questionTypeBox.Size = new System.Drawing.Size(165, 20);
            this._questionTypeBox.TabIndex = 3;
            // 
            // _fillTheBlankLayout
            // 
            this._fillTheBlankLayout.ColumnCount = 2;
            this._fillTheBlankLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364F));
            this._fillTheBlankLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.63636F));
            this._fillTheBlankLayout.Controls.Add(this._chineseLabel, 0, 0);
            this._fillTheBlankLayout.Controls.Add(this._englishLabel, 0, 1);
            this._fillTheBlankLayout.Controls.Add(this._inputEnglish, 1, 1);
            this._fillTheBlankLayout.Controls.Add(this._outputChinese, 1, 0);
            this._fillTheBlankLayout.Location = new System.Drawing.Point(4, 10);
            this._fillTheBlankLayout.Margin = new System.Windows.Forms.Padding(2);
            this._fillTheBlankLayout.Name = "_fillTheBlankLayout";
            this._fillTheBlankLayout.RowCount = 2;
            this._fillTheBlankLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._fillTheBlankLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._fillTheBlankLayout.Size = new System.Drawing.Size(356, 77);
            this._fillTheBlankLayout.TabIndex = 1;
            this._fillTheBlankLayout.Visible = false;
            // 
            // _chineseLabel
            // 
            this._chineseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._chineseLabel.AutoSize = true;
            this._chineseLabel.Location = new System.Drawing.Point(5, 13);
            this._chineseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._chineseLabel.Name = "_chineseLabel";
            this._chineseLabel.Size = new System.Drawing.Size(47, 12);
            this._chineseLabel.TabIndex = 0;
            this._chineseLabel.Text = "Chinese";
            // 
            // _englishLabel
            // 
            this._englishLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._englishLabel.AutoSize = true;
            this._englishLabel.Location = new System.Drawing.Point(5, 51);
            this._englishLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._englishLabel.Name = "_englishLabel";
            this._englishLabel.Size = new System.Drawing.Size(47, 12);
            this._englishLabel.TabIndex = 1;
            this._englishLabel.Text = "English";
            // 
            // _inputEnglish
            // 
            this._inputEnglish.AccessibleName = "EnglishInputBox";
            this._inputEnglish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._inputEnglish.Enabled = false;
            this._inputEnglish.Location = new System.Drawing.Point(60, 47);
            this._inputEnglish.Margin = new System.Windows.Forms.Padding(2);
            this._inputEnglish.Name = "_inputEnglish";
            this._inputEnglish.Size = new System.Drawing.Size(294, 21);
            this._inputEnglish.TabIndex = 2;
            // 
            // _outputChinese
            // 
            this._outputChinese.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._outputChinese.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._outputChinese.Location = new System.Drawing.Point(60, 12);
            this._outputChinese.Margin = new System.Windows.Forms.Padding(2);
            this._outputChinese.Name = "_outputChinese";
            this._outputChinese.ReadOnly = true;
            this._outputChinese.Size = new System.Drawing.Size(294, 14);
            this._outputChinese.TabIndex = 3;
            // 
            // _multipleChoiceLayout
            // 
            this._multipleChoiceLayout.ColumnCount = 1;
            this._multipleChoiceLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._multipleChoiceLayout.Controls.Add(this._outputEnglish, 0, 0);
            this._multipleChoiceLayout.Controls.Add(this._firstOption, 0, 1);
            this._multipleChoiceLayout.Controls.Add(this._secondOption, 0, 2);
            this._multipleChoiceLayout.Controls.Add(this._thirdOption, 0, 3);
            this._multipleChoiceLayout.Controls.Add(this._fourthOption, 0, 4);
            this._multipleChoiceLayout.Location = new System.Drawing.Point(4, 10);
            this._multipleChoiceLayout.Margin = new System.Windows.Forms.Padding(2);
            this._multipleChoiceLayout.Name = "_multipleChoiceLayout";
            this._multipleChoiceLayout.RowCount = 5;
            this._multipleChoiceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this._multipleChoiceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._multipleChoiceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._multipleChoiceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._multipleChoiceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._multipleChoiceLayout.Size = new System.Drawing.Size(243, 163);
            this._multipleChoiceLayout.TabIndex = 2;
            this._multipleChoiceLayout.Visible = false;
            // 
            // _outputEnglish
            // 
            this._outputEnglish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._outputEnglish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._outputEnglish.Location = new System.Drawing.Point(2, 9);
            this._outputEnglish.Margin = new System.Windows.Forms.Padding(2);
            this._outputEnglish.Name = "_outputEnglish";
            this._outputEnglish.ReadOnly = true;
            this._outputEnglish.Size = new System.Drawing.Size(238, 14);
            this._outputEnglish.TabIndex = 0;
            // 
            // _firstOption
            // 
            this._firstOption.AccessibleName = "FirstOption";
            this._firstOption.AutoSize = true;
            this._firstOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this._firstOption.Location = new System.Drawing.Point(2, 34);
            this._firstOption.Margin = new System.Windows.Forms.Padding(2);
            this._firstOption.Name = "_firstOption";
            this._firstOption.Size = new System.Drawing.Size(239, 28);
            this._firstOption.TabIndex = 1;
            this._firstOption.TabStop = true;
            this._firstOption.Text = "(1)";
            this._firstOption.UseVisualStyleBackColor = true;
            // 
            // _secondOption
            // 
            this._secondOption.AccessibleName = "SecondOption";
            this._secondOption.AutoSize = true;
            this._secondOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this._secondOption.Location = new System.Drawing.Point(2, 66);
            this._secondOption.Margin = new System.Windows.Forms.Padding(2);
            this._secondOption.Name = "_secondOption";
            this._secondOption.Size = new System.Drawing.Size(239, 28);
            this._secondOption.TabIndex = 2;
            this._secondOption.TabStop = true;
            this._secondOption.Text = "(2)";
            this._secondOption.UseVisualStyleBackColor = true;
            // 
            // _thirdOption
            // 
            this._thirdOption.AccessibleName = "ThirdOption";
            this._thirdOption.AutoSize = true;
            this._thirdOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this._thirdOption.Location = new System.Drawing.Point(2, 98);
            this._thirdOption.Margin = new System.Windows.Forms.Padding(2);
            this._thirdOption.Name = "_thirdOption";
            this._thirdOption.Size = new System.Drawing.Size(239, 28);
            this._thirdOption.TabIndex = 3;
            this._thirdOption.TabStop = true;
            this._thirdOption.Text = "(3)";
            this._thirdOption.UseVisualStyleBackColor = true;
            // 
            // _fourthOption
            // 
            this._fourthOption.AccessibleName = "FourthOption";
            this._fourthOption.AutoSize = true;
            this._fourthOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fourthOption.Location = new System.Drawing.Point(2, 130);
            this._fourthOption.Margin = new System.Windows.Forms.Padding(2);
            this._fourthOption.Name = "_fourthOption";
            this._fourthOption.Size = new System.Drawing.Size(239, 31);
            this._fourthOption.TabIndex = 4;
            this._fourthOption.TabStop = true;
            this._fourthOption.Text = "(4)";
            this._fourthOption.UseVisualStyleBackColor = true;
            // 
            // _stopButton
            // 
            this._stopButton.AccessibleName = "StopButton";
            this._stopButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._stopButton.Enabled = false;
            this._stopButton.Location = new System.Drawing.Point(222, 124);
            this._stopButton.Margin = new System.Windows.Forms.Padding(2);
            this._stopButton.Name = "_stopButton";
            this._stopButton.Size = new System.Drawing.Size(71, 27);
            this._stopButton.TabIndex = 2;
            this._stopButton.Text = "Stop";
            this._stopButton.UseVisualStyleBackColor = true;
            this._stopButton.Click += new System.EventHandler(this.ClickStopButton);
            // 
            // _deadlineProgressBar
            // 
            this._deadlineProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._deadlineProgressBar.Location = new System.Drawing.Point(105, 156);
            this._deadlineProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this._deadlineProgressBar.MarqueeAnimationSpeed = 10;
            this._deadlineProgressBar.Maximum = 10;
            this._deadlineProgressBar.Name = "_deadlineProgressBar";
            this._deadlineProgressBar.Size = new System.Drawing.Size(99, 20);
            this._deadlineProgressBar.TabIndex = 3;
            // 
            // _elapsedTimeLabel
            // 
            this._elapsedTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._elapsedTimeLabel.AutoSize = true;
            this._elapsedTimeLabel.Location = new System.Drawing.Point(25, 160);
            this._elapsedTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._elapsedTimeLabel.Name = "_elapsedTimeLabel";
            this._elapsedTimeLabel.Size = new System.Drawing.Size(53, 12);
            this._elapsedTimeLabel.TabIndex = 4;
            this._elapsedTimeLabel.Text = "00:00:00";
            // 
            // _scoreLabel
            // 
            this._scoreLabel.AccessibleName = "Score";
            this._scoreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._scoreLabel.AutoSize = true;
            this._scoreLabel.Location = new System.Drawing.Point(231, 160);
            this._scoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._scoreLabel.Name = "_scoreLabel";
            this._scoreLabel.Size = new System.Drawing.Size(53, 12);
            this._scoreLabel.TabIndex = 5;
            this._scoreLabel.Text = "Score: 0";
            // 
            // _timerForQuestion
            // 
            this._timerForQuestion.Interval = 1000;
            this._timerForQuestion.Tick += new System.EventHandler(this.TickTimerForQuestion);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 202);
            this.Controls.Add(this._mainLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this._mainMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "TestForm";
            this.Text = "Spelling Checker 1000 words";
            this._mainLayout.ResumeLayout(false);
            this._mainLayout.PerformLayout();
            this._mainMenu.ResumeLayout(false);
            this._mainMenu.PerformLayout();
            this._statusDisplayBar.ResumeLayout(false);
            this._statusDisplayBar.PerformLayout();
            this._testWindow.ResumeLayout(false);
            this._customizationLayout.ResumeLayout(false);
            this._customizationLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numberOfQuestionBox)).EndInit();
            this._fillTheBlankLayout.ResumeLayout(false);
            this._fillTheBlankLayout.PerformLayout();
            this._multipleChoiceLayout.ResumeLayout(false);
            this._multipleChoiceLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainLayout;
        private System.Windows.Forms.GroupBox _testWindow;
        private System.Windows.Forms.StatusStrip _statusDisplayBar;
        private System.Windows.Forms.ToolStripStatusLabel _statusDisplay;
        private System.Windows.Forms.Button _startButton;
        private System.Windows.Forms.Button _nextButton;
        private System.Windows.Forms.TableLayoutPanel _fillTheBlankLayout;
        private System.Windows.Forms.Label _chineseLabel;
        private System.Windows.Forms.Label _englishLabel;
        private System.Windows.Forms.TextBox _inputEnglish;
        private System.Windows.Forms.TextBox _outputChinese;
        private System.Windows.Forms.TableLayoutPanel _multipleChoiceLayout;
        private System.Windows.Forms.TextBox _outputEnglish;
        private System.Windows.Forms.RadioButton _firstOption;
        private System.Windows.Forms.RadioButton _secondOption;
        private System.Windows.Forms.RadioButton _thirdOption;
        private System.Windows.Forms.RadioButton _fourthOption;
        private System.Windows.Forms.MenuStrip _mainMenu;
        private System.Windows.Forms.ToolStripMenuItem _fileMenu;
        private System.Windows.Forms.ToolStripMenuItem _exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _examinationMenu;
        private System.Windows.Forms.ToolStripMenuItem _startMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _nextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _stopMenuItem;
        private System.Windows.Forms.ToolStripSeparator _examinationMenuSeparator;
        private System.Windows.Forms.ToolStripMenuItem _numberOfQuestionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _tenQuestionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _twentyQuestionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _fiftyQuestionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _questionTypeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _allFillInTheBlankMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _allMultipleChoiceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _pickUpRandomlyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _helpMenu;
        private System.Windows.Forms.ToolStripMenuItem _aboutDictionaryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _aboutSpellingCheckerMenuItem;
        private System.Windows.Forms.TableLayoutPanel _customizationLayout;
        private System.Windows.Forms.Label _numberOfQuestionsLabel;
        private System.Windows.Forms.Label _questionTypeLabel;
        private System.Windows.Forms.ComboBox _questionTypeBox;
        private System.Windows.Forms.NumericUpDown _numberOfQuestionBox;
        private System.Windows.Forms.Button _stopButton;
        private System.Windows.Forms.ProgressBar _deadlineProgressBar;
        private System.Windows.Forms.Label _elapsedTimeLabel;
        private System.Windows.Forms.Label _scoreLabel;
        private System.Windows.Forms.Timer _timerForQuestion;
    }
}

