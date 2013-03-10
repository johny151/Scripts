/*public class FindAngle : MonoBehaviour {
    public GameObject goPlayer;
 
    void Update() {
 
    	Vector3 v3Pos;
    	float fAngle;
 
    	if (Input.GetMouseButtonDown(0)) {
         	// Project the mouse point into world space at
            //   at the distance of the player.
         	v3Pos = Input.mousePosition;
         	v3Pos.z = (goPlayer.transform.position.z - Camera.main.transform.position.z);
         	v3Pos = Camera.main.ScreenToWorldPoint(v3Pos);
         	v3Pos = v3Pos - goPlayer.transform.position;
         	fAngle = Mathf.Atan2 (v3Pos.y, v3Pos.x) * Mathf.Rad2Deg;
         	if (fAngle < 0.0f) fAngle += 360.0f;
         	Debug.Log ("1) "+fAngle);
         }
		if(Input.GetAxis("Mouse Y") > 0 && Input.GetMouseButton(0)) {
 
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
 
		}
	}
}*/