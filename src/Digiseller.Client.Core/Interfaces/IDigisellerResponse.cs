namespace Digiseller.Client.Core.Interfaces
{
    public interface IDigisellerResponse
    {
        bool HasErrors();
        string ErrorMessage { get; }
        int ErrorCode { get; }
    }
}