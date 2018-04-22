using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelFireplace : MonoBehaviour {

	private void OnTriggerStay(Collider other) {
		if (Input.GetKey(KeyCode.Space) && !GameSystem.m_FuelIgnite && GameSystem.m_ChopLogs) {
			GameSystem.m_FuelIgnite = true;
			IngameUI.m_IngameUI.SetToggle(4);
		}
	}
}
