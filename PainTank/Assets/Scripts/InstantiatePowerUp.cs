using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InstantiatePowerUp : MonoBehaviour {
    public GameObject Wall;
    public GameObject Shield;
    public GameObject Laser;
    public GameObject Map;

    public int pooledamount = 1;

    private List<GameObject> powerups;
	// Use this for initialization
	void Start ()
    {
        powerups = new List<GameObject>();
        for (int i = 0; i < pooledamount; i++)
        {
            GameObject wall = (GameObject)Instantiate(Wall);
            wall.SetActive(false);
            powerups.Add(wall);
            GameObject shield = (GameObject)Instantiate(Shield);
            shield.SetActive(false);
            powerups.Add(shield);
            GameObject laser = (GameObject)Instantiate(Laser);
            laser.SetActive(false);
            powerups.Add(laser);
        }

        InvokeRepeating("InstantiatePowerUps", 2f, 20f);
	}
	
    void InstantiatePowerUps()
    {
        int rnd = Random.Range(0, powerups.Count);

        if (rnd == 0)
        {
            foreach (var item in powerups)
            {
                if (!item.activeInHierarchy)
                {
                    if (item.name.StartsWith("Wall"))
                    {
                        Vector3 rdnTransform = new Vector3(Random.Range(-37.5f, 37.5f), 1f, Random.Range(-37.5f, 37.5f));
                        item.SetActive(true);
                        item.transform.position = rdnTransform;
                        item.transform.rotation = transform.rotation;

                    }
                }
            }
        }

        if (rnd == 1)
        {
            foreach (var item in powerups)
            {
                if (!item.activeInHierarchy)
                {
                    if (item.name.StartsWith("Shield"))
                    {
                        Vector3 rdnTransform = new Vector3(Random.Range(-37.5f, 37.5f), 1f, Random.Range(-37.5f, 37.5f));
                        item.SetActive(true);
                        item.transform.position = rdnTransform;
                        item.transform.rotation = transform.rotation;

                    }
                }
            }
        }

        if (rnd == 2)
        {
            foreach (var item in powerups)
            {
                if (!item.activeInHierarchy)
                {
                    if (item.name.StartsWith("Laser"))
                    {
                        Vector3 rdnTransform = new Vector3(Random.Range(-37.5f, 37.5f), 1f, Random.Range(-37.5f, 37.5f));
                        item.SetActive(true);
                        item.transform.position = rdnTransform;
                        item.transform.rotation = transform.rotation;

                    }
                }
            }
        }
    }
}

