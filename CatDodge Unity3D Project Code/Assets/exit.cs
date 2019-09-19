using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class exit : MonoBehaviour {

    public Button exit_button;

    void Start ()
    {
        Button exit = exit_button.GetComponent<Button>();
        exit.onClick.AddListener(Exit);
    }

    void Exit()
    {
        Application.Quit();
    }
}
