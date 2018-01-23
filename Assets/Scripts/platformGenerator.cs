using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformGenerator : MonoBehaviour {


	public float distanceBetween;
	private float platformWidth;
	public static int maxPlatforms = 5;
	private int platforms = 0;
	public GameObject[] thePlatform = new GameObject[maxPlatforms];
	Vector3 newVector;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (platforms <= maxPlatforms) {

			newVector = transform.position;

			Instantiate (thePlatform[Random.Range(0,4)], newVector, transform.rotation);

			newVector = new Vector3(transform.position.x,transform.position.y, transform.position.z + 19.815f);

			transform.position = newVector;

			++platforms;

	}
}
}
