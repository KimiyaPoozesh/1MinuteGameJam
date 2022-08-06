using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bullet,shooter;
    [SerializeField]
    Transform shootPosition;
    public float bulletForce = 20f;
    Vector2 target_position;
    void Update(){
        if(GetComponent<PlayerInputManager>().shoot)
        { 
        
        Debug.Log("in");
        gameObject.GetComponent<Rigidbody2D>().velocity =new Vector2(0,-100)* Time.deltaTime ;
        
        // Vector2 aim = target_position - (Vector2)shootPosition.position;
    // GameObject bullet_Obj = Instantiate(bullet, shootPosition.position, new Quaternion());
    // bullet_Obj.GetComponent<bullet>().shoot(aim, shoot.er);
        }
        
    }
}