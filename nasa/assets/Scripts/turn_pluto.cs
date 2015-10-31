using UnityEngine;
using System.Collections;

public class turn_pluto : MonoBehaviour {

	// Use this for initialization

	public GameObject sun;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.RotateAround (sun.transform.position, Vector3.down, 15 * Time.deltaTime);
	
	}
}
