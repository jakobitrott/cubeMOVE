using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformGenerator : MonoBehaviour {


	private float platformWidth;
	private int platforms = 0;
	private int maxPlatforms = 5;
	//public GameObject[] thePlatform = new GameObject[maxPlatforms];
	 List<GameObject> thePlatform;
	public GameObject platform;
	public GameObject player;
	Vector3 newVector;

	// Use this for initialization
	void Start () {
		//player = new GameObject ();
		thePlatform = new List<GameObject>();
		for (int i = 0; i < 5; i++) {
			Debug.Log ("bokb");
			thePlatform.Add (Instantiate (platform as GameObject, newVector,transform.rotation));
			updateGeneratorPosition ();
		}
			
			
		}

	void Update(){
		if (player.transform.position.z - thePlatform [0].transform.position.z > 20) {
			GameObject objectdestroy = thePlatform [0];
			thePlatform.Remove (objectdestroy);
			Destroy (objectdestroy);
			--platforms;

			while (platforms != maxPlatforms) {

				thePlatform.Add (Instantiate (platform as GameObject, newVector,transform.rotation));
				updateGeneratorPosition ();
			
			}
		}


	}

	void updateGeneratorPosition(){


		newVector = transform.position;
		newVector = new Vector3(transform.position.x,transform.position.y, transform.position.z + 19.815f);
		transform.position = newVector;
		++platforms;

	}
	}
	
	// Update is called once per frame


