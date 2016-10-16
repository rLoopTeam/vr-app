using UnityEngine;
using System.Collections;

public class down : MonoBehaviour
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

    public void MoveDown()
    {
        platformObject.transform.position += new Vector3(0f, -1f, 0f);
    }
}
