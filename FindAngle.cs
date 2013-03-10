using UnityEngine;
using System.Collections;
public class FindAngle : MonoBehaviour {
    public GameObject goPlayer;
 
    void Update() {
 		goPlayer = GameObject.FindGameObjectWithTag("Player");
    	Vector3 v3Pos;
    	float fAngle;
 		int speed = 20;
    	if ((Input.touchCount == 1) && (Input.GetTouch(0).phase == TouchPhase.Began)) {
         	// Project the mouse point into world space at
            //   at the distance of the player.
         	v3Pos = Input.mousePosition;
         	v3Pos.z = (goPlayer.transform.position.z - Camera.main.transform.position.z);
         	v3Pos = Camera.main.ScreenToWorldPoint(v3Pos);
         	v3Pos = v3Pos - goPlayer.transform.position;
         	fAngle = Mathf.Atan2 (v3Pos.y, v3Pos.x) * Mathf.Rad2Deg;
         	if (fAngle < 0.0f) fAngle += 360.0f;
         	Debug.Log ("1) "+fAngle);
			if (fAngle > 60 && fAngle < 120){
				transform.Translate(Vector3.up * Time.deltaTime);
			}
			else if (fAngle < 30 || fAngle > 330){
				transform.Translate(Vector3.right * Time.deltaTime);
			}
			else if (fAngle < 210 && fAngle > 150){
				transform.Translate(Vector3.left * Time.deltaTime);
			}
			else if (fAngle < 300 && fAngle > 240){
				transform.Translate(Vector3.down * Time.deltaTime);
			}
         }

		/*if(Input.GetAxis("Mouse Y") > 0 && Input.GetMouseButton(0)) {
 
        	transform.Translate(Vector3(0,speed,0) * Time.deltaTime);
 
		}
 
		else if(Input.GetAxis("Mouse X") < 0 && Input.GetMouseButton(0)) {
 
        	transform.Translate(Vector3(-speed,0,0) * Time.deltaTime);
 
		}
 
		else if(Input.GetAxis("Mouse Y") < 0 && Input.GetMouseButton(0)) {
 
        	transform.Translate(Vector3(0,-speed,0) * Time.deltaTime);
		}
 
		else if(Input.GetAxis("Mouse X") > 0 && Input.GetMouseButton(0)) {
 
        		transform.Translate(Vector3(speed,0,0) * Time.deltaTime);
 
		}*/
	}
}