using System;

namespace CodeRed.TaggedStringReplacer
{
    public class ReplaceableTag<T>
    {
        public string Tag { get; set; }
        public Func<T, string> Func { get; set; }
    }
}
