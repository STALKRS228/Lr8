using System.Runtime.Serialization;

namespace first5
{
    [Serializable]
    internal class TaskDoneException : Exception
    {
        public TaskDoneException()
        {
        }

        public TaskDoneException(string? message) : base(message)
        {
        }

        public TaskDoneException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TaskDoneException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}