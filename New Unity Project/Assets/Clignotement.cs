using UnityEngine;
using System.Collections;

public class Clignotement : MonoBehaviour {
	public GameObject obj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((int)Time.fixedTime % 3 == 0)
			obj.SetActive(true);
		else
			obj.SetActive(false);
	}
}
