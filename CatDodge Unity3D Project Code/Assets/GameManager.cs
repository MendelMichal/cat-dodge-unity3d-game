using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject EndGameMenuUI;

    public float slowness = 10f;
	public void Start(){

        globalnezmiene.shaking = 0;

        EndGameMenuUI.SetActive(false);

        Time.timeScale = 1f;
		Time.fixedDeltaTime = Time.fixedDeltaTime;

	}
	public void EndGame ()
	{
        StartCoroutine(RestartLevel());
    }

	IEnumerator RestartLevel ()
	{
		Time.timeScale = 1f / slowness;
		Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

		yield return new WaitForSeconds(0.5f);

        globalnezmiene.shaking = 1;

        Time.timeScale = 0f;
        EndGameMenuUI.SetActive(true);
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
