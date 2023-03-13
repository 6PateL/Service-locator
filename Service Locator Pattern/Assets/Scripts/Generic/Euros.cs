 using System;
 using System.Numerics;

 public class Euros : Currency<BigInteger> {
     
     public Euros() {
         this.value = new BigInteger(0); 
     }

     public override event Action<BigInteger> OnValueChangeEvent;
     
     public override void Add(BigInteger amount) {
         throw new NotImplementedException();
     }

     public override void Spend(BigInteger amount) {
         throw new NotImplementedException();
     }
 }
