using System;
using System.Collections;
using System.Collections.Generic;

namespace Net.FreeORM.Base
{
    public sealed class Hashmap
    {
        private Hashtable h = null;
        private List<string> _keys = null;

        public Hashmap()
        {
            h = new Hashtable();
            _keys = new List<string>();
        }

        public string[] Keys()
        {
            string[] arr = _keys.ToArray();
            return arr;
        }

        public object Get(string key)
        {
            object val = null;

            if (_keys.IndexOf(key) > -1)
            {
                val = h[key];
            }

            return val;
        }

        public void Set(string key, object value)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(key))
                {
                    throw new ArgumentException("Key can not be null, empty or white space.");
                }

                if (_keys.IndexOf(key) == -1)
                {
                    h.Add(key, value);
                    _keys.Add(key);
                    return;
                }

                h[key] = value;
                return;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}