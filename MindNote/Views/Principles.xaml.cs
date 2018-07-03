using MindNote.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MindNote.Views
{
    /// <summary>
    /// Interaction logic for Principles.xaml
    /// </summary>
    public partial class Principles : UserControl
    {
        private readonly PrinciplesViewModel _viewModel;

        public Principles()
        {
            _viewModel = new PrinciplesViewModel();
            DataContext = _viewModel;

            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (evernoteBrowser != null)
            {
                Note selectedNote = (sender as ComboBox).SelectedItem as Note;
                if(selectedNote != null)
                {
                    evernoteBrowser.Navigate(selectedNote.Uri);
                }                
            }
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            evernoteBrowser.Navigate((evernotesCombo.SelectedItem as Note).Uri);
        }
    }
}
