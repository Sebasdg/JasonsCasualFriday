using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinner : MonoBehaviour {

	private void OnTriggerStay(Collider other) {
		if (Input.GetKey(KeyCode.Space) && !GameSystem.m_Dinner && GameSystem.m_Cook) {
			GameSystem.m_Dinner = true;
			IngameUI.m_IngameUI.SetToggle(8);
		}
	}
}
