using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour {

    public float maxHeight;
    public float minHeight;

	void Update () {
        float hoverHeight = (maxHeight + minHeight) / 2.0f;
        float hoverRange = maxHeight - minHeight;
        float hoverSpeed = 10.0f;

        this.transform.position = Vector3.up * (hoverHeight + Mathf.Cos(Time.time * hoverSpeed) * hoverRange);
    }
}
