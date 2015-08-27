using UnityEngine;
using System.Collections;

public class ChoosePowerUp : MonoBehaviour
{
    private GameObject controller;
    private bool isSpawned = false;
    public GameObject Rectangle;
    public GameObject[] powerup;
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
        if (this.gameObject.tag == "JackEagle")
        {
            if (!isSpawned)
            {
                rectangle = Instantiate(Rectangle) as GameObject;
                rectangle.transform.SetParent(powerup[0].transform);
                isSpawned = true;
                arrayPos = 0;
            }

            if (Input.GetButtonDown(gameObject.name + "_RightBumper"))
            {

                arrayPos += 1;
                if (arrayPos < powerup.Length)
                {
                    if (powerup[arrayPos] == null)
                    {
                        arrayPos-= 1;
                    }
                }
                rectangle.transform.SetParent(powerup[arrayPos].transform, false);
                Debug.Log(powerup[arrayPos].name);
            }
        }
        if (Input.GetButtonDown(gameObject.name + "_LeftBumper"))
        {
            arrayPos -= 1;
            if (arrayPos < 0)
            {
                arrayPos = 0;
                if (arrayPos < powerup.Length)
                {
                    if (powerup[arrayPos] == null)
                    {
                        arrayPos += 1;
                    }
                }
                
            }
            rectangle.transform.SetParent(powerup[arrayPos].transform, false);
        }
    }
}


