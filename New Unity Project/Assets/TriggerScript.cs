using UnityEngine;
using System.Collections;

public class TriggerScript : MonoBehaviour {

	public Transform light;
	public Transform caractere;
	public Transform fond;
	// Use this for initialization
	void Start () {
		//renderer.enabled (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		light.GetComponent<Light>().enabled = false;
		caractere.GetComponent<CharacterMotor>().movement.maxForwardSpeed = 6;
		fond.GetComponent<MeshCollider>().enabled = false;
		fond.GetComponent<MeshRenderer>().enabled = false;
	}
}