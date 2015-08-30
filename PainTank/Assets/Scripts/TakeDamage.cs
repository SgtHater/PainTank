using UnityEngine;
using System.Collections;

public class TakeDamage : MonoBehaviour {

    GameObject controller;
    UiController control;
	// Use this for initialization
	void Start ()
    {
        this.controller = GameObject.Find("UIController");
        this.control = controller.GetComponent<UiController>();
	}
	
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "JackEagle")
        {
            TankController jack = other.gameObject.GetComponent<TankController>();
            jack.Health -= 10;
            this.control.Healthbar[0].fillAmount -= 0.1f;
        }
        if (other.gameObject.tag == "TankVader")
        {
            TankController vader = other.gameObject.GetComponent<TankController>();
            vader.Health -= 10;
            this.control.Healthbar[1].fillAmount -= 0.1f;
        }
        if (other.gameObject.tag == "HeisenTank")
        {
            TankController heisen = other.gameObject.GetComponent<TankController>();
            heisen.Health -= 10;
            this.control.Healthbar[2].fillAmount -= 0.1f;
        }
        if (other.gameObject.tag == "JamesTank")
        {
            TankController james = other.gameObject.GetComponent<TankController>();
            james.Health -= 10;
            this.control.Healthbar[3].fillAmount -= 0.1f;
        }
    }
}
