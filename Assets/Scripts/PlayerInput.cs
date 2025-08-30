using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private CharacterMovement movement;

    private Vector2 horizontalMovement, verticalMovement, moveDirection;

    private void Update()
    {
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");

        moveDirection = moveDirection.normalized;

        movement.MoveCharacter(moveDirection);
    }
}
