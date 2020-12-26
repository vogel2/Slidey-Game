using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision colInfo)
    {
        if (colInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit " + colInfo.collider.name);
            movement.enabled = false;
        }
    }
}
