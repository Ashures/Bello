using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;

    public Sprite upSprite;
    public Sprite downSprite;
    public Sprite leftSprite;
    public Sprite rightSprite;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = downSprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey))
        {
            spriteRenderer.sprite = upSprite;
        }

        if (Input.GetKey(downKey))
        {
            spriteRenderer.sprite = downSprite;
        }

        if (Input.GetKey(rightKey))
        {
            spriteRenderer.sprite = rightSprite;
        }

        if (Input.GetKey(leftKey))
        {
            spriteRenderer.sprite = leftSprite;
        }
    }

    
}
