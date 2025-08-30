using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D characterRB;
    [SerializeField] private float moveForce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveCharacter(Vector2 direction)
    {
        characterRB.AddForce(direction * Time.deltaTime * moveForce, ForceMode2D.Impulse);
    }
}
