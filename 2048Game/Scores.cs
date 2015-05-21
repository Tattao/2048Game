using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace _2048Game
{
    public class Scores : INotifyPropertyChanged
    {
        private int score;
        public int Score
        {
            get { return score; }
            set
            {
                if (value != score)
                {
                    score = value;
                    RaisePropertyChanged("Score");
                }
            }
        }

        public Scores()
        {
            Score = 0;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
