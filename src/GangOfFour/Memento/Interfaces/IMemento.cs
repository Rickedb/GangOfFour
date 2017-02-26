using System;
namespace GangOfFour.Memento.Interfaces
{
    public interface IMemento
    {
        void saveState(Object memento);
        Memento restoreState<Memento>(Memento obj);
    }
}
