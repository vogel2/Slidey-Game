using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    bool isHit = false;
        
    void OnCollisionEnter(Collision colInfo)
    {
        if (colInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit " + colInfo.collider.name);

            isHit = true;

            movement.enabled = false;
        }
    }

    void Update()
    {
        if(isHit == true)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
