using System;

namespace com.dakshata.data.model.common
{
    public interface IOperationResponse<T>
    {
        T Result { get; }

        Exception Error { get; }

        string Message { get; }

        bool Success();

        string CommandId { get; }
    }

}