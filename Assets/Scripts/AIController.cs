using UnityEngine;

public class AIController : MonoBehaviour
{
    [SerializeField] private float vehicalSpeed;
    [SerializeField] private float despawnTimer;
    [SerializeField] private float speedVarriance = 5;
    [SerializeField] private float trueSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, despawnTimer);
        trueSpeed = vehicalSpeed + Random.Range(-speedVarriance, speedVarriance);
    }

    // Update is called once per frame
    void Update()
    {
        // Move forwards by a set speed  +/- a random amount within a bound 
        transform.Translate(Vector3.forward * Time.deltaTime * trueSpeed);

        // If below the stadium, destroy the object
        if (transform.position.y < -1)
        {
           Destroy(gameObject);
        }
    }
}
