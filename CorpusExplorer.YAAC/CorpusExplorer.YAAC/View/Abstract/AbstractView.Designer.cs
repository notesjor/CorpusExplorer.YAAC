namespace CorpusExplorer.YAAC.View.Abstract
{
  partial class AbstractView
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(578, 30);
      this.panel1.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 421);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(578, 90);
      this.panel2.TabIndex = 1;
      // 
      // AbstractView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "AbstractView";
      this.Size = new System.Drawing.Size(578, 511);
      this.ResumeLayout(false);

    }

    #endregion

    protected System.Windows.Forms.Panel panel1;
    protected System.Windows.Forms.Panel panel2;
  }
}
