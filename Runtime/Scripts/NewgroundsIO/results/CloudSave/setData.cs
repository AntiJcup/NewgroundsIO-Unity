using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewgroundsIO.results.CloudSave {

	public class setData : NewgroundsIO.BaseResult {

		public NewgroundsIO.objects.SaveSlot slot { get; set; }


		/// <summary>Constructor</summary>
		public setData()
		{
			this.__object = "CloudSave.setData";

			this.__properties.Add("slot");
			this.__objectMap.Add("slot","SaveSlot");
		}

		/// <summary>Clones the properties of this object to another (or new) object.</summary>
		/// <param name="cloneTo">An object to clone properties to. If null, a new instance will be created.</param>
		/// <returns>The object that was cloned to.</returns>
		public NewgroundsIO.results.CloudSave.setData clone(NewgroundsIO.results.CloudSave.setData cloneTo = null) {
			if (cloneTo == null) cloneTo = new NewgroundsIO.results.CloudSave.setData();
			cloneTo.__properties.ForEach(propName => {
				cloneTo.GetType().GetProperty(propName).SetValue(cloneTo, this.GetType().GetProperty(propName).GetValue(this), null);
			});
			cloneTo.__ngioCore = this.__ngioCore;
			return cloneTo;
		}

	}

}

