namespace MpcNET.Message
{
    public interface IMpdResponse<T>
    {
        IMpdResponseState State { get; }
        T Body { get; }
    }

    public class MpdResponse<T> : IMpdResponse<T>
    {
        public MpdResponse(string endLine, T body, bool connected)
        {
            State = new MpdResponseState(endLine, connected);
            Body = body;
        }

        public IMpdResponseState State { get; }
        public T Body { get; }
    }
}
