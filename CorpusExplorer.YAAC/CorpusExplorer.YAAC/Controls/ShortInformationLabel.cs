using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorpusExplorer.YAAC.Controls
{
  public partial class ShortInformationLabel : UserControl
  {
    public ShortInformationLabel()
    {
      InitializeComponent();
    }

    public string Label
    {
      get { return label1.Text; }
      set { label1.Text = value; }
    }

    public string Value
    {
      get { return label2.Text; }
      set { label2.Text = value; }
    }

    public double SplitterDistance
    {
      get { return ((double)splitContainer1.SplitterDistance) / ((double)splitContainer1.Width - splitContainer1.SplitterWidth); }
      set { splitContainer1.SplitterDistance = (int)(((double)splitContainer1.Width) * value); }
    }
  }
}
