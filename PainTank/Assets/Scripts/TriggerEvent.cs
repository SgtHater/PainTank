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
                Utility.IsPowerUpInPanel = true;
                GameObject powerup = Instantiate(Prefab) as GameObject;
                powerup.transform.SetParent(this.controller.GetComponent<UiController>().PanelArray[0]);
                Transform Main = other.transform.parent;
                for (int i = 0; i < Main.GetComponent<ChoosePowerUp>().powerup.Length; i++)
                {
                    if (Main.GetComponent<ChoosePowerUp>().powerup[i] == null)
                    {
                        Main.GetComponent<ChoosePowerUp>().powerup[i] = powerup;
                        break;
                    }
                    
                }
                this.gameObject.SetActive(false);
            }
        }
        else if (other.gameObject.tag == "TankVader")
        {
            if (this.controller.GetComponent<UiController>().PanelArray[0].childCount <= 3)
            {
                Utility.IsPowerUpInPanel = true;
                GameObject powerup = Instantiate(Prefab) as GameObject;
                powerup.transform.SetParent(this.controller.GetComponent<UiController>().PanelArray[2]);
                Transform Main = other.transform.parent;
                for (int i = 0; i < Main.GetComponent<ChoosePowerUp>().powerup.Length; i++)
                {
                    if (Main.GetComponent<ChoosePowerUp>().powerup[i] == null)
                    {
                        Main.GetComponent<ChoosePowerUp>().powerup[i] = powerup;
                        break;
                    }

                }
                this.gameObject.SetActive(false);
            }
        }
    }

}
