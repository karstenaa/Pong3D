using UnityEngine;
using System.Collections;

public class CarX : Car {

    protected override float moveX()
    {
        return Input.GetAxis("Horizontal");
    }
    protected override bool isFireButton()
    {
        return Input.GetKey(KeyCode.Space);
    }
}
