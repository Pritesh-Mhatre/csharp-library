using System;

namespace com.dakshata.data.model.common
{

    public class OperationResponse<T> : IOperationResponse<T>
    {
        public static readonly OperationResponse<bool> SUCCESS = new OperationResponse<bool>(true, null, null, null);

        public T Result { get; set; }

        public Exception Error { get; set; }

        public string Message { get; set; }

        public bool Status { get; set; }

        public string CommandId { get; set; }

        public OperationResponse()
        {
            this.Status = false;
            this.Result = default(T);
            this.Message = null;
            this.CommandId = null;
        }

        public OperationResponse(T result, Exception error, string message, string commandId)
        {
            this.Result = result;
            this.Error = error;
            this.Status = (error == null);
            this.CommandId = commandId;

            if (message != null)
            {
                this.Message = message;
            }
            else if (error != null)
            {
                if (error.Message != null)
                {
                    this.Message = error.Message;
                }
                else
                {
                    this.Message = error.GetType().Name;
                }
            }
            else
            {
                this.Message = null;
            }

        }

        public bool Success()
        {
            return Status;
        }
    }
}