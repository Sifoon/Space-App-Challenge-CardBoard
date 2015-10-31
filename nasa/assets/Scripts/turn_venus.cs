using UnityEngine;
using System.Collections;

public class turn_venus : MonoBehaviour {

	// Use this for initialization
	public float vitesse;
	public GameObject sun;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	transform.Rotate(0,vitesse,20*Time.deltaTime,0);
		transform.RotateAround (sun.transform.position, Vector3.down,-12.6074f * Time.deltaTime);
	
	}
}
