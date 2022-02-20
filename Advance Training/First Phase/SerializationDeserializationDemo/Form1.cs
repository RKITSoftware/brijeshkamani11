using Newtonsoft.Json;
using SerializationDeserializationDemo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace SerializationDeserializationDemo
{
    /// <summary>
    /// Startup Form of this application
    /// </summary>
    public partial class Form1 : Form
    {
        #region Private Fields
        private const string _jsonFilePath = "../../Backup/Backup_JSON.json";
        private const string _xmlFilePath = "../../Backup/Backup_XML.xml";
        private const string _binaryFilePath = "../../Backup/Backup_Binary.dat";
        private string _previewText;
        #endregion

        #region Constructors

        /// <summary>
        /// Will Load All Form Component of Form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Events Methods

        /// <summary>
        /// Called after Form Loaded Successfully.
        /// Will Create Backup Folder and Load previously saved Data.
        /// </summary>
        /// <param name="sender">
        /// Hold Current form Object.
        /// </param>
        /// <param name="e">
        /// Contains Event Arguments.
        /// </param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // For Backup in Our Data
            Directory.CreateDirectory("../../Backup");

            // load old Data if previously saved.
            if (File.Exists(_jsonFilePath))
                DGVEmployee.DataSource = new BindingSource(DeserializeFromJSON(), "");
        }

        /// <summary>
        /// Called After Backup Button Clicked.
        /// For Save Data From Table in Particular Formate into Local File.
        /// </summary>
        /// <param name="sender">
        /// Contains Object Of Button Class.
        /// </param>
        /// <param name="e">
        /// Contains Argument Data.
        /// </param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Load Table Data Into List of Employees.
            List<Employee> objEmployees = new List<Employee>();
            foreach (DataGridViewRow objDaraGridViewRow in DGVEmployee.Rows)
            {
                Employee objEmployee = (Employee)objDaraGridViewRow.DataBoundItem;
                if (objEmployee != null)
                {
                    objEmployees.Add(objEmployee);
                }

            }

            // Backup List of Employee only if User Selected Proper Formate.
            if (cb_formateType.SelectedIndex != -1)
            {
                // Checking Which Formate User Selected.
                switch (cb_formateType.SelectedItem.ToString())
                {
                    case "JSON": Backup_JSON(objEmployees); break;
                    case "XML": Backup_XML(objEmployees); break;
                    case "Binary": Backup_Binary(objEmployees); break;

                }

            }

            // Update Preview Text after new Backup Data.
            richTextBox1.Text = _previewText;
        }

        /// <summary>
        /// Called After Restore Button Clicked.
        /// For Restore saved Data From file into Table..
        /// </summary>
        /// <param name="sender">
        /// Contains Object Of Button Class.
        /// </param>
        /// <param name="e">
        /// Contains Argument Data.
        /// </param>
        private void button2_Click(object sender, EventArgs e)
        {
            // Backup List of Employee only if User Selected Proper Formate. 
            if (cb_formateType.SelectedIndex != -1)
            {

                List<Employee> objEmployee = null;

                // Checking Which Formate User Selected.
                switch (cb_formateType.SelectedItem.ToString())
                {
                    case "JSON":
                        objEmployee = Restore_JSON();
                        break;
                    case "XML":
                        objEmployee = Restore_XML();
                        break;
                    case "Binary":
                        objEmployee = Restore_Binary();
                        break;

                }

                // Check If Backup of Selected Type is found or not.
                if (objEmployee == null)
                {
                    MessageBox.Show("Backup of " + cb_formateType.SelectedItem.ToString() + " not Found!");
                }
                else
                {
                    // Restoring Data into Table if Backup found
                    DGVEmployee.DataSource = new BindingSource(objEmployee, "");
                    richTextBox1.Text = _previewText;
                }
            }
        }
        #endregion

        #region Private Methods

        /// <summary>
        /// It will serialize List of Employee object into JSON string.
        /// </summary>
        /// <param name="objEmployees"> Contains Data of List of Employees. </param>
        /// <returns> string contains Data of List of Employees in JSON formate. </returns>
        private string SerializeIntoJSON(List<Employee> objEmployees)
        {
            return JsonConvert.SerializeObject(objEmployees);
        }

        /// <summary>
        /// It will De-serialize object from JSON string of Backup_JSON file into List of Employee Object..
        /// </summary>
        /// <returns> List of Employees object that backup from File or null if Backup not found. </returns>
        private List<Employee> DeserializeFromJSON()
        {
            if (File.Exists(_jsonFilePath))
                return JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText(_jsonFilePath));
            return null;
        }

        /// <summary>
        /// It will serialize List of Employee object into XML string.
        /// </summary>
        /// <param name="objEmployees"> Contains Data of List of Employees. </param>
        /// <returns> string contains Data of List of Employees in XML formate. </returns>
        private string SerializeIntoXML(List<Employee> objEmployees)
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Employee>));
            using (StringWriter stringWriter = new StringWriter())
            {
                xmlserializer.Serialize(stringWriter, objEmployees);
                return stringWriter.ToString();
            }
        }

        /// <summary>
        /// It will De-serialize object from XML string of Backup_XML file into List of Employee Object..
        /// </summary>
        /// <returns> List of Employees object that backup from File or null if Backup not found. </returns>
        private List<Employee> DeserializeFromXML()
        {
            if (File.Exists(_xmlFilePath))
            {
                XmlSerializer xmlDeserializer = new XmlSerializer(typeof(List<Employee>));
                using (TextReader reader = new StreamReader(_xmlFilePath))
                {
                    return (List<Employee>)xmlDeserializer.Deserialize(reader);
                }

            }
            return null;
        }

        /// <summary>
        /// It will Serialize Data of object of List of Employee into Binary formate and save Data in Backup_Binary file.
        /// </summary>
        /// <param name="objEmployees"> refer to object which data will be saved. </param>
        /// <returns> Boolean Value that indicate whether data successfully saved or not. </returns>
        private bool SerializeIntoBinary(List<Employee> objEmployees)
        {
            try
            {
                using (FileStream objFileStream = new FileStream(_binaryFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    new BinaryFormatter().Serialize(objFileStream, objEmployees);
                    MessageBox.Show("Data saved in " + _binaryFilePath.Substring(13) + " file in Backup Folder.");
                    return true;
                }
            }
            catch (IOException ie)
            {
                MessageBox.Show(ie.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            return false;

        }

        /// <summary>
        /// It will De-serialize object from Binary serialized formated file into List of Employee Object..
        /// </summary>
        /// <returns> List of Employees object that backup from File or null if Backup not found. </returns>
        private List<Employee> DeserializeFromBinary()
        {
            if (File.Exists(_binaryFilePath))
            {
                using (FileStream filestream = new FileStream(_binaryFilePath, FileMode.OpenOrCreate))
                {
                    return (List<Employee>)new BinaryFormatter().Deserialize(filestream);
                }
            }
            return null;
        }

        /// <summary>
        /// It will Backup data of List of Employee into File in JSON Formate.
        /// </summary>
        /// <param name="objEmployees"> refer to Object Which data will be saved into File. </param>
        private void Backup_JSON(List<Employee> objEmployees)
        {
            // Serialize into string for Preview on Screen.
            _previewText = SerializeIntoJSON(objEmployees);

            // Saving String into File in JSON Formate.
            SaveStringToFile(_jsonFilePath, _previewText);

        }

        /// <summary>
        /// Restore Saved JSON Data from file.
        /// </summary>
        /// <returns> Objects data That Restored From File or null. </returns>
        private List<Employee> Restore_JSON()
        {
            List<Employee> objectEmployees = DeserializeFromJSON();
            if (objectEmployees != null)
            {
                // Changing Preview Text If Backup Found.
                _previewText = SerializeIntoJSON(objectEmployees);
                return objectEmployees;
            }
            return null;
        }

        /// <summary>
        /// It will Backup data of List of Employee into File in XML Formate.
        /// </summary>
        /// <param name="objEmployees"> refer to Object Which data will be saved into File. </param>
        private void Backup_XML(List<Employee> objEmployees)
        {
            // Serialize into string for Preview on Screen.
            _previewText = SerializeIntoXML(objEmployees);

            // Saving String into File in XML Formate.
            SaveStringToFile(_xmlFilePath, _previewText);
        }

        /// <summary>
        /// Restore Saved XML Data from file.
        /// </summary>
        /// <returns> Objects data That Restored From File or null. </returns>
        private List<Employee> Restore_XML()
        {
            List<Employee> objEmployees = DeserializeFromXML();
            if (objEmployees != null)
            {
                // Changing Preview Text If Backup Found.
                _previewText = SerializeIntoXML(objEmployees);
                return objEmployees;
            }
            return null;
        }

        /// <summary>
        /// It will Backup data of List of Employee into File in binary Formate.
        /// </summary>
        /// <param name="objEmployees"> refer to Object Which data will be saved into File. </param>
        private void Backup_Binary(List<Employee> objEmployees)
        {
            if (SerializeIntoBinary(objEmployees))
            {
                _previewText = BinaryToString();
            }
        }

        /// <summary>
        /// Restore Saved Binary formated Data from file.
        /// </summary>
        /// <returns> Objects data That Restored From File or null. </returns>
        private List<Employee> Restore_Binary()
        {
            List<Employee> employees = DeserializeFromBinary();
            if (employees != null)
            {
                _previewText = BinaryToString();
                return employees;
            }
            return null;
        }

        /// <summary>
        /// It will Save String Data into Given File Path.
        /// </summary>
        /// <param name="filepath"> Contains File Path Where Data Will be Saved. </param>
        /// <param name="stringdata"> Contain Data a String That will be saved. </param>
        private void SaveStringToFile(string filepath, string stringdata)
        {
            try
            {
                File.WriteAllText(filepath, stringdata);
                MessageBox.Show("Data saved in " + filepath.Substring(13) + " file in Backup Folder..");

            }
            catch (IOException ie)
            {
                MessageBox.Show(ie.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// It will generate human readable string from Binary formated saved file.
        /// </summary>
        /// <returns> saved binary data in string formate. </returns>
        private string BinaryToString()
        {
            if (!File.Exists(_binaryFilePath))
                return "";
            using (FileStream fs = new FileStream(_binaryFilePath, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (BinaryReader binaryReader = new BinaryReader(fs))
                {
                    return Convert.ToBase64String(binaryReader.ReadBytes(Convert.ToInt32(fs.Length)));
                }

            }

        }
        #endregion
    }
}
