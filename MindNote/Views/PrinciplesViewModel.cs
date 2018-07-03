using MindNote.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindNote.Views
{
    public class PrinciplesViewModel
    {
        private readonly ObservableCollection<Principle> principles = new ObservableCollection<Principle>();

        public ObservableCollection<Principle> Principles { get { return this.principles; } }
               
        public PrinciplesViewModel()
        {
            principles = JsonConvert.DeserializeObject<ObservableCollection<Principle>>(File.ReadAllText(@"Data\principles.json"));
        }

    }
}
