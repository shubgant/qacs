using System;

namespace LiskovSubstitution { 
    public interface ILogger {
        void Handle(string message);
    }
}