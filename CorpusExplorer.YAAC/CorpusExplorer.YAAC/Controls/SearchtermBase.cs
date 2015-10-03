using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorpusExplorer.YAAC.Controls.Delegates;

namespace CorpusExplorer.YAAC.Controls
{
  public partial class SearchtermBase : UserControl
  {
    private DataTable _dataTable;

    public SearchtermBase()
    {
      InitializeComponent();
    }

    public event StartSearchDelegate StartSearch;

    private void btn_start_Click(object sender, EventArgs e)
    {
      if (StartSearch == null) return;
      work_search.RunWorkerAsync();
    }

    private void btn_stop_Click(object sender, EventArgs e)
    {
      work_search.CancelAsync();
    }

    private void work_search_DoWork(object sender, DoWorkEventArgs e)
    {
      btn_start.Enabled = false;
      btn_stop.Enabled = true;

      _dataTable = StartSearch(txt_query.Text, chk_words.Checked, chk_case.Checked, chk_regex.Checked);
    }

    private void work_search_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      btn_start.Enabled = true;
      btn_stop.Enabled = false;
    }
  }
}
