using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{  
    public CharacterController controller;
    public Vector3 direction = new Vector3(0.0f,0.0f,0.0f);
    public bool groundedPlayer;
    public float runSpeed = 7.0f;
    public float jumpSpeed = 19.0f;
    public float playerGravity;             //gravity value currently applied to player
    private static float upGravity = -35.0f; //default gravity
    private static float downGravity = -50.0f; //gravity after hangThreshold
    private static float hangThreshold = 0.008f;    //distance traveled between Update calls must exceed this to switch to downGravity
    private float oldY; //y position on previous frame

    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        oldY=gameObject.transform.position.y;
    }

    void Update()
    {
        if(controller){
            handleMove();
            groundedPlayer = controller.isGrounded;
        }
    }

    void handleMove()
    {        
        Vector3 input  = new Vector3(Input.GetAxis("Horizontal"),0.0f, Input.GetAxis("Vertical")).normalized * runSpeed;
        direction.x = input.x;
        direction.z = input.z;
        if(input != Vector3.zero) gameObject.transform.forward = input;    //faces player in direction of movement
   
        float newY = gameObject.transform.position.y;   
        if(groundedPlayer){
            playerGravity=upGravity;                //resets gravity
            if(direction.y<0.0f)direction.y=-7.0f; //keeps player attached to floor for slopes
            if(Input.GetButtonDown("Jump")){
                direction.y += jumpSpeed;
            }
        }else if(oldY==newY){   //cancels vertical momentum at peak and against ceilings
            direction.y=-1.0f;
        }      
        else if(oldY-newY>hangThreshold){    //increases gravity while descending for better-feeling jump
            playerGravity=downGravity;
        }
        oldY=newY;
        float time = Time.deltaTime;
        direction.y += playerGravity * time;
        controller.Move(direction * time);


    }

    void FixedUpdate(){
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }        
    }
}
