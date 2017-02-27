using System;
namespace GangOfFour.Memento.Interfaces
{
    public interface IMemento
    {
        void saveState<Memento>(Memento memento);
        Memento restoreState<Memento>(Memento obj);
    }
}
