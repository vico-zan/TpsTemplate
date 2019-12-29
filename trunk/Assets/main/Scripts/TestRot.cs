using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRot : MonoBehaviour {

    Quaternion q1, q2;

    // Start is called before the first frame update
    void Start() {
        q1 = Quaternion.AngleAxis(90, Vector3.up);
    }

    // Update is called once per frame
    void Update() {
        transform.rotation = Quaternion.Lerp(transform.rotation, q1, Time.deltaTime);
    }
}
