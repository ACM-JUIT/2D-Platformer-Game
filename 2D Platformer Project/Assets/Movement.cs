
// *************************                Read Comments carefully to understand this script              ****************************************

// There are 2 scripts responsilble for player's movement, CharacterController2D.cs and Movement.cs (this one)

//The CharacterController2D.cs is a large script consisting of a lot of components, go through that but ou don't need to fully understand to work on the project

//CharacterController2D.cs contains actual function which add movement and physics to the object, eg. Move() function

/*
 
This script (Movement.cs) asks player for input and passes those input values to the Move() function inside CharacterController2D.cs class, in other words we're calling the
Move() funciton in this script (inside FixedUpdate() method) 

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movement : MonoBehaviour
{
    public CharacterController2D controller;                        // Reference to the CharacterController2D.cs class so that we can access Move() function

    float Xmove;                                                    // Float variavle to pass inside Move() containing left and right movement info
    
    [SerializeField]                         // This means that the playerSpeed variable would be readable but not changable (since it's not public) in the inspector panel

    float playerSpeed = 40;                                         // The player's speed

    bool jump = false;
   
    void Update()
    {
        /* The following GetAxisRaw(Horizontal) takes 'A' and 'D' keys and controllers joystick as input keys and returns a float value between -1 and 1.
           In the case of a keyboard it only returns 1 and -1  */

        Xmove = Input.GetAxisRaw("Horizontal") * playerSpeed;       // This Xmove becomes the players velocity since -ve and +ve only defines direction, and its multiplied by speed.
        
        if (Input.GetButtonDown("Jump"))                            // This takes spacebar as input
        {
            jump = true;                                            // Setting jump value as true so that Move() could execute jumping
        }  
    }
    private void FixedUpdate()                                      // We use FixedUpdate() to deal with physics in gameObjects
    {
        controller.Move(Xmove*Time.fixedDeltaTime, false, jump);        // Calling Move() function
        jump = false;                                                   //Setting jump to false so that it could be true again in the Update() method
    }
}
