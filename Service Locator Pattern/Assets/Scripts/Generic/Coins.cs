using System;

public class Coins : Currency<int> {
    
    public Coins() {
        this.value = 0; 
    }
    
    public override event Action<int> OnValueChangeEvent;
    
    public override void Add(int amount) {
        throw new NotImplementedException();
    }
    public override void Spend(int amount) {
        throw new NotImplementedException();
    }
}
