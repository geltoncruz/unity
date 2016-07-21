using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject follow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Chamada apos processamento físico.
	void LateUpdate () {
		Vector3 followPosition = follow.transform.position;
		Vector3 cameraPosition = new Vector3 (
			followPosition.x, followPosition.y, transform.position.z
		);
		transform.position = cameraPosition;
	}
}
