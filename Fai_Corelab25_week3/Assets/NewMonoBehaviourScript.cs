using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class StartOnSpace : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.isKinematic = false; 
        }
    }
}
