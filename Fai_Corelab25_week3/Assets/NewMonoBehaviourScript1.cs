using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public Camera fromCamera; 
    public Camera toCamera;  

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (fromCamera != null)
            {
                fromCamera.enabled = false;
                fromCamera.gameObject.SetActive(false);
            }

            if (toCamera != null)
            {
                toCamera.gameObject.SetActive(true);
                toCamera.enabled = true;
            }
        }
    }
}
