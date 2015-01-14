using UnityEngine;
using System.Collections;

public class BattleMenuVer2 : MonoBehaviour
{
    //public class GUIButton
    //{
    //    public string controlName;
    //    public string text;
    //    public Rect rect;
    //}

    //GUIButton[] buttons;
    //int current;

    //void OnGUI()
    //{
    //    float axis = Input.GetAxis("Vertical");
    //    if (axis < 0)
    //    {
    //        current--;
    //    }
    //    else if (axis > 0)
    //    {
    //        current++;
    //    }

    //    current = Mathf.Clamp(current, 0, buttons.Length - 1);
    //    foreach (var button in buttons)
    //    {
    //        GUI.SetNextControlName(button.controlName);
    //        if (GUI.Button(button.rect, button.text))
    //        { 
                
    //        }
    //        GUI.FocusControl(buttons[current].controlName);
    //    }
    //}

    string[] buttonNames = { "Attack", "Ally", "Item", "Run" };
    bool[] buttons;
    int curSelection;

    void Start()
    {
        buttons = new bool[buttonNames.Length];
        curSelection = 0;
    }

    void OnGUI()
    {
        for (int i = 0; i < buttonNames.Length; i++)
        {
            GUI.SetNextControlName(buttonNames[i]);
            buttons[i] = GUI.Button(new Rect(10, 70 + (20 * i), 80, 20), buttonNames[i]);
        }

        // using buttons with keystroke
        if (Input.GetButton("Use"))
        {
            // when the use key is pressed, the selected button will activate
            buttons[curSelection] = true;
        }

        if (buttons[0])
        {
            // attack
            Debug.Log("attack");
        }
        else if (buttons[1])
        {
            // ally
            Debug.Log("ally");
        }
        else if (buttons[2])
        {
            // item
            Debug.Log("item");
        }
        else if (buttons[3])
        {
            // run
            Debug.Log("run");
        }

        // cycling throgh buttons
        if (Input.GetButton("Down"))
        {
            GUI.FocusControl(buttonNames[curSelection + 1]);
            //if (curSelection > buttonNames.Length)
            //    curSelection = 0;
        }
        else if (Input.GetButton("Up"))
        {
            GUI.FocusControl(buttonNames[curSelection - 1]);
            //if (curSelection < buttonNames.Length)
            //    curSelection = buttonNames.Length;
        }
    }
}