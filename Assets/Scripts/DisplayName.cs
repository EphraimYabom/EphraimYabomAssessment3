using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayName : MonoBehaviour
{
    public TMP_Text playerName;
    private void Awake()
    {
        if (NameInputManager.nameinputmanager != null)
        {
            playerName.text = NameInputManager.nameinputmanager.playerName;
        }
        else
        {
            Debug.LogError("Scene23 instance is not found.");
        }
    }
}

