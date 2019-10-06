using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private SpriteRenderer spriteRender;
    public Sprite normLeaf;
    public Sprite darkLeaf;

    public KeyCode pressedKey;

    // Start is called before the first frame update
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(pressedKey))
        {
            spriteRender.sprite = darkLeaf;
        }

        if(Input.GetKeyUp(pressedKey))
        {
            spriteRender.sprite = normLeaf;
        }
    }
}
