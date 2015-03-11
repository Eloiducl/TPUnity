using UnityEngine;
using System.Collections;

public class pouet : MonoBehaviour {
	
	public Transform caillou;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire2"))
		{
			Debug.Log("coucou");
			Transform proj = GameObject.Instantiate(caillou, transform.position + (transform.forward * 2.0f),Quaternion.identity) as Transform;
			proj.rigidbody.AddForce(transform.forward * 100f,ForceMode.Impulse);
		}
	}
}
