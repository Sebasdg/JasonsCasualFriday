using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berrybush : MonoBehaviour {

	public GameObject m_BerryGO;

	private void OnTriggerStay(Collider other) {
		if (Input.GetKey(KeyCode.Space) && !GameSystem.m_Berries) {
			m_BerryGO.SetActive(false);
			GameSystem.m_Berries = true;
			IngameUI.m_IngameUI.SetToggle(0);
		}
	}
}
