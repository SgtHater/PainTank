using UnityEngine;
using System.Collections;

public class FlyOutOfMap : MonoBehaviour
{
    GameObject controller;
    UiController control;

    void Awake()
    {
        this.controller = GameObject.Find("UIController");
        this.control = this.controller.GetComponent<UiController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "JackEagleBody")
        {
            Destroy(other.gameObject);
            this.control.Healthbar[0].fillAmount = 0f;
        }
        if (other.gameObject.tag == "TankVaderBody")
        {
            Destroy(other.gameObject);
            this.control.Healthbar[1].fillAmount = 0f;
        }
        if (other.gameObject.tag == "HeisenTankBody")
        {
            Destroy(other.gameObject);
            this.control.Healthbar[2].fillAmount = 0f;
        }
        if (other.gameObject.tag == "JamesTankBody")
        {
            Destroy(other.gameObject);
            this.control.Healthbar[3].fillAmount = 0f;
        }
    }
}
