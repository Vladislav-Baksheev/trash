using MobileApplicationDevelopment2_1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MobileApplicationDevelopment2_1.ViewModel
{
    public class MainVM
    {
        public ICommand AddCommand { get; set;}


        public Note Note { get; set; }

        public NoteVM? CurrentNote { get; set; }

        public ObservableCollection<NoteVM> Notes { get; set; } = new();

        public MainVM()
        {
            AddCommand = new RelayCommand(AddNote);
        }

        public void AddNote(object? parameter)
        {
            CurrentNote = new NoteVM(new Note());
            //CurrentNote.Name = "Vlad";
            //CurrentNote.Text = "Vlad";
            //CurrentNote.Date = DateTime.Now;

            Notes.Add(CurrentNote);
        }
    }
}
