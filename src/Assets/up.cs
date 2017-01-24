using UnityEngine;
using System.Collections;

public class up : MonoBehaviour
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

    public void MoveUp()
    {
		if (platformObject.transform.position.y < 4f) {
			platformObject.transform.position += new Vector3 (0f, 1f, 0f);
		}
		if (platformObject.transform.position.y > 4f && pressureVessel.transform.position.y < 3f) {
			pressureVessel.transform.position += new Vector3 (0f, 1f, 0f);
		}

    }
}
