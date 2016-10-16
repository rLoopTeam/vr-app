using UnityEngine;
using System.Collections;

public class left : MonoBehaviour {

    public GameObject platformObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void MoveLeft ()
    {
        platformObject.transform.Rotate(0, 20, 0);
    }
}
