using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Navitur.ViewModel;

namespace Navitur.ViewModel
{
    public class CommandBase : ICommand
    {


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();
            if (canExecFunc != null)
                return canExecFunc.Invoke(parameter);
            else
                return true;
        }

        public void Execute(object parameter)
        {
            //throw new NotImplementedException();

            if (execAction != null)
                execAction.Invoke(parameter);
        }

        private Action<Object> execAction;
        private Func<Object, bool> canExecFunc;

        public CommandBase(Action<Object> execAct)
        {
            this.execAction = execAct;
            this.canExecFunc = null;
        }









    }
}
