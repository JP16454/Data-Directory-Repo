using System;
using System.Windows;

namespace Navitur.ViewModel
{
    public class MvvmMessageBoxEventArgs
    {
        private MessageBoxButton button;
        private string caption;
        private MessageBoxResult defaultResult;
        private MessageBoxImage icon;
        private string msgbxTxt;
        private MessageBoxOptions options;
        private Action<MessageBoxResult> resultAction;

        public MvvmMessageBoxEventArgs(Action<MessageBoxResult> resultAction, string msgbxTxt, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options)
        {
            this.resultAction = resultAction;
            this.msgbxTxt = msgbxTxt;
            this.caption = caption;
            this.button = button;
            this.icon = icon;
            this.defaultResult = defaultResult;
            this.options = options;
        }
    }
}