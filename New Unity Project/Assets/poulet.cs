using UnityEngine;
using System.Collections;

public class poulet : MonoBehaviour {

	public Transform truc;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Mathf.Abs (Input.GetAxis ("Horizontal")) > 0.2) {
			transform.Rotate(0,Input.GetAxis("Horizontal")*5f,0);
		}*/
		if ((Mathf.Abs(Input.GetAxis("Vertical")) > 0.1) || (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1))
			truc.GetComponent<Animator>().enabled = true;
		else
			truc.GetComponent<Animator>().enabled = false;

		/*
		if (Input.GetButtonDown ("Horizontal") || Input.GetButtonDown ("Vertical")) {
			truc.GetComponent<Animator>().enabled = true;
			truc.GetComponent<Animator>().SetBool("bouge",true);
		}
		else truc.GetComponent<Animator>().enabled = false;
*/
	}
}