using UnityEngine;
using static PlayerInformation;
public class PlayerMovement : MonoBehaviour
{
    private BoxCollider2D collider;
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
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
