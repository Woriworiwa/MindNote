using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindNote.Models
{
    public class Note
    {
        public string Title { get; set; }

        public Uri Uri { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
