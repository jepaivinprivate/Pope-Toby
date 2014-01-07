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
		this.transform.rotation *=  Quaternion.AngleAxis(RotationSpeed, Vector3.one);
	}
}
