//<author>Nicholas Irwin</author>


namespace EndarScripts.Utilities
{
	using System;
	using System.Collections.Generic;
	using System.Reflection;
	using UnityEngine;

	/// <summary>
	/// A set of helpful methods and extensions.
	/// </summary>
	public static class NPUtilities
	{
		#region Methods

		/// <summary>
		/// The GetCollisionDirection
		/// </summary>
		/// <param name="c">The <see cref="Collision"/></param>
		/// <returns>The <see cref="Vector3"/></returns>
		public static Vector3 GetCollisionDirection(Collision c)
		{
			Vector3 dir = Vector3.zero;
			//c.
			return dir;
		}

		/// <summary>
		/// Checks if a layer is in a layer mask.
		/// </summary>
		/// <param name="lm">The <see cref="LayerMask"/></param>
		/// <param name="layerNum">The <see cref="int"/></param>
		/// <returns>The <see cref="bool"/></returns>
		public static bool IsLayerInMask(LayerMask lm, int layerNum)
		{
			return lm == (lm | (1 << layerNum));
		}

		/// <summary>
		/// Checks if a layer is in a layer mask.
		/// </summary>
		/// <param name="lm">The <see cref="LayerMask"/></param>
		/// <param name="layerName">The <see cref="string"/></param>
		/// <returns>The <see cref="bool"/></returns>
		public static bool IsLayerInMask(LayerMask lm, string layerName)
		{
			return lm == (lm | (1 << LayerMask.NameToLayer(layerName)));
		}

		/// <summary>
		/// Checks if this LayerMask contains a layer.
		/// </summary>
		/// <param name="lm">The <see cref="LayerMask"/></param>
		/// <param name="layerName">The <see cref="string"/></param>
		/// <returns>The <see cref="bool"/></returns>
		public static bool MaskHasLayer(this LayerMask lm, string layerName)
		{
			return lm == (lm | (1 << LayerMask.NameToLayer(layerName)));
		}
		public static Transform FindTransformOfName(this GameObject go, string nam)
		{
			Transform result = null;
			List<Transform> allChildren = new List<Transform>(go.GetComponentsInChildren<Transform>());

			result = allChildren.Find(x => x.gameObject.name == nam);
			return result;
		}
		public static Type GetType(string typeName)
		{
			Type type = null;

			// Try a direct type lookup
			type = Type.GetType(typeName);
			if (type != null)
			{
				return type;
			}


#if (!UNITY_EDITOR && UNITY_METRO) == false // no AppDomain on WinRT
			// If we still haven't found the proper type, we can enumerate all of the loaded
			// assemblies and see if any of them define the type
			foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				// See if that assembly defines the named type
				type = assembly.GetType(typeName);
				if (type != null)
				{
					return type;
				}
			}
#endif

			return null;
		}

		#endregion
	}
}
