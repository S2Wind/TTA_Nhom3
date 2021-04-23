using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movevement : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField]
    float spinspeed = 10f;

    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard.wKey.IsPressed())
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (keyboard.sKey.IsPressed())
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        if (keyboard.aKey.IsPressed())
        {
            transform.Rotate(0, -spinspeed * Time.deltaTime, 0f);
        }
        if (keyboard.dKey.IsPressed())
        {
            transform.Rotate(0, spinspeed * Time.deltaTime, 0f);
        }
        if (keyboard.qKey.IsPressed())
        {
            transform.Rotate(-spinspeed * Time.deltaTime, 0f, 0f);
        }
        if (keyboard.eKey.IsPressed())
        {
            transform.Rotate(spinspeed * Time.deltaTime, 0f, 0f);
        }
    }
}
