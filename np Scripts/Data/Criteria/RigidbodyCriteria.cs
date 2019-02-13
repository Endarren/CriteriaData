using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace npScripts
{
	[CreateAssetMenu(fileName = "Rigidbody Criteria Data", menuName = "nonPareil/Criteria/Rigidbody CriteriaData")]
	public class RigidbodyCriteria : CriteriaDataBase
	{
		public bool checkVelocityMagnitude;
		public NumberCompare velocityMagCompare;
		public float velocityMagValue;



		public bool checkAngVelocityMagnitude;
		public NumberCompare angVelocityMagCompare;
		public float angVelocityMagValue;

		public bool checkMass;
		public NumberCompare massCompare;
		public float massCompareValue;

		public bool checkGravity;
		public bool useGravity;


		public bool checkKinematic;
		public bool isKinematic;

		public bool mustMetAll;
		bool DoesKinematicMet (Rigidbody rb)
		{
			if (checkKinematic)
			{
				return rb.isKinematic == isKinematic;
			}
			return true;
		}
		bool DoesAngVelocityMet (Rigidbody rb)
		{
			if (checkAngVelocityMagnitude)
			{
				float mag = rb.angularVelocity.magnitude;
				return NPNumberCompare.CompreNumbers(mag, angVelocityMagValue, angVelocityMagCompare);
			}

			return true;
		}
		bool DoesVelocityMagnitudeMet(Rigidbody rb)
		{
			if(checkVelocityMagnitude)
			{
				float mag = rb.velocity.magnitude;
				return NPNumberCompare.CompreNumbers(mag, velocityMagValue, velocityMagCompare);
			}
			return true;
		}
		bool DoesMassMet(Rigidbody rb)
		{
			if (checkMass)
			{
				return NPNumberCompare.CompreNumbers(rb.mass, massCompareValue, massCompare);
			}
			return true;
		}
		bool DoesGravityMet (Rigidbody rb)
		{
			if (checkGravity)
			{
				return rb.useGravity == useGravity;
			}
			return true;
		}
		public override bool MetsCriteria(System.Object o)
		{
			if (!(o is GameObject))
				return false;
			GameObject go = (GameObject)o;
			Rigidbody rb = go.GetComponent<Rigidbody>();
			

			if (rb != null)
			{
				if (mustMetAll)
					return DoesGravityMet(rb) && DoesMassMet(rb) && DoesVelocityMagnitudeMet(rb) && DoesAngVelocityMet(rb) && DoesKinematicMet(rb);
				else
					return DoesGravityMet(rb) || DoesMassMet(rb) || DoesVelocityMagnitudeMet(rb) || DoesAngVelocityMet(rb) || DoesKinematicMet(rb);

			}
			return false;
		}
	}
}
