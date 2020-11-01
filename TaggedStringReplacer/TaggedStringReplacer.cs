namespace CodeRed.TaggedStringReplacer
{
    public class TaggedStringReplacer<T> : ITaggedStringReplacer<T>  
    {
        public string ReplaceTaggedStrings(string taggedString, T dataObject, IReplacements<T> replacements)
        {
            var result = taggedString;

            for (var i = 0; i < replacements.Count; i++)
            {
                var replacement = replacements[i];
                if (taggedString.Contains(replacement.Tag))
                    result = result.Replace(replacement.Tag, replacement.Func.Invoke(dataObject));
            }

            return result;
        }
    }
}