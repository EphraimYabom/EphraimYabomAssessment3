using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NameInputManager : MonoBehaviour
{
    public static NameInputManager nameinputmanager;
    public TMP_InputField nameInputField; // Reference to the Input Field
    
    public string playerName; // Variable to store player's name

    public void OnNextButtonClicked()
    {
        playerName = nameInputField.text; // Get the name from the input field
        PlayerPrefs.SetString("PlayerName", playerName); // Save the name using PlayerPrefs
        SceneManager.LoadScene("NextScene"); // Load the next scene
    }
}
