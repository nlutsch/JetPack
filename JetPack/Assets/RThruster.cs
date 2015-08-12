using UnityEngine;
using System.Collections;

public class RThruster : MonoBehaviour
{
    public float Force = 5.0f;
    public Rigidbody RightThruster;
    private Vector3 Direction = new Vector3(0, 10, 1);

    // Use this for initialization
    void Start ()
    {
        RightThruster = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            RightThruster.AddForce(Direction * Force, ForceMode.Impulse);
    }
}
