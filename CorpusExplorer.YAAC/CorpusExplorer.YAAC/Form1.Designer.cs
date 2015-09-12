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
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.page_concordance = new System.Windows.Forms.TabPage();
      this.page_concordancePlot = new System.Windows.Forms.TabPage();
      this.page_fileView = new System.Windows.Forms.TabPage();
      this.page_ngram = new System.Windows.Forms.TabPage();
      this.page_cooccurrences = new System.Windows.Forms.TabPage();
      this.page_wordlist = new System.Windows.Forms.TabPage();
      this.page_keywordlist = new System.Windows.Forms.TabPage();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel4 = new System.Windows.Forms.Panel();
      this.searchtermBase1 = new CorpusExplorer.YAAC.Controls.SearchtermBase();
      this.panel5 = new System.Windows.Forms.Panel();
      this.searchtermBase2 = new CorpusExplorer.YAAC.Controls.SearchtermBase();
      this.panel6 = new System.Windows.Forms.Panel();
      this.panel7 = new System.Windows.Forms.Panel();
      this.panel8 = new System.Windows.Forms.Panel();
      this.searchtermSortable1 = new CorpusExplorer.YAAC.Controls.SearchtermSortable();
      this.panel9 = new System.Windows.Forms.Panel();
      this.searchtermSortable2 = new CorpusExplorer.YAAC.Controls.SearchtermSortable();
      this.panel10 = new System.Windows.Forms.Panel();
      this.panel11 = new System.Windows.Forms.Panel();
      this.searchtermSortable3 = new CorpusExplorer.YAAC.Controls.SearchtermSortable();
      this.panel12 = new System.Windows.Forms.Panel();
      this.panel13 = new System.Windows.Forms.Panel();
      this.searchtermSortable4 = new CorpusExplorer.YAAC.Controls.SearchtermSortable();
      this.panel14 = new System.Windows.Forms.Panel();
      this.panel15 = new System.Windows.Forms.Panel();
      this.searchtermBase3 = new CorpusExplorer.YAAC.Controls.SearchtermBase();
      this.panel16 = new System.Windows.Forms.Panel();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.page_concordance.SuspendLayout();
      this.page_concordancePlot.SuspendLayout();
      this.page_fileView.SuspendLayout();
      this.page_ngram.SuspendLayout();
      this.page_cooccurrences.SuspendLayout();
      this.page_wordlist.SuspendLayout();
      this.page_keywordlist.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel7.SuspendLayout();
      this.panel9.SuspendLayout();
      this.panel11.SuspendLayout();
      this.panel13.SuspendLayout();
      this.panel15.SuspendLayout();
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
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
      this.toolStripMenuItem1.Text = "File";
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
      this.splitContainer1.Panel1.Controls.Add(this.listBox1);
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
      // listBox1
      // 
      this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(0, 30);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(194, 477);
      this.listBox1.TabIndex = 3;
      // 
      // panel2
      // 
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 507);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(194, 30);
      this.panel2.TabIndex = 2;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(194, 30);
      this.panel1.TabIndex = 1;
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
      this.page_concordance.Controls.Add(this.panel15);
      this.page_concordance.Location = new System.Drawing.Point(4, 22);
      this.page_concordance.Name = "page_concordance";
      this.page_concordance.Padding = new System.Windows.Forms.Padding(3);
      this.page_concordance.Size = new System.Drawing.Size(578, 511);
      this.page_concordance.TabIndex = 0;
      this.page_concordance.Text = "Concordance";
      this.page_concordance.UseVisualStyleBackColor = true;
      // 
      // page_concordancePlot
      // 
      this.page_concordancePlot.Controls.Add(this.panel3);
      this.page_concordancePlot.Location = new System.Drawing.Point(4, 22);
      this.page_concordancePlot.Name = "page_concordancePlot";
      this.page_concordancePlot.Padding = new System.Windows.Forms.Padding(3);
      this.page_concordancePlot.Size = new System.Drawing.Size(578, 511);
      this.page_concordancePlot.TabIndex = 1;
      this.page_concordancePlot.Text = "Concordance Plot";
      this.page_concordancePlot.UseVisualStyleBackColor = true;
      // 
      // page_fileView
      // 
      this.page_fileView.Controls.Add(this.panel5);
      this.page_fileView.Location = new System.Drawing.Point(4, 22);
      this.page_fileView.Name = "page_fileView";
      this.page_fileView.Padding = new System.Windows.Forms.Padding(3);
      this.page_fileView.Size = new System.Drawing.Size(578, 511);
      this.page_fileView.TabIndex = 2;
      this.page_fileView.Text = "File View";
      this.page_fileView.UseVisualStyleBackColor = true;
      // 
      // page_ngram
      // 
      this.page_ngram.Controls.Add(this.panel7);
      this.page_ngram.Location = new System.Drawing.Point(4, 22);
      this.page_ngram.Name = "page_ngram";
      this.page_ngram.Padding = new System.Windows.Forms.Padding(3);
      this.page_ngram.Size = new System.Drawing.Size(578, 511);
      this.page_ngram.TabIndex = 3;
      this.page_ngram.Text = "N-Grams";
      this.page_ngram.UseVisualStyleBackColor = true;
      // 
      // page_cooccurrences
      // 
      this.page_cooccurrences.Controls.Add(this.panel9);
      this.page_cooccurrences.Location = new System.Drawing.Point(4, 22);
      this.page_cooccurrences.Name = "page_cooccurrences";
      this.page_cooccurrences.Padding = new System.Windows.Forms.Padding(3);
      this.page_cooccurrences.Size = new System.Drawing.Size(578, 511);
      this.page_cooccurrences.TabIndex = 4;
      this.page_cooccurrences.Text = "Cooccurrences";
      this.page_cooccurrences.UseVisualStyleBackColor = true;
      // 
      // page_wordlist
      // 
      this.page_wordlist.Controls.Add(this.panel11);
      this.page_wordlist.Location = new System.Drawing.Point(4, 22);
      this.page_wordlist.Name = "page_wordlist";
      this.page_wordlist.Padding = new System.Windows.Forms.Padding(3);
      this.page_wordlist.Size = new System.Drawing.Size(578, 511);
      this.page_wordlist.TabIndex = 5;
      this.page_wordlist.Text = "Word List";
      this.page_wordlist.UseVisualStyleBackColor = true;
      // 
      // page_keywordlist
      // 
      this.page_keywordlist.Controls.Add(this.panel13);
      this.page_keywordlist.Location = new System.Drawing.Point(4, 22);
      this.page_keywordlist.Name = "page_keywordlist";
      this.page_keywordlist.Padding = new System.Windows.Forms.Padding(3);
      this.page_keywordlist.Size = new System.Drawing.Size(578, 511);
      this.page_keywordlist.TabIndex = 6;
      this.page_keywordlist.Text = "Keyword List";
      this.page_keywordlist.UseVisualStyleBackColor = true;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.searchtermBase1);
      this.panel3.Controls.Add(this.panel4);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel3.Location = new System.Drawing.Point(3, 418);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(572, 90);
      this.panel3.TabIndex = 0;
      // 
      // panel4
      // 
      this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel4.Location = new System.Drawing.Point(372, 0);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(200, 90);
      this.panel4.TabIndex = 0;
      // 
      // searchtermBase1
      // 
      this.searchtermBase1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.searchtermBase1.Location = new System.Drawing.Point(0, 0);
      this.searchtermBase1.Name = "searchtermBase1";
      this.searchtermBase1.Size = new System.Drawing.Size(372, 90);
      this.searchtermBase1.TabIndex = 1;
      // 
      // panel5
      // 
      this.panel5.Controls.Add(this.searchtermBase2);
      this.panel5.Controls.Add(this.panel6);
      this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel5.Location = new System.Drawing.Point(3, 418);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(572, 90);
      this.panel5.TabIndex = 1;
      // 
      // searchtermBase2
      // 
      this.searchtermBase2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.searchtermBase2.Location = new System.Drawing.Point(0, 0);
      this.searchtermBase2.Name = "searchtermBase2";
      this.searchtermBase2.Size = new System.Drawing.Size(372, 90);
      this.searchtermBase2.TabIndex = 1;
      // 
      // panel6
      // 
      this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel6.Location = new System.Drawing.Point(372, 0);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(200, 90);
      this.panel6.TabIndex = 0;
      // 
      // panel7
      // 
      this.panel7.Controls.Add(this.searchtermSortable1);
      this.panel7.Controls.Add(this.panel8);
      this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel7.Location = new System.Drawing.Point(3, 358);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(572, 150);
      this.panel7.TabIndex = 0;
      // 
      // panel8
      // 
      this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel8.Location = new System.Drawing.Point(372, 0);
      this.panel8.Name = "panel8";
      this.panel8.Size = new System.Drawing.Size(200, 150);
      this.panel8.TabIndex = 1;
      // 
      // searchtermSortable1
      // 
      this.searchtermSortable1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.searchtermSortable1.Location = new System.Drawing.Point(0, 0);
      this.searchtermSortable1.Name = "searchtermSortable1";
      this.searchtermSortable1.Size = new System.Drawing.Size(372, 150);
      this.searchtermSortable1.TabIndex = 2;
      // 
      // panel9
      // 
      this.panel9.Controls.Add(this.searchtermSortable2);
      this.panel9.Controls.Add(this.panel10);
      this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel9.Location = new System.Drawing.Point(3, 358);
      this.panel9.Name = "panel9";
      this.panel9.Size = new System.Drawing.Size(572, 150);
      this.panel9.TabIndex = 1;
      // 
      // searchtermSortable2
      // 
      this.searchtermSortable2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.searchtermSortable2.Location = new System.Drawing.Point(0, 0);
      this.searchtermSortable2.Name = "searchtermSortable2";
      this.searchtermSortable2.Size = new System.Drawing.Size(372, 150);
      this.searchtermSortable2.TabIndex = 2;
      // 
      // panel10
      // 
      this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel10.Location = new System.Drawing.Point(372, 0);
      this.panel10.Name = "panel10";
      this.panel10.Size = new System.Drawing.Size(200, 150);
      this.panel10.TabIndex = 1;
      // 
      // panel11
      // 
      this.panel11.Controls.Add(this.searchtermSortable3);
      this.panel11.Controls.Add(this.panel12);
      this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel11.Location = new System.Drawing.Point(3, 358);
      this.panel11.Name = "panel11";
      this.panel11.Size = new System.Drawing.Size(572, 150);
      this.panel11.TabIndex = 1;
      // 
      // searchtermSortable3
      // 
      this.searchtermSortable3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.searchtermSortable3.Location = new System.Drawing.Point(0, 0);
      this.searchtermSortable3.Name = "searchtermSortable3";
      this.searchtermSortable3.Size = new System.Drawing.Size(372, 150);
      this.searchtermSortable3.TabIndex = 2;
      // 
      // panel12
      // 
      this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel12.Location = new System.Drawing.Point(372, 0);
      this.panel12.Name = "panel12";
      this.panel12.Size = new System.Drawing.Size(200, 150);
      this.panel12.TabIndex = 1;
      // 
      // panel13
      // 
      this.panel13.Controls.Add(this.searchtermSortable4);
      this.panel13.Controls.Add(this.panel14);
      this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel13.Location = new System.Drawing.Point(3, 358);
      this.panel13.Name = "panel13";
      this.panel13.Size = new System.Drawing.Size(572, 150);
      this.panel13.TabIndex = 1;
      // 
      // searchtermSortable4
      // 
      this.searchtermSortable4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.searchtermSortable4.Location = new System.Drawing.Point(0, 0);
      this.searchtermSortable4.Name = "searchtermSortable4";
      this.searchtermSortable4.Size = new System.Drawing.Size(372, 150);
      this.searchtermSortable4.TabIndex = 2;
      // 
      // panel14
      // 
      this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel14.Location = new System.Drawing.Point(372, 0);
      this.panel14.Name = "panel14";
      this.panel14.Size = new System.Drawing.Size(200, 150);
      this.panel14.TabIndex = 1;
      // 
      // panel15
      // 
      this.panel15.Controls.Add(this.searchtermBase3);
      this.panel15.Controls.Add(this.panel16);
      this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel15.Location = new System.Drawing.Point(3, 418);
      this.panel15.Name = "panel15";
      this.panel15.Size = new System.Drawing.Size(572, 90);
      this.panel15.TabIndex = 1;
      // 
      // searchtermBase3
      // 
      this.searchtermBase3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.searchtermBase3.Location = new System.Drawing.Point(0, 0);
      this.searchtermBase3.Name = "searchtermBase3";
      this.searchtermBase3.Size = new System.Drawing.Size(372, 90);
      this.searchtermBase3.TabIndex = 1;
      // 
      // panel16
      // 
      this.panel16.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel16.Location = new System.Drawing.Point(372, 0);
      this.panel16.Name = "panel16";
      this.panel16.Size = new System.Drawing.Size(200, 90);
      this.panel16.TabIndex = 0;
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
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.page_concordance.ResumeLayout(false);
      this.page_concordancePlot.ResumeLayout(false);
      this.page_fileView.ResumeLayout(false);
      this.page_ngram.ResumeLayout(false);
      this.page_cooccurrences.ResumeLayout(false);
      this.page_wordlist.ResumeLayout(false);
      this.page_keywordlist.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel5.ResumeLayout(false);
      this.panel7.ResumeLayout(false);
      this.panel9.ResumeLayout(false);
      this.panel11.ResumeLayout(false);
      this.panel13.ResumeLayout(false);
      this.panel15.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.ListBox listBox1;
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
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel4;
    private Controls.SearchtermBase searchtermBase1;
    private System.Windows.Forms.Panel panel5;
    private Controls.SearchtermBase searchtermBase2;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.Panel panel7;
    private Controls.SearchtermSortable searchtermSortable1;
    private System.Windows.Forms.Panel panel8;
    private System.Windows.Forms.Panel panel9;
    private Controls.SearchtermSortable searchtermSortable2;
    private System.Windows.Forms.Panel panel10;
    private System.Windows.Forms.Panel panel11;
    private Controls.SearchtermSortable searchtermSortable3;
    private System.Windows.Forms.Panel panel12;
    private System.Windows.Forms.Panel panel13;
    private Controls.SearchtermSortable searchtermSortable4;
    private System.Windows.Forms.Panel panel14;
    private System.Windows.Forms.Panel panel15;
    private Controls.SearchtermBase searchtermBase3;
    private System.Windows.Forms.Panel panel16;
  }
}

