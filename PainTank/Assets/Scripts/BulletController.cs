using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour
{

    public void OnCollisionEnter(Collision other)
    {
        Invoke("Destroy", 3f);
    }

    void Destroy()
    {
        this.transform.position = Vector3.zero;
        this.transform.rotation = Quaternion.identity;
        this.gameObject.SetActive(false);
    }
}
