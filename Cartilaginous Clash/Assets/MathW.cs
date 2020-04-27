using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MathW
{
    #region Sign
    public static float Sign(float input)
    {
        if (input == 0)
            return 0;
        else if (input > 0)
            return 1f;
        else
            return -1f;
    }

    public static int Sign(int input)
    {
        if (input == 0)
            return 0;
        else if (input > 0)
            return 1;
        else
            return -1;
    }
    #endregion

    public static bool IsBetween(float f, float min, float max)
    {
        if (f > min && f < max)
            return true;
        else
            return false;
    }
    public static bool IsBetween(int f, float min, float max)
    {
        if (f > min && f < max)
            return true;
        else
            return false;
    }
    public static bool IsBetween(float f, int min, float max)
    {
        if (f > min && f < max)
            return true;
        else
            return false;
    }
    public static bool IsBetween(float f, float min, int max)
    {
        if (f > min && f < max)
            return true;
        else
            return false;
    }
}
