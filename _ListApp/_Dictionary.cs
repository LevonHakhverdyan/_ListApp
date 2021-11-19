using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ListApp
{
    public class _Dictionary
    {
        private int _capacity = 0;
        private int _defaultCapacity = 4;
        private string[] _temp;
        private int _version;
        private string[] _items;
        //private string[] _iteams =
        // new string[]
        // {
        //    "Januar",
        //    "February",
        //    "March",
        //    "April",
        //    "May",
        //    "June",
        //    "July",
        //    "August",
        //    "September",
        //    "October",
        //    "November",
        //     "December"
        // };
        public int Count { get => _version; }
        public _Dictionary (int capacity)
        {
            _items = new string [capacity];
            _capacity = capacity;
        }
        public _Dictionary()
        {

        }
        public int this[string key]
        {
            get
            {

                return GetIndexOfMont(key);
            }
            
        }
        private int GetIndexOfMont(string key)
        {
            int defaultmonth = 0;
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i] == key)
                {
                    defaultmonth = i;
                }

            }
            defaultmonth++;
            return defaultmonth;

        }
        public void Add(string value)
        {
            InsureCapacity();
            _items[_version++] = value;
        }
        public override string ToString()
        {
            return $"Count={Count}";
        }
        private void InsureCapacity()
        {
            if (_capacity == 0)
            {
                _capacity = _defaultCapacity;
                _items = new string [_defaultCapacity];
            }

            if (_version >= _capacity)
            {
                _capacity *= 2;
                _temp = new string[_items.Length];
                //for (int i = 0; i < _items.Length; i++)
                //{
                //    _temp[i] = _items[i];
                //}
                Array.Copy(_items, 0, _temp, 0, _items.Length);
                _items = new string[_capacity];
                Array.Copy(_temp, 0, _items, 0, _temp.Length);
                //for (int i = 0; i < _temp.Length; i++)
                //{
                //    _items[i] = _temp[i];
                //}
                _temp = null;
            }
        }
    }
}
