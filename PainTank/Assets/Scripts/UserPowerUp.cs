using UnityEngine;
using System.Collections;

public class UserPowerUp : MonoBehaviour {

    private ChoosePowerUp powerUp;

	// Use this for initialization
	void Start ()
    {
        this.powerUp = GetComponentInChildren<ChoosePowerUp>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        InstantiatePowerUp();
	}

    void InstantiatePowerUp()
    {
        if (this.gameObject.name == "JackEagle")
        {
            if (Input.GetButtonDown(this.gameObject.name + "_UsePowerUp"))
            {
                if (this.powerUp.PowerUps[this.powerUp.arrayPos].name.StartsWith("Shield"))
                {
                    Debug.Log("Haha ein Schild");
                }
                if (this.powerUp.PowerUps[this.powerUp.arrayPos].name.StartsWith("Laser"))
                {
                    Debug.Log("Haha ein Laser");
                }
                if (this.powerUp.PowerUps[this.powerUp.arrayPos].name.StartsWith("Wall"))
                {
                    Debug.Log("Haha ein Wall");
                }
                if (this.powerUp.PowerUps[this.powerUp.arrayPos].name.StartsWith("Nitro"))
                {
                    Debug.Log("Haha ein Nitro");
                }
            }
        }
        else if (this.gameObject.name == "TankVader")
        {
            if (Input.GetButtonDown(this.gameObject.name + "_UsePowerUp"))
            {
                if (this.powerUp.PowerUps[this.powerUp.arrayPos].name.StartsWith("Shield"))
                {
                    Debug.Log("Haha ein Schild");
                }
                if (this.powerUp.PowerUps[this.powerUp.arrayPos].name.StartsWith("Laser"))
                {
                    Debug.Log("Haha ein Laser");
                }
                if (this.powerUp.PowerUps[this.powerUp.arrayPos].name.StartsWith("Wall"))
                {
                    Debug.Log("Haha ein Wall");
                }
                if (this.powerUp.PowerUps[this.powerUp.arrayPos].name.StartsWith("Nitro"))
                {
                    Debug.Log("Haha ein Nitro");
                }
            }
        }
        else if (this.gameObject.name == "HeisenTank")
        {
            if (Input.GetButtonDown(this.gameObject.name + "_UsePowerUp"))
            {
                if (this.powerUp.PowerUps[this.powerUp.arrayPos].name.StartsWith("Shield"))
                {
                    Debug.Log("Haha ein Schild");
                }
                if (this.powerUp.PowerUps[this.powerUp.arrayPos].name.StartsWith("Laser"))
                {
                    Debug.Log("Haha ein Laser");
                }
                if (this.powerUp.PowerUps[this.powerUp.arrayPos].name.StartsWith("Wall"))
                {
                    Debug.Log("Haha ein Wall");
                }
                if (this.powerUp.PowerUps[this.powerUp.arrayPos].name.StartsWith("Nitro"))
                {
                    Debug.Log("Haha ein Nitro");
                }
            }
        }
        else if (this.gameObject.name == "JamesTank")
        {
            if (Input.GetButtonDown(this.gameObject.name + "_UsePowerUp"))
            {
                if (this.powerUp.PowerUps[this.powerUp.arrayPos].name.StartsWith("Shield"))
                {
                    Debug.Log("Haha ein Schild");
                }
                if (this.powerUp.PowerUps[this.powerUp.arrayPos].name.StartsWith("Laser"))
                {
                    Debug.Log("Haha ein Laser");
                }
                if (this.powerUp.PowerUps[this.powerUp.arrayPos].name.StartsWith("Wall"))
                {
                    Debug.Log("Haha ein Wall");
                }
                if (this.powerUp.PowerUps[this.powerUp.arrayPos].name.StartsWith("Nitro"))
                {
                    Debug.Log("Haha ein Nitro");
                }
            }
        }

    }
}
