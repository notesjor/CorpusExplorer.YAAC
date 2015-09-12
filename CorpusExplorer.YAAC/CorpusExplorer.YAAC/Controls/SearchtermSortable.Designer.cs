namespace CorpusExplorer.YAAC.Controls
{
  partial class SearchtermSortable
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
      this.button3 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.checkBox4 = new System.Windows.Forms.CheckBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.panel3.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel5.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.button3);
      this.panel3.Controls.SetChildIndex(this.button3, 0);
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.checkBox4);
      this.panel4.Controls.Add(this.label2);
      // 
      // panel5
      // 
      this.panel5.Controls.Add(this.comboBox1);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(165, 4);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 2;
      this.button3.Text = "Sort";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.Dock = System.Windows.Forms.DockStyle.Left;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(62, 30);
      this.label2.TabIndex = 0;
      this.label2.Text = "Sort by";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // checkBox4
      // 
      this.checkBox4.AutoSize = true;
      this.checkBox4.Dock = System.Windows.Forms.DockStyle.Left;
      this.checkBox4.Location = new System.Drawing.Point(62, 0);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
      this.checkBox4.Size = new System.Drawing.Size(82, 30);
      this.checkBox4.TabIndex = 1;
      this.checkBox4.Text = "Invert Order";
      this.checkBox4.UseVisualStyleBackColor = true;
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(3, 5);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(237, 21);
      this.comboBox1.TabIndex = 0;
      // 
      // SearchtermSortable
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Name = "SearchtermSortable";
      this.panel3.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel5.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.CheckBox checkBox4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox comboBox1;
  }
}
