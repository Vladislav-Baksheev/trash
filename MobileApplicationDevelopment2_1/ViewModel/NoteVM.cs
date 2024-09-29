using MobileApplicationDevelopment2_1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MobileApplicationDevelopment2_1.ViewModel
{
    public class NoteVM : INotifyPropertyChanged
    {
        public Note Note { get; set; }

        public string Name
        {
            get
            {
                return Note.Name;
            }

            set
            {
                if(Note.Name != value)
                {
                    Note.Name = value;
                    OnPropertyChanged(nameof(Name));
                }          
            }
        }

        public string Text
        {
            get
            {
                return Note.Text;
            }

            set
            {
                if (Note.Text != value)
                {
                    Note.Text = value;
                    OnPropertyChanged(nameof(Text));
                }    
            }
        }

        public DateTime Date
        {
            get
            {
                return Note.Date;
            }

            set
            {
                if (Note.Date != value)
                {
                    Note.Date = value;
                    OnPropertyChanged(nameof(Date));
                }              
            }
        }

        public NoteVM(Note note)
        {
            Note = note;
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
