using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorpusExplorer.Sdk.Model;

namespace CorpusExplorer.YAAC.View.Abstract
{
  public partial class AbstractView : UserControl
  {
    public AbstractView()
    {
      InitializeComponent();
    }

    public Selection Selection { get; set; }
  }
}
