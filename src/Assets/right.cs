using UnityEngine;
using System.Collections;

public class right : MonoBehaviour
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

    public void MoveRight ()
    {
        platformObject.transform.Rotate(0, -20, 0);
    }
}
