using UnityEngine;
using System.Collections;

public class LThruster : MonoBehaviour 
{
    public float Force = 5.0f;
    public Rigidbody LeftThruster;
    private Vector3 Direction = new Vector3(0, 10, 1);

	// Use this for initialization
	void Start () 
    {
        LeftThruster = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            LeftThruster.AddForce(Direction * Force, ForceMode.Impulse);
	}
}
