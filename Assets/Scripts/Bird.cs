using UnityEngine;
using UnityEngine.InputSystem;

public class Bird : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private InputActionReference inputActions;

    const float JumpForce = 100.0f;

    private InputAction jump;

    private void Start()
    {
        jump = inputActions.action;
        jump.performed += Jumped;
    }

    void Jumped(InputAction.CallbackContext callbackContext)
    {
        rb.linearVelocity = Vector2.zero;
        rb.totalForce = Vector2.zero;
        rb.AddForceY(JumpForce);
    }
        
}
