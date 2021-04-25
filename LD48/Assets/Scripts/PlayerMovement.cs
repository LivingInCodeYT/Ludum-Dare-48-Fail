using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private Rigidbody2D rb;
    private Animator anim;
    private float hInput;

    [Header("Movement")]
    public float moveSpeed;
    public int jumpForce;
    public Transform groundCheck;
    public LayerMask whatIsGround;
    private bool isGrounded;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>(); will add when i add animation
    }
    void Update() {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, whatIsGround);
        hInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space)) {
            if (isGrounded) {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
        }
    }
    void FixedUpdate() {
        rb.velocity = new Vector2(hInput * moveSpeed, rb.velocity.y);    
    }
}