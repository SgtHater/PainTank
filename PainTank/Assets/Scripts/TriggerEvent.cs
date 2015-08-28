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
        if (other.gameObject.transform.parent.tag == "JackEagle")
        {
            if (this.controller.GetComponent<UiController>().PanelArray[0].childCount <= 3)
            {
                Utility.IsPowerUpInPanel = true;
                Utility.JackTankIsPowerUpInPanel = true;
                GameObject powerup = Instantiate(Prefab) as GameObject;
                powerup.transform.SetParent(this.controller.GetComponent<UiController>().PanelArray[0]);
                for (int i = 0; i < other.GetComponent<ChoosePowerUp>().PowerUps.Length; i++)
                {
                    if (other.GetComponent<ChoosePowerUp>().PowerUps[i] == null)
                    {
                        other.GetComponent<ChoosePowerUp>().PowerUps[i] = powerup;
                        break;
                    }
                    
                }
                this.gameObject.SetActive(false);
            }
        }
        else if (other.gameObject.transform.parent.tag == "TankVader")
        {
            if (this.controller.GetComponent<UiController>().PanelArray[2].childCount <= 3)
            {
                Utility.IsPowerUpInPanel = true;
                Utility.TankVaderPowerUpInPanel = true;
                GameObject powerup = Instantiate(Prefab) as GameObject;
                powerup.transform.SetParent(this.controller.GetComponent<UiController>().PanelArray[2]);
                for (int i = 0; i < other.GetComponent<ChoosePowerUp>().PowerUps.Length; i++)
                {
                    if (other.GetComponent<ChoosePowerUp>().PowerUps[i] == null)
                    {
                        other.GetComponent<ChoosePowerUp>().PowerUps[i] = powerup;
                        break;
                    }

                }
                this.gameObject.SetActive(false);
            }
        }
        if (other.gameObject.transform.parent.tag == "JamesTank")
        {
            if (this.controller.GetComponent<UiController>().PanelArray[3].childCount <= 3)
            {
                Utility.IsPowerUpInPanel = true;
                Utility.JamesTankPowerUpInPanel = true;
                GameObject powerup = Instantiate(Prefab) as GameObject;
                powerup.transform.SetParent(this.controller.GetComponent<UiController>().PanelArray[0]);
                for (int i = 0; i < other.GetComponent<ChoosePowerUp>().PowerUps.Length; i++)
                {
                    if (other.GetComponent<ChoosePowerUp>().PowerUps[i] == null)
                    {
                        other.GetComponent<ChoosePowerUp>().PowerUps[i] = powerup;
                        break;
                    }

                }
                this.gameObject.SetActive(false);
            }
        }
        if (other.gameObject.transform.parent.tag == "HeisenTank")
        {
            if (this.controller.GetComponent<UiController>().PanelArray[1].childCount <= 3)
            {
                Utility.IsPowerUpInPanel = true;
                Utility.HeisenTankPowerUpInPanel = true;
                GameObject powerup = Instantiate(Prefab) as GameObject;
                powerup.transform.SetParent(this.controller.GetComponent<UiController>().PanelArray[0]);
                for (int i = 0; i < other.GetComponent<ChoosePowerUp>().PowerUps.Length; i++)
                {
                    if (other.GetComponent<ChoosePowerUp>().PowerUps[i] == null)
                    {
                        other.GetComponent<ChoosePowerUp>().PowerUps[i] = powerup;
                        break;
                    }

                }
                this.gameObject.SetActive(false);
            }
        }
    }

}
