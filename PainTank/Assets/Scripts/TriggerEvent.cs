using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TriggerEvent : MonoBehaviour
{
    public GameObject controller;
    public GameObject Prefab;

    void Awake()
    {
        controller = GameObject.Find("UIController");

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "JackEagle")
        {
            if (this.controller.GetComponent<UiController>().PanelArray[0].childCount <= 3)
            {
                GameObject powerup = Instantiate(Prefab) as GameObject;
                powerup.transform.SetParent(this.controller.GetComponent<UiController>().PanelArray[0]);
                this.gameObject.SetActive(false);
            }
        }
    }

}
