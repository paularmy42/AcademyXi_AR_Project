using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    public bool trueOrFalse = true;
    public float decimalNumber = 1.3f;
    public int speed = 1;
    public string someText = "This is some simple text";
    private float anotherFloat = 1.2f;

	// Use this for initialization
	void Start ()
    {
        Debug.Log("Captain's Log; Star Date 3043.");
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.eulerAngles += new Vector3(speed, 0, 0);
    }
}
