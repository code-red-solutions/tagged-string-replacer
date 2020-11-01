using System;
using System.Collections.Generic;

namespace CodeRed.TaggedStringReplacer
{
    public class Replacements<T> : IReplacements<T>
    {
        private readonly SortedDictionary<int, ReplaceableTag<T>> _data  = new SortedDictionary<int, ReplaceableTag<T>>();

        public ReplaceableTag<T> this[int index]
        {
            //TODO: Check range
            get { return _data[index]; }
        }

        public void Add(int index, ReplaceableTag<T> item)
        {
            //TODO: Check range
            _data.Add(index, item);
        }

        public void Add(int index, string tag, Func<T, string> func)
        {
            //TODO: Check range
            _data.Add(index, new ReplaceableTag<T>{Tag = tag, Func = func});
        }

        public void Remove(int index)
        {
            //TODO: Check range
            _data.Remove(index);
        }

        public int Count
        {
            get { return _data.Count; }
        }
    }
}
