using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scene24 : MonoBehaviour

{

    public TMP_Text display_player_name;


    private void Awake()

    {

        if (Scene23.scene23 != null)

        {

            display_player_name.text = Scene23.scene23.player_name;

        }

        else

        {

            Debug.LogError("Scene23 instance is not found.");

        }

    }

}
