using UnityEngine;
using System.Collections;

public class turn_earth : MonoBehaviour {


	public float vitesse;
	public GameObject sun;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(0,vitesse,20*Time.deltaTime,0);
		transform.RotateAround (sun.transform.position, Vector3.down, 10.7218f * Time.deltaTime);	
	
	}
}
