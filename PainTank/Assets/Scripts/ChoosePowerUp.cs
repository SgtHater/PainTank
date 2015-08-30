using UnityEngine;
using System.Collections;

public class ChoosePowerUp : MonoBehaviour
{
    GameObject controller;
    private bool JackEagleisSpawned = false;
    private bool HeisentankisSpawned = false;
    private bool TankVaderisSpawned = false;
    private bool JamesTankisSpawned = false;

    public GameObject Rectangle;
    public GameObject[] EaglePowerUps;
    public GameObject[] VaderPowerUps;
    public GameObject[] HeisenPowerUps;
    public GameObject[] JamesPowerUps;
    private GameObject rectangle;
    public int EagleArrayPos;
    public int VaderArrayPos;
    public int JamesArrayPos;
    public int HeisenArrayPos;


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
                rectangle.transform.SetParent(EaglePowerUps[0].transform);
                JackEagleisSpawned = true;
                EagleArrayPos = 0;
            }
            if (Input.GetButtonDown(this.gameObject.transform.parent.name + "_RightBumper"))
            {
                EagleArrayPos += 1;
                if (EagleArrayPos < EaglePowerUps.Length)
                {
                    if (EaglePowerUps[EagleArrayPos] == null)
                    {
                        EagleArrayPos -= 1;
                    }
                }
                rectangle.transform.SetParent(EaglePowerUps[EagleArrayPos].transform, false);

            }
            if (Input.GetButtonDown(this.gameObject.transform.parent.name + "_LeftBumper"))
            {
                EagleArrayPos -= 1;
                if (EagleArrayPos < 0)
                {
                    EagleArrayPos = 0;
                    if (EagleArrayPos < EaglePowerUps.Length)
                    {
                        if (EaglePowerUps[EagleArrayPos] == null)
                        {
                            EagleArrayPos += 1;
                        }
                    }

                }
                rectangle.transform.SetParent(EaglePowerUps[EagleArrayPos].transform, false);
                Debug.Log(EagleArrayPos);
            }

        }
        else if (this.gameObject.transform.parent.tag == "TankVader")
        {
            if (!TankVaderisSpawned && Utility.TankVaderPowerUpInPanel)
            {
                rectangle = Instantiate(Rectangle) as GameObject;
                rectangle.transform.SetParent(VaderPowerUps[0].transform);
                TankVaderisSpawned = true;
                VaderArrayPos = 0;
            }
            if (Input.GetButtonDown(this.gameObject.transform.parent.name + "_RightBumper"))
            {
                VaderArrayPos += 1;
                if (VaderArrayPos < VaderPowerUps.Length)
                {
                    if (VaderPowerUps[VaderArrayPos] == null)
                    {
                        VaderArrayPos -= 1;
                    }
                }
                rectangle.transform.SetParent(VaderPowerUps[VaderArrayPos].transform, false);

            }
            if (Input.GetButtonDown(this.gameObject.transform.parent.name + "_LeftBumper"))
            {
                VaderArrayPos -= 1;
                if (VaderArrayPos < 0)
                {
                    VaderArrayPos = 0;
                    if (VaderArrayPos < VaderPowerUps.Length)
                    {
                        if (VaderPowerUps[VaderArrayPos] == null)
                        {
                            VaderArrayPos += 1;
                        }
                    }

                }
                rectangle.transform.SetParent(VaderPowerUps[VaderArrayPos].transform, false);
                Debug.Log(VaderArrayPos);
            }

        }
        else if (this.gameObject.transform.parent.tag == "HeisenTank")
        {
            if (!HeisentankisSpawned && Utility.HeisenTankPowerUpInPanel)
            {
                rectangle = Instantiate(Rectangle) as GameObject;
                rectangle.transform.SetParent(HeisenPowerUps[0].transform);
                HeisentankisSpawned = true;
                HeisenArrayPos = 0;
            }
            if (Input.GetButtonDown(this.gameObject.transform.parent.name + "_RightBumper"))
            {
                HeisenArrayPos += 1;
                if (HeisenArrayPos < HeisenPowerUps.Length)
                {
                    if (HeisenPowerUps[HeisenArrayPos] == null)
                    {
                        HeisenArrayPos -= 1;
                    }
                }
                rectangle.transform.SetParent(HeisenPowerUps[HeisenArrayPos].transform, false);

            }
            if (Input.GetButtonDown(this.gameObject.transform.parent.name + "_LeftBumper"))
            {
                HeisenArrayPos -= 1;
                if (HeisenArrayPos < 0)
                {
                    HeisenArrayPos = 0;
                    if (HeisenArrayPos < HeisenPowerUps.Length)
                    {
                        if (HeisenPowerUps[HeisenArrayPos] == null)
                        {
                            HeisenArrayPos += 1;
                        }
                    }

                }
                rectangle.transform.SetParent(HeisenPowerUps[HeisenArrayPos].transform, false);
                Debug.Log(HeisenArrayPos);
            }

        }
        else if (this.gameObject.transform.parent.tag == "JamesTank")
        {
            if (!JamesTankisSpawned && Utility.JamesTankPowerUpInPanel)
            {
                rectangle = Instantiate(Rectangle) as GameObject;
                rectangle.transform.SetParent(JamesPowerUps[0].transform);
                JamesTankisSpawned = true;
                JamesArrayPos = 0;
            }
            if (Input.GetButtonDown(this.gameObject.transform.parent.name + "_RightBumper"))
            {
                JamesArrayPos += 1;
                if (JamesArrayPos < JamesPowerUps.Length)
                {
                    if (JamesPowerUps[JamesArrayPos] == null)
                    {
                        JamesArrayPos -= 1;
                    }
                }
                rectangle.transform.SetParent(JamesPowerUps[JamesArrayPos].transform, false);

            }
            if (Input.GetButtonDown(this.gameObject.transform.parent.name + "_LeftBumper"))
            {
                JamesArrayPos -= 1;
                if (JamesArrayPos < 0)
                {
                    JamesArrayPos = 0;
                    if (JamesArrayPos < JamesPowerUps.Length)
                    {
                        if (JamesPowerUps[JamesArrayPos] == null)
                        {
                            JamesArrayPos += 1;
                        }
                    }

                }
                rectangle.transform.SetParent(JamesPowerUps[JamesArrayPos].transform, false);
                Debug.Log(JamesArrayPos);
            }
        }

    }
}


