#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;

namespace CollectionBase
{
	/// <summary>
	/// Summary description for Data.
	/// </summary>
	public class Data
	{
		public Data() : this("", "", "", "")
		{
		}

		public Data(string cat_Id, string cat_Name, string desc, string other)
		{
			this.cat_Id = cat_Id;
			this.cat_Name = cat_Name;
			this.desc = desc;
			this.other = other;
		}
		private string cat_Name;
		public string CategoryName
		{
			get
			{
				return this.cat_Name;
			}
			set
			{
				this.cat_Name = value;
			}
		}
		private string desc;
		public string Description
		{
			get
			{
				return this.desc;
			}
			set
			{
				this.desc = value;
			}
		}
		private string cat_Id;
		public string CategoryID
		{
			get
			{
				return this.cat_Id;
			}
			set
			{
				this.cat_Id = value;
			}
		}
		private string other;
		public string OtherInfo
		{
			get
			{
				return this.other;
			}
			set
			{
				this.other = value;
			}
		}
	}
}
