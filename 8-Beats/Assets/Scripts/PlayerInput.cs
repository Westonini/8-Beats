using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Renderer render;

    [SerializeField]
    private Color colorDefault = Color.white;

    [SerializeField]
    private Color colorChange = Color.white;

    public KeyCode pressedKey1;
    public KeyCode pressedKey2;
    

    void Start()
    {
        render = GetComponent<Renderer>();
        render.material.color = colorDefault;
    }

    void Update()
    {
        if (Input.GetKeyDown(pressedKey1) | Input.GetKeyDown(pressedKey2))
        {
            render.material.color = colorChange;
        }

        if (Input.GetKeyUp(pressedKey1) | Input.GetKeyUp(pressedKey2))
        {
            render.material.color = colorDefault;
        }
    }
}
