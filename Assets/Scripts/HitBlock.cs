using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBlock : MonoBehaviour {

    // Use this for initialization
    private int timesHit;
    public int maxHits;
    private LevelManager levelManager;
    public Sprite[] hitSprites;

	void Start () {
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
	}

    private void OnCollisionEnter2D(Collision2D collision) {
        timesHit++;
        if (timesHit >= maxHits)
        {
            Destroy(gameObject);
            WinDetector.bricks_counter++;
            if (WinDetector.bricks_counter >= WinDetector.level_counter)
            {
                levelManager.LevelSelect("Win");
            }
        }   else
        {
            LoadSprites();
        }
    }

    private void LoadSprites(){
        int spriteIndex = timesHit - 1;
        this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
    }
    
    // Update is called once per frame
    void Update () {
		
	}
}
