using UnityEngine;
using System.Collections;

public class AutoWalkMain : MonoBehaviour {

    CardboardHead head = null;
    public float speed;
    GameObject obj;

    // Use this for initialization
    void Start () {
        head = Camera.main.GetComponent<StereoController>().Head;
        obj = GameObject.Find("arrowMark");

    }
	
	// Update is called once per frame
	void Update () {
        matColor mc = obj.GetComponent<matColor>();
        if (mc.colorNow=="green")
        {
            walk();
        }        

	
	}

    public void walk()
    {
        Vector3 direction = new Vector3(head.transform.forward.x, 0, head.transform.forward.z).normalized * speed * Time.deltaTime;
        Quaternion rotation = Quaternion.Euler(new Vector3(0, -transform.rotation.eulerAngles.y, 0));
        transform.Translate(rotation * direction);
    }

}
