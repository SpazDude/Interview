namespace ConsoleApplication1
{
    public interface IGenerateOutput
    {
        string GenerateOutput();
    }

    public interface IRange
    {
        int Lower { get; }
        int Upper { get; }
    }
}
