using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// Save object state
        /// </summary>
        /// <param name="memento">An ICloneable Object</param>
        public void saveState(Object memento)
        {
            if (!this.canBeCloned(memento))
                throw new NotSupportedException("Object does not implement ICloneable, therefore, we cannot save his state");

            this.currentSnapshot = ((ICloneable)memento).Clone();
        }

        public void pushState(Object memento)
        {
            if (!this.canBeCloned(memento))
                throw new NotSupportedException("Object does not implement ICloneable, therefore, we cannot save his state");

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
            if (previous <= 0)
                return obj;

            if (this.snapshots.Count == 0)
                obj = this.restoreState<Memento>(obj);
            if (previous >= this.snapshots.Count)
                obj = (Memento)this.snapshots.FirstOrDefault();
            else
                obj = (Memento)this.snapshots[this.snapshots.Count - previous];

            return obj;
        }

        private Memento getSnapshot<Memento>()
        {
            return (Memento)this.currentSnapshot;
        }

        private bool canBeCloned(Object obj)
        {
            return (obj as ICloneable != null);
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

    }
}