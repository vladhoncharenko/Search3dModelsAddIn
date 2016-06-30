using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Search3dModels.Model
{
    [XmlRoot(elementName:"Settings")]
    public  class SettingsClass

    {
        public static SettingsClass instance;
        public SettingsClass() {}

        [XmlElement("Login")]
        public  string login{ get;  set;}

        [XmlElement("Password")]
        public  string password{ get;  set;}

        [XmlElement("ModelsPath")]
        public  string modelsPath{ get;  set;}       

        public static SettingsClass Instance{
            get{
                if (instance == null){
                    instance = new SettingsClass();
                }
                return instance;
            }
        }
        private string textToWrite = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n" +
                      "<Settings xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\n" +
                      "<Login></Login>\n<Password></Password>\n<ModelsPath></ModelsPath>\n</Settings>";
       
         public bool WriteSettings(){ 
            try{
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(SettingsClass));

            string curFile = @"C:\SolidWorks Data\search3DModels.xml";
            if(!File.Exists(curFile)){
            System.IO.File.Create(@"C:\SolidWorks Data\search3DModels.xml").Dispose(); ;
            System.IO.File.WriteAllText(@"C:\SolidWorks Data\search3DModels.xml", textToWrite);
            }


            using (var myWriter = new StreamWriter(@"C:\SolidWorks Data\search3DModels.xml"))
            {
                writer.Serialize(myWriter, Instance);
                myWriter.Close();
            }

            }catch (Exception e){
                 MessageBox.Show(e.Message, "readSettings()", MessageBoxButtons.OK);
                 return false;
            }
            return true;
         }


      public bool ReadSettings()
      {
          try{
              string curFile = @"C:\SolidWorks Data\search3DModels.xml";
              if (!File.Exists(curFile))
              {
                  System.IO.File.Create(@"C:\SolidWorks Data\search3DModels.xml").Dispose();                 
                  System.IO.File.WriteAllText(@"C:\SolidWorks Data\search3DModels.xml", textToWrite);
              }
              var serializer = new XmlSerializer(typeof(SettingsClass));
              using (var reader = new StreamReader(@"C:\SolidWorks Data\search3DModels.xml")){
                  SettingsClass deserialize = (SettingsClass)serializer.Deserialize(reader);
                  login = deserialize.login;
                  password = deserialize.password;
                  modelsPath = deserialize.modelsPath;
              }
          }catch (Exception e) {
              MessageBox.Show(e.Message, "readSettings()", MessageBoxButtons.OK);
              return false;
          }
          return true;
      }
    }
 }

