using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorpusExplorer.Sdk.Helper;
using CorpusExplorer.Sdk.Model;
using CorpusExplorer.Sdk.Terminal;
using CorpusExplorer.Sdk.Utils.DocumentProcessing.Cleanup;

namespace CorpusExplorer.YAAC
{
  public partial class Form1 : Form
  {
    private TerminalController _ecosystem;

    public Form1()
    {
      _ecosystem = CorpusExplorerEcosystem.Initialize();
      _ecosystem.ProjectNew();

      InitializeComponent();
    }

    private Project Project => _ecosystem.Project;

    private void menu_exit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void menu_file_open_file_Click(object sender, EventArgs e)
    {
      var ofd = new OpenFileDialog
      {
        Filter = string.Join("|", Configuration.AddonScrapers.Select(x => x.Key)),
        CheckFileExists = true
      };

      if (ofd.ShowDialog() != DialogResult.OK) return;

      var filter = Configuration.AddonScrapers.ToArray()[ofd.FilterIndex - 1].Value;
      filter.Files = ofd.FileNames;

      var cleanup = new StandardCleanup
      {
        ScraperResults = filter.Execute()
      };

      var tagger = Configuration.AddonParsers.FirstOrDefault(x => x.DisplayName == "Keine Annotation - Nur Textimport");
      if (tagger == null)
      {
        MessageBox.Show("RawText-Tagger not available. Please install CorpusExplorer:\nhttp://corpusexplorer.de");
        return;
      }
      tagger.ScraperResults = cleanup.Execute();

      Project.Add(tagger.Execute());

      RefreshDataBinding();
    }

    private void menu_file_close_all_Click(object sender, EventArgs e)
    {
      _ecosystem.ProjectNew();
      RefreshDataBinding();
    }

    private void RefreshDataBinding()
    {
      list_FileList.Items.Clear();

      foreach (var displayname in Project.SelectAll.DocumentDisplaynames)
      {
        list_FileList.Items.Add(displayname);
      }

      sil_documents.Value = Project.SelectAll.CountDocuments.ToString();
      sil_documents.Value = Project.SelectAll.CountToken.ToString();

      concordancePlotView1.Selection = Project.SelectAll;
      concordanceView1.Selection = Project.SelectAll;
      cooccurrenceView1.Selection = Project.SelectAll;
      fileView1.Selection = Project.SelectAll;
      keywordView1.Selection = Project.SelectAll;
      nGramView1.Selection = Project.SelectAll;
      wordlistView1.Selection = Project.SelectAll;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void helpToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Process.Start("https://github.com/notesjor/CorpusExplorer.YAAC");
    }
  }
}
