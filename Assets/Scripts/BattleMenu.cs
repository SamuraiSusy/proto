using UnityEngine;
using System.Collections;

public class BattleMenu : MonoBehaviour
{
    public Camera cam1, cam2, cam3;

    float menuCenterX, menuCenterY;
    float menuLeft, menuTop;

    int buttonWidth, buttonHeight;
    float buttonX, buttonY;

    bool menuOpen, attackMenuOpen, itemMenuOpen, allyMenuOpen;

    string mainText, menuText, attackMenuText;

    public Battle ally;
    public BattleAI enemy;

	// Use this for initialization
	void Start ()
    {
        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;

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

        menuText = "Menu";
        attackMenuText = "Press backspace to go back";
        mainText = menuText;
        
        ally = gameObject.GetComponent<Battle>();
        enemy = gameObject.GetComponent<BattleAI>();

	}
	
	// Update is called once per frame
	void Update ()
    {}

    void OnGUI()
    {
        GUI.Box(new Rect(menuLeft, menuTop, Screen.width / 2, Screen.height / 3), mainText);
        if (menuOpen == true)
        {
            mainText = menuText;
            DrawMenu();
        }
        else if (attackMenuOpen == true)
        {
            mainText = attackMenuText;
            //GUI.Box(new Rect(menuLeft, menuTop, Screen.width / 2, Screen.height / 3), mainText);
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
            DrawMonsterMenu();
        }
        else if (GUI.Button(new Rect(buttonX, buttonY + 80, buttonWidth, buttonHeight), "Items"))
        {
            DrawItemMenu();
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
            enemy.enemyHPAmount -= ally.allyBaseDmg + ally.attack1Dmg;
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

        if (Input.GetKey(KeyCode.Backspace))
        {
            attackMenuOpen = false;
            menuOpen = true;
        }
    }

    void DrawItemMenu()
    {
        if (cam1.enabled == true)
        {
            cam1.enabled = false;
            cam2.enabled = true;
        }
        else if (cam2.enabled == true)
        {
            cam1.enabled = true;
            cam2.enabled = false;
        }
    }

    // don't quite get it but it changes the cameras wrong way
    // still usable; only little, fixable bug
    void DrawMonsterMenu()
    {
        if (cam1.enabled == true)
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = true;
        }
        else if (cam3.enabled == true)
        {
            cam1.enabled = true;
            cam3.enabled = false;
        }
    }

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