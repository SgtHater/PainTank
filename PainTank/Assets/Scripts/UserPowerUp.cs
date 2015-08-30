using UnityEngine;
using System.Collections;

public class UserPowerUp : MonoBehaviour {

    private ChoosePowerUp powerUp;
    private LineRenderer laser;
    private GameObject jackmuzzle;
    private GameObject vadermuzzle;
    private GameObject heisenmuzzle;
    private GameObject jamesmuzzle;
    private Ray ray;
    private Transform muzzletransform;

    public GameObject WallPrefab;

	// Use this for initialization
	void Start ()
    {
        this.powerUp = GetComponentInChildren<ChoosePowerUp>();
        this.laser = GetComponent<LineRenderer>();
        this.vadermuzzle = GameObject.FindGameObjectWithTag("VaderMuzzle");
        this.jackmuzzle = GameObject.FindGameObjectWithTag("JackMuzzle");
        this.heisenmuzzle = GameObject.FindGameObjectWithTag("HeisenMuzzle");
        this.jamesmuzzle = GameObject.FindGameObjectWithTag("JamesMuzzle");


    }

    // Update is called once per frame
    void Update ()
    {
        InstantiatePowerUp();
	}

    void InstantiatePowerUp()
    {
        if (this.gameObject.tag == "JackEagle" && this.powerUp.EaglePowerUps != null)
        {
            if (Input.GetButtonDown(this.gameObject.name + "_UsePowerUp"))
            {
                if (this.powerUp.EaglePowerUps[this.powerUp.EagleArrayPos].name.StartsWith("Shield"))
                {
                    Debug.Log("Haha ein Schild");
                }
                if (this.powerUp.EaglePowerUps[this.powerUp.EagleArrayPos].name.StartsWith("Laser"))
                {
                    LaserBeam(jackmuzzle.transform);
                }
                if (this.powerUp.EaglePowerUps[this.powerUp.EagleArrayPos].name.StartsWith("Wall"))
                {
                    InstantiateWall(jackmuzzle.transform);
                }
                if (this.powerUp.EaglePowerUps[this.powerUp.EagleArrayPos].name.StartsWith("Nitro"))
                {
                    Debug.Log("Haha ein Nitro");
                }
            }
        }
        else if (this.gameObject.tag == "TankVader")
        {
            if (Input.GetButtonDown(this.gameObject.name + "_UsePowerUp"))
            {
                if (this.powerUp.VaderPowerUps[this.powerUp.VaderArrayPos].name.StartsWith("Shield"))
                {
                    Debug.Log("Haha ein Schild");
                }
                if (this.powerUp.VaderPowerUps[this.powerUp.VaderArrayPos].name.StartsWith("Laser"))
                {
                    LaserBeam(vadermuzzle.transform);
                }
                if (this.powerUp.VaderPowerUps[this.powerUp.VaderArrayPos].name.StartsWith("Wall"))
                {
                    InstantiateWall(vadermuzzle.transform);
                }
                if (this.powerUp.VaderPowerUps[this.powerUp.VaderArrayPos].name.StartsWith("Nitro"))
                {
                    Debug.Log("Haha ein Nitro");
                }
            }
        }
        else if (this.gameObject.tag == "HeisenTank")
        {
            if (Input.GetButtonDown(this.gameObject.name + "_UsePowerUp"))
            {
                if (this.powerUp.HeisenPowerUps[this.powerUp.HeisenArrayPos].name.StartsWith("Shield"))
                {
                    Debug.Log("Haha ein Schild");
                }
                if (this.powerUp.HeisenPowerUps[this.powerUp.HeisenArrayPos].name.StartsWith("Laser"))
                {
                    LaserBeam(heisenmuzzle.transform);
                }
                if (this.powerUp.HeisenPowerUps[this.powerUp.HeisenArrayPos].name.StartsWith("Wall"))
                {
                    InstantiateWall(heisenmuzzle.transform);
                }
                if (this.powerUp.HeisenPowerUps[this.powerUp.HeisenArrayPos].name.StartsWith("Nitro"))
                {
                    Debug.Log("Haha ein Nitro");
                }
            }
        }
        else if (this.gameObject.tag == "JamesTank")
        {
            if (Input.GetButtonDown(this.gameObject.name + "_UsePowerUp"))
            {
                if (this.powerUp.JamesPowerUps[this.powerUp.JamesArrayPos].name.StartsWith("Shield"))
                {
                    Debug.Log("Haha ein Schild");
                }
                if (this.powerUp.JamesPowerUps[this.powerUp.JamesArrayPos].name.StartsWith("Laser"))
                {
                    LaserBeam(jamesmuzzle.transform);
                }
                if (this.powerUp.JamesPowerUps[this.powerUp.JamesArrayPos].name.StartsWith("Wall"))
                {
                    InstantiateWall(jamesmuzzle.transform);
                }
                if (this.powerUp.JamesPowerUps[this.powerUp.JamesArrayPos].name.StartsWith("Nitro"))
                {
                    Debug.Log("Haha ein Nitro");
                }
            }
        }

    }

    void LaserBeam(Transform muzzle)
    {
        this.muzzletransform = muzzle;
        this.ray = new Ray(muzzletransform.position, muzzletransform.up);
        RaycastHit hit;

        float shotDistance = 500;
        if (Physics.Raycast(ray,out hit,shotDistance))
        {
            shotDistance = hit.distance;
            if (hit.collider)
            {
                Debug.Log("Shot");
            }
        }
        StartCoroutine("RenderLaser", ray.direction * shotDistance);
    }

    IEnumerator RenderLaser(Vector3 hitpoint)
    {
        laser.enabled = true;
        
        laser.SetPosition(0, muzzletransform.position);
        laser.SetPosition(1, muzzletransform.position + hitpoint);

        yield return null;

        laser.enabled = false;
    }

    void InstantiateWall(Transform muzzle)
    {
        GameObject wall = (GameObject)Instantiate(WallPrefab, new Vector3(muzzle.position.x + 5, muzzle.position.y , muzzle.position.z ), Quaternion.identity);
    }
}
