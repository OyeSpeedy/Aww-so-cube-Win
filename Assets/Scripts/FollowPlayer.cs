using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 cordinates;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = player.position + cordinates;
    }
}
