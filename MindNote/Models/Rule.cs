using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindNote.Models
{
    public class Rule
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string FormattedText { get { return this.ToString(); } set { } }

        public override string ToString()
        {
            return string.Format("{0}: {1}", "Principle", Text);
        }
    }
}
