
using UnityEngine;

public class PlayerMovementt : MonoBehaviour
{
    [SerializeField, Range(0f,100f)]
    float moveSpeed = 35f;

    private Rigidbody2D rb;
    private Animator animator;
    public Vector2 moveDirection1;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate(){
        Move();
    }
    void Move(){
        var moveDirection = GetComponent<PlayerInputManager>().moveDirection;
        rb.velocity = moveDirection * moveSpeed * Time.deltaTime * 10;
    }
}
