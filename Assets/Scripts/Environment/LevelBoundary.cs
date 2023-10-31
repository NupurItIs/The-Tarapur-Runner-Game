using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{

    // when a variable is 
    //static .. it doesnt appear in the inspect pannel ..ie rhs of unity 
    //public .. it will appear in rhs inspect panel of unity 
    public static float leftSide = -3.5f;
    public static float rightSide = 3.5f;
    public  float internalLeft;
    public  float internalRight;
        
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;    }
}
