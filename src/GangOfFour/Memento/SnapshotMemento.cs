using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using GangOfFour.Memento.Interfaces;

namespace GangOfFour.Memento
{
    public class SnapshotMemento : IMemento
    {
        private List<Object> snapshots;
        private Object currentSnapshot;

        public SnapshotMemento()
        {
            this.snapshots = new List<object>();
        }

        public void saveState(Object memento)
        {
            this.currentSnapshot = ((ICloneable)memento).Clone();
        }

        public void pushState(Object memento)
        {
            this.currentSnapshot = ((ICloneable)memento).Clone();
            this.snapshots.Add(this.currentSnapshot);
        }

        public Memento restoreState<Memento>(Memento obj)
        {
            obj = this.getSnapshot<Memento>();
            return obj;
        }

        public Memento restoreState<Memento>(Memento obj, int previous)
        {
            if (this.snapshots.Count == 0)
                obj = this.restoreState<Memento>(obj);
            if (previous >= this.snapshots.Count)
                obj = (Memento)this.snapshots.FirstOrDefault();
            else
                obj = (Memento)this.snapshots[this.snapshots.Count - previous];

            return obj;
        }

        //protected bool compareWithMemento<Memento>(Memento obj)
        //{
        //    return this.compareWithMemento<Memento>(obj, this.getSnapshot<Memento>());
        //}

        //protected bool compareWithMemento<Memento>(Memento first, Memento second)
        //{
        //    if (first == null)
        //        return (second == null) ? true : false;
        //    else
        //        if (second == null)
        //        return false;

        //    foreach (var prop in first.GetType().GetProperties())
        //    {
        //        Type type = prop.GetType();
        //        prop.GetValue()

        //    }

        //    return true;
        //}

        private Memento getSnapshot<Memento>()
        {
            return (Memento)this.currentSnapshot;
        }
    }
}