using UnityEngine;
using System.Collections;

public class changeAnimBycol : MonoBehaviour {

    GameObject obj;
    Animator anim;


    // Use this for initialization
    void Start()
    {

        obj = GameObject.Find("arrowMark");
        anim = GetComponent<Animator>();
        anim.SetBool("isMoving", false);

    }

    // Update is called once per frame
    void Update()
    {

        matColor mc = obj.GetComponent<matColor>();

        if (mc.colorNow=="green")
        {
            anim.SetBool("isMoving", true);
        }
        else
        {
            anim.SetBool("isMoving", false);
        }

    }
}
