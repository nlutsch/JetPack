using UnityEngine;
using System.Collections;

public class Flight : MonoBehaviour
{
    public float Speed = 100.0f;
    public float AirResistance = 3.0f;
    public float Rotation = 200.0f;

    Vector3 MoveDirection = Vector3.zero;
    public Rigidbody Controller;
    public GameObject Empty;

    // Use this for initialization
    void Start()
    {
        Controller = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        Controller.AddForce(new Vector3(0, 0, -1) * AirResistance, ForceMode.Impulse);
        //MoveDirection = new Vector3(MoveDirection.x, MoveDirection.y, 1);
        //MoveDirection *= Speed;
        //this.transform.Translate(MoveDirection * Time.deltaTime);
        //if (Empty.transform.rotation.z > 35) 
        //{
        //    Empty.transform.rotation = Quaternion.Euler(Empty.transform.rotation.x, Empty.transform.rotation.y, 35); 
        //}
    }
}
