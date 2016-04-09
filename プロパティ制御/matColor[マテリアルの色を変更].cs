using UnityEngine;
using System.Collections;

public class matColor : MonoBehaviour {

    public GameObject myObj;
    public string colorNow;


    // Use this for initialization
    void Start () {
        myObj = this.gameObject;
        colorNow = "red";
        myObj.GetComponent<Renderer>().material.color = Color.red;


    }
	
	// Update is called once per frame
	void Update () {

        }

    public void changeColor()
    {
        myObj = this.gameObject;

        if(myObj.GetComponent<Renderer>().material.color == Color.green)
        {
            colorNow = "red";
            myObj.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            colorNow = "green";
            myObj.GetComponent<Renderer>().material.color = Color.green;
        }

    }

}
