using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewgroundsIO.components.Gateway {

	/// <summary>Pings the Newgrounds.io server.</summary>
	public class ping : NewgroundsIO.BaseComponent {


		/// <summary>Constructor</summary>
		public ping()
		{
			this.__object = "Gateway.ping";

		}

		/// <summary>Clones the properties of this object to another (or new) object.</summary>
		/// <param name="cloneTo">An object to clone properties to. If null, a new instance will be created.</param>
		/// <returns>The object that was cloned to.</returns>
		public NewgroundsIO.components.Gateway.ping clone(NewgroundsIO.components.Gateway.ping cloneTo = null) {
			if (cloneTo == null) cloneTo = new NewgroundsIO.components.Gateway.ping();
			cloneTo.__properties.ForEach(propName => {
				cloneTo.GetType().GetProperty(propName).SetValue(cloneTo, this.GetType().GetProperty(propName).GetValue(this), null);
			});
			cloneTo.__ngioCore = this.__ngioCore;
			return cloneTo;
		}

	}

}

