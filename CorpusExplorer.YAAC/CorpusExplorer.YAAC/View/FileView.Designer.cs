namespace CorpusExplorer.YAAC.View
{
  partial class FileView
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
      this.searchtermBase2 = new CorpusExplorer.YAAC.Controls.SearchtermBase();
      this.panel6 = new System.Windows.Forms.Panel();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.searchtermBase2);
      this.panel2.Controls.Add(this.panel6);
      // 
      // searchtermBase2
      // 
      this.searchtermBase2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.searchtermBase2.Location = new System.Drawing.Point(0, 0);
      this.searchtermBase2.Name = "searchtermBase2";
      this.searchtermBase2.Size = new System.Drawing.Size(378, 90);
      this.searchtermBase2.TabIndex = 3;
      // 
      // panel6
      // 
      this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel6.Location = new System.Drawing.Point(378, 0);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(200, 90);
      this.panel6.TabIndex = 2;
      // 
      // FileView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Name = "FileView";
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Controls.SearchtermBase searchtermBase2;
    private System.Windows.Forms.Panel panel6;
  }
}
