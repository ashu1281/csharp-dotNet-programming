namespace cshar_programming
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    internal class CommentAttribute : Attribute
    {
        public string Text { get; set; }
    }
}