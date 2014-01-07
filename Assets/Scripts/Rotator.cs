using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
	public float RotationSpeed = 1.0f;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{	
		//this.transform.rotation *=  Quaternion.AngleAxis(RotationSpeed, Vector3.one);
		this.transform.position = new Vector3(this.transform.position.x + Time.deltaTime/1000.0f, this.transform.position.y, this.transform.position.z);
	}
}
