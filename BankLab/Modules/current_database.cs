using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLab.Modules
{
public class current_database
{
	public struct CurrentDataBase
	{
		public string TableName;
		public string DataBasePath;
		public DBBankLabFunctions I_CurrentDataBase;
	}

	private CurrentDataBase DataBase;  
	
	public current_database(string TableName, 
							string DataBasePath, 
							DBBankLabFunctions CurrentDataBase)
	{
		DataBase.I_CurrentDataBase = CurrentDataBase;
		DataBase.TableName = TableName;
		DataBase.DataBasePath = DataBasePath;
	}

	public current_database()
	{
		DataBaseClearValue();	
	}

	public string GetTableName()
	{
		return DataBase.TableName;
	}

	public void SetTableName(string Value)
	{
		DataBase.TableName = Value;
	}
	
	public string GetDatabasePath()
	{
		return DataBase.DataBasePath;
	}
	
	public void SetDataBasePath(string Value)
	{
		DataBase.DataBasePath = Value;
	}

	public void SetCurrentDataBase(DBBankLabFunctions Value)
	{
		DataBase.I_CurrentDataBase = Value;
	}

	public DBBankLabFunctions GetCurrentDataBase()
	{
		return DataBase.I_CurrentDataBase;
	}

	public CurrentDataBase GetDataBase()
	{
		return DataBase;
	}

	public void SetDataBase(CurrentDataBase Value)
	{
		DataBase = Value;
	}

	public void DataBaseClearValue()
	{
		DataBase.I_CurrentDataBase = null;
		DataBase.TableName = String.Empty;
		DataBase.DataBasePath = String.Empty;
	}
}
}