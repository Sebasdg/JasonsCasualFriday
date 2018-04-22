using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bath : MonoBehaviour {

	public Light m_Sun;
	public Kill m_Kill;

	private void OnTriggerStay(Collider other) {
		if (!GameSystem.m_Bath && GameSystem.m_Toilet) {
			GameSystem.m_Bath = true;
			IngameUI.m_IngameUI.SetToggle(10);

			m_Sun.color = new Color(0.92f,1.0f,1.0f,1.0f);
			m_Sun.intensity = 0.2f;

			m_Kill.SpawnSurivors();
		}
	}
}
