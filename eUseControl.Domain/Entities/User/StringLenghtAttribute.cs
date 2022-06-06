using System;

namespace eUseControl.Domain.Entities.User
{
    internal class StringLenghtAttribute : Attribute
    {
        private int v;
        private int minimLength;
        private string errorMessage;

        public StringLenghtAttribute(int v, int MinimLength, string ErrorMessage)
        {
            this.v = v;
            minimLength = MinimLength;
            errorMessage = ErrorMessage;
        }
    }
}