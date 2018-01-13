using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potions {

	public enum e_Potions{
		None,
		Health,
		Force,
		Poison
	}

	public static e_Potions m_potions = e_Potions.None;
}
