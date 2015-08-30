using UnityEngine;
using System.Collections;

public class TankController : MonoBehaviour
{
    [SerializeField]
    GameObject tower;
    public FireController FireController;
    public float Health = 100;
    public float MovementSpeed;
    public float RotationSpeedY;
    public float RotationSpeedX;
    public float Rotation;

    void Start()
    {
    }

    void Update()
    {
        BodyMovement();
        TowerRotation();
        CheckHealth();
    }

    void BodyMovement()
    {
        if (Input.GetAxis(gameObject.name + "_Tank_Vertical") != 0)
        {
            MovementSpeed = Input.GetAxis(gameObject.name + "_Tank_Vertical");
            this.transform.Translate(Vector3.forward * MovementSpeed / 2);
        }
        if (Input.GetAxis(gameObject.name + "_Tank_Horizontal") != 0)
        {
            Rotation = Input.GetAxis(gameObject.name + "_Tank_Horizontal");
            this.transform.Rotate(0, Rotation * 2, 0);
        }
    }
    void TowerRotation()
    {
        Vector3 direction = Vector3.one;
        direction.x *= Input.GetAxis(gameObject.name +"_Tower_Horizontal");
        direction.y *= 0;
        direction.z *= Input.GetAxis(gameObject.name + "_Tower_Vertical");
        if (direction.sqrMagnitude > 0)
        {
            tower.transform.rotation = Quaternion.Lerp(this.tower.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime);
        }
    }

    void CheckHealth()
    {
        if (Health == 0)
        {
            Destroy(this.gameObject);
        }
    }
}