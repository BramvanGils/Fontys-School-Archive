using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBehaviourScript : MonoBehaviour {
	int XScale = 2;
	int YScale = 2;
	int ZScale = 2;

	// Use this for initialization
	void Start () {
		GetComponent<Transform>().localScale = new Vector3 (XScale, YScale, ZScale);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R))
		{
			GetComponent<Renderer>().material.color = Color.red;
		}
		if (Input.GetKeyDown(KeyCode.G))
		{
			GetComponent<Renderer>().material.color = Color.green;
		}
		if (Input.GetKeyDown(KeyCode.B))
		{
			GetComponent<Renderer>().material.color = Color.blue;
		}
	}
}
