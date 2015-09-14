namespace CorpusExplorer.YAAC
{
  partial class Form1
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.menu_file_open_file = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.menu_file_close_all = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.list_FileList = new System.Windows.Forms.ListBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.shortInformationLabel2 = new CorpusExplorer.YAAC.Controls.ShortInformationLabel();
      this.shortInformationLabel1 = new CorpusExplorer.YAAC.Controls.ShortInformationLabel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.page_concordance = new System.Windows.Forms.TabPage();
      this.concordanceView1 = new CorpusExplorer.YAAC.View.ConcordanceView();
      this.page_concordancePlot = new System.Windows.Forms.TabPage();
      this.concordancePlotView1 = new CorpusExplorer.YAAC.View.ConcordancePlotView();
      this.page_fileView = new System.Windows.Forms.TabPage();
      this.fileView1 = new CorpusExplorer.YAAC.View.FileView();
      this.page_ngram = new System.Windows.Forms.TabPage();
      this.nGramView1 = new CorpusExplorer.YAAC.View.NGramView();
      this.page_cooccurrences = new System.Windows.Forms.TabPage();
      this.cooccurrenceView1 = new CorpusExplorer.YAAC.View.CooccurrenceView();
      this.page_wordlist = new System.Windows.Forms.TabPage();
      this.wordlistView1 = new CorpusExplorer.YAAC.View.WordlistView();
      this.page_keywordlist = new System.Windows.Forms.TabPage();
      this.keywordView1 = new CorpusExplorer.YAAC.View.KeywordView();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.page_concordance.SuspendLayout();
      this.page_concordancePlot.SuspendLayout();
      this.page_fileView.SuspendLayout();
      this.page_ngram.SuspendLayout();
      this.page_cooccurrences.SuspendLayout();
      this.page_wordlist.SuspendLayout();
      this.page_keywordlist.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(784, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file_open_file,
            this.toolStripSeparator1,
            this.menu_file_close_all,
            this.toolStripSeparator2,
            this.menu_exit});
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
      this.toolStripMenuItem1.Text = "File";
      // 
      // menu_file_open_file
      // 
      this.menu_file_open_file.Name = "menu_file_open_file";
      this.menu_file_open_file.Size = new System.Drawing.Size(152, 22);
      this.menu_file_open_file.Text = "Open File(s)";
      this.menu_file_open_file.Click += new System.EventHandler(this.menu_file_open_file_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
      // 
      // menu_file_close_all
      // 
      this.menu_file_close_all.Name = "menu_file_close_all";
      this.menu_file_close_all.Size = new System.Drawing.Size(152, 22);
      this.menu_file_close_all.Text = "Close All Files";
      this.menu_file_close_all.Click += new System.EventHandler(this.menu_file_close_all_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
      // 
      // menu_exit
      // 
      this.menu_exit.Name = "menu_exit";
      this.menu_exit.Size = new System.Drawing.Size(152, 22);
      this.menu_exit.Text = "Exit";
      this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(61, 20);
      this.toolStripMenuItem2.Text = "Settings";
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "Help";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 24);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.list_FileList);
      this.splitContainer1.Panel1.Controls.Add(this.panel2);
      this.splitContainer1.Panel1.Controls.Add(this.panel1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
      this.splitContainer1.Size = new System.Drawing.Size(784, 537);
      this.splitContainer1.SplitterDistance = 194;
      this.splitContainer1.TabIndex = 1;
      // 
      // list_FileList
      // 
      this.list_FileList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.list_FileList.FormattingEnabled = true;
      this.list_FileList.Location = new System.Drawing.Point(0, 30);
      this.list_FileList.Name = "list_FileList";
      this.list_FileList.Size = new System.Drawing.Size(194, 455);
      this.list_FileList.TabIndex = 3;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.shortInformationLabel2);
      this.panel2.Controls.Add(this.shortInformationLabel1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 485);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(194, 52);
      this.panel2.TabIndex = 2;
      // 
      // shortInformationLabel2
      // 
      this.shortInformationLabel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.shortInformationLabel2.Label = "Token:";
      this.shortInformationLabel2.Location = new System.Drawing.Point(0, 24);
      this.shortInformationLabel2.Name = "shortInformationLabel2";
      this.shortInformationLabel2.Size = new System.Drawing.Size(194, 28);
      this.shortInformationLabel2.SplitterDistance = 0.39896373056994816D;
      this.shortInformationLabel2.TabIndex = 1;
      this.shortInformationLabel2.Value = "0000";
      // 
      // shortInformationLabel1
      // 
      this.shortInformationLabel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.shortInformationLabel1.Label = "Documents:";
      this.shortInformationLabel1.Location = new System.Drawing.Point(0, 0);
      this.shortInformationLabel1.Name = "shortInformationLabel1";
      this.shortInformationLabel1.Size = new System.Drawing.Size(194, 24);
      this.shortInformationLabel1.SplitterDistance = 0.39896373056994816D;
      this.shortInformationLabel1.TabIndex = 0;
      this.shortInformationLabel1.Value = "0000";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.pictureBox3);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(194, 30);
      this.panel1.TabIndex = 1;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
      this.pictureBox1.Image = global::CorpusExplorer.YAAC.Properties.Resources.Document_Add_01;
      this.pictureBox1.Location = new System.Drawing.Point(134, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(30, 30);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.menu_file_open_file_Click);
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Left;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 30);
      this.label1.TabIndex = 0;
      this.label1.Text = "Corpus:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // pictureBox3
      // 
      this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
      this.pictureBox3.Image = global::CorpusExplorer.YAAC.Properties.Resources.Garbage;
      this.pictureBox3.Location = new System.Drawing.Point(164, 0);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(30, 30);
      this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox3.TabIndex = 3;
      this.pictureBox3.TabStop = false;
      this.pictureBox3.Click += new System.EventHandler(this.menu_file_close_all_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.page_concordance);
      this.tabControl1.Controls.Add(this.page_concordancePlot);
      this.tabControl1.Controls.Add(this.page_fileView);
      this.tabControl1.Controls.Add(this.page_ngram);
      this.tabControl1.Controls.Add(this.page_cooccurrences);
      this.tabControl1.Controls.Add(this.page_wordlist);
      this.tabControl1.Controls.Add(this.page_keywordlist);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(586, 537);
      this.tabControl1.TabIndex = 0;
      // 
      // page_concordance
      // 
      this.page_concordance.Controls.Add(this.concordanceView1);
      this.page_concordance.Location = new System.Drawing.Point(4, 22);
      this.page_concordance.Name = "page_concordance";
      this.page_concordance.Padding = new System.Windows.Forms.Padding(3);
      this.page_concordance.Size = new System.Drawing.Size(578, 511);
      this.page_concordance.TabIndex = 0;
      this.page_concordance.Text = "Concordance";
      this.page_concordance.UseVisualStyleBackColor = true;
      // 
      // concordanceView1
      // 
      this.concordanceView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.concordanceView1.Location = new System.Drawing.Point(3, 3);
      this.concordanceView1.Name = "concordanceView1";
      this.concordanceView1.Size = new System.Drawing.Size(572, 505);
      this.concordanceView1.TabIndex = 0;
      // 
      // page_concordancePlot
      // 
      this.page_concordancePlot.Controls.Add(this.concordancePlotView1);
      this.page_concordancePlot.Location = new System.Drawing.Point(4, 22);
      this.page_concordancePlot.Name = "page_concordancePlot";
      this.page_concordancePlot.Padding = new System.Windows.Forms.Padding(3);
      this.page_concordancePlot.Size = new System.Drawing.Size(578, 511);
      this.page_concordancePlot.TabIndex = 1;
      this.page_concordancePlot.Text = "Concordance Plot";
      this.page_concordancePlot.UseVisualStyleBackColor = true;
      // 
      // concordancePlotView1
      // 
      this.concordancePlotView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.concordancePlotView1.Location = new System.Drawing.Point(3, 3);
      this.concordancePlotView1.Name = "concordancePlotView1";
      this.concordancePlotView1.Size = new System.Drawing.Size(572, 505);
      this.concordancePlotView1.TabIndex = 0;
      // 
      // page_fileView
      // 
      this.page_fileView.Controls.Add(this.fileView1);
      this.page_fileView.Location = new System.Drawing.Point(4, 22);
      this.page_fileView.Name = "page_fileView";
      this.page_fileView.Padding = new System.Windows.Forms.Padding(3);
      this.page_fileView.Size = new System.Drawing.Size(578, 511);
      this.page_fileView.TabIndex = 2;
      this.page_fileView.Text = "File View";
      this.page_fileView.UseVisualStyleBackColor = true;
      // 
      // fileView1
      // 
      this.fileView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.fileView1.Location = new System.Drawing.Point(3, 3);
      this.fileView1.Name = "fileView1";
      this.fileView1.Size = new System.Drawing.Size(572, 505);
      this.fileView1.TabIndex = 0;
      // 
      // page_ngram
      // 
      this.page_ngram.Controls.Add(this.nGramView1);
      this.page_ngram.Location = new System.Drawing.Point(4, 22);
      this.page_ngram.Name = "page_ngram";
      this.page_ngram.Padding = new System.Windows.Forms.Padding(3);
      this.page_ngram.Size = new System.Drawing.Size(578, 511);
      this.page_ngram.TabIndex = 3;
      this.page_ngram.Text = "N-Grams";
      this.page_ngram.UseVisualStyleBackColor = true;
      // 
      // nGramView1
      // 
      this.nGramView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.nGramView1.Location = new System.Drawing.Point(3, 3);
      this.nGramView1.Name = "nGramView1";
      this.nGramView1.Size = new System.Drawing.Size(572, 505);
      this.nGramView1.TabIndex = 0;
      // 
      // page_cooccurrences
      // 
      this.page_cooccurrences.Controls.Add(this.cooccurrenceView1);
      this.page_cooccurrences.Location = new System.Drawing.Point(4, 22);
      this.page_cooccurrences.Name = "page_cooccurrences";
      this.page_cooccurrences.Padding = new System.Windows.Forms.Padding(3);
      this.page_cooccurrences.Size = new System.Drawing.Size(578, 511);
      this.page_cooccurrences.TabIndex = 4;
      this.page_cooccurrences.Text = "Cooccurrences";
      this.page_cooccurrences.UseVisualStyleBackColor = true;
      // 
      // cooccurrenceView1
      // 
      this.cooccurrenceView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cooccurrenceView1.Location = new System.Drawing.Point(3, 3);
      this.cooccurrenceView1.Name = "cooccurrenceView1";
      this.cooccurrenceView1.Size = new System.Drawing.Size(572, 505);
      this.cooccurrenceView1.TabIndex = 0;
      // 
      // page_wordlist
      // 
      this.page_wordlist.Controls.Add(this.wordlistView1);
      this.page_wordlist.Location = new System.Drawing.Point(4, 22);
      this.page_wordlist.Name = "page_wordlist";
      this.page_wordlist.Padding = new System.Windows.Forms.Padding(3);
      this.page_wordlist.Size = new System.Drawing.Size(578, 511);
      this.page_wordlist.TabIndex = 5;
      this.page_wordlist.Text = "Word List";
      this.page_wordlist.UseVisualStyleBackColor = true;
      // 
      // wordlistView1
      // 
      this.wordlistView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.wordlistView1.Location = new System.Drawing.Point(3, 3);
      this.wordlistView1.Name = "wordlistView1";
      this.wordlistView1.Size = new System.Drawing.Size(572, 505);
      this.wordlistView1.TabIndex = 0;
      // 
      // page_keywordlist
      // 
      this.page_keywordlist.Controls.Add(this.keywordView1);
      this.page_keywordlist.Location = new System.Drawing.Point(4, 22);
      this.page_keywordlist.Name = "page_keywordlist";
      this.page_keywordlist.Padding = new System.Windows.Forms.Padding(3);
      this.page_keywordlist.Size = new System.Drawing.Size(578, 511);
      this.page_keywordlist.TabIndex = 6;
      this.page_keywordlist.Text = "Keyword List";
      this.page_keywordlist.UseVisualStyleBackColor = true;
      // 
      // keywordView1
      // 
      this.keywordView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.keywordView1.Location = new System.Drawing.Point(3, 3);
      this.keywordView1.Name = "keywordView1";
      this.keywordView1.Size = new System.Drawing.Size(572, 505);
      this.keywordView1.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 561);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.page_concordance.ResumeLayout(false);
      this.page_concordancePlot.ResumeLayout(false);
      this.page_fileView.ResumeLayout(false);
      this.page_ngram.ResumeLayout(false);
      this.page_cooccurrences.ResumeLayout(false);
      this.page_wordlist.ResumeLayout(false);
      this.page_keywordlist.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.ListBox list_FileList;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage page_concordance;
    private System.Windows.Forms.TabPage page_concordancePlot;
    private System.Windows.Forms.TabPage page_fileView;
    private System.Windows.Forms.TabPage page_ngram;
    private System.Windows.Forms.TabPage page_cooccurrences;
    private System.Windows.Forms.TabPage page_wordlist;
    private System.Windows.Forms.TabPage page_keywordlist;
    private System.Windows.Forms.PictureBox pictureBox1;
    private Controls.ShortInformationLabel shortInformationLabel2;
    private Controls.ShortInformationLabel shortInformationLabel1;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.ToolStripMenuItem menu_file_open_file;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem menu_file_close_all;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem menu_exit;
    private View.ConcordanceView concordanceView1;
    private View.ConcordancePlotView concordancePlotView1;
    private View.FileView fileView1;
    private View.NGramView nGramView1;
    private View.CooccurrenceView cooccurrenceView1;
    private View.WordlistView wordlistView1;
    private View.KeywordView keywordView1;
  }
}

