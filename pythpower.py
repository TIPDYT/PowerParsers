class PowerData:
    def __init__(self, data):
        self.Data = data
        self.Parsed = {}
        curlines = len(data.split("\n"))
        curtext = data.split("\n")
        for i in range(0, curlines, 1):
            if curtext[i].startswith("$"):
                index1 = curtext[i].find("=")
                self.Parsed[curtext[i][1:index1]] = curtext[i][index1:len(curtext[i])].replace("=", "")
    def GetValue(self, variablename):
        return self.Parsed[variablename]
    def AddData(self, variablename, variablevalue):
        self.Data = self.Data + "\n$" + variablename + "=" + variablevalue
        self.Parsed[variablename] = variablevalue
    def GetCurrentData(self):
        return self.Data
    def ClearData(self):
        self.Data = ""
        self.Parsed = {}