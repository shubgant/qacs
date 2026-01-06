using System;
namespace InterfaceSegregation
{
    public interface ILogger
    {
        void Handle(string message);
    }
}