//<author>Nicholas Irwin</author>
//<company> nonPareil Institute</company>
//<copyright file ="CriteriaData.cs" All Rights Reserved
//</copyright>
//<date>1/29/2018</date>

namespace npScripts
{
	using npScripts.Utilities;
	using System.Collections.Generic;
	using UnityEngine;

	/// <summary>
	/// Used to determine if something mets certain requirements.
	/// </summary>
	[CreateAssetMenu(fileName = "Criteria Data", menuName = "nonPareil/Criteria/CriteriaData")]
	public class CriteriaData : CriteriaDataBase
	{
		#region Fields


		/// <summary>
		/// Defines the useTag
		/// </summary>
		public bool useTag;

		/// <summary>
		/// The list of tags that are allowed.
		/// </summary>
		[Tooltip("The tags that are allowed.")]
		public List<string> allowedTags = new List<string>();

		/// <summary>
		/// Defines the useLayers
		/// </summary>
		public bool useLayers;

		/// <summary>
		/// The layers that are allowed.
		/// </summary>
		[Tooltip("The layers that are allowed.")]
		public LayerMask allowedLayers;

		/// <summary>
		/// If true, all conditions must be met to pass.
		/// </summary>
		[Tooltip("If true, all conditions must be met to pass.")]
		public bool mustMeetAll = true;

		#endregion

		#region Methods
		/// <summary>
		/// Checks if an object meets the requirements.
		/// </summary>
		/// <param name="go">The <see cref="GameObject"/></param>
		/// <returns>The <see cref="bool"/></returns>
		public override bool MetsCriteria(System.Object o)
		{

			if (o == null)
				return false;
			if (!(o is GameObject))
				return false;
			GameObject go = (GameObject)o;
			bool result = true;
			if (mustMeetAll)
			{
				if (useTag)
					result = result && allowedTags.Contains(go.tag);
				if (useLayers)
					result = result && NPUtilities.IsLayerInMask(allowedLayers, go.layer);
			}
			else
			{
				result = false;
				if (useTag)
					result = result || allowedTags.Contains(go.tag);
				if (useLayers)
					result = result || NPUtilities.IsLayerInMask(allowedLayers, go.layer);
			}


			return result;
		}

		#endregion
	}
}
