using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLock : MonoBehaviour
{
    private bool locked;
    private Image lockImage;
    private Color lockedColor;


    //YEA want event because otherwise will have to call updates all the time

    //must be on all lockable buttons.


        //when locked, not allowed to be pressed. 
        // is a darker color, and has lock image present on front of it.
        //will need to use their names because to find on 

    // perhaps use events to listen for different things to lock/unlock?
    //this might be too annoying.. as too many and they are all paired.
    //perhaps puzzles reference specific button to UNlock after it? after 'Yes' message, will unlock specific button.



}
