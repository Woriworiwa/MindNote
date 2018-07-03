using MindNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MindNote.Views
{
    public class BooksViewModel
    {
        private ICommand openBookCommand;

        public ICommand OpenBookCommand
        {
            get { return this.openBookCommand ?? (openBookCommand = new SimpleCommand { CanExecuteDelegate = x => true, ExecuteDelegate = x => this.DoOpenBook(x) }); }
        }

        protected virtual void DoOpenBook(object sender)
        {
            System.Diagnostics.Process si = new System.Diagnostics.Process();
            si.StartInfo.WorkingDirectory = "c:\\";
            si.StartInfo.UseShellExecute = false;
            si.StartInfo.FileName = @"C:\Program Files (x86)\Foxit Software\Foxit Reader\FoxitReader.exe";
            si.StartInfo.Arguments = string.Format("\"G:\\My Drive\\UX\\Principles\\InteractionDesignPswd_Gr8design.pptx.pdf\"" + @" /pwd Gr8design" + " /A page={0}", sender.ToString());           
            si.StartInfo.CreateNoWindow = true;
            si.StartInfo.RedirectStandardInput = true;
            si.StartInfo.RedirectStandardOutput = true;
            si.StartInfo.RedirectStandardError = true;
            si.Start();
        }
    }
}
