using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //左矢印を離したとき
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);//左に 3 動かす
        }

        //右矢印を離したとき
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);//右に 3 動かす
        }
	}
}
