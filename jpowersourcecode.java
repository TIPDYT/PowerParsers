package tipdyt.power;

import java.util.HashMap;


public class PowerData {
	static private String CurrentData;
	static private HashMap<String, Object> Parsed = new HashMap<String, Object>();
	static public void NewFile(String Data) {
		CurrentData = Data;
		String newline = System.lineSeparator();
		String[] splitted = Data.split(newline);
		for (String line : splitted) {
			if (line.startsWith("$")) {
				String varname;
				String varvalue;
				int indexofequal = line.indexOf("=");
				varname = line.substring(1, indexofequal).replace("=", "");
				varvalue = line.substring(indexofequal, line.length()).replace("=", "");
				Parsed.put(varname, varvalue);
			}
		}
	}
	static public Object GetValue(String VariableName){
		return Parsed.get(VariableName);
	}
	static public void ClearData() {
		Parsed.clear();
	}
	static public String GetCurrentData() {
		return CurrentData;
	}
	static public void AddData(String VariableName, Object VariableValue) {
		Parsed.put(VariableName, VariableValue);
		CurrentData = CurrentData + System.lineSeparator() + "$" + VariableName + "=" + VariableValue;
	}
}
