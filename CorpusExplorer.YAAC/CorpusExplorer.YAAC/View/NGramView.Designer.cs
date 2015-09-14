namespace CorpusExplorer.YAAC.View
{
  partial class NGramView
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
      this.searchtermSortable1 = new CorpusExplorer.YAAC.Controls.SearchtermSortable();
      this.panel8 = new System.Windows.Forms.Panel();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.searchtermSortable1);
      this.panel2.Controls.Add(this.panel8);
      this.panel2.Location = new System.Drawing.Point(0, 361);
      this.panel2.Size = new System.Drawing.Size(578, 150);
      // 
      // searchtermSortable1
      // 
      this.searchtermSortable1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.searchtermSortable1.Location = new System.Drawing.Point(0, 0);
      this.searchtermSortable1.Name = "searchtermSortable1";
      this.searchtermSortable1.Size = new System.Drawing.Size(378, 150);
      this.searchtermSortable1.TabIndex = 4;
      // 
      // panel8
      // 
      this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel8.Location = new System.Drawing.Point(378, 0);
      this.panel8.Name = "panel8";
      this.panel8.Size = new System.Drawing.Size(200, 150);
      this.panel8.TabIndex = 3;
      // 
      // NGramView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Name = "NGramView";
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Controls.SearchtermSortable searchtermSortable1;
    private System.Windows.Forms.Panel panel8;
  }
}
