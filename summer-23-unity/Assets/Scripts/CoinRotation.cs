using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public float speed = -120.0f;
    private MeshRenderer model;

    void Start(){
       model = gameObject.GetComponent<MeshRenderer>();
    }

    void Update(){
        model.transform.Rotate(0.0f,0.0f,speed*Time.deltaTime); //rotates only visible mesh, nothing else.
    }
}
