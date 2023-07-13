using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateCount : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;

    void Awake(){
        textMeshPro = FindObjectOfType<TextMeshProUGUI>();
    }

    public void NewValue(int count){       //called by Player when they get a coin
        textMeshPro = FindObjectOfType<TextMeshProUGUI>();
        textMeshPro.text = "Coins: "+count;
    }
}
