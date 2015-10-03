namespace CorpusExplorer.YAAC.Controls
{
  partial class SearchtermBase
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
      this.panel2 = new System.Windows.Forms.Panel();
      this.chk_regex = new System.Windows.Forms.CheckBox();
      this.chk_case = new System.Windows.Forms.CheckBox();
      this.chk_words = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txt_query = new System.Windows.Forms.TextBox();
      this.panel3 = new System.Windows.Forms.Panel();
      this.btn_stop = new System.Windows.Forms.Button();
      this.btn_start = new System.Windows.Forms.Button();
      this.panel4 = new System.Windows.Forms.Panel();
      this.panel5 = new System.Windows.Forms.Panel();
      this.work_search = new System.ComponentModel.BackgroundWorker();
      this.panel2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.chk_regex);
      this.panel2.Controls.Add(this.chk_case);
      this.panel2.Controls.Add(this.chk_words);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(572, 30);
      this.panel2.TabIndex = 3;
      // 
      // chk_regex
      // 
      this.chk_regex.AutoSize = true;
      this.chk_regex.Dock = System.Windows.Forms.DockStyle.Left;
      this.chk_regex.Location = new System.Drawing.Point(207, 0);
      this.chk_regex.Name = "chk_regex";
      this.chk_regex.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
      this.chk_regex.Size = new System.Drawing.Size(57, 30);
      this.chk_regex.TabIndex = 3;
      this.chk_regex.Text = "Regex";
      this.chk_regex.UseVisualStyleBackColor = true;
      // 
      // chk_case
      // 
      this.chk_case.AutoSize = true;
      this.chk_case.Dock = System.Windows.Forms.DockStyle.Left;
      this.chk_case.Location = new System.Drawing.Point(157, 0);
      this.chk_case.Name = "chk_case";
      this.chk_case.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
      this.chk_case.Size = new System.Drawing.Size(50, 30);
      this.chk_case.TabIndex = 2;
      this.chk_case.Text = "Case";
      this.chk_case.UseVisualStyleBackColor = true;
      // 
      // chk_words
      // 
      this.chk_words.AutoSize = true;
      this.chk_words.Dock = System.Windows.Forms.DockStyle.Left;
      this.chk_words.Location = new System.Drawing.Point(100, 0);
      this.chk_words.Name = "chk_words";
      this.chk_words.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
      this.chk_words.Size = new System.Drawing.Size(57, 30);
      this.chk_words.TabIndex = 1;
      this.chk_words.Text = "Words";
      this.chk_words.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Left;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 30);
      this.label1.TabIndex = 0;
      this.label1.Text = "Search Term";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.txt_query);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 30);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
      this.panel1.Size = new System.Drawing.Size(572, 30);
      this.panel1.TabIndex = 4;
      // 
      // txt_query
      // 
      this.txt_query.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txt_query.Location = new System.Drawing.Point(0, 5);
      this.txt_query.Name = "txt_query";
      this.txt_query.Size = new System.Drawing.Size(572, 20);
      this.txt_query.TabIndex = 0;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.btn_stop);
      this.panel3.Controls.Add(this.btn_start);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(0, 60);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(572, 30);
      this.panel3.TabIndex = 5;
      // 
      // btn_stop
      // 
      this.btn_stop.Enabled = false;
      this.btn_stop.Location = new System.Drawing.Point(84, 4);
      this.btn_stop.Name = "btn_stop";
      this.btn_stop.Size = new System.Drawing.Size(75, 23);
      this.btn_stop.TabIndex = 1;
      this.btn_stop.Text = "Stop";
      this.btn_stop.UseVisualStyleBackColor = true;
      this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
      // 
      // btn_start
      // 
      this.btn_start.Location = new System.Drawing.Point(3, 4);
      this.btn_start.Name = "btn_start";
      this.btn_start.Size = new System.Drawing.Size(75, 23);
      this.btn_start.TabIndex = 0;
      this.btn_start.Text = "Start";
      this.btn_start.UseVisualStyleBackColor = true;
      this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
      // 
      // panel4
      // 
      this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel4.Location = new System.Drawing.Point(0, 90);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(572, 30);
      this.panel4.TabIndex = 6;
      // 
      // panel5
      // 
      this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel5.Location = new System.Drawing.Point(0, 120);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(572, 30);
      this.panel5.TabIndex = 7;
      // 
      // work_search
      // 
      this.work_search.DoWork += new System.ComponentModel.DoWorkEventHandler(this.work_search_DoWork);
      this.work_search.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.work_search_RunWorkerCompleted);
      // 
      // SearchtermBase
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panel5);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.panel2);
      this.Name = "SearchtermBase";
      this.Size = new System.Drawing.Size(572, 150);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.CheckBox chk_regex;
    private System.Windows.Forms.CheckBox chk_case;
    private System.Windows.Forms.CheckBox chk_words;
    private System.Windows.Forms.Label label1;
    protected System.Windows.Forms.Panel panel2;
    protected System.Windows.Forms.Panel panel1;
    protected System.Windows.Forms.Panel panel3;
    protected System.Windows.Forms.Panel panel4;
    protected System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.TextBox txt_query;
    private System.Windows.Forms.Button btn_stop;
    private System.Windows.Forms.Button btn_start;
    private System.ComponentModel.BackgroundWorker work_search;
  }
}
