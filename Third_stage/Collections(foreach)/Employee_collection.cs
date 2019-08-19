using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection
{
    public class Employee_collection : IEnumerable, IEnumerator, IList
    {
        private Employee[] collectionElements = null;

        public Employee_collection()
        {
            collectionElements = new Employee[5];
            collectionElements[0] = new Employee("Tom", "Johnson", "Marketing", 30);
            collectionElements[1] = new Employee("Bob", "Rudman", "Development", 42);
            collectionElements[2] = new Employee("James", "McAllen", "Accounting", 32);
            collectionElements[3] = new Employee("John", "Smith", "Sales", 25);
            collectionElements[4] = new Employee("Sarah", "Connor", "Financial", 27);
        }
        internal Employee[] ElemetsArray { get => collectionElements; set => collectionElements = value; }
        private int _position = -1;

        public bool MoveNext()
        {
            if (_position < collectionElements.Length -1)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Current
        {
            get { return collectionElements[_position]; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool IsFixedSize
        {
            get { return false; }
        }

        public int Count
        {
            get { return collectionElements.Length; }
        }

        public object SyncRoot => collectionElements.SyncRoot;

        public bool IsSynchronized => collectionElements.IsSynchronized;

        public object this[int index] { get => ((IList)collectionElements)[index]; set => ((IList)collectionElements)[index] = value; }

        public void Reset()
        {
            _position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }

        public bool Contains(object value)
        {
            if (collectionElements.Contains((Employee)value)) return true;
            else return false;
        }

        public int Add(object value)
        {
            return ((IList)collectionElements).Add(value);
        }
       
        public void Clear()
        {
            ((IList)collectionElements).Clear();
        }

        public int IndexOf(object value)
        {
            return ((IList)collectionElements).IndexOf(value);
        }

        public void Insert(int index, object value)
        {
            ((IList)collectionElements).Insert(index, value);
        }

        public void Remove(object value)
        {
            ((IList)collectionElements).Remove(value);
        }

        public void RemoveAt(int index)
        {
            ((IList)collectionElements).RemoveAt(index);
        }

        public void CopyTo(Array array, int index)
        {
            collectionElements.CopyTo(array, index);
        }
    }
}