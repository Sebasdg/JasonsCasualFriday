using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopWood : MonoBehaviour {

	private void OnTriggerStay(Collider other) {
		if (Input.GetKey(KeyCode.Space) && !GameSystem.m_ChopWood && GameSystem.m_Breakfast) {
			GameSystem.m_ChopWood = true;
			IngameUI.m_IngameUI.SetToggle(2);
		}
	}
}
