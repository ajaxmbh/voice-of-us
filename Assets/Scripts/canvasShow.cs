using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class canvasShow : MonoBehaviour
{
    public GameObject canvasObject;
    public GameObject player;

    void OnTriggerEnter(Collider consentCollider)
    {
        if (consentCollider.CompareTag("Player"))
        {
            canvasObject.SetActive(true);
            Debug.Log("Collider activated");
            player.SetActive(false);
        }
    }

}
