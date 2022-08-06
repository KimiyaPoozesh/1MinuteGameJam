using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    public Vector2 moveDirection;

    [HideInInspector]
    public bool shoot;
    public bool boost;

    void Update(){
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");
        if (moveDirection.y < 0)
        {
            moveDirection.y = 0;
        }
        moveDirection.Normalize();
        if (Input.GetKeyDown(KeyCode.Space)) shoot = true;
        else shoot = false;

       if (Input.GetKeyDown(KeyCode.LeftShift)) boost = true;
       else boost = false;
    }
}
