using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
	public float RotationSpeed3D = 1.0f;

	// Use this for initialization
	void Start ()
	{
	
	}
	

	void UpdateDebugInfo()
	{
		bool logging = true;
		
		if (logging)
			Debug.Log("Rotation speed: " + RotationSpeed3D + " DeltaTime: " + Time.timeDelta);
	}
	
	// Update is called once per frame
	void Update ()
	{	
		this.transform.rotation =  Quaternion.AngleAxis(RotationSpeed3D * Time.time, Vector3.one) / (Time.timeDelta *13);
	}
}
