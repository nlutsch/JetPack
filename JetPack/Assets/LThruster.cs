using UnityEngine;
using System.Collections;

public class LThruster : MonoBehaviour {

    public float Force = 10.0f;
    public Rigidbody LeftThruster;
    private Vector3 Direction = new Vector3(.2f, 1, 0);

	// Use this for initialization
	void Start () 
    {
        LeftThruster = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        LeftThruster.AddForce(Direction * Force, ForceMode.Impulse);
	}
}
