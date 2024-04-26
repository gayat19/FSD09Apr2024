using System.Runtime.Serialization;

namespace ShoppingModelLibrary.Exceptions
{
    [Serializable]
    internal class NoCartWithGivenID : Exception
    {
        string message;


        public NoCartWithGivenID()
        {
            message = "No cart for teh given id";
        }

        public NoCartWithGivenID(int key)
        {
            message = "No cart for teh given id "+key;
        }
        public override string Message => message;

    }
}