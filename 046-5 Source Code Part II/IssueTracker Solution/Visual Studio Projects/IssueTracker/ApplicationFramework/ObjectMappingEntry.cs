using System;

namespace ApplicationFramework
{
	/// <summary>
	/// Summary description for ObjectMappingEntry.
	/// </summary>
	public class ObjectMappingEntry
	{
		string _Viewer;
		string _BusinessObjectName;
		Controller.ControllerActions _Action;

		public string Viewer
		{
			set
			{ 
				_Viewer = value; 
			}
			get
			{ 
				return _Viewer; 
			}
		}

		public string BusinessObjectName
		{
			set
			{
				_BusinessObjectName = value;
			}
			get
			{
				return _BusinessObjectName;
			}
		}

		public Controller.ControllerActions Action
		{
			set
			{
				_Action = value;
			}
			get
			{
				return _Action;
			}
		}
	
	}
}
