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
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.panel3 = new System.Windows.Forms.Panel();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.panel4 = new System.Windows.Forms.Panel();
      this.panel5 = new System.Windows.Forms.Panel();
      this.panel2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.checkBox3);
      this.panel2.Controls.Add(this.checkBox2);
      this.panel2.Controls.Add(this.checkBox1);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(572, 30);
      this.panel2.TabIndex = 3;
      // 
      // checkBox3
      // 
      this.checkBox3.AutoSize = true;
      this.checkBox3.Dock = System.Windows.Forms.DockStyle.Left;
      this.checkBox3.Location = new System.Drawing.Point(207, 0);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
      this.checkBox3.Size = new System.Drawing.Size(57, 30);
      this.checkBox3.TabIndex = 3;
      this.checkBox3.Text = "Regex";
      this.checkBox3.UseVisualStyleBackColor = true;
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Dock = System.Windows.Forms.DockStyle.Left;
      this.checkBox2.Location = new System.Drawing.Point(157, 0);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
      this.checkBox2.Size = new System.Drawing.Size(50, 30);
      this.checkBox2.TabIndex = 2;
      this.checkBox2.Text = "Case";
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Dock = System.Windows.Forms.DockStyle.Left;
      this.checkBox1.Location = new System.Drawing.Point(100, 0);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
      this.checkBox1.Size = new System.Drawing.Size(57, 30);
      this.checkBox1.TabIndex = 1;
      this.checkBox1.Text = "Words";
      this.checkBox1.UseVisualStyleBackColor = true;
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
      this.panel1.Controls.Add(this.textBox1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 30);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
      this.panel1.Size = new System.Drawing.Size(572, 30);
      this.panel1.TabIndex = 4;
      // 
      // textBox1
      // 
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox1.Location = new System.Drawing.Point(0, 5);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(572, 20);
      this.textBox1.TabIndex = 0;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.button2);
      this.panel3.Controls.Add(this.button1);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(0, 60);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(572, 30);
      this.panel3.TabIndex = 5;
      // 
      // button2
      // 
      this.button2.Enabled = false;
      this.button2.Location = new System.Drawing.Point(84, 4);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Stop";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(3, 4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Start";
      this.button1.UseVisualStyleBackColor = true;
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
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Label label1;
    protected System.Windows.Forms.Panel panel2;
    protected System.Windows.Forms.Panel panel1;
    protected System.Windows.Forms.Panel panel3;
    protected System.Windows.Forms.Panel panel4;
    protected System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
  }
}
