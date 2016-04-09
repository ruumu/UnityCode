using UnityEngine;
using System.Collections;

public class rotateWithCamera : MonoBehaviour {

    public GameObject targetObject;
    public GameObject thisObject;

    // Use this for initialization
    void Start () {
        targetObject = GameObject.Find("Head");
        thisObject = GameObject.Find("BoxUnityChan");

    }
	
	// Update is called once per frame
	void Update ()
    {


        thisObject.transform.rotation = Quaternion.Euler(0, targetObject.transform.localEulerAngles.y, 0);

    }
}
