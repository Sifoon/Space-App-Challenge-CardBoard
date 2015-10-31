using UnityEngine;
using System.Collections;

public class turn_hst : MonoBehaviour {
	public GameObject earth;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (earth.transform.position, Vector3.down, 100 * Time.deltaTime);

	}
}
