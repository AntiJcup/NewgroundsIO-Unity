using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewgroundsIO.components.Loader {

	/// <summary>Loads the official URL where the latest version of your app can be found (as defined in your "Official URLs" settings), and logs a referral to your API stats.</summary>
	public class loadOfficialUrl : NewgroundsIO.BaseComponent {

		/// <summary>Set this to false to get a JSON response containing the URL instead of doing an actual redirect.</summary>
		public bool redirect { get; set; } = true;

		/// <summary>Set this to false to skip logging this as a referral event.</summary>
		public bool log_stat { get; set; } = true;


		/// <summary>Constructor</summary>
		public loadOfficialUrl()
		{
			this.__object = "Loader.loadOfficialUrl";

			this.__properties.Add("host");
			this.__properties.Add("redirect");
			this.__properties.Add("log_stat");
		}

		/// <summary>Clones the properties of this object to another (or new) object.</summary>
		/// <param name="cloneTo">An object to clone properties to. If null, a new instance will be created.</param>
		/// <returns>The object that was cloned to.</returns>
		public NewgroundsIO.components.Loader.loadOfficialUrl clone(NewgroundsIO.components.Loader.loadOfficialUrl cloneTo = null) {
			if (cloneTo == null) cloneTo = new NewgroundsIO.components.Loader.loadOfficialUrl();
			cloneTo.__properties.ForEach(propName => {
				cloneTo.GetType().GetProperty(propName).SetValue(cloneTo, this.GetType().GetProperty(propName).GetValue(this), null);
			});
			cloneTo.__ngioCore = this.__ngioCore;
			return cloneTo;
		}

	}

}

