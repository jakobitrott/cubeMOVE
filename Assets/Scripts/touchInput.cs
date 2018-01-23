using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchInput : MonoBehaviour {

	private Vector3 fp;   //First touch position
	private Vector3 lp;   //Last touch position
	public float newPosition;

	void Start()
	{
		//dragDistance = Screen.height * 15 / 100; //dragDistance is 15% height of the screen
	}

	void Update()
	{


		if (Input.touchCount == 1) // user is touching the screen with a single touch
		{
			Touch touch = Input.GetTouch(0); // get the touch
			 if (touch.phase == TouchPhase.Stationary) { // update the last position based on where they moved
				lp = touch.position; // last position touched
			

					Vector3 touchTarget = new Vector3 (lp.x, 0.0f, 0.0f);
					float touchX = Camera.main.WorldToScreenPoint (touchTarget).x;
					Vector3 target = new Vector3 (touchX, 0f, 0f);
					//check if the drag is vertical or horizontal
					    //If the horizontal movement is greater than the vertical movement...
						if ((lp.x > Screen.width/2)) {  //If the movement was to the right)//Right swipe
							Debug.Log ("Right Swipe");

							transform.position = Vector3.MoveTowards (transform.position, -target, 3* Time.deltaTime);
						} else {   //Left swipe
							
							transform.position = Vector3.MoveTowards (transform.position, target, 3* Time.deltaTime);
									
							Debug.Log ("Left Swipe");
						}
					
				}
				

			}
		}
	}
