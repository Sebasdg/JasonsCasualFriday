using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_survivor : MonoBehaviour {

	public List<Rigidbody> m_Rigidbodies = new List<Rigidbody>();
	public Kill m_Kill;
	private bool Alive = true;

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "KillCube" && Alive) {
			for (int i = 0; i < m_Rigidbodies.Count; i++) {
				m_Rigidbodies[i].isKinematic = false;
			}

			m_Kill.SurvivorKilled();

			Alive = false;
		}
	}
}
