//<author>Nicholas Irwin</author>
//<company> nonPareil Institute</company>
//<copyright file ="CriteriaDataBase.cs" All Rights Reserved
//</copyright>
//<date>1/30/2018</date>

namespace npScripts
{
	using UnityEngine;

	/// <summary>
	/// Holds the base class for CriteriaData classes.
	/// </summary>
	public abstract class CriteriaDataBase : ScriptableObject
	{
		#region Methods

		/// <summary>
		/// Checks if an object meets the requirements.
		/// </summary>
		/// <param name="go">The <see cref="GameObject"/></param>
		/// <returns>The <see cref="bool"/></returns>
		public abstract bool MetsCriteria(System.Object go);

		#endregion
	}
}
