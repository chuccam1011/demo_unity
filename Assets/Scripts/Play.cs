using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public static string theName;
    public GameObject inputField;
    public GameObject textDisPlay;
    public string myFirstScene, mySecondScene;
    private string nextScene;
    private Rect buttonRect;
    private static bool created = false;
    private void Start()
    {
    }
    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text;

        Scene scene = SceneManager.GetActiveScene();
  
        SceneManager.LoadScene("main");

    }
    private void Awake()
    {
        Debug.Log("Awake:" + SceneManager.GetActiveScene().name);
        // Ensure the script is not deleted while loading.
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
        else
        {
            Destroy(this.gameObject);
        }

    }
    private void OnGUI()
    {
        // Return the current Active Scene in order to get the current Scene name.
        Scene scene = SceneManager.GetActiveScene();

        // Check if the name of the current Active Scene is your first Scene.
        if (scene.name == myFirstScene)
        {
            // nextButton = "Load Next Scene";
            nextScene = mySecondScene;
        }
        else
        {
            // nextButton = "Load Previous Scene";
            nextScene = myFirstScene;
        }

        // Display the button used to swap scenes.
        //GUIStyle buttonStyle = new GUIStyle(GUI.skin.GetStyle("button"));
        //buttonStyle.alignment = TextAnchor.MiddleCenter;
        //buttonStyle.fontSize = 12 * (width / 200);

        //if (GUI.Button(buttonRect, nextButton, buttonStyle))
        //{
        //}
    }
}
