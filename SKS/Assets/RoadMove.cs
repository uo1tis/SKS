using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMove : MonoBehaviour {

    public GameObject road;
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.right * Time.deltaTime*4);
        if (this.transform.position.x > 19)
        {
            transform.localPosition = new Vector3(transform.position.x-39, transform.position.y, transform.position.z);
        }

	}
}
