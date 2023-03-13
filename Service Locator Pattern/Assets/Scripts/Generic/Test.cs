using System;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Coins _coins;
    private Euros _euros;
    
    private void Start() {
        _coins = new Coins();
        _euros = new Euros(); 
    }
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
           Debug.Log("Euro" + " "  + _euros.value); 
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
           Debug.Log("Coins" + " " + _coins.value); 
        }
    }
}