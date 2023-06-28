using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Header("Gameplay Values")] [SerializeField]
    private float speed;

    [Header("References")] [SerializeField]
    private new Rigidbody2D rigidbody2D;

    private Vector2 _velocity, _currentInput;

    private void FixedUpdate()
    {
        var newPosition = rigidbody2D.position + _currentInput * (speed * Time.deltaTime);
        rigidbody2D.MovePosition(newPosition);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _currentInput = context.ReadValue<Vector2>();
    }
}