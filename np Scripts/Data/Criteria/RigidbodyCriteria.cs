using UnityEngine;

namespace EndarScripts
{
	[CreateAssetMenu(fileName = "Rigidbody Criteria Data", menuName = "EndarScripts/Criteria/Rigidbody CriteriaData")]
	public class RigidbodyCriteria : CriteriaDataBase
	{
		#region Public Fields

		public bool is2D;
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
		public float gravityScale2D;
		public NumberCompare gravityCompare = NumberCompare.Equal;

		public bool checkKinematic;
		public bool isKinematic;

		public bool mustMetAll;

		#endregion Public Fields

		#region Public Methods

		public override bool MetsCriteria(System.Object o)
		{
			if (!(o is GameObject))
				return false;
			GameObject go = (GameObject)o;
			if (is2D)
			{
				Rigidbody2D rb = go.GetComponent<Rigidbody2D>();

				if (rb != null)
				{
					if (mustMetAll)
						return DoesGravityMet(rb) && DoesMassMet(rb) && DoesVelocityMagnitudeMet(rb) && DoesAngVelocityMet(rb);
					else
						return DoesGravityMet(rb) || DoesMassMet(rb) || DoesVelocityMagnitudeMet(rb) || DoesAngVelocityMet(rb);
				}
			}
			else
			{
				Rigidbody rb = go.GetComponent<Rigidbody>();

				if (rb != null)
				{
					if (mustMetAll)
						return DoesGravityMet(rb) && DoesMassMet(rb) && DoesVelocityMagnitudeMet(rb) && DoesAngVelocityMet(rb) && DoesKinematicMet(rb);
					else
						return DoesGravityMet(rb) || DoesMassMet(rb) || DoesVelocityMagnitudeMet(rb) || DoesAngVelocityMet(rb) || DoesKinematicMet(rb);
				}
			}

			return false;
		}

		#endregion Public Methods

		#region Private Methods

		private bool DoesKinematicMet(Rigidbody rb)
		{
			if (checkKinematic)
			{
				return rb.isKinematic == isKinematic;
			}
			return true;
		}

		private bool DoesAngVelocityMet(Rigidbody rb)
		{
			if (checkAngVelocityMagnitude)
			{
				float mag = rb.angularVelocity.magnitude;
				return NPNumberCompare.CompreNumbers(mag, angVelocityMagValue, angVelocityMagCompare);
			}

			return true;
		}

		private bool DoesAngVelocityMet(Rigidbody2D rb)
		{
			if (checkAngVelocityMagnitude)
			{
				return NPNumberCompare.CompreNumbers(rb.angularVelocity, angVelocityMagValue, angVelocityMagCompare);
			}

			return true;
		}

		private bool DoesVelocityMagnitudeMet(Rigidbody rb)
		{
			if (checkVelocityMagnitude)
			{
				float mag = rb.velocity.magnitude;
				return NPNumberCompare.CompreNumbers(mag, velocityMagValue, velocityMagCompare);
			}
			return true;
		}

		private bool DoesVelocityMagnitudeMet(Rigidbody2D rb)
		{
			if (checkVelocityMagnitude)
			{
				float mag = rb.velocity.magnitude;
				return NPNumberCompare.CompreNumbers(mag, velocityMagValue, velocityMagCompare);
			}
			return true;
		}

		private bool DoesMassMet(Rigidbody rb)
		{
			if (checkMass)
			{
				return NPNumberCompare.CompreNumbers(rb.mass, massCompareValue, massCompare);
			}
			return true;
		}

		private bool DoesMassMet(Rigidbody2D rb)
		{
			if (checkMass)
			{
				return NPNumberCompare.CompreNumbers(rb.mass, massCompareValue, massCompare);
			}
			return true;
		}

		private bool DoesGravityMet(Rigidbody rb)
		{
			if (checkGravity)
			{
				return rb.useGravity == useGravity;
			}
			return true;
		}

		private bool DoesGravityMet(Rigidbody2D rb)
		{
			if (checkGravity)
			{
				return NPNumberCompare.CompreNumbers(rb.gravityScale, gravityScale2D, gravityCompare);
			}
			return true;
		}

		#endregion Private Methods
	}
}
