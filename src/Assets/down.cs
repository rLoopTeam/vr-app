using UnityEngine;
using System.Collections;

public class down : MonoBehaviour
{

    public GameObject platformObject;
	public GameObject pressureVessel;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveDown()
    {
		if (platformObject.transform.position.y >= 2f) {
			platformObject.transform.position -= new Vector3 (0f, 1f, 0f);
		}
		if (platformObject.transform.position.y >= 1f && pressureVessel.transform.position.y >= 1f) {
			pressureVessel.transform.position -= new Vector3 (0f, 1f, 0f);
		}
    }
}
