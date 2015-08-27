using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FireController : MonoBehaviour
{

    public GameObject Bullet;
    List<GameObject> BulletPool;
    int poolAmount = 10;

	void Start ()
    {
        BulletPool = new List<GameObject>();
        for (int i = 0; i < poolAmount; i++)
        {
            GameObject bullet = (GameObject)Instantiate(Bullet);
            bullet.SetActive(false);
            BulletPool.Add(bullet);
        }
	}

    public void ActivateBullet(Transform muzzelTransform)
    {
        foreach (var bullet in BulletPool)
        {
            if (!bullet.activeInHierarchy)
            {
                bullet.SetActive(true);
                bullet.transform.position = muzzelTransform.position;
                bullet.GetComponent<Rigidbody>().AddForce(muzzelTransform.up *2 , ForceMode.Impulse);
            }
        }
    }
}
