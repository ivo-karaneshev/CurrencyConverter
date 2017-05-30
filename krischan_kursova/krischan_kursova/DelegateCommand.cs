using System;
using System.Windows.Input;

namespace krischan_kursova
{
    class DelegateCommand : ICommand
    {
        private Action actionToExecute;
        private Func<bool> condition;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action actionToExecute, Func<bool> condition)
        {
            this.actionToExecute = actionToExecute;
            this.condition = condition;
        }

        public bool CanExecute(object parameter)
        {
            return condition();
        }

        public void Execute(object parameter)
        {
            actionToExecute();
        }
    }
}
