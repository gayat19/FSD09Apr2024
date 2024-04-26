using System.Runtime.Serialization;

namespace ShoppingDALLibrary
{
    [Serializable]
    internal class NoCartWithGivenID : Exception
    {
        private int key;

        public NoCartWithGivenID()
        {
        }

        public NoCartWithGivenID(int key)
        {
            this.key = key;
        }

        public NoCartWithGivenID(string? message) : base(message)
        {
        }

        public NoCartWithGivenID(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoCartWithGivenID(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}