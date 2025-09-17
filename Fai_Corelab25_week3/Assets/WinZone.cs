using UnityEngine;
using TMPro;

public class WinZone : MonoBehaviour
{
    private TMP_Text winText;

    void Start()
    {
        GameObject go = GameObject.Find("WinText");
        if (go != null)
        {
            winText = go.GetComponent<TMP_Text>();
            winText.enabled = false;
        }
        else
        {
            Debug.LogWarning("WinText!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && winText != null)
        {
            winText.enabled = true;
            winText.text = "You Won Yappie!";
            Debug.Log("You Won Yappie!");
        }
    }
}
