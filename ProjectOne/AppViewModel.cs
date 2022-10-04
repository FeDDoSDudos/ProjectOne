using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    internal class AppViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Question> Questiones { get; set; }

        private Question selectedQuestion { get; set; }
        public Question SelectedQuestion
        {
            get { return selectedQuestion; }
            set { selectedQuestion = value; OnPropertyChanged("SelectedQuestion"); }
        }

        /// <summary>
        /// Команда для проверки ответа
        /// </summary>
        private RelayCommand checkAnswerCommand;
        public RelayCommand CheckAnswerCommand
        {
            get
            {
                return checkAnswerCommand ??
                    (checkAnswerCommand = new RelayCommand(obj =>
                    {

                    }));
            }
        }

        public AppViewModel()
        {
            Questiones = new ObservableCollection<Question>
            {
                new Question { Name="1", Answer1="a", Answer2="b", Answer3="c", Answer4="d" },
                new Question { Name="2", Answer1="b", Answer2="c", Answer3="d", Answer4="a" },
                new Question { Name="3", Answer1="c", Answer2="d", Answer3="a", Answer4="b" },
                new Question { Name="4", Answer1="d", Answer2="a", Answer3="b", Answer4="c" },
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
