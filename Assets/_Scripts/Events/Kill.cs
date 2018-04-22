using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {

	public List<GameObject> survivors = new List<GameObject>();
	public int m_KillCount;

	public void SpawnSurivors() {
		for (int i = 0; i < survivors.Count; i++) {
			survivors[i].SetActive(true);
		}
	}

	public void SurvivorKilled() {
		m_KillCount++;

		if (m_KillCount == survivors.Count) {
			GameSystem.m_IntrudersKilled = true;
			IngameUI.m_IngameUI.SetToggle(11);
		}
	}
}
