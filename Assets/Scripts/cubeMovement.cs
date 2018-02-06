using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cubeMovement : MonoBehaviour {

	// Use this for initialization
	public float z;
	Vector3 moveZ;
	public TextMeshProUGUI text;
	private int score = 1;

	public float changeSpeed = 3.0f;
	
	// Update is called once per frame
	void Update () {
		//changeSpeed = changeSpeed + Time.deltaTime;
		z = transform.position.z;
		z++;
		moveZ = new Vector3 (transform.position.x, transform.position.y, z);
			transform.position = Vector3.MoveTowards(transform.position,moveZ,changeSpeed* Time.deltaTime);

	}
	void OnTriggerEnter(Collider other) {
		text.text = score.ToString ();	
		++score;
	}
}
