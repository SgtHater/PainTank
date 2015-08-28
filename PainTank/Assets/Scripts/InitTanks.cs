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
        jack.transform.position = new Vector3(-23, 0.75f, 32);
        jack.transform.rotation = Quaternion.Euler(0, 150, 0);
        jack.GetComponent<TankController>().FireController = fireController;
        jack.gameObject.tag = "JackEagle";
        jack.gameObject.name = "JackEagle";

        //TankVader Spawner
        vader.transform.position = new Vector3(32, 0.75f, 30);
        vader.transform.rotation = Quaternion.Euler(0, 200, 0);
        vader.GetComponent<TankController>().FireController = fireController;
        vader.gameObject.tag = "TankVader";
        vader.gameObject.name = "TankVader";

        //HeisenTank Spawner
        heisen.transform.position = new Vector3(-31, 0.75f, -30);
        heisen.transform.rotation = Quaternion.Euler(0, 50, 0);
        heisen.GetComponent<TankController>().FireController = fireController;
        heisen.gameObject.tag = "HeisenTank";
        heisen.gameObject.name = "HeisenTank";

        //JohnMcTank Spawner
        james.transform.position = new Vector3(32, 0.75f, -32);
        james.transform.rotation = Quaternion.Euler(0, -30, 0);
        james.GetComponent<TankController>().FireController = fireController;
        james.gameObject.tag = "JamesTank";
        james.gameObject.name = "JamesTank";
    }
}
