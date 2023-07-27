using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    void OnTriggerEnter(Collider collider){
        if(collider.tag=="Player"){
            collider.SendMessage("Kill");
        }
    }
}
