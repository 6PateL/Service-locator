using System;
using UnityEngine.UI;

public abstract class Currency<T> { 
   public T value;
   public abstract event Action<T> OnValueChangeEvent;
   public abstract void Add(T amount);
   public abstract void Spend(T amount);
}
