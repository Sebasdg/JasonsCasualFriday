using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toilet : MonoBehaviour {

	private void OnTriggerStay(Collider other) {
		if (Input.GetKey(KeyCode.Space) && !GameSystem.m_Toilet && GameSystem.m_Dinner) {
			GameSystem.m_Toilet = true;
			IngameUI.m_IngameUI.SetToggle(9);
		}
	}
}
