using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject cameraRoot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = cameraRoot.transform.position;
        transform.rotation = cameraRoot.transform.rotation;
    }
}
