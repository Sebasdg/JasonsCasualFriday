using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayBills : MonoBehaviour {

	public Transform m_MailboxDoor;
	public Transform m_MailboxFlag;


	private void OnTriggerStay(Collider other) {
		if (Input.GetKey(KeyCode.Space) && !GameSystem.m_PayBills && GameSystem.m_FuelIgnite) {
			GameSystem.m_PayBills = true;
			IngameUI.m_IngameUI.SetToggle(5);

			m_MailboxDoor.transform.localEulerAngles = new Vector3(0, 0, 0);
			m_MailboxFlag.transform.localEulerAngles = new Vector3(0, 0, 0);
		}
	}
}
