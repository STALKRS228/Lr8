using System.Runtime.Serialization;

namespace first2
{
    [Serializable]
    internal class TaskLengthException : Exception
    {
        public TaskLengthException()
        {
        }

        public TaskLengthException(string? message) : base(message)
        {
        }

        public TaskLengthException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TaskLengthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}