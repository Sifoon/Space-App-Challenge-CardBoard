using UnityEngine;
using System.Collections;

public class turn_saturn : MonoBehaviour {

	// Use this for initialization
	public GameObject sun;
		public float vitesse;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	transform.Rotate(0,vitesse,20*Time.deltaTime,0);
		transform.RotateAround (sun.transform.position, Vector3.down, 3.470f * Time.deltaTime);
	}
}
