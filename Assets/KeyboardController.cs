﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : Controller
{
    public override float horizontalAxis()
    {
        if(Input.GetKey(KeyCode.Q))
            return -1.0f;
        else if(Input.GetKey(KeyCode.D))
            return 1.0f;
        else
            return 0.0f;
    }

    public override float verticalAxis()
    {
        if(Input.GetKey(KeyCode.Z))
            return 1.0f;
        else if(Input.GetKey(KeyCode.S))
            return -1.0f;
        else
            return 0.0f;
    }

    public override bool actionButton() { return Input.GetKeyDown(KeyCode.Space); }
}
