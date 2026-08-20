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
    [SerializeField]
    private GameObject restartUI;
    [SerializeField]
    private GameObject scoreUI;
    const float JumpForce = 100.0f;

    private InputAction jump;
    private bool isAlive = true;

    private void Start()
    {
        jump = inputActions.action;
        jump.performed += Jumped;
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.AngleAxis(Mathf.Atan2(rb.linearVelocityY * 2.0f, 10.0f) * Mathf.Rad2Deg, Vector3.forward);
    }

    void Jumped(InputAction.CallbackContext callbackContext)
    {
        rb.linearVelocity = Vector2.zero;
        rb.totalForce = Vector2.zero;
        rb.AddForceY(JumpForce);
        animator.Play("Bird", 0, 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isAlive)
        {
            jump.performed -= Jumped;
            isAlive = false;
            restartUI.SetActive(true);
            Jumped(new InputAction.CallbackContext());
            Scenario.Speed = 0.0f;
            Pipe.Speed = 0.0f;
            scoreUI.transform.position = new Vector3(0.0f, 25f, 0.0f);
        }
    }
}
