using UnityEngine;
using System.Collections;

public class ShootController : MonoBehaviour
{
    public GameObject ParentTank;
    public FireController fireController;

    void Update()
    {
        if (Input.GetAxis(ParentTank.name + "_Fire") != 0)
        {
            fireController.ActivateBullet(this.transform);
        }
    }
}
