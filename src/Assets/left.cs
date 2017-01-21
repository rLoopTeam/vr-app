using UnityEngine;
using System.Collections;

public class left : MonoBehaviour {

    public GameObject platformObject;
	public int speed = 1;
	private Vector3 targetAngle;
	private bool moveMe = false;
	private Vector3 currentAngle;

	// Use this for initialization
	void Start () {
		currentAngle = platformObject.transform.eulerAngles;

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (moveMe);
		Debug.Log ("current: " + currentAngle.y + " ¦¦ target: " + targetAngle.y);
		if (moveMe) {
			currentAngle = new Vector3 (
				Mathf.LerpAngle (currentAngle.x, targetAngle.x, Time.deltaTime),
				Mathf.LerpAngle (currentAngle.y, targetAngle.y, Time.deltaTime),
				Mathf.LerpAngle (currentAngle.z, targetAngle.z, Time.deltaTime));

			platformObject.transform.eulerAngles = currentAngle;
			if (currentAngle.y+1 > targetAngle.y) {
				Debug.Log ("equal");
				moveMe = false;

			}
		}
	}

    public void MoveLeft ()
    {
        //platformObject.transform.Rotate(0, 20, 0);

		if (moveMe == false) {
			currentAngle = platformObject.transform.eulerAngles;
			targetAngle = new Vector3 (currentAngle.x, currentAngle.y + 45f, currentAngle.z); 
			moveMe = true;
		}
		// platformObject.transform.rotation = Quaternion.Lerp (transform.rotation, new Quaternion.Euler(transform.rotation.x, 345f, transform.rotation.z), Time.deltaTime * speed);

    }
	public void MoveRight ()
	{
		//platformObject.transform.Rotate(0, 20, 0);

		if (moveMe == false) {
			currentAngle = platformObject.transform.eulerAngles;
			targetAngle = new Vector3 (currentAngle.x, currentAngle.y + 315f, currentAngle.z); 
			moveMe = true;
		}
		// platformObject.transform.rotation = Quaternion.Lerp (transform.rotation, new Quaternion.Euler(transform.rotation.x, 345f, transform.rotation.z), Time.deltaTime * speed);

	}
}
