using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour {

    // Update is called once per frame
    private float leftBorder;
    private float rightBorder;

    void Start() {
        leftBorder = Camera.main.ViewportToScreenPoint(new Vector3(0, 0, 10f)).x;
        rightBorder = Camera.main.ViewportToScreenPoint(new Vector3(1, 0, 10f)).x;
    }

	void Update () {
        float mousePos = Mathf.Clamp(Input.mousePosition.x, leftBorder, rightBorder);
        this.transform.position = new Vector3((Mathf.Clamp( Mathf.Clamp(Input.mousePosition.x, leftBorder, rightBorder) / (rightBorder - leftBorder) * 16f, 0.5f, 15.5f)), this.transform.position.y, 0f);
	}
}
