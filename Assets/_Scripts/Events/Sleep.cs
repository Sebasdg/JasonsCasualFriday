using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : MonoBehaviour {

	private void OnTriggerStay(Collider other) {

		if(other.gameObject.name != "c_jason") {
			return;
		}

		if (Input.GetKey(KeyCode.Space) && !GameSystem.m_Sleep && GameSystem.m_IntrudersKilled) {
			print("Test1");
			GameSystem.m_Sleep = true;
			IngameUI.m_IngameUI.SetToggle(12);

			IngameUI.m_IngameUI.PlayerEnding();
		}
	}
}
