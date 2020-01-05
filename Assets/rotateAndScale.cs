using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAndScale : MonoBehaviour {
    // Use this for initialization
    void Start () {
        Switch.select = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Switch.select == 0)
        {
            if (Input.GetKey(KeyCode.B))
            {
                transform.localScale += new Vector3(0.001f, 0.001f, 0.001f);
            }
            else if (Input.GetKey(KeyCode.N))
            {
                transform.localScale -= new Vector3(0.001f, 0.001f, 0.001f);
            }
            if (Input.GetKey(KeyCode.L))
            {
                //transform.Rotate(Vector3.up, -5 * Time.deltaTime);
                transform.Rotate(100 * Time.deltaTime, 1 * Time.deltaTime, 1 * Time.deltaTime);

            }
            else if (Input.GetKey(KeyCode.K))
            {
                transform.Rotate(-100 * Time.deltaTime, 1 * Time.deltaTime, 1 * Time.deltaTime);
                //transform.Rotate(Vector3.up, 5 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.Y))
            {
                //transform.Rotate(Vector3.up, -5 * Time.deltaTime);
                transform.Rotate(1 * Time.deltaTime, 100 * Time.deltaTime, 1 * Time.deltaTime);

            }
            else if (Input.GetKey(KeyCode.U))
            {
                transform.Rotate(1 * Time.deltaTime, -100 * Time.deltaTime, 1 * Time.deltaTime);
                //transform.Rotate(Vector3.up, 5 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.H))
            {
                //transform.Rotate(Vector3.up, -5 * Time.deltaTime);
                transform.Rotate(1 * Time.deltaTime, 1 * Time.deltaTime, 100 * Time.deltaTime);

            }
            else if (Input.GetKey(KeyCode.J))
            {
                transform.Rotate(1 * Time.deltaTime, 1 * Time.deltaTime, -100 * Time.deltaTime);
                //transform.Rotate(Vector3.up, 5 * Time.deltaTime);
            }
        }
        Debug.Log(Switch.select + " og");
    }
}
