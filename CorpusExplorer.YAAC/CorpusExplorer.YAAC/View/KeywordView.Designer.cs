namespace CorpusExplorer.YAAC.View
{
  partial class KeywordView
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

    #region Vom Komponenten-Designer generierter Code

    /// <summary> 
    /// Erforderliche Methode für die Designerunterstützung. 
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.searchtermSortable4 = new CorpusExplorer.YAAC.Controls.SearchtermSortable();
      this.panel14 = new System.Windows.Forms.Panel();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.searchtermSortable4);
      this.panel2.Controls.Add(this.panel14);
      this.panel2.Location = new System.Drawing.Point(0, 361);
      this.panel2.Size = new System.Drawing.Size(578, 150);
      // 
      // searchtermSortable4
      // 
      this.searchtermSortable4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.searchtermSortable4.Location = new System.Drawing.Point(0, 0);
      this.searchtermSortable4.Name = "searchtermSortable4";
      this.searchtermSortable4.Size = new System.Drawing.Size(378, 150);
      this.searchtermSortable4.TabIndex = 4;
      // 
      // panel14
      // 
      this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel14.Location = new System.Drawing.Point(378, 0);
      this.panel14.Name = "panel14";
      this.panel14.Size = new System.Drawing.Size(200, 150);
      this.panel14.TabIndex = 3;
      // 
      // KeywordView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Name = "KeywordView";
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Controls.SearchtermSortable searchtermSortable4;
    private System.Windows.Forms.Panel panel14;
  }
}
