using System;

namespace ExceptionTraining
{
    class InputException : Exception
    {
        public InputException(){}
        public InputException(string message) : base(message){}
    }
}
