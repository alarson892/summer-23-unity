using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UpdateCount;

public class CoinPickup : MonoBehaviour
{
    public UpdateCount uc;
    void Start(){
        uc = GameObject.Find("CoinCounter").GetComponent<UpdateCount>();
    }

    public int coins=0;
    void OnTriggerEnter(Collider collider){
        if(collider.tag=="Coin"){
            coins++;
            uc.NewValue(coins);
            Destroy(collider.gameObject);
        }
    }

}
