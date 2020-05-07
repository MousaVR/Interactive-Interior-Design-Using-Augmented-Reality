
using UnityEngine;


public class FollowObject : MonoBehaviour
{

    public void FollowTheObject(Vector3 pos, Quaternion rot)
    {
        transform.position = pos;
        transform.rotation = rot;
    }
}
