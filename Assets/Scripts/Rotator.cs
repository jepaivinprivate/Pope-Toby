using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		this.transform.rotation *=  Quaternion.AngleAxis(1, Vector3.one);
		}
}
