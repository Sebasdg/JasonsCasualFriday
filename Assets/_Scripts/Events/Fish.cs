using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour {

	private void OnTriggerStay(Collider other) {
		if (Input.GetKey(KeyCode.Space) && !GameSystem.m_Fish && GameSystem.m_PayBills) {
			GameSystem.m_Fish = true;
			IngameUI.m_IngameUI.SetToggle(6);
		}
	}
}