using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        if (player != null)
        {
            Vector3 newPosition = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z);
            transform.position = newPosition;
        }
    }
}
