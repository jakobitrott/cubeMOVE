using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCube : MonoBehaviour {

	public GameObject remains; 


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (gameObject.GetComponent<Transform> ().position.y < 0) {
			Instantiate (remains, transform.position, transform.rotation);
			Destroy (gameObject);
		}
	

	}


	void OnCollisionEnter(Collision col){

		if(col.gameObject.name == "walls") 
			{
			Debug.Log("wall");
			Instantiate (remains, transform.position, transform.rotation);
			Destroy (gameObject);

		}
	}

	}
		


