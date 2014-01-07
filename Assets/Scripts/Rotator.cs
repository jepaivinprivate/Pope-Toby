using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
	public float RotationSpeed3D = 1.0f;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	
	// Update is called once per frame
	void Update ()
	{	
		this.transform.rotation = Vector3.zero;
		
	}
}
