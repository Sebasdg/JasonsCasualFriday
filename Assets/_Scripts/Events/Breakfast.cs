using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakfast : MonoBehaviour {

	private void OnTriggerStay(Collider other) {
		if (Input.GetKey(KeyCode.Space) && !GameSystem.m_Breakfast && GameSystem.m_Berries) {
			GameSystem.m_Breakfast = true;
			IngameUI.m_IngameUI.SetToggle(1);
		}
	}
}
