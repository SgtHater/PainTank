using UnityEngine;
using System.Collections;

public class ShootController : MonoBehaviour
{
    public GameObject ParentTank;
    public TankController TankController;
    public Color BulletColor;
    public float delay = 3;
    bool fired = false;

    void Update()
    {
        FireDelay();
        ActivateTimer();
        ChangeBulletColor();
    }
    void FireDelay()
    {
        if (Input.GetAxis(ParentTank.name + "_Tank_Fire") != 0)
        {
            if (!fired)
            {
                TankController.FireController.ActivateBullet(this.transform, BulletColor);
                fired = true;
                ActivateTimer();
            }
        }
    } 
    void ActivateTimer()
    {
        if (fired)
        {
            delay -= Time.deltaTime;
            if (delay <= 0)
            {
                fired = false;
                delay = 3.5f;
            }
        }
    }
    void ChangeBulletColor()
    {
        if (ParentTank.name == "JackEagle")
        {
            BulletColor = Color.green;
        }
        else if (ParentTank.name == "TankVader")
        {
            BulletColor = Color.white;
        }
        else if (ParentTank.name == "HeisenTank")
        {
            BulletColor = Color.blue;
        }
        else if (ParentTank.name == "JamesTank")
        {
            BulletColor = Color.red;
        }
    }
}
