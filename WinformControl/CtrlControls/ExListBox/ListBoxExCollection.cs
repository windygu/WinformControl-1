using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections;

namespace CtrlControls.ExListBox
{
    [ListBindable(false)]
    public class ListBoxExCollection : IList
    {
        private ListBoxEx _owner;

        public ListBoxExCollection(ListBoxEx owner)
        {
            this._owner = owner;
        }

        public int Add(object value)
        {
            if (!(value is ListBoxExItem))
                throw new ArgumentException();
            return this._owner.OldItems.Add(value);
        }

        public void Clear()
        {
            this._owner.OldItems.Clear();
        }

        public bool Contains(object value)
        {
            if (!(value is ListBoxExItem))
                throw new ArgumentException();
            return this._owner.OldItems.Contains(value);
        }

        public int IndexOf(object value)
        {
            if (!(value is ListBoxExItem))
                throw new ArgumentException();
            return this._owner.OldItems.IndexOf(value);
        }

        public void Insert(int index, object value)
        {
            if (!(value is ListBoxExItem))
                throw new ArgumentException();
            this._owner.OldItems.Insert(index, value);
        }

        public bool IsFixedSize
        {
            get { return false; }
        }

        public bool IsReadOnly
        {
            get { return this._owner.OldItems.IsReadOnly; }
        }

        public void Remove(object value)
        {
            this._owner.OldItems.Remove(value);
        }

        public void RemoveAt(int index)
        {
            this._owner.OldItems.RemoveAt(index);
        }

        public object this[int index]
        {
            get
            {
                return this._owner.OldItems[index];
            }
            set
            {
                this._owner.OldItems[index] = value; 
            }
        }

        public void CopyTo(Array array, int index)
        {
            this._owner.OldItems.CopyTo((object[])array, index);
        }

        public int Count
        {
            get { return this._owner.OldItems.Count; }
        }

        public bool IsSynchronized
        {
            get { return false; }
        }

        public object SyncRoot
        {
            get { return this; }
        }

        public IEnumerator GetEnumerator()
        {
            return this._owner.OldItems.GetEnumerator();
        }
    }
}
