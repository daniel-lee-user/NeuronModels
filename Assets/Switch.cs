using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

    public static int select = 0;
	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Q))
        {
            if(select == 1)
            {
                select--;
            } else
            {
                select++;
            }
        }
	}
}
