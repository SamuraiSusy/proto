using UnityEngine;
using System.Collections;

public class BattleMenu : MonoBehaviour
{
    float menuCenterX, menuCenterY;
    float menuLeft, menuTop;

    int buttonWidth, buttonHeight;
    float buttonX, buttonY;

    bool menuOpen, attackMenuOpen, itemMenuOpen, allyMenuOpen;

	// Use this for initialization
	void Start ()
    {
        menuCenterX = Screen.width / 2;
        menuCenterY = Screen.height / 2;

        menuLeft = menuCenterX - 300;
        menuTop = menuCenterY + 60;

        buttonWidth = 60;
        buttonHeight = 40;
        buttonX = menuLeft + 20f;
        buttonY = menuTop + 20f;

        menuOpen = true;
        attackMenuOpen = false;
        itemMenuOpen = false;
        allyMenuOpen = false;

	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnGUI()
    {
        GUI.Box(new Rect(menuLeft, menuTop, Screen.width / 2, Screen.height / 3), "test");
        if (menuOpen == true)
        {
            DrawMenu();
        }
        else if (attackMenuOpen == true)
        {
            DrawAttackMenu();
        }
        else
            Debug.Log("derp");
    }

    void DrawMenu()
    {
        //GUI.Box(new Rect(menuLeft, menuTop, Screen.width / 2, Screen.height / 3), "test");

        // also replace with texture versions
        if(GUI.Button(new Rect(buttonX, buttonY, buttonWidth, buttonHeight), "Attack"))
        {
            Attack();
        }
        else if (GUI.Button(new Rect(buttonX + 80, buttonY, buttonWidth, buttonHeight), "Change"))
        {
            Debug.Log("change ur lovely monstaa");
        }
        else if (GUI.Button(new Rect(buttonX, buttonY + 80, buttonWidth, buttonHeight), "Items"))
        {
            UseItem();
        }
        else if (GUI.Button(new Rect(buttonX + 80, buttonY + 80, buttonWidth, buttonHeight), "Run"))
        {
            RunAway();
        }
    }

    void DrawAttackMenu()
    {
        if (GUI.Button(new Rect(buttonX, buttonY, buttonWidth, buttonHeight), "Attack1"))
        {
            Debug.Log("attack 1");
        }
        else if (GUI.Button(new Rect(buttonX + 80, buttonY, buttonWidth, buttonHeight), "Attack2"))
        {
            Debug.Log("attack 2");
        }
        else if (GUI.Button(new Rect(buttonX, buttonY + 80, buttonWidth, buttonHeight), "Attack3"))
        {
            Debug.Log("attack 3");
        }
        else if (GUI.Button(new Rect(buttonX + 80, buttonY + 80, buttonWidth, buttonHeight), "Attack4"))
        {
            Debug.Log("attack 4");
        }
    }

    void DrawItemMenu()
    { }

    void DrawMonsterMenu()
    { }

    void Attack()
    {
        menuOpen = false;
        attackMenuOpen = true;
        DrawAttackMenu();
    }

    void UseItem()
    {
        Debug.Log("you used item");
    }

    void RunAway()
    {
        Debug.Log("you ran away");
        // here exit from battle scene
    }
}