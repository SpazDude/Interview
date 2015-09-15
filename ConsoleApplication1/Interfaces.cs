namespace ConsoleApplication1
{
    public interface IOutputGenerator
    {
        string GenerateOutput();
    }

    public interface IRange
    {
        int Lower { get; }
        int Upper { get; }
    }
}
