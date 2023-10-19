using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror; 

public class PlayerHealth : NetworkBehaviour 
{
    [SyncVar]
    public int Health = 100; 
    public void Damage (int amount)
    {
        Health -= amount;
        if (Health <=0)
        {
            gameObject.SetActive(false); 
        }
    }
}
