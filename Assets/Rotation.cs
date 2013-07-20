using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
		transform.Rotate( new Vector3( 0.5f, 1.0f, 0.0f ) );
	}
}
