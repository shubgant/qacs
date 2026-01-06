using System;

namespace SingleResponsibility
{
    public interface ILogger
    {
        void Handle(string exceptionMessage);
    }
}