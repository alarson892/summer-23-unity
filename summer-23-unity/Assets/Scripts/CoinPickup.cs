using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UpdateCount;

public class CoinPickup : MonoBehaviour
{
    public UpdateCount uc;
    public int coins=0;
    void OnTriggerEnter(Collider collider){
        Debug.Log(collider.tag);
        if(collider.tag=="Coin"){
            coins++;
            uc.NewValue(coins);
            Destroy(collider.gameObject);
        }
    }

}
