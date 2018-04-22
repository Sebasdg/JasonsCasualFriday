using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choplogs : MonoBehaviour {

	private void OnTriggerStay(Collider other) {
		if (Input.GetKey(KeyCode.Space) && !GameSystem.m_ChopLogs && GameSystem.m_ChopWood) {
			GameSystem.m_ChopLogs = true;
			IngameUI.m_IngameUI.SetToggle(3);
		}
	}
}
