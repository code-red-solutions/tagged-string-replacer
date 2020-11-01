namespace CodeRed.TaggedStringReplacer
{
    public interface ITaggedStringReplacer<T>  
    {
        string ReplaceTaggedStrings(string taggedString, T dataObject,  IReplacements<T> replacements);
    }
}
