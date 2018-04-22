using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IngameUI : MonoBehaviour {

	public static IngameUI m_IngameUI;
	public static bool LockControlls;

	public GameObject m_Player;
	public GameObject m_PauseScreen;
	public GameObject m_MenuStuff;

	public GameObject m_TaskScreen;
	public List<GameObject> m_tasks = new List<GameObject>();

	public GameObject m_EndScreen;
	public Animator m_EndAnimator;

	void Start() {
		m_IngameUI = this;
	}

	void Update() {

		if (Input.GetKeyDown(KeyCode.Escape)) {
			TogglePauseMenu();
		}

		if (LockControlls) {
			return;
		}

		if (Input.GetKeyDown(KeyCode.Tab)) {
			m_TaskScreen.SetActive(true);
		}

		if (Input.GetKeyUp(KeyCode.Tab)) {
			m_TaskScreen.SetActive(false);
		}


	}

	public void SetToggle(int i) {
		m_tasks[i].SetActive(true);
	}

	public void PlayerEnding() {
		LockControlls = true;
		m_PauseScreen.SetActive(false);

		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;

		m_TaskScreen.SetActive(false);
		m_EndScreen.SetActive(true);
		m_EndAnimator.SetTrigger("PlayEnd");
	}

	public void TogglePauseMenu() {

		if (m_PauseScreen.activeInHierarchy) {
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
			LockControlls = false;
			m_PauseScreen.SetActive(false);
		}
		else {
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			LockControlls = true;
			m_PauseScreen.SetActive(true);
		}

	}

	public void StartGame(GameObject go) {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		m_Player.SetActive(true);
		go.SetActive(false);
		m_MenuStuff.SetActive(false);
	}

	public void RestartScene() {
		Debug.Log("Restarting game");
		LockControlls = false;

		GameSystem.m_Berries = false;
		GameSystem.m_Breakfast = false;
		GameSystem.m_ChopWood = false;
		GameSystem.m_ChopLogs = false;
		GameSystem.m_FuelIgnite = false;
		GameSystem.m_PayBills = false;
		GameSystem.m_Fish = false;
		GameSystem.m_Cook = false;
		GameSystem.m_Dinner = false;
		GameSystem.m_Toilet = false;
		GameSystem.m_Bath = false;

		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;

		SceneManager.LoadScene(0);
	}

	public void QuitGame() {
		Debug.Log("Application shutdown");
		Application.Quit();
	}
}
