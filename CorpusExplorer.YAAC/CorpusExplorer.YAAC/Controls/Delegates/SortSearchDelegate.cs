using System.Data;

namespace CorpusExplorer.YAAC.Controls.Delegates
{
  public delegate DataTable SortSearchDelegate(DataTable dataTable, SortSearchCompareDelegate func, bool isInverse);
}