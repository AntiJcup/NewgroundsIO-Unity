using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewgroundsIO.components.App {

	/// <summary>Increments "Total Views" statistic.</summary>
	public class logView : NewgroundsIO.BaseComponent {


		/// <summary>Constructor</summary>
		public logView()
		{
			this.__object = "App.logView";

			this.__properties.Add("host");
		}

		/// <summary>Clones the properties of this object to another (or new) object.</summary>
		/// <param name="cloneTo">An object to clone properties to. If null, a new instance will be created.</param>
		/// <returns>The object that was cloned to.</returns>
		public NewgroundsIO.components.App.logView clone(NewgroundsIO.components.App.logView cloneTo = null) {
			if (cloneTo == null) cloneTo = new NewgroundsIO.components.App.logView();
			cloneTo.__properties.ForEach(propName => {
				cloneTo.GetType().GetProperty(propName).SetValue(cloneTo, this.GetType().GetProperty(propName).GetValue(this), null);
			});
			cloneTo.__ngioCore = this.__ngioCore;
			return cloneTo;
		}

	}

}

