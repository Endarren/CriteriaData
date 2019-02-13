using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace npScripts
{
	[CreateAssetMenu(fileName = "Composite Criteria Data", menuName = "nonPareil/Criteria/Composite CriteriaData")]
	public class CompositeCriteria : CriteriaDataBase
	{
		public CriteriaDataBase [] criteria;
		public override bool MetsCriteria(System.Object go)
		{
			for (int i = 0; i < criteria.Length; i++)
			{
				if (!criteria [i].MetsCriteria(go))
					return false;
			}
			return true;
		}
	}
}