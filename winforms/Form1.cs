using System.Reflection;
using System.Text.Unicode;
using System;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CrearXML();
        }

        private static void CrearXML()
        {
            //XDocument xml = new XDocument(new XDeclaration("1.0", "UTF-8", "true"));

            //XNamespace cac = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2";
            XNamespace cbc = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2";
            //XNamespace ccts = "urn:un:unece:uncefact:documentation:2";
            //XNamespace ds = "http://www.w3.org/2000/09/xmldsig#";
            //XNamespace ext = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2";
            //XNamespace qdt = "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2";
            //XNamespace udt = "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2";
            //XNamespace xsi = "http://www.w3.org/2001/XMLSchema-instance";

            XElement invoice = new XElement(
                "Invoice",
                new XAttribute(XNamespace.Xmlns + "cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"),
                new XElement(cbc + "UBLVersionID", "TEXTO")
            );

            XDocument myDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "true"),
                invoice //, new XElement("Books", new XElement("Book", new XAttribute("ISBN-13", "978-0545139700"), new XElement("Title", " Harry Potter and the Deathly Hallows ")))
            );


            //xml.Save("C://EJB/test.xml");
            myDoc.Save("C://PerfLogs/test2.xml");
        }
    }
}