using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlip : MonoBehaviour
{
    SpriteRenderer sprite;
    float xValue;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        xValue = transform.position.x;

        if(xValue < 0f) { sprite.flipX = true; }
        else { sprite.flipX = false; }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
