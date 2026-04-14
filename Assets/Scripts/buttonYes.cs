using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class buttonYes : MonoBehaviour
{
    public GameObject canvasObject;
    public GameObject player;
    public GameObject consentCollider;
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        canvasObject.SetActive(false);
        consentCollider.SetActive(false);
        player.SetActive(true);
    }
}
