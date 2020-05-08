using System;

//Reporter
namespace Observer
{
    public interface IObserver
    {
        void Update(Temperature temperature);

    }
}