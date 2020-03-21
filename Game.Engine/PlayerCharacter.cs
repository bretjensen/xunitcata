using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Game.Engine.Annotations;

namespace Game.Engine
{
    public class PlayerCharacter : INotifyPropertyChanged
    {
        private int _health = 100;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Nickname { get; set; }
        public bool IsNoob { get; set; }

        public int Health
        {
            get => _health;
            private set
            {
                _health = value;
                OnPropertyChanged();
            }
        }

        public event EventHandler<EventArgs> PlayerSlept; 

        public PlayerCharacter()
        {
            IsNoob = true;
        }

        public void Sleep()
        {
            var healthIncrease = CalculateHealthIncrease();
            Health += healthIncrease;
            OnPlayerSlept(EventArgs.Empty);
        }

        private int CalculateHealthIncrease()
        {
            var rnd = new Random();
            return rnd.Next(1, 101);
        }

        protected virtual void OnPlayerSlept(EventArgs e)
        {
            PlayerSlept?.Invoke(this, e);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}