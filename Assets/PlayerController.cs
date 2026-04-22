using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput.x = Keyboard.current.dKey.isPressed ? 1f :
                      Keyboard.current.aKey.isPressed ? -1f : 0f;
        moveInput.y = Keyboard.current.wKey.isPressed ? 1f :
                      Keyboard.current.sKey.isPressed ? -1f : 0f;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveInput * moveSpeed;
    }
}