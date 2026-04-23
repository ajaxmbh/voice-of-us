using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scriptShow : MonoBehaviour
{
    public GameObject scriptObject;
    public GameObject player;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            scriptObject.SetActive(true);
            Debug.Log("Collider activated");
            
        }
    }

    void OnTriggerExit(Collider collider)
    {
        scriptObject.SetActive(false);
        Debug.Log("Script removed!");
    }


}
