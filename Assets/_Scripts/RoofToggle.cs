using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofToggle : MonoBehaviour {

	public MeshRenderer m_RoofMesh;

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.name != "c_jason") {
			return;
		}

		m_RoofMesh.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
	}

	private void OnTriggerExit(Collider other) {
		if (other.gameObject.name != "c_jason") {
			return;
		}

		m_RoofMesh.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
	}
}
