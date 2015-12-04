using UnityEngine;
using System.Collections;

public class CarZ : Car {

    protected override float moveZ()
    {
        return Input.GetAxis("Vertical");
    }
    protected override bool isFireButton()
    {
        return Input.GetKey(KeyCode.RightControl);
    }
}
