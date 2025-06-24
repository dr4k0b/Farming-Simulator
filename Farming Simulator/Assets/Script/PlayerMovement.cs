using UnityEngine;
using UnityEngine.InputSystem;
using static GlobalInformation;
public class PlayerMovement : MonoBehaviour
{
    BoxCollider2D collider;
    void Start()
    {
        
    }
    void Update()
    {
        GroundCheck();
    }
    public void GroundCheck()
    {
        Debug.DrawRay((transform.position - (Vector3)(collider.size / 2) * collider.size.x), transform.right, Color.red);
        grounded = Physics.Raycast(transform.position - (Vector3)(collider.size / 2), transform.right, collider.size.x);
    }
}
