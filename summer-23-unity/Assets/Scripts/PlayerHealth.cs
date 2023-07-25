using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    private bool heldFlag = true;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            if(!heldFlag){
                Kill();
            }
        }
        else{
            heldFlag=false;
        }
        
        
    }

    void Damage(int amount){
        if(currentHealth-amount<=0){
            Kill();
        }
        else{
            currentHealth-=amount;
        }
    }

    void Damage(float amount){
        Damage((int)amount);
    }


    void Kill(){
        currentHealth = maxHealth;
        Debug.Log("Died");
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }
}
