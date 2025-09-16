using UnityEngine;
using TMPro;

public class LoseZone : MonoBehaviour
{
    private TMP_Text loseText;

    void Start()
    {
        GameObject go = GameObject.Find("LoseText");
        if (go != null)
        {
            loseText = go.GetComponent<TMP_Text>();
            loseText.enabled = false;
        }
        else
        {
            Debug.LogWarning("LoseText not found!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && loseText != null)
        {
            loseText.enabled = true;
            loseText.text = "You Lost!";
            Debug.Log("You Lost!");
        }
    }
}
