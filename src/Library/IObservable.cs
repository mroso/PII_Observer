using System;
using System.Collections.Generic;

//Sensor

namespace Observer
{
    public interface IObservable
    {
        List <IObserver> observers { get; set; }

        void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }
         void Unsubscribe (IObserver observer)
         {
             observers.Remove(observer);
         }
    }