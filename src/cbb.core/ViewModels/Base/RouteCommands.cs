using System;
using System.Windows.Input;

namespace cbb.core
{
    public class RouteCommands : ICommand
    {
        #region events

        public event EventHandler CanExecuteChanged;

        #endregion

        #region constructor

        public RouteCommands(Action action)
        {
            _action = action;
        }

        #endregion

        #region private members

        /// <summary>
        /// The action to execute
        /// </summary>
        private Action _action = null;

        #endregion


        #region public methods

        /// <summary>
        /// Defines the method that determines wheter the command can execute in its current state
        /// </summary>
        /// <param name="parameter">Data used by the command. If the command does not require data to be passed, this object can be set to <see langword="null"/>.</param>
        /// <returns>
        ///     <see langword="true"/> if this command can be executed; otherwise, <see langword="false"/>
        /// </returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }
        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter"> Data used by the command. If the command does not require data to be passed, this object can be set to <see langword="null"/>.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void Execute(object parameter)
        {
            _action();
        }
        
        #endregion
    }
}
