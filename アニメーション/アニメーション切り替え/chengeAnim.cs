using UnityEngine;
using System.Collections;

public class chengeAnim : MonoBehaviour {

    GameObject obj;
    Animator anim;
    

    // Use this for initialization
    void Start () {

        obj = GameObject.Find("unitychan");
        anim = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {

        FollowVer3 fv3 = GetComponent<FollowVer3>();

        if (fv3.isMove)
        {
            anim.SetBool("UnityChanWalk", true);
        }
        else
        {
            anim.SetBool("UnityChanWalk", false);
        }

    }
}
