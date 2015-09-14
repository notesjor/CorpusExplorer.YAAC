namespace CorpusExplorer.YAAC.View
{
  partial class ConcordanceView
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
      this.searchtermBase3 = new CorpusExplorer.YAAC.Controls.SearchtermBase();
      this.panel16 = new System.Windows.Forms.Panel();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.searchtermBase3);
      this.panel2.Controls.Add(this.panel16);
      // 
      // searchtermBase3
      // 
      this.searchtermBase3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.searchtermBase3.Location = new System.Drawing.Point(0, 0);
      this.searchtermBase3.Name = "searchtermBase3";
      this.searchtermBase3.Size = new System.Drawing.Size(378, 90);
      this.searchtermBase3.TabIndex = 3;
      // 
      // panel16
      // 
      this.panel16.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel16.Location = new System.Drawing.Point(378, 0);
      this.panel16.Name = "panel16";
      this.panel16.Size = new System.Drawing.Size(200, 90);
      this.panel16.TabIndex = 2;
      // 
      // ConcordanceView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Name = "ConcordanceView";
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Controls.SearchtermBase searchtermBase3;
    private System.Windows.Forms.Panel panel16;
  }
}
