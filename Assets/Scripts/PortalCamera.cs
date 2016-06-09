using UnityEngine;
using System.Collections;

public class PortalCamera : MonoBehaviour {

	public Transform PlayerCamera;
	public Transform PortalIn;
	public Transform PortalOut;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 portalViewVector = PortalIn.position - PlayerCamera.position;
		float length = portalViewVector.magnitude;

		//this accounts for the rotation of the outgoing portal screen, e.g. "forward" is in direction of the portal
		Quaternion rotationFix = PortalOut.parent.rotation;
		portalViewVector = rotationFix * portalViewVector;
		Vector3 newPosition = PortalOut.position + portalViewVector;

		transform.position = newPosition;
		transform.LookAt(newPosition);
	}
}
