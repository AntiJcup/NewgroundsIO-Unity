using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewgroundsIO.components.CloudSave {

	/// <summary>Returns a specific #saveslot object.</summary>
	public class loadSlot : NewgroundsIO.BaseComponent {

		/// <summary>The slot number.</summary>
		public int id { get; set; }


		/// <summary>Constructor</summary>
		public loadSlot()
		{
			this.__object = "CloudSave.loadSlot";

			this.__properties.Add("id");
			this.__required.Add("id");
			this.__requireSession = true;
		}

		/// <summary>Clones the properties of this object to another (or new) object.</summary>
		/// <param name="cloneTo">An object to clone properties to. If null, a new instance will be created.</param>
		/// <returns>The object that was cloned to.</returns>
		public NewgroundsIO.components.CloudSave.loadSlot clone(NewgroundsIO.components.CloudSave.loadSlot cloneTo = null) {
			if (cloneTo == null) cloneTo = new NewgroundsIO.components.CloudSave.loadSlot();
			cloneTo.__properties.ForEach(propName => {
				cloneTo.GetType().GetProperty(propName).SetValue(cloneTo, this.GetType().GetProperty(propName).GetValue(this), null);
			});
			cloneTo.__ngioCore = this.__ngioCore;
			return cloneTo;
		}

	}

}

