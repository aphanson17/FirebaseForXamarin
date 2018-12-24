using System;

namespace Firebase
{
    public interface IFirebase
    {
        string LoginWithEmailAndPassword(string email, string password);
    }
}
