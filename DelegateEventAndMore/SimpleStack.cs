using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventAndMore
{
    internal class SimpleStack<T>
    {
        private List<T> _list;

        public SimpleStack()
        {
            _list = new List<T>();
        }

        public void push(T item)
        {
            _list.Add(item);
        }

        public T pop()
        {
            if (_list.Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            T lastElement = _list.Last();
            _list.RemoveAt(_list.Count - 1);
            return lastElement;
        }
        public T peak()
        {
            if (_list.Count == 0)
            {
                throw new IndexOutOfRangeException();
            }

            return _list.Last();
        }

        public bool IsElementPresent(T item)
        {
            return _list.Contains(item);
        }

        public override string ToString()
        {
            string text = "[";
            for (int i = 0; i < _list.Count; i++)
            {
                text += _list[i].ToString();
                text += i == _list.Count - 1 ? "" : ",";
            }
            text += "]";

            return text;
        }
      
    }
