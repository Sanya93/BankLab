using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using Access = Microsoft.Office.Interop.Access;
using System.Runtime.Remoting.Lifetime;


namespace BankLab
{
public class DBBankLabFunctions 
{
	private OleDbCommandBuilder I_OleCommandBuilder;
	private OleDbConnection I_OleConnection;
	private OleDbDataAdapter I_OleDataAdapter;
	private DataSet ResultDataSet;
	private Form Parent;

	/// <summary>
	/// Если требуется создать новую базу данных, то необходимо
	/// вызвать статичный метод CreateDataBase.
	/// </summary>
	/// <param name="path"></param>
	public DBBankLabFunctions(string path, Form parent)
	{
		I_OleConnection = new OleDbConnection(
								"Provider=Microsoft.ACE.OLEDB.12.0;" + "OLE DB Services = -1;" +
								"Data Source=" + path);
		I_OleDataAdapter = new OleDbDataAdapter();
		ResultDataSet = new DataSet();
		Parent = parent;
	}

	public DBBankLabFunctions(OleDbConnection OleConnection, Form parent)
	{
		I_OleConnection = OleConnection;
		I_OleDataAdapter = new OleDbDataAdapter();
		ResultDataSet = new DataSet();
		Parent = parent;
	}

	~DBBankLabFunctions()
	{
	}

	public void FreeDB()
	{

		//ResultDataSet.;
		//I_OleDataAdapter.InitializeLifetimeService;
		//ILease gg = (ILease)I_OleConnection.InitializeLifetimeService();
		//gg.InitialLeaseTime = TimeSpan.FromMilliseconds(1000);
		//MessageBox.Show(gg.CurrentLeaseTime.ToString());
		//OleDbConnection.ReleaseObjectPool();
		//I_OleConnection.Dispose();
	}

	public bool OpenTable(string TableName)
	{
		try {
				OleDbCommand Command = new OleDbCommand();
				//I_OleConnection.Open();
				Command.CommandText = "SELECT * FROM " + TableName;
				Command.Connection = I_OleConnection;
				I_OleDataAdapter.SelectCommand = Command;
				I_OleCommandBuilder = new OleDbCommandBuilder(I_OleDataAdapter);
				ResultDataSet.Tables.Clear();
				I_OleDataAdapter.Fill(ResultDataSet, TableName);
				//I_OleConnection.Close();
				return true;
			}
		catch (System.Data.OleDb.OleDbException ex) { 
			I_OleConnection.Close();
			return false;
		}
	}

	public DataSet GetDataSet() 
	{
		return ResultDataSet;
	}

	public static int CreateDataBase(string path)
	{
		Access.Application AccessAplication = new Access.Application();
		AccessAplication.NewCurrentDatabase(path,Access.AcNewDatabaseFormat.acNewDatabaseFormatUserDefault);
		AccessAplication.CloseCurrentDatabase();
		AccessAplication.Quit();
		return 0;
	}
	
	public int DeleteTable(string TableName)
	{
		try {
			string query = "DROP TABLE " + "`" + TableName + "`";
			I_OleConnection.Open();
			OleDbCommand comm = new OleDbCommand(query, I_OleConnection);
			comm.ExecuteNonQuery();
			I_OleConnection.Close();
		}
		catch (Exception ex) {
			I_OleConnection.Close();
			return 0;
		}
		return 1;
	}

	public int CreateDataBaseTemplate(string TableName)
	{
		string Query = "CREATE TABLE " + TableName +
					   "(years number CONSTRAINT years PRIMARY KEY";
		for (int i = 1; i < 19; i++) {
			Query += " , X" + i.ToString() + " text";
		}
		for (int i = 1; i <= 7; i++) {
			Query += " , K" + i.ToString() + " text";
		}
		Query += ")";
		I_OleConnection.Open();
		OleDbCommand command = new OleDbCommand(Query, I_OleConnection);
		try {
			command.ExecuteNonQuery();
		}
		catch (OleDbException ex) {
			I_OleConnection.Close();
			return 0;
		}
		I_OleConnection.Close();
		return 1;
	}

	public int SaveTable(string TableName, DataGridView SourceTable)
	{
		if ((OpenTable(TableName))) {
			DialogResult Result = MessageBox.Show("Вы хотите заменить таблицу?", 
												  "Таблица с таким именем существует", 
												  MessageBoxButtons.OKCancel, 
												  MessageBoxIcon.Question);
			if (Result == DialogResult.OK) {
					DeleteTable(TableName);
			}
			else {
				return 0;
			}
		}
		int CreateResult = CreateDataBaseTemplate(TableName);
		if (CreateResult == 0) {
			DialogResult Result = MessageBox.Show("Невозможно сохранить таблицу с таким именем!",
												  "Продолжить сохранение?",
												   MessageBoxButtons.YesNo,
												   MessageBoxIcon.Exclamation);
			if (Result == DialogResult.Yes) {
				save_form MDISaveForm = new save_form(null, null);
				object[] Args = new object[2];
				Args[0] = (BankLab)SourceTable.Parent;
				Args[1] = SourceTable;
				((BankLab)SourceTable.Parent).MDI.ShowMDIForm(MDISaveForm, Args);
				return -1;
			}
		}
		string Query;
		OleDbCommand command;
		I_OleConnection.Open();
		string Fields = " (years";
		for (int i = 1; i < SourceTable.ColumnCount; i++) {
			Fields += " , X" + i.ToString();
		}
		Fields += ")";
		for (int i = 0; i < SourceTable.RowCount; i++) {
			Query = "INSERT INTO " + TableName +
						Fields + " VALUES (";
			for (int j = 0; j < SourceTable.ColumnCount; j++) {
				if (SourceTable.Rows[i].Cells[j].Value == null) {
					Query += "'" + "'" + ",";
				}
				else {
					Query += "'" + SourceTable.Rows[i].Cells[j].Value.ToString() + "'" + ",";
				}
			}
			Query = Query.Remove(Query.Length - 1);
			Query += ")";
			command = new OleDbCommand(Query, I_OleConnection);
			command.ExecuteNonQuery();
		}
		I_OleConnection.Close();
		OpenTable(TableName);
		((BankLab)SourceTable.Parent).CurrentDataTable.LinkDataTableToDataSet();
		return 1;
	}

	public void UpdateTableData(DataSet data, string tableName)
	{
		I_OleConnection.Open();
		I_OleDataAdapter.Update(data, tableName); 
		I_OleConnection.Close();
	}

	public List<string> GetTableList() {
		DataTable I_DataTable = new DataTable();
		I_OleConnection.Open();
		I_DataTable = I_OleConnection.GetOleDbSchemaTable(
						 OleDbSchemaGuid.Tables,
						 new object[] { null, null, null, "TABLE" });
		List<string> table_list = new List<string>();
		foreach (DataRow item in I_DataTable.Rows) {
			table_list.Add((string)item["TABLE_NAME"]);
		}
		I_OleConnection.Close();
		return table_list;
	}
}
}