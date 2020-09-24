using System;
using System.Windows.Input;

namespace EnlaceDatos
{
    public class MyComand : ICommand
    {
        Action action;
        Func<bool> canExecute;
        public MyComand(Action action) : this(action, () => true){}

        public MyComand(Action action, Func<bool> canExecute)
        {
            this.action = action;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return canExecute();
        }

        public void Execute(object parameter)
        {
            action();
        }

        public void ReevaluateCanExecute()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
