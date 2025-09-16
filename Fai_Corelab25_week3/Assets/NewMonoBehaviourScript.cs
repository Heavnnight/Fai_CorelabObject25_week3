using UnityEngine;

using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class NewBehaviourScript : MonoBehaviour
{
    public float force = 50f;
    public Vector3 dir = Vector3.forward;
    Rigidbody rb; bool started;

    void Start() { rb = GetComponent<Rigidbody>(); rb.isKinematic = true; }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            started = true;
            rb.isKinematic = false;
            rb.linearVelocity = Vector3.zero; rb.angularVelocity = Vector3.zero;
            rb.AddForce(dir.normalized * force, ForceMode.VelocityChange);
        }
    }
}
