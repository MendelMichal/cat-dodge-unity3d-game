using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseMenuUI;
    public Button Resume_button;
    public Button pause_button;
    public Button menu_button;

    void Start () {
        pauseMenuUI.SetActive(false);
        Button resume = Resume_button.GetComponent<Button>();
        Button pause = pause_button.GetComponent<Button>();

        pause.onClick.AddListener(Pause);
        resume.onClick.AddListener(Resume);
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

}
