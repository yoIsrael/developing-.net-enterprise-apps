using System;

namespace IntegrationCommon
{
	/// <summary>
	/// Summary description for IIntegrationAdapter.
	/// </summary>
	public interface IIntegrationAdapter
	{
		void LoadConfigurationData();
		string ReadRecord( int intRecordID );
		string ReadAllRecords();
		bool WriteRecords( string strData );
		string SendToServer( string strData );
	}
}
