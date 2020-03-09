using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;


namespace mvwater_netfw
{
    class parseXml
    {
        //Frame adapted from kim3-sudo Chisel
        //https://github.com/kim3-sudo/chisel/blob/master/xmlparse.cs as of hash 77a5740

        string databaseType = string.Empty;
        string serverName = string.Empty;
        string username = string.Empty;
        string password = string.Empty;

        //create a function called settingsParser that reads in settings document and parses it
        public string[] settingsParser(string shortUserFileName)
        {

            //allow messageboxes to be shown
            var showInfoBox = new messageBox();

            //initialize a new instance of the XmlDocument class
            XmlDocument settingsXDoc = new XmlDocument();

            //declare the default settings filename as a string
            string settingsXDocFName = "default.xml";

            //force a valid settings doc
            bool validDoc = false;
            while (validDoc == false)
            {
                //if settings document field is left empty, then use default.xml doc

                string settingsPath = string.Empty;
                settingsPath = Directory.GetCurrentDirectory() + @"\default.xml";
                //if the user specifies a filename...
                if (shortUserFileName != "")
                {
                    //SPECIFY A NEW SETTINGS DOC
                    //assume settings doc is valid for now...will update during error checking
                    validDoc = true;

                    string settingsFilename = string.Empty;
                    settingsFilename = shortUserFileName;
                    settingsPath = Directory.GetCurrentDirectory() + @"\settings\";
                    settingsXDocFName = string.Concat(settingsPath, settingsFilename);

                    //show a messagebox with the user's chosen settings file
                    string infoMessage = string.Empty;
                    infoMessage = "Informational: Using " + shortUserFileName + " settings file.";
                    getMessage.theMessage = infoMessage;

                    try //to load the XML file
                    {
                        settingsXDoc.Load(settingsXDocFName);
                    }
                    catch //a failed load
                    {
                        //show a messagebox with the error
                        string errorMessage = "ERROR 10: Unable to read the settings XML file.";
                        //pass the error message into the messagebox function
                        getMessage.theMessage = errorMessage;
                        validDoc = false;
                    }

                    try //to get information from tag names
                    {
                        //Xml parsing in c# document load
                        settingsXDoc.Load(settingsXDocFName);

                        //store matching tags in new variables by XML node
                        XmlNodeList xmlDatabaseType = settingsXDoc.GetElementsByTagName("databaseType");
                        XmlNodeList xmlServerName = settingsXDoc.GetElementsByTagName("serverName");
                        XmlNodeList xmlUsername = settingsXDoc.GetElementsByTagName("username");
                        XmlNodeList xmlPassword = settingsXDoc.GetElementsByTagName("password");
                    }
                    catch
                    {
                        //show a messagebox with the error
                        string errorMessage = "ERROR 11: Settings load failure or failure during reading.";
                        //pass the error message into the messagebox function
                        getMessage.theMessage = errorMessage;
                        validDoc = false;
                    }

                    try
                    {
                        //Xml parsing in c# document load
                        settingsXDoc.Load(settingsXDocFName);

                        //store matching tags in new variables by XML node
                        XmlNodeList xmlDatabaseType = settingsXDoc.GetElementsByTagName("databaseType");
                        XmlNodeList xmlServerName = settingsXDoc.GetElementsByTagName("serverName");
                        XmlNodeList xmlUsername = settingsXDoc.GetElementsByTagName("username");
                        XmlNodeList xmlPassword = settingsXDoc.GetElementsByTagName("password");

                        //convert XmlNodeList objects to strings
                        databaseType = xmlDatabaseType.ToString();
                        serverName = xmlServerName.ToString();
                        username = xmlUsername.ToString();
                        password = xmlPassword.ToString();

                        //error checking complete; XML document should be syntactically correct
                        validDoc = true;
                    }
                    catch //a settings conversion failure into strings
                    {
                        //show a messagebox with the error
                        string errorMessage = "ERROR 12: Settings conversion failure.";
                        //pass the error message into the messagebox function
                        getMessage.theMessage = errorMessage;
                        validDoc = false;
                    }

                    //noting to convert to a different filetype

                    //in case it wasn't specified earlier, reinforce...
                    validDoc = true;
                }
                else if (shortUserFileName == "")
                {
                    //use the default.xml doc
                    settingsPath = Directory.GetCurrentDirectory() + @"\settings\default.xml";
                    settingsXDocFName = "default.xml";
                    string settingsXml = string.Empty;

                    //show a messagebox with the user's chosen settings file
                    // code needs to go here for hte message box for confirmation
                    // write a class/function pair to do this
                    string infoMessage = string.Empty;
                    infoMessage = "Informational: Using default.xml settings file.";

                    try //to load the XML file
                    {
                        settingsXDoc.Load(settingsXDocFName);
                    }
                    catch //a failed load
                    {
                        //show a messagebox with the error
                        string errorMessage = "ERROR 10: Unable to read the settings XML file.";
                        //pass the error message into the messagebox function
                        getMessage.theMessage = errorMessage;
                        validDoc = false;
                    }

                    try //to get information from tag names
                    {
                        //Xml parsing in c# document load
                        settingsXDoc.Load(settingsXDocFName);

                        //store matching tags in new variables by XML node
                        XmlNodeList xmlDatabaseType = settingsXDoc.GetElementsByTagName("databaseType");
                        XmlNodeList xmlServerName = settingsXDoc.GetElementsByTagName("serverName");
                        XmlNodeList xmlUsername = settingsXDoc.GetElementsByTagName("username");
                        XmlNodeList xmlPassword = settingsXDoc.GetElementsByTagName("password");
                    }
                    catch
                    {
                        //show a messagebox with the error
                        string errorMessage = "ERROR 11: Settings load failure or failure during reading.";
                        //pass the error message into the messagebox function
                        getMessage.theMessage = errorMessage;
                        validDoc = false;
                    }

                    try
                    {
                        //Xml parsing in c# document load
                        settingsXDoc.Load(settingsXDocFName);

                        //store matching tags in new variables by XML node
                        XmlNodeList xmlDatabaseType = settingsXDoc.GetElementsByTagName("databaseType");
                        XmlNodeList xmlServerName = settingsXDoc.GetElementsByTagName("serverName");
                        XmlNodeList xmlUsername = settingsXDoc.GetElementsByTagName("username");
                        XmlNodeList xmlPassword = settingsXDoc.GetElementsByTagName("password");

                        //convert XmlNodeList objects to strings
                        databaseType = xmlDatabaseType.ToString();
                        serverName = xmlServerName.ToString();
                        username = xmlUsername.ToString();
                        password = xmlPassword.ToString();

                        //error checking complete; XML document should be syntactically correct
                        validDoc = true;
                    }
                    catch //a settings conversion failure into strings
                    {
                        //show a messagebox with the error
                        string errorMessage = "ERROR 12: Settings conversion failure.";
                        //pass the error message into the messagebox function
                        getMessage.theMessage = errorMessage;
                        validDoc = false;
                    }

                    //noting to convert to a different filetype

                    //in case it wasn't specified earlier, reinforce...
                    validDoc = true;
                }
            }
            string[] comboinfo = new string[4];
            comboinfo[0] = databaseType;
            comboinfo[1] = serverName;
            comboinfo[2] = username;
            comboinfo[3] = password;

            return comboinfo;
        }
    }
}
