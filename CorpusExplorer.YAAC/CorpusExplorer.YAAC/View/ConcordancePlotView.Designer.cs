namespace CorpusExplorer.YAAC.View
{
  partial class ConcordancePlotView
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
      this.searchtermBase1 = new CorpusExplorer.YAAC.Controls.SearchtermBase();
      this.panel4 = new System.Windows.Forms.Panel();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.searchtermBase1);
      this.panel2.Controls.Add(this.panel4);
      // 
      // searchtermBase1
      // 
      this.searchtermBase1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.searchtermBase1.Location = new System.Drawing.Point(0, 0);
      this.searchtermBase1.Name = "searchtermBase1";
      this.searchtermBase1.Size = new System.Drawing.Size(378, 90);
      this.searchtermBase1.TabIndex = 3;
      // 
      // panel4
      // 
      this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel4.Location = new System.Drawing.Point(378, 0);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(200, 90);
      this.panel4.TabIndex = 2;
      // 
      // ConcordancePlotView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Name = "ConcordancePlotView";
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Controls.SearchtermBase searchtermBase1;
    private System.Windows.Forms.Panel panel4;
  }
}
