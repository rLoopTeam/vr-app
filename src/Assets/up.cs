using UnityEngine;
using System.Collections;

public class up : MonoBehaviour
{

    public GameObject platformObject;

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
        platformObject.transform.position += new Vector3(0f, 1f, 0f);
    }
}
