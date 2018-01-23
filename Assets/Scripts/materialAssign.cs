using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialAssign : MonoBehaviour {

	public Material[] randomMaterials = new Material[3];
	private Material random;
	public GameObject[] walls;

	// Use this for initialization
	void Start () {
		random = randomMaterials [Random.Range (0, randomMaterials.Length)];


		for (int i = 0; i < walls.Length; i++) {
			walls [i].GetComponent<Renderer> ().material = random;
		}
		//gameObject.GetComponent<Renderer> ().material = randomMaterials [Random.Range (0, randomMaterials.Length)];

		//gameObject.GetComponentInChildren<Renderer> ().material = randomMaterials [Random.Range (0, randomMaterials.Length)];



	}
	

}
