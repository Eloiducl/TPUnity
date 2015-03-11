using UnityEngine;
using System.Collections;

public class marteau : MonoBehaviour {


	public Transform light;
	public Transform caractere;
	public Transform fond;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider col)
	{
		light.GetComponent<Light>().enabled = true;
		caractere.GetComponent<CharacterMotor>().movement.maxForwardSpeed = 0;
		fond.GetComponent<MeshCollider>().enabled = true;
		fond.GetComponent<MeshRenderer>().enabled = true;
	}
}
