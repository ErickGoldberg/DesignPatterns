namespace DesignPatterns.Creational.Prototype
{
    public class Report : Document
    {
        public Report(string title, string content) : base(title, content)
        {
        }

        public override Document Clone()
        {
            return new Report(Title, Content);
        }
    }

    public class Resume : Document
    {
        public Resume(string title, string content) : base(title, content)
        {
        }

        public override Document Clone()
        {
            return new Resume(Title, Content);
        }
    }

}
