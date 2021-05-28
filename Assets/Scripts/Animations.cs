using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite[] spriteArray;
    public int currentSprite;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        ChangeSprite();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ChangeSprite()
    {
        for (int i = 0; i <= spriteArray.Length; i++)
        {
            spriteRenderer.sprite = spriteArray[i];
            currentSprite++;
            if (currentSprite >= spriteArray.Length)
            {
                currentSprite = 0;
                i = 0;
            }

        }
        
    }
}
