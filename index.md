


# Рефакторинг кода предложенного на  собесе 
Предожили отрефакторить следующий код:
```csharp
public interface IMyClass1Saver
{
  void SaveAsXmlToFile(FileWriter fileWriter);
  void SaveAsXmlToDatabase(DatabaseWriter databaseWriter);
  void SaveAsJsonToFile(FileWriter fileWriter);
  void SaveAsJsonToDatabase(DatabaseWriter databaseWriter);
}

public class MyClass1 : IMyClass1Saver
{
	public string FNameRus;
  public string LNameRus;
  public string MNameRus;
  public string FNameEng;
  public string LNameEng;
  public string MNameEng;
  public string PassportNumber1;
  public string PassportNumber2;
  
  public string GetFullName(int language)
  {
  	if (language == 0)
    	return $"{LNameRus} {FNameRus} {MNameRus}";
    else if (language == 1)
    	return $"{LNameEng} {FNameEng} {MNameEng}";
    else
    	return null;
  }
  
  public void SaveAsXmlToFile(FileWriter fileWriter)
  {
  	XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
    var stringWriter = new StringWriter();
    XmlWriter xmlWriter = XmlWriter.Create(stringWriter);
    xmlSerializer.Serialize(xmlWriter, this);
    var xml = stringWriter.ToString();
    
    fileWriter.Write(xml);
    
    stringWriter.Dispose();
    xmlWriter.Dispose();
  }
  
  public void SaveAsXmlToDatabase(DatabaseWriter databaseWriter)
  {
  	XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
    var stringWriter = new StringWriter();
    XmlWriter xmlWriter = XmlWriter.Create(stringWriter);
    xmlSerializer.Serialize(xmlWriter, this);
    var xml = stringWriter.ToString();
    
    databaseWriter.Write(xml);
    
    stringWriter.Dispose();
    xmlWriter.Dispose();
  }
  
  public void SaveAsJsonToFile(FileWriter fileWriter)
  {
  	throw new NotSupportedException();
  }
  
  public void SaveAsJsonToDatabase(DatabaseWriter databaseWriter)
  {
  	throw new NotSupportedException();
  }
}

```
