using System;

namespace CodeRed.TaggedStringReplacer
{
    public interface IReplacements<T>
    {
        ReplaceableTag<T> this[int index] { get; }
        int Count { get; }
        void Add(int index, ReplaceableTag<T> item);
        void Add(int index, string tag, Func<T, string> func);
        void Remove(int index);
    }
}