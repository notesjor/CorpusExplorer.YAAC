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
      this.shortInformationLabel1 = new CorpusExplorer.YAAC.Controls.ShortInformationLabel();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.col_hit = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.col_kwic = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.col_file = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.shortInformationLabel1);
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
      // shortInformationLabel1
      // 
      this.shortInformationLabel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.shortInformationLabel1.Label = "Concordance Hits:";
      this.shortInformationLabel1.Location = new System.Drawing.Point(0, 0);
      this.shortInformationLabel1.Name = "shortInformationLabel1";
      this.shortInformationLabel1.Size = new System.Drawing.Size(232, 30);
      this.shortInformationLabel1.SplitterDistance = 0.50216450216450215D;
      this.shortInformationLabel1.TabIndex = 0;
      this.shortInformationLabel1.Value = "0";
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_hit,
            this.col_kwic,
            this.col_file});
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 30);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.Size = new System.Drawing.Size(578, 391);
      this.dataGridView1.TabIndex = 2;
      // 
      // col_hit
      // 
      this.col_hit.FillWeight = 50F;
      this.col_hit.HeaderText = "Hit";
      this.col_hit.Name = "col_hit";
      this.col_hit.ReadOnly = true;
      this.col_hit.Width = 50;
      // 
      // col_kwic
      // 
      this.col_kwic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.col_kwic.HeaderText = "KWIC";
      this.col_kwic.Name = "col_kwic";
      this.col_kwic.ReadOnly = true;
      // 
      // col_file
      // 
      this.col_file.HeaderText = "File";
      this.col_file.Name = "col_file";
      this.col_file.ReadOnly = true;
      // 
      // ConcordanceView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dataGridView1);
      this.Name = "ConcordanceView";
      this.Controls.SetChildIndex(this.panel1, 0);
      this.Controls.SetChildIndex(this.panel2, 0);
      this.Controls.SetChildIndex(this.dataGridView1, 0);
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Controls.SearchtermBase searchtermBase3;
    private System.Windows.Forms.Panel panel16;
    private Controls.ShortInformationLabel shortInformationLabel1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_hit;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_kwic;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_file;
  }
}
