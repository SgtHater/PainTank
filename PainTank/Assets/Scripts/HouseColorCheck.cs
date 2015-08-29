using UnityEngine;
using System.Collections;

public class HouseColorCheck : MonoBehaviour
{
    Renderer renderer;
    GameObject otherGameobject;
    void Start()
    {
        this.renderer = GetComponent<Renderer>();
    }


    public void OnCollisionEnter(Collision other)
    {
        this.otherGameobject = other.gameObject;
        this.renderer.material.color = otherGameobject.GetComponent<Renderer>().GetComponent<Renderer>().material.color;

    }
} 
