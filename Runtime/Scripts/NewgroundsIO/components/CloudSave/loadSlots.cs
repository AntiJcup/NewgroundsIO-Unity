using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewgroundsIO.components.CloudSave {

	/// <summary>Returns a list of #saveslot objects.</summary>
	public class loadSlots : NewgroundsIO.BaseComponent {


		/// <summary>Constructor</summary>
		public loadSlots()
		{
			this.__object = "CloudSave.loadSlots";

			this.__requireSession = true;
		}

		/// <summary>Clones the properties of this object to another (or new) object.</summary>
		/// <param name="cloneTo">An object to clone properties to. If null, a new instance will be created.</param>
		/// <returns>The object that was cloned to.</returns>
		public NewgroundsIO.components.CloudSave.loadSlots clone(NewgroundsIO.components.CloudSave.loadSlots cloneTo = null) {
			if (cloneTo == null) cloneTo = new NewgroundsIO.components.CloudSave.loadSlots();
			cloneTo.__properties.ForEach(propName => {
				cloneTo.GetType().GetProperty(propName).SetValue(cloneTo, this.GetType().GetProperty(propName).GetValue(this), null);
			});
			cloneTo.__ngioCore = this.__ngioCore;
			return cloneTo;
		}

	}

}

