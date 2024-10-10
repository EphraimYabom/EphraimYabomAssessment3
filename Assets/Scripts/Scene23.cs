using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Scene23 : MonoBehaviour
{
    public static Scene23 scene23;
    public TMP_InputField inputField; // Assign this in the Inspector

    public string player_name;

    private void Awake()
    {
        if (scene23 == null)
        {
            scene23 = this;
            GameObject persistentObject = new GameObject("PlayerData");
            persistentObject.AddComponent<Scene23>();
            DontDestroyOnLoad(persistentObject);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetPlayerName()
    {
        if (inputField != null)
        {
            player_name = inputField.text;
            SceneManager.LoadSceneAsync("Scene 24");
        }
        else
        {
            Debug.LogError("InputField is not set in the Inspector.");
        }
    }
}