using UnityEngine;
using System.Collections;

public class BattleAI : MonoBehaviour
{
    public Camera camera;
    public GUIText enemyName, enemyHP;

    public int enemyHPAmount;
    // Use this for initialization
    void Start()
    {
        // sprite position
        Vector3 spritePos = camera.ScreenToWorldPoint(new Vector3(Screen.width / 5f, Screen.height / 1.25f, 10));
        transform.position = spritePos;

        // guitext pos
        // position uses viewport values (0 to 1)
        enemyName.transform.position = new Vector2(0.15f, 0.98f);
        enemyName.text = "Kisuli";
        enemyName.color = Color.black;

        enemyHP.transform.position = new Vector2(0.45f, 0.98f);
        enemyHP.text = "HP: " + enemyHPAmount;
        enemyHP.color = Color.black;

        enemyHPAmount = 30;
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
