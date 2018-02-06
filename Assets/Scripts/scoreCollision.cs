using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class scoreCollision : MonoBehaviour {
	public TextMeshProUGUI text;
	private int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("jesus");
		text.text = score.ToString ();	
		++score;
	}
	}
