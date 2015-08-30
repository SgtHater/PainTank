using UnityEngine;
using System.Collections;

public class InitTanks : MonoBehaviour
{
    public FireController fireController;
    public GameObject TankVader;
    public GameObject JackEagle;
    public GameObject HeisenTank;
    public GameObject JamesTank;


	void Start ()
    {
        GameObject jackEagle = (GameObject)Instantiate(JackEagle);
        GameObject tankVader = (GameObject)Instantiate(TankVader);
        GameObject heisenTank  = (GameObject)Instantiate(HeisenTank);
        GameObject jamesTank = (GameObject)Instantiate(JamesTank);
        SpawnTanks(jackEagle, tankVader, heisenTank, jamesTank);

    }
    void SpawnTanks(GameObject jack, GameObject vader, GameObject heisen, GameObject james)
    {
        //JackEagle Spawner

        jack.transform.position = new Vector3(32, 0.75f, -32); //32, 0.75f, -32
        jack.transform.rotation = Quaternion.Euler(0, -30, 0); //0, -30, 0
        jack.GetComponent<TankController>().FireController = fireController;
        jack.gameObject.tag = "JackEagle";
        jack.gameObject.name = "JackEagle";
        Transform[] jackChilds = jack.GetComponentsInChildren<Transform>();
        foreach (var item in jackChilds)
        {
            if (item.name == "_Body")
            {
                item.transform.tag = "JackEagleBody";
                break;
            }
            if (item.name == "Canon_Muzzle")
            {
                item.transform.tag = "JackMuzzle";
            }
        }

        //TankVader Spawner
        vader.transform.position = new Vector3(32, 0.75f, 30);
        vader.transform.rotation = Quaternion.Euler(0, 200, 0);
        vader.GetComponent<TankController>().FireController = fireController;
        vader.gameObject.tag = "TankVader";
        vader.gameObject.name = "TankVader";
        Transform[] vaderChilds = vader.GetComponentsInChildren<Transform>();
        foreach (var item in vaderChilds)
        {
            if (item.name == "_Body")
            {
                item.transform.tag = "TankVaderBody";
                break;
            }
            if (item.name == "Canon_Muzzle")
            {
                item.transform.tag = "VaderMuzzle";
            }
        }

        //HeisenTank Spawner
        heisen.transform.position = new Vector3(-31, 0.75f, -30);
        heisen.transform.rotation = Quaternion.Euler(0, 50, 0);
        heisen.GetComponent<TankController>().FireController = fireController;
        heisen.gameObject.tag = "HeisenTank";
        heisen.gameObject.name = "HeisenTank";
        Transform[] heisenChilds = heisen.GetComponentsInChildren<Transform>();
        foreach (var item in heisenChilds)
        {
            if (item.name == "_Body")
            {
                item.transform.tag = "HeisenTankBody";
                break;
            }
            if (item.name == "Canon_Muzzle")
            {
                item.transform.tag = "HeisenMuzzle";
            }
        }

        //JamesTank Spawner
        james.transform.position = new Vector3(-23, 0.75f, 32); //-23, 0.75f, 32
        james.transform.rotation = Quaternion.Euler(0, 150, 0); //0, 150, 0
        james.GetComponent<TankController>().FireController = fireController;
        james.gameObject.tag = "JamesTank";
        james.gameObject.name = "JamesTank";
        Transform[] jamesChild = james.GetComponentsInChildren<Transform>();
        foreach (var item in jamesChild)
        {
            if (item.name == "_Body")
            {
                item.transform.tag = "JamesTankBody";
                break;
            }
            if (item.name == "Canon_Muzzle")
            {
                item.transform.tag = "JamesMuzzle";
            }
        }
    }
}
