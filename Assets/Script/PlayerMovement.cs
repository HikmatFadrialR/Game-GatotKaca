using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce;
    public float movespeed;
    bool facingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerJump();
        FlipTrigger();
    }

    private void FixedUpdate()
    {
        PlayerController();
    }

    void PlayerController()
    {
        float x = Input.GetAxisRaw("Horizontal");

        Vector3 movement = new Vector3(x * movespeed, rb.velocity.y, 0f);
        rb.velocity = movement;
    }

    void FlipTrigger()
    {
        if (rb.velocity.x < 0 && facingRight)
        {
            FlipPlayer();
        }
        else if (rb.velocity.x > 0 && !facingRight)
        {
            FlipPlayer();
        }
    }

    void FlipPlayer()
    {
        facingRight = !facingRight;

        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }

    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0f);
        }
    }
}
