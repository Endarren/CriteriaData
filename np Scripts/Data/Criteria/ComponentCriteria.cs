using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace EndarScripts
{
	[CreateAssetMenu(fileName = "Component Criteria Data", menuName = "nonPareil/Criteria/Component Criteria")]
	public class ComponentCriteria : CriteriaDataBase
	{
		public List<string> componentNames = new List<string>();
		public int minToMet;

		public override bool MetsCriteria(object o)
		{
			if (!(o is GameObject))
				return false;
			int metCount = 0;
			GameObject go = (GameObject)o;
			for (int i = 0; i < componentNames.Count; i++)
			{
				if (go.GetComponent(componentNames [i]) != null)
				{
					metCount++;
					if (metCount >= minToMet)
						break;
				}
			}

			return metCount >= minToMet;
		}
	}
}
