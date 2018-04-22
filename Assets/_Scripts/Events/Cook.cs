using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cook : MonoBehaviour {

	private void OnTriggerStay(Collider other) {
		if (Input.GetKey(KeyCode.Space) && !GameSystem.m_Cook && GameSystem.m_Fish) {
			GameSystem.m_Cook = true;
			IngameUI.m_IngameUI.SetToggle(7);
		}
	}
}
