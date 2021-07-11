namespace DotNetDesignPatternDemos.Creational.Builder
{
    public class Field
    {
        public string Type, Name;

        public override string ToString()
        {
            return $"public {Type} {Name}";
        }
    }
}