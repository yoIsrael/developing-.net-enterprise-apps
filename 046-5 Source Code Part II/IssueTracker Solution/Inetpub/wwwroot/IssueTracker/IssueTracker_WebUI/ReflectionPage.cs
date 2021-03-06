using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Reflection;
using BusinessRules;



namespace WebUI
{
	/// <summary>
	/// Summary description for ReflectionPage.
	/// </summary>
	public class ReflectionPage : System.Web.UI.Page
	{
		private BusinessObject _SourceObject;

		public BusinessObject BusinessObject
		{
			get { return _SourceObject; }
			set { _SourceObject = value; }
		}

		public void ReflectBusinessObject()
		{
			string strObjectPrefix;
			string strObjectValue;
			string strFieldName;
			Type objType;
			Type controlType;
			PropertyInfo propObject;

			try
			{
				objType = _SourceObject.GetType();
				strObjectPrefix = objType.FullName.Substring( 
					objType.FullName.IndexOf(".") + 1 ) + "_";

				//iterate through all controls on the page
				foreach( Control controlChild in Page.Controls[1].Controls )
				{
					if( controlChild.ClientID != null )
					{
						if( controlChild.ClientID.StartsWith( strObjectPrefix ) )
						{
							//get the property value matching the control name
							controlType = controlChild.GetType();

							//get the field name
							strFieldName = controlChild.ClientID.Substring( 
								controlChild.ClientID.IndexOf( "_" ) + 1 );

							//get the text value
							propObject = objType.GetProperty( strFieldName );
							strObjectValue = propObject.GetValue( _SourceObject, 
								null ).ToString().TrimEnd();

							//set the textbox control

							if( controlType.Name.CompareTo( "TextBox" ) == 0 )
							{
								((TextBox)controlChild).Text = strObjectValue;
							}

							if( controlType.Name.CompareTo( "DropDownList" ) == 0 )
							{
								((DropDownList)controlChild).SelectedIndex = 
									int.Parse(strObjectValue);
							}
						}
					}
				}
			}
			catch( Exception x )
			{
			}

			return;
		}
	}
}
