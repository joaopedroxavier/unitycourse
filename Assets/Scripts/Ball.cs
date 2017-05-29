using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Bar bar;
    private bool has_started = false;
    private Vector3 ball_to_bar;
    public Rigidbody2D rigi2d;
	// Use this for initialization
	void Start ()
    {
        ball_to_bar = this.transform.position - bar.transform.position;
	}

    // Update is called once per frame
    void Update()
    {
        if (!has_started)
        {
            this.transform.position = bar.transform.position + ball_to_bar;
            if (Input.GetMouseButtonDown(0))
            {
                has_started = true;
                float side = Random.Range(-1f, 1f);
                if (side < 0) this.rigi2d.velocity = new Vector2(-1f * Random.Range(2f, 5f), 10f);
                else this.rigi2d.velocity = new Vector2(1f * Random.Range(2f, 5f), 10f);
            }
        }
    }
}
