using UnityEngine;
using System.Collections;

public class left : MonoBehaviour {

    public GameObject platformObject;
	public int speed = 1;
	private Vector3 targetAngle;
	private bool moveMe = false;
	private Vector3 currentAngle;
	public Rigidbody rb;
	public MeshRenderer rend;
	private float slowCheck;
	private float addMe = 315f;
	private float newAngle;

	// Use this for initialization
	void Start () {
		currentAngle = platformObject.transform.eulerAngles;
		rb = platformObject.GetComponent<Rigidbody>();
		rend = platformObject.GetComponent<MeshRenderer>();

	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (moveMe);
		//Debug.Log ("current: " + currentAngle.y + " ¦¦ target: " + targetAngle.y);
		//Debug.Log ("rotation velocity: " + rb.angularVelocity.magnitude);
		//if (moveMe) {
			currentAngle = new Vector3 (
				Mathf.LerpAngle (currentAngle.x, targetAngle.x, Time.deltaTime),
				Mathf.LerpAngle (currentAngle.y, targetAngle.y, Time.deltaTime),
				Mathf.LerpAngle (currentAngle.z, targetAngle.z, Time.deltaTime));

			platformObject.transform.eulerAngles = currentAngle;
			//if (slowCheck > rb.angularVelocity.magnitude && rb.angularVelocity.magnitude < 0.1) {
			//	Debug.Log ("equal");
			//	moveMe = true;

			// }
		//}
		slowCheck = rb.angularVelocity.magnitude;
	}

    public void MoveLeft ()
    {
        //platformObject.transform.Rotate(0, 20, 0);

		//if (moveMe == false) {
			currentAngle = platformObject.transform.eulerAngles;
			targetAngle = new Vector3 (currentAngle.x, currentAngle.y + 45f, currentAngle.z); 
			//if (targetAngle.y > 360) {
			//	targetAngle.y = targetAngle.y -360; 
			//}
			//moveMe = true;
		//}
		// platformObject.transform.rotation = Quaternion.Lerp (transform.rotation, new Quaternion.Euler(transform.rotation.x, 345f, transform.rotation.z), Time.deltaTime * speed);

    }
	public void MoveRight ()
	{
		//platformObject.transform.Rotate(0, 20, 0);

		//if (moveMe == false) {
			currentAngle = platformObject.transform.eulerAngles;
		Debug.Log("current: " + currentAngle.y);
	
		newAngle = currentAngle.y - 45f;
		Debug.Log ("new: " + newAngle);
		//if (newAngle > 360) {
		//	newAngle = newAngle - 360;
		//}
		//Debug.Log (newAngle);
			targetAngle = new Vector3 (currentAngle.x, newAngle, currentAngle.z); 
			//if (targetAngle.y < 0 ) {
			//	targetAngle.y = targetAngle.y * -1;
			//}
			//moveMe = true;
		//}
		// platformObject.transform.rotation = Quaternion.Lerp (transform.rotation, new Quaternion.Euler(transform.rotation.x, 345f, transform.rotation.z), Time.deltaTime * speed);

	}
}
