using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Damage : MonoBehaviour {

    private Image JackLife;
    private Image VaderLife;
    private Image HeisenLife;
    private Image JamesLife;

    void Start()
    {
        this.JackLife = GetComponent<Image>();
        this.VaderLife = GetComponent<Image>();
        this.HeisenLife = GetComponent<Image>();
        this.JamesLife = GetComponent<Image>();
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "TankVader")
        {
            TankController vader = other.gameObject.GetComponent<TankController>();
            VaderLife.fillAmount = vader.Health;
            vader.Health -= 10;

        }
    }
}
