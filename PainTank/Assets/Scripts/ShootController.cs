using UnityEngine;
using System.Collections;

public class ShootController : MonoBehaviour
{
    public GameObject ParentTank;
    public TankController TankController;
    public float delay = 3;
    bool fired = false;

    void Update()
    {
        FireDelay();
        ActivateTimer();
    }
    void FireDelay()
    {
        if (Input.GetAxis(ParentTank.name + "_Tank_Fire") != 0)
        {
            if (!fired)
            {
                TankController.FireController.ActivateBullet(this.transform);
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
}
