using UnityEngine;
using System.Collections;

public class InitTanks : MonoBehaviour
{
    public FireController fireController;
    public GameObject TankVader;
    public GameObject JackEagle;
    public GameObject HeisenTank;
    public GameObject JohnMcTank;


	void Start ()
    {
        GameObject jackEagle = (GameObject)Instantiate(JackEagle);
        GameObject tankVader = (GameObject)Instantiate(TankVader);
        GameObject heisenTank  = (GameObject)Instantiate(HeisenTank);
        GameObject johnMcTank = (GameObject)Instantiate(JohnMcTank);
        SpawnTanks(jackEagle, tankVader, heisenTank, johnMcTank);

    }
    void SpawnTanks(GameObject jack, GameObject vader, GameObject heisen, GameObject john)
    {
        //JackEagle Spawner
        jack.transform.position = new Vector3(-23, 0.75f, 32);
        jack.transform.rotation = Quaternion.Euler(0, 150, 0);
        jack.GetComponent<TankController>().FireController = fireController;
        jack.gameObject.name = "JackEagle";

        //TankVader Spawner
        vader.transform.position = new Vector3(32, 0.75f, 30);
        vader.transform.rotation = Quaternion.Euler(0, 200, 0);
        vader.GetComponent<TankController>().FireController = fireController;
        vader.gameObject.name = "TankVader";

        //HeisenTank Spawner
        heisen.transform.position = new Vector3(-31, 0.75f, -30);
        heisen.transform.rotation = Quaternion.Euler(0, 50, 0);
        heisen.GetComponent<TankController>().FireController = fireController;
        heisen.gameObject.name = "HeisenTank";

        //JohnMcTank Spawner
        john.transform.position = new Vector3(32, 0.75f, -32);
        john.transform.rotation = Quaternion.Euler(0, -30, 0);
        john.GetComponent<TankController>().FireController = fireController;
        john.gameObject.name = "JohnMcTank";
    }
}
