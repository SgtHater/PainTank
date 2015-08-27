using UnityEngine;
using System.Collections;

public class UserPowerUp : MonoBehaviour {

    private ChoosePowerUp powerUp;

	// Use this for initialization
	void Start ()
    {
        this.powerUp = GetComponent<ChoosePowerUp>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        InstantiatePowerUp();
	}

    void InstantiatePowerUp()
    {
        if (Input.GetButtonDown(this.gameObject.name + "_UsePowerUp") && this.powerUp.powerup[this.powerUp.arrayPos] != null)
        {
            if (this.powerUp.powerup[this.powerUp.arrayPos].name.StartsWith("Shield"))
            {
                Debug.Log("Haha ein Schild");
                
            }
            if (this.powerUp.powerup[this.powerUp.arrayPos].name.StartsWith("Laser"))
            {
                Debug.Log("Haha ein Laser");
            }
            if (this.powerUp.powerup[this.powerUp.arrayPos].name.StartsWith("Wall"))
            {
                Debug.Log("Haha ein Wall");
            }
            if (this.powerUp.powerup[this.powerUp.arrayPos].name.StartsWith("Nitro"))
            {
                Debug.Log("Haha ein Nitro");
            }
        }
    }
}
