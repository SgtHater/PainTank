using UnityEngine;
using System.Collections;

public class ChoosePowerUp : MonoBehaviour
{
    private GameObject controller;
    private bool JackEagleisSpawned = false;
    private bool HeisentankisSpawned = false;
    private bool TankVaderisSpawned = false;
    private bool JamesTankisSpawned = false;

    public GameObject Rectangle;
    public GameObject[] PowerUps;
    private GameObject rectangle;
    public int arrayPos;
    

    void Awake()
    {
        controller = GameObject.Find("UIController");
    }
    void Update()
    {
        if (Utility.IsPowerUpInPanel)
        {
            ChoosePowerUps();
        }
    }

    void ChoosePowerUps()
    {
        if (this.gameObject.transform.parent.tag == "JackEagle")
        {
            if (!JackEagleisSpawned && Utility.JackTankIsPowerUpInPanel)
            {
                rectangle = Instantiate(Rectangle) as GameObject;
                rectangle.transform.SetParent(PowerUps[0].transform);
                JackEagleisSpawned = true;
                arrayPos = 0;
            }

            if (Input.GetButtonDown(this.gameObject.transform.parent.name + "_RightBumper"))
            {
                arrayPos += 1;
                if (arrayPos < PowerUps.Length)
                {
                    if (PowerUps[arrayPos] == null)
                    {
                        arrayPos-= 1;
                    }
                }
                rectangle.transform.SetParent(PowerUps[arrayPos].transform, false);
                
            }
            if (Input.GetButtonDown(this.gameObject.transform.parent.name + "_LeftBumper"))
            {
                arrayPos -= 1;
                if (arrayPos < 0)
                {
                    arrayPos = 0;
                    if (arrayPos < PowerUps.Length)
                    {
                        if (PowerUps[arrayPos] == null)
                        {
                            arrayPos += 1;
                        }
                    }

                }
                rectangle.transform.SetParent(PowerUps[arrayPos].transform, false);
                Debug.Log(arrayPos);
            }
        }
        else if (this.gameObject.transform.parent.tag == "TankVader")
        {
            if (!TankVaderisSpawned && Utility.TankVaderPowerUpInPanel)
            {
                rectangle = Instantiate(Rectangle) as GameObject;
                rectangle.transform.SetParent(PowerUps[0].transform);
                TankVaderisSpawned = true;
                arrayPos = 0;
            }

            if (Input.GetButtonDown(this.gameObject.transform.parent.name + "_RightBumper"))
            {
                arrayPos += 1;
                if (arrayPos < PowerUps.Length)
                {
                    if (PowerUps[arrayPos] == null)
                    {
                        arrayPos -= 1;
                    }
                }
                rectangle.transform.SetParent(PowerUps[arrayPos].transform, false);

            }
            if (Input.GetButtonDown(this.gameObject.transform.parent.name + "_LeftBumper"))
            {
                arrayPos -= 1;
                if (arrayPos < 0)
                {
                    arrayPos = 0;
                    if (arrayPos < PowerUps.Length)
                    {
                        if (PowerUps[arrayPos] == null)
                        {
                            arrayPos += 1;
                        }
                    }

                }
                rectangle.transform.SetParent(PowerUps[arrayPos].transform, false);
                Debug.Log(arrayPos);
            }
        }
        else if (this.gameObject.transform.parent.tag == "HeisenTank")
        {
            if (!HeisentankisSpawned && Utility.HeisenTankPowerUpInPanel)
            {
                rectangle = Instantiate(Rectangle) as GameObject;
                rectangle.transform.SetParent(PowerUps[0].transform);
                HeisentankisSpawned = true;
                arrayPos = 0;
            }

            if (Input.GetButtonDown(this.gameObject.transform.parent.name + "_RightBumper"))
            {
                arrayPos += 1;
                if (arrayPos < PowerUps.Length)
                {
                    if (PowerUps[arrayPos] == null)
                    {
                        arrayPos -= 1;
                    }
                }
                rectangle.transform.SetParent(PowerUps[arrayPos].transform, false);

            }
            if (Input.GetButtonDown(this.gameObject.transform.parent.name + "_LeftBumper"))
            {
                arrayPos -= 1;
                if (arrayPos < 0)
                {
                    arrayPos = 0;
                    if (arrayPos < PowerUps.Length)
                    {
                        if (PowerUps[arrayPos] == null)
                        {
                            arrayPos += 1;
                        }
                    }

                }
                rectangle.transform.SetParent(PowerUps[arrayPos].transform, false);
                Debug.Log(arrayPos);
            }
        }
        else if (this.gameObject.transform.parent.tag == "JamesTank")
        {
            if (!JamesTankisSpawned && Utility.JamesTankPowerUpInPanel)
            {
                rectangle = Instantiate(Rectangle) as GameObject;
                rectangle.transform.SetParent(PowerUps[0].transform);
                JamesTankisSpawned = true;
                arrayPos = 0;
            }

            if (Input.GetButtonDown(this.gameObject.transform.parent.name + "_RightBumper"))
            {
                arrayPos += 1;
                if (arrayPos < PowerUps.Length)
                {
                    if (PowerUps[arrayPos] == null)
                    {
                        arrayPos -= 1;
                    }
                }
                rectangle.transform.SetParent(PowerUps[arrayPos].transform, false);

            }
            if (Input.GetButtonDown(this.gameObject.transform.parent.name + "_LeftBumper"))
            {
                arrayPos -= 1;
                if (arrayPos < 0)
                {
                    arrayPos = 0;
                    if (arrayPos < PowerUps.Length)
                    {
                        if (PowerUps[arrayPos] == null)
                        {
                            arrayPos += 1;
                        }
                    }

                }
                rectangle.transform.SetParent(PowerUps[arrayPos].transform, false);
                Debug.Log(arrayPos);
            }
        }

    }
}


