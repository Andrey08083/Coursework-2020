using CefSharp;

namespace Курсач__Framework_
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.currentPageLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.actionsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.searchButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHeader = new System.Windows.Forms.MenuStrip();
            this.otherToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.pageReload = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.forwardSearch = new System.Windows.Forms.Button();
            this.backSearch = new System.Windows.Forms.Button();
            this.formContainer = new System.Windows.Forms.SplitContainer();
            this.treePages = new System.Windows.Forms.TreeView();
            this.змінитиТемуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coldButton = new System.Windows.Forms.ToolStripMenuItem();
            this.warmButton = new System.Windows.Forms.ToolStripMenuItem();
            this.grayButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHeader.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formContainer)).BeginInit();
            this.formContainer.Panel1.SuspendLayout();
            this.formContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentPageLabel
            // 
            this.currentPageLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.currentPageLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentPageLabel.Location = new System.Drawing.Point(121, 724);
            this.currentPageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentPageLabel.Name = "currentPageLabel";
            this.currentPageLabel.Size = new System.Drawing.Size(1357, 28);
            this.currentPageLabel.TabIndex = 0;
            this.currentPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.Location = new System.Drawing.Point(13, 724);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 28);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.forwardButton.Location = new System.Drawing.Point(1486, 724);
            this.forwardButton.Margin = new System.Windows.Forms.Padding(4);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(100, 28);
            this.forwardButton.TabIndex = 2;
            this.forwardButton.Text = "Вперед";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // actionsToolStrip
            // 
            this.actionsToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchButton});
            this.actionsToolStrip.Name = "actionsToolStrip";
            this.actionsToolStrip.Size = new System.Drawing.Size(41, 24);
            this.actionsToolStrip.Text = "Дії";
            // 
            // searchButton
            // 
            this.searchButton.CheckOnClick = true;
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(192, 26);
            this.searchButton.Text = "Пошук (Ctrl+F)";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // menuHeader
            // 
            this.menuHeader.BackColor = System.Drawing.Color.Linen;
            this.menuHeader.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStrip,
            this.otherToolStrip,
            this.налаштуванняToolStripMenuItem});
            this.menuHeader.Location = new System.Drawing.Point(0, 0);
            this.menuHeader.Name = "menuHeader";
            this.menuHeader.Size = new System.Drawing.Size(1599, 28);
            this.menuHeader.TabIndex = 6;
            this.menuHeader.Text = "menuStrip1";
            // 
            // otherToolStrip
            // 
            this.otherToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageReload,
            this.aboutAuthor,
            this.aboutProgram});
            this.otherToolStrip.Name = "otherToolStrip";
            this.otherToolStrip.Size = new System.Drawing.Size(56, 24);
            this.otherToolStrip.Text = "Інше";
            // 
            // pageReload
            // 
            this.pageReload.Name = "pageReload";
            this.pageReload.Size = new System.Drawing.Size(291, 26);
            this.pageReload.Text = "Перезавантаження сторінки";
            this.pageReload.Click += new System.EventHandler(this.pageReload_Click);
            // 
            // aboutAuthor
            // 
            this.aboutAuthor.Name = "aboutAuthor";
            this.aboutAuthor.Size = new System.Drawing.Size(291, 26);
            this.aboutAuthor.Text = "Про автора";
            this.aboutAuthor.Click += new System.EventHandler(this.aboutAuthor_Click);
            // 
            // aboutProgram
            // 
            this.aboutProgram.Name = "aboutProgram";
            this.aboutProgram.Size = new System.Drawing.Size(291, 26);
            this.aboutProgram.Text = "Про програму";
            this.aboutProgram.Click += new System.EventHandler(this.aboutProgram_Click);
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.змінитиТемуToolStripMenuItem});
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            this.налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.налаштуванняToolStripMenuItem.Text = "Налаштування";
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchGroupBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.searchGroupBox.Controls.Add(this.searchBox);
            this.searchGroupBox.Controls.Add(this.forwardSearch);
            this.searchGroupBox.Controls.Add(this.backSearch);
            this.searchGroupBox.Enabled = false;
            this.searchGroupBox.Location = new System.Drawing.Point(3, 355);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(205, 82);
            this.searchGroupBox.TabIndex = 7;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Пошук";
            this.searchGroupBox.Visible = false;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(7, 21);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(192, 22);
            this.searchBox.TabIndex = 2;
            // 
            // forwardSearch
            // 
            this.forwardSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.forwardSearch.Location = new System.Drawing.Point(126, 49);
            this.forwardSearch.Name = "forwardSearch";
            this.forwardSearch.Size = new System.Drawing.Size(73, 23);
            this.forwardSearch.TabIndex = 1;
            this.forwardSearch.Text = "Вперед";
            this.forwardSearch.UseVisualStyleBackColor = true;
            this.forwardSearch.Click += new System.EventHandler(this.forwardSearch_Click);
            // 
            // backSearch
            // 
            this.backSearch.Location = new System.Drawing.Point(6, 49);
            this.backSearch.Name = "backSearch";
            this.backSearch.Size = new System.Drawing.Size(68, 23);
            this.backSearch.TabIndex = 0;
            this.backSearch.Text = "Назад";
            this.backSearch.UseVisualStyleBackColor = true;
            this.backSearch.Click += new System.EventHandler(this.backSearch_Click);
            // 
            // formContainer
            // 
            this.formContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formContainer.Location = new System.Drawing.Point(0, 28);
            this.formContainer.Margin = new System.Windows.Forms.Padding(0);
            this.formContainer.Name = "formContainer";
            // 
            // formContainer.Panel1
            // 
            this.formContainer.Panel1.Controls.Add(this.treePages);
            this.formContainer.Panel1.Controls.Add(this.searchGroupBox);
            this.formContainer.Panel1MinSize = 200;
            this.formContainer.Panel2MinSize = 500;
            this.formContainer.Size = new System.Drawing.Size(1599, 682);
            this.formContainer.SplitterDistance = 216;
            this.formContainer.TabIndex = 12;
            // 
            // treePages
            // 
            this.treePages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treePages.BackColor = System.Drawing.Color.Linen;
            this.treePages.Location = new System.Drawing.Point(0, 0);
            this.treePages.Name = "treePages";
            this.treePages.Size = new System.Drawing.Size(213, 349);
            this.treePages.TabIndex = 0;
            this.treePages.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.pageList);
            // 
            // змінитиТемуToolStripMenuItem
            // 
            this.змінитиТемуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coldButton,
            this.warmButton,
            this.grayButton});
            this.змінитиТемуToolStripMenuItem.Name = "змінитиТемуToolStripMenuItem";
            this.змінитиТемуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.змінитиТемуToolStripMenuItem.Text = "Змінити тему";
            // 
            // coldButton
            // 
            this.coldButton.Name = "coldButton";
            this.coldButton.Size = new System.Drawing.Size(224, 26);
            this.coldButton.Text = "Холодна";
            this.coldButton.Click += new System.EventHandler(this.changeTheme);
            // 
            // warmButton
            // 
            this.warmButton.Name = "warmButton";
            this.warmButton.Size = new System.Drawing.Size(224, 26);
            this.warmButton.Text = "Тепла";
            this.warmButton.Click += new System.EventHandler(this.changeTheme);
            // 
            // grayButton
            // 
            this.grayButton.Name = "grayButton";
            this.grayButton.Size = new System.Drawing.Size(224, 26);
            this.grayButton.Text = "Сіра";
            this.grayButton.Click += new System.EventHandler(this.changeTheme);
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1599, 761);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.currentPageLabel);
            this.Controls.Add(this.formContainer);
            this.Controls.Add(this.menuHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "mainForm";
            this.Text = "Керівник по ритм-іграх";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.menuHeader.ResumeLayout(false);
            this.menuHeader.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.formContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formContainer)).EndInit();
            this.formContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentPageLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem searchButton;
        private System.Windows.Forms.MenuStrip menuHeader;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button forwardSearch;
        private System.Windows.Forms.Button backSearch;
        private System.Windows.Forms.ToolStripMenuItem pageReload;
        private System.Windows.Forms.ToolStripMenuItem aboutAuthor;
        private System.Windows.Forms.ToolStripMenuItem otherToolStrip;
        private System.Windows.Forms.SplitContainer formContainer;
        private System.Windows.Forms.TreeView treePages;
        private System.Windows.Forms.ToolStripMenuItem aboutProgram;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem змінитиТемуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coldButton;
        private System.Windows.Forms.ToolStripMenuItem warmButton;
        private System.Windows.Forms.ToolStripMenuItem grayButton;
    }
}

