namespace CorpusExplorer.YAAC.View
{
  partial class WordlistView
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
      this.searchtermSortable3 = new CorpusExplorer.YAAC.Controls.SearchtermSortable();
      this.panel12 = new System.Windows.Forms.Panel();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.searchtermSortable3);
      this.panel2.Controls.Add(this.panel12);
      this.panel2.Location = new System.Drawing.Point(0, 361);
      this.panel2.Size = new System.Drawing.Size(578, 150);
      // 
      // searchtermSortable3
      // 
      this.searchtermSortable3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.searchtermSortable3.Location = new System.Drawing.Point(0, 0);
      this.searchtermSortable3.Name = "searchtermSortable3";
      this.searchtermSortable3.Size = new System.Drawing.Size(378, 150);
      this.searchtermSortable3.TabIndex = 4;
      // 
      // panel12
      // 
      this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel12.Location = new System.Drawing.Point(378, 0);
      this.panel12.Name = "panel12";
      this.panel12.Size = new System.Drawing.Size(200, 150);
      this.panel12.TabIndex = 3;
      // 
      // WordlistView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Name = "WordlistView";
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Controls.SearchtermSortable searchtermSortable3;
    private System.Windows.Forms.Panel panel12;
  }
}
