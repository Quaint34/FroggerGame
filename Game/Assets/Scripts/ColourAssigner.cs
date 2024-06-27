using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourAssigner : MonoBehaviour
{
    [SerializeField] public List<Color> Colours = new List<Color>();
    private SpriteRenderer sprite;
    


    public void Start()
    {
        ChangeColour();
    }

    private void ChangeColour()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = Colours[Random.Range(0, Colours.Count)];
    }
}
