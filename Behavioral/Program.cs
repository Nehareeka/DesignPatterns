using Behavioral.ChainOfResponsibility;
using Behavioral.Command;
using Behavioral.Iterator;
using Behavioral.Mediator;
using Behavioral.Memento;
using Behavioral.Observer;
using Behavioral.State;
using Behavioral.Strategy;
using Behavioral.TemplateMethod;
using Behavioral.Visitor;

namespace Behavioral
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region Chain Of Responsibilty

            //new CoRClient().Main();

            #endregion

            #region Command

            //new CommandClient().Main();

            #endregion

            #region Iterator

            //new IteratorClient().Main();

            #endregion

            #region Mediator

            //new MediatorClient().Main();

            #endregion

            #region Memento

            //new MementoClient().Main();

            #endregion

            #region Observer

            //new ObserverClient().Main();

            #endregion

            #region State

            //new StateClient().Main();

            #endregion

            #region Strategy

            //new StrategyClient().Main();

            #endregion

            #region TemplateMethod

            //new TemplateMethodClient().Main();

            #endregion

            #region Visitor

            new VisitorClient().Main();

            #endregion
        }
    }
}
