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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.col_rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.col_freq = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.col_range = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.col_ngram = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_rank,
            this.col_freq,
            this.col_range,
            this.col_ngram});
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 30);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.Size = new System.Drawing.Size(578, 331);
      this.dataGridView1.TabIndex = 3;
      // 
      // col_rank
      // 
      this.col_rank.FillWeight = 50F;
      this.col_rank.HeaderText = "Rank";
      this.col_rank.Name = "col_rank";
      this.col_rank.ReadOnly = true;
      this.col_rank.Width = 50;
      // 
      // col_freq
      // 
      this.col_freq.FillWeight = 50F;
      this.col_freq.HeaderText = "Frequency";
      this.col_freq.Name = "col_freq";
      this.col_freq.ReadOnly = true;
      this.col_freq.Width = 75;
      // 
      // col_range
      // 
      this.col_range.HeaderText = "Range";
      this.col_range.Name = "col_range";
      this.col_range.ReadOnly = true;
      this.col_range.Width = 75;
      // 
      // col_ngram
      // 
      this.col_ngram.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.col_ngram.HeaderText = "NGram";
      this.col_ngram.Name = "col_ngram";
      this.col_ngram.ReadOnly = true;
      // 
      // NGramView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dataGridView1);
      this.Name = "NGramView";
      this.Controls.SetChildIndex(this.panel1, 0);
      this.Controls.SetChildIndex(this.panel2, 0);
      this.Controls.SetChildIndex(this.dataGridView1, 0);
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Controls.SearchtermSortable searchtermSortable1;
    private System.Windows.Forms.Panel panel8;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_rank;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_freq;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_range;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_ngram;
  }
}
