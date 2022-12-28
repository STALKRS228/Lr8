using System.Runtime.Serialization;

namespace first2
{
    [Serializable]
    internal class TaskDateException : Exception
    {
        public TaskDateException()
        {
        }

        public TaskDateException(string? message) : base(message)
        {
        }

        public TaskDateException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TaskDateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}namespace first4
{
    public class TaskDate {
        private void TaskDateException(string ?message) {

        }
    }
}