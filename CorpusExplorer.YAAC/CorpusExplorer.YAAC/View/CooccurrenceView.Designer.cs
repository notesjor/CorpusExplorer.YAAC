namespace CorpusExplorer.YAAC.View
{
  partial class CooccurrenceView
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
      this.searchtermSortable2 = new CorpusExplorer.YAAC.Controls.SearchtermSortable();
      this.panel10 = new System.Windows.Forms.Panel();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.searchtermSortable2);
      this.panel2.Controls.Add(this.panel10);
      this.panel2.Location = new System.Drawing.Point(0, 361);
      this.panel2.Size = new System.Drawing.Size(578, 150);
      // 
      // searchtermSortable2
      // 
      this.searchtermSortable2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.searchtermSortable2.Location = new System.Drawing.Point(0, 0);
      this.searchtermSortable2.Name = "searchtermSortable2";
      this.searchtermSortable2.Size = new System.Drawing.Size(378, 150);
      this.searchtermSortable2.TabIndex = 4;
      // 
      // panel10
      // 
      this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel10.Location = new System.Drawing.Point(378, 0);
      this.panel10.Name = "panel10";
      this.panel10.Size = new System.Drawing.Size(200, 150);
      this.panel10.TabIndex = 3;
      // 
      // CooccurrenceView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Name = "CooccurrenceView";
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Controls.SearchtermSortable searchtermSortable2;
    private System.Windows.Forms.Panel panel10;
  }
}
