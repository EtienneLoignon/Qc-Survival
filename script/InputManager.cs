﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{

    //-- Axes

    public static float MainHorizontal()
    {
        float r = 0.0f;
        r += Input.GetAxis("J_MainHorizontal");
        r += Input.GetAxis("K_MainHorizontal");
        return Mathf.Clamp(r, -1.0f, 1.0f);
    }

    public static float MainVertical()
    {
        float r = 0.0f;
        r += Input.GetAxis("J_MainVertical");
        r += Input.GetAxis("K_MainVertical");
        return Mathf.Clamp(r, -1.0f, 1.0f);
    }

    public static Vector3 MainJoystick()
    {
        return new Vector3(MainHorizontal(), 0, MainVertical());
    }

    // -- buttons

    public static bool AButton()
    {
        return Input.GetButtonDown("A_Button");
    }

    public static bool BButton()
    {
        return Input.GetButtonDown("B_Button");
    }

    public static bool XButton()
    {
        return Input.GetButtonDown("X_Button");
    }

    public static bool YButton()
    {
        return Input.GetButtonDown("Y_Button");
    }

    public static bool StartButton()
    {
        return Input.GetButtonDown("Start_Button");
    }

    public static bool BackButton()
    {
        return Input.GetButtonDown("Back_Button");
    }

    public static bool LeftBumper()
    {
        return Input.GetButtonDown("Left_Bumper");
    }

    public static bool RightBumper()
    {
        return Input.GetButtonDown("Right_Bumper");
    }



}
