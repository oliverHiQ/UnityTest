using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("I got started");
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (new Vector3 (0,1,0));

	}
}
