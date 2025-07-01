using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private Vector2 movement;
    private bool isFacingRight = true;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position +  movement * speed * Time.fixedDeltaTime);
    }

    private void Flip()
    {
        if (movement.x > 0 && !isFacingRight)
        {
            isFacingRight = true;
            spriteRenderer.flipX = true;
        }
        else if (movement.x < 0 && isFacingRight)
        {
            isFacingRight = false;
            spriteRenderer.flipX = false;
        }
    }
}
