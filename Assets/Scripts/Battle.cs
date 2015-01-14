using UnityEngine;
using System.Collections;

public class Battle : MonoBehaviour
{
    public Camera camera;
    public GUIText allyName, allyHP;

    public int allyHPAmount;
    public int allyBaseDmg, attack1Dmg;

	// Use this for initialization
	void Start ()
    {
        Vector3 spritePos = camera.ScreenToWorldPoint(new Vector3(Screen.width / 1.2f, Screen.height / 4.5f, 10));
        transform.position = spritePos;

        // text position uses viewport values (0 to 1)
        allyName.transform.position = new Vector2(0.90f, 0.05f);
        allyName.text = "Koiruli";
        allyName.color = Color.black;

        allyHP.transform.position = new Vector2(0.60f, 0.05f);
        allyHP.text = "HP: " + allyHPAmount;
        allyHP.color = Color.black;

        allyHPAmount = 50;
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
