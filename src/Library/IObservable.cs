using System;
using System.Collections.Generic;

//Sensor

namespace Observer
{
    public interface IObservable
    {
        private List <IObserver> observers 
        { 
            get
            {
                return this.observers;
            }
        }

        void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }
         void Unsubscribe (IObserver observer)
         {
             observers.Remove(observer);
         }
    }
    }