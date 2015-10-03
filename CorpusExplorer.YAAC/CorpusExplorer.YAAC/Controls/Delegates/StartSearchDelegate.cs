using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorpusExplorer.YAAC.Controls.Delegates
{
  public delegate DataTable StartSearchDelegate(string query, bool findOnlyWord, bool isCaseSensitive, bool isRegex);
}
