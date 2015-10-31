using UnityEngine;
using System.Collections;

public class turn_mars : MonoBehaviour {

	public GameObject earth;
	public float vitesse;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	transform.Rotate(0,vitesse,20*Time.deltaTime,0);
		transform.RotateAround (earth.transform.position, Vector3.down, 8.6677f * Time.deltaTime);
	}
}
