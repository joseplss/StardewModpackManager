using StardewModpackManager.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StardewModpackManager.services
{
    public class XmlService
    {
        // Create method that will create an XML file if it does not exist, and return the path to the XML file
        public string CreateXmlFileIfNotExists()
        {
            try {
                string basePath = CommonUtils.CreateFolderIfNotExists("StardewModpackManagerData");
                string xmlFilePath = System.IO.Path.Combine(basePath, "userConfig.xml");
                if (!System.IO.File.Exists(xmlFilePath))
                {
                    XmlDocument doc = new System.Xml.XmlDocument();

                    // Create the root <configuration> element
                    XmlElement root = doc.CreateElement("configuration");
                    doc.AppendChild(root);

                    // Create the <userProfile> element and append it to <configuration>
                    XmlElement userProfile = doc.CreateElement("userProfile");
                    root.AppendChild(userProfile);

                    // Save the XML document to the specified path
                    doc.Save(xmlFilePath);
                }
                else
                {
                    // If the file exists, ensure <userProfile> exists as a direct child of <configuration>
                    XmlDocument doc = new System.Xml.XmlDocument();
                    doc.Load(xmlFilePath);

                    if (doc.DocumentElement == null || doc.DocumentElement.Name != "configuration")
                        throw new InvalidOperationException("Root element must be <configuration>.");

                    if (doc.DocumentElement.SelectSingleNode("userProfile") == null)
                    {
                        XmlElement userProfile = doc.CreateElement("userProfile");
                        doc.DocumentElement.AppendChild(userProfile);
                        doc.Save(xmlFilePath);
                    }
                }
                return xmlFilePath;
            } catch (Exception ex)
            {
                Console.WriteLine($"Failed to create or validate XML file at base directory.", ex);
                return String.Empty;
            }
        }

        private void SetXMLValue(XmlDocument doc, string parentNodeName, string childNodeName, string value)
        {
            XmlNode? parentNode = doc.SelectSingleNode($"/configuration/{parentNodeName}");
            if (parentNode == null)
            {
                throw new InvalidOperationException($"Parent node '{parentNodeName}' does not exist.");
            }
            var childNode = doc.CreateElement(childNodeName);
            childNode.InnerText = value;

            // Set key and value to child node
            XmlNode? existingNode = parentNode.SelectSingleNode(childNodeName);
            if (existingNode != null)
            {
                existingNode.InnerText = value; // Update existing node
            }
            else
            {
                parentNode.AppendChild(childNode); // Add new child node
            }
        }

        public void AddXMLKeyValue(string xmlFilePath, string parentNode, string key, string value)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFilePath);
            // Ensure the root element is <configuration>
            if (doc.DocumentElement == null || doc.DocumentElement.Name != "configuration")
                throw new InvalidOperationException("Root element must be <configuration>.");
            // Create <{parentNode}></{parentNode}> element if it doesn't exist
            XmlNode? userProfile = doc.SelectSingleNode($"/configuration/{parentNode}");
            if (userProfile == null)
            {
                userProfile = doc.CreateElement(parentNode);
                doc.DocumentElement.AppendChild(userProfile);
            }
            // Set child nodes for userName and userEmail
            SetXMLValue(doc, parentNode, key, value);
            // Save the changes to the XML file
            doc.Save(xmlFilePath);
        }

        public string GetXMLKeyValue(string xmlFilePath, string key) 
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlFilePath);
                // Ensure the root element is <configuration>
                if (doc.DocumentElement == null || doc.DocumentElement.Name != "configuration")
                    throw new InvalidOperationException("Root element must be <configuration>.");
                // Get the value of the specified key
                XmlNode? node = doc.SelectSingleNode($"/configuration/userProfile/{key}");
                return node?.InnerText ?? string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to get XML key value for '{key}' from '{xmlFilePath}'.", ex);
                return string.Empty;
            }
        }

    }
}
