using UnityEngine;
using System.Collections;

public class TankController : MonoBehaviour
{
    [SerializeField]
    GameObject tower;
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
    }

    void BodyMovement()
    {
        if (Input.GetAxis(gameObject.name + "_Vertical") != 0)
        {
            MovementSpeed = Input.GetAxis(gameObject.name + "_Vertical");
            this.transform.Translate(Vector3.forward * MovementSpeed / 2);
        }
        if (Input.GetAxis(gameObject.name + "_Horizontal") != 0)
        {
            Rotation = Input.GetAxis(gameObject.name + "_Horizontal");
            this.transform.Rotate(0, Rotation * 2, 0);
        }
    }
    void TowerRotation()
    {
        Vector3 direction = Vector3.one;
        direction.x *= Input.GetAxis(tower.name +"_Horizontal");
        direction.y *= 0;
        direction.z *= Input.GetAxis(tower.name + "_Vertical");
        if (direction.sqrMagnitude > 0)
        {
            tower.transform.rotation = Quaternion.Lerp(this.tower.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime);
        }
    }
}