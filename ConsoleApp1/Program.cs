using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"D:\04_Projects\ASDK-S32_SDK\sdk_codebase\tools\pex\Repositories\SDK_RELEASE_VERSION_ID_Repository\CPUs\S32K148_144\signal_configuration.xml";

            ParserSignal.signal_configuration sc = DeserialModuleSignal(file);

            ParserSignal.functional_properties_declarationsFunctional_property_declaration propertyDec = new ParserSignal.functional_properties_declarationsFunctional_property_declaration()
            {
                id = "InitValue",
                name = "Initial Value",
                description = "Initial Value"
            };

            List<ParserSignal.functional_properties_declarationsFunctional_property_declarationState_declaration> lstState = new List<ParserSignal.functional_properties_declarationsFunctional_property_declarationState_declaration>();

            lstState.Add(new ParserSignal.functional_properties_declarationsFunctional_property_declarationState_declaration()
            {
                id = "state_0",
                name = "Low",
                description = "Low"
            });

            lstState.Add(new ParserSignal.functional_properties_declarationsFunctional_property_declarationState_declaration()
            {
                id = "state_1",
                name = "High",
                description = "High",
            });

            propertyDec.state_declaration = lstState.ToArray();

            List<ParserSignal.functional_properties_declarationsFunctional_property_declaration> lstFuncProperty = new List<ParserSignal.functional_properties_declarationsFunctional_property_declaration>();
            List<ParserSignal.pinsPin> lstPins = new List<ParserSignal.pinsPin>();


            bool haveInit = false;

            foreach (var item in sc.functional_properties_declarations)
            {
                lstFuncProperty.Add(item);
                haveInit = true;
            }

            if (!haveInit)
            {
                lstFuncProperty.Add(propertyDec);
            }

            sc.functional_properties_declarations = lstFuncProperty.ToArray();



            // list functional property
            ParserSignal.pinsPinFunctional_property pinFunc = new ParserSignal.pinsPinFunctional_property();

            List<ParserSignal.pinsPinFunctional_propertyState> lstPinsFuncState = new List<ParserSignal.pinsPinFunctional_propertyState>();

            lstPinsFuncState.Add(new ParserSignal.pinsPinFunctional_propertyState()
            {
                id = "state_0",
                configuration = new ParserSignal.pinsPinFunctional_propertyStateConfiguration()
                {
                    assign = new ParserSignal.pinsPinFunctional_propertyStateConfigurationAssign()
                    {
                        bit_field_value = "0"
                    }
                }

            });

            lstPinsFuncState.Add(new ParserSignal.pinsPinFunctional_propertyState()
            {
                id = "state_1",
                configuration = new ParserSignal.pinsPinFunctional_propertyStateConfiguration()
                {
                    assign = new ParserSignal.pinsPinFunctional_propertyStateConfigurationAssign()
                    {
                        bit_field_value = "0x1"
                    }
                }
            });

            pinFunc.id = "InitValue";
            pinFunc.@default = "state_0";
            pinFunc.state = lstPinsFuncState.ToArray();

            foreach (var item in sc.pins)
            {
                if (!item.name.Contains("PT"))
                {
                    lstPins.Add(item);
                    continue;
                }

                List<ParserSignal.pinsPinFunctional_property> lstPinsFunc = new List<ParserSignal.pinsPinFunctional_property>();

                haveInit = false;
                foreach (var item2 in item.functional_properties)
                {
                    lstPinsFunc.Add(item2);
                    if (item2.id.Contains("InitValue"))
                    {
                        haveInit = true;
                    }
                }

                if (!haveInit)
                {
                    lstPinsFunc.Add(pinFunc);
                }

                item.functional_properties = lstPinsFunc.ToArray();

                lstPins.Add(item);
            }


            sc.pins = lstPins.ToArray();

            SerialModuleSignal(sc, "outSignal.xml");


            ///////////////////////////////////////////////////////////////////////////////////////
            ///
            ///////////////////////////////////////////////////////////////////////////////////////
            // Property 
            string fileProperty = @"d:\04_Projects\ASDK-S32_SDK\sdk_codebase\tools\pex\Repositories\SDK_RELEASE_VERSION_ID_Repository\CPUs\S32K148_144\property_model_configuration.xml";
            ParserProperty.property_configuration pc = DeserialModuleProperty(fileProperty);

            List<ParserProperty.propertiesEnum_property> lstProperty = new List<ParserProperty.propertiesEnum_property>();

            List<ParserProperty.propertiesEnum_propertyState> lstEnumState = new List<ParserProperty.propertiesEnum_propertyState>();

            lstEnumState.Add(new ParserProperty.propertiesEnum_propertyState() { id = "state_0", caption = "Initial Value is configured on the corresponding pin", description = "Initial Value is configured on the corresponding pin" });
            lstEnumState.Add(new ParserProperty.propertiesEnum_propertyState() { id = "state_1", caption = "Initial Value is configured on the corresponding pin", description = "Initial Value is configured on the corresponding pin" });


            string pattern = @"(PORT\w)_PCR(\d+)_(\w+)";

            string currID = "0";
            string preID = "0";
            string prePort = "PORTA";

            foreach (var item in pc.properties)
            {
                foreach (Match item2 in Regex.Matches(item.id, pattern))
                {
                    if (item2.Groups[3].Value.Equals("InitValue"))
                    {
                        break;
                    }

                    currID = item2.Groups[2].Value;

                    if (preID.CompareTo(currID) != 0)
                    {
                        ParserProperty.propertiesEnum_property pt = new ParserProperty.propertiesEnum_property();
                        pt.caption = "Initial Value";
                        pt.description = "Initial Value";
                        pt.@default = "state_0";
                        pt.state = lstEnumState.ToArray();

                        pt.id = string.Format("{0}_PCR{1}_InitValue", prePort, preID);

                        preID = currID;
                        prePort = item2.Groups[1].Value;

                        lstProperty.Add(pt);

                    }
                }

                if (!item.id.Contains("InitValue"))
                {
                    lstProperty.Add(item);
                }
            }
            pc.properties = lstProperty.ToArray();
            SerialModuleProperty(pc, "outProperty.xml");

            ///////////////////////////////////////////////////////////////////////////////////////
            ///
            ///////////////////////////////////////////////////////////////////////////////////////
            // Item
            string fileItem = @"D:\04_Projects\ASDK-S32_SDK\sdk_codebase\tools\pex\Repositories\SDK_RELEASE_VERSION_ID_Repository\Beans\PinSettings\IncS32K148_144.item";
            ParserItem.ListItem pi = DeserialModuleItem(fileItem);
            ParserItem.ListItemTGrupItem tGrupItem = new ParserItem.ListItemTGrupItem();
            tGrupItem = pi.TGrupItem;


            // Add a new field
            ParserItem.ListItemTGrupItemGrupItemTGrupItemEditorDataElectrical_property itemElectricalPro = new ParserItem.ListItemTGrupItemGrupItemTGrupItemEditorDataElectrical_property()
            {
                name = "Initial Value",
                brief_name = "Initial Value",
                symbol_suffix = "_InitValue"
            };

            List<ParserItem.ListItemTGrupItemGrupItem> lstGrupItemLevel2 = new List<ParserItem.ListItemTGrupItemGrupItem>();



            foreach (var item in tGrupItem.Children)
            {
                if (item.TGrupItem.Name.Equals("Electrical properties"))
                {
                    // Add electrical property
                    List<ParserItem.ListItemTGrupItemGrupItemTGrupItemEditorDataElectrical_property> lstElect = new List<ParserItem.ListItemTGrupItemGrupItemTGrupItemEditorDataElectrical_property>();

                    bool haveInitValueItemProp = false;
                    foreach (var item2 in item.TGrupItem.EditorData.electrical_properties_declarations)
                    {
                        lstElect.Add(item2);
                        haveInitValueItemProp = true;
                    }

                    if (!haveInitValueItemProp)
                    {
                        lstElect.Add(itemElectricalPro);
                    }

                    item.TGrupItem.EditorData.electrical_properties_declarations = lstElect.ToArray();


                    List<ParserItem.ListItemTGrupItemGrupItemTGrupItemGrupItem> lstChildren = new List<ParserItem.ListItemTGrupItemGrupItemTGrupItemGrupItem>();

                    // Add Initival value for each pin
                    foreach (var item2 in item.TGrupItem.Children)
                    {
                        List<ParserItem.ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItem> lstInitPins = new List<ParserItem.ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItem>();

                        bool haveInitValueItem = false;
                        foreach (var item3 in item2.TGrupItem.Children)
                        {
                            lstInitPins.Add(item3);
                            haveInitValueItem = true;
                        }

                        if (!haveInitValueItem)
                        {
                            if (item2.TGrupItem.Symbol.Contains("PT"))
                            {
                                // Add pin func prop item
                                ParserItem.ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPinFuncPropItem tPinFuncPropItem = new
                                    ParserItem.ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPinFuncPropItem()
                                {
                                    Name = "Initial Value Field",
                                    Hint = "Initial value control",
                                    ItemLevel = "BASIC",
                                    EditLine = true,
                                    DefaultValue = "<Automatic>",
                                    CanDelete = true,
                                    IconPopup = true,
                                    SortStyle = "alpha used eicons",
                                    PinFunctionalPropertyId = "InitValue",
                                    ForcePinName = String.Format("{0}", item2.TGrupItem.Symbol),
                                    Symbol = String.Format("{0}_InitValue", item2.TGrupItem.Symbol)
                                };

                                ParserItem.ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItem pinInit = new ParserItem.ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItem()
                                {
                                    TPinFuncPropItem = tPinFuncPropItem
                                };

                                lstInitPins.Add(pinInit);
                            }
                        }

                        item2.TGrupItem.Children = lstInitPins.ToArray();

                        lstChildren.Add(item2);
                    }

                    item.TGrupItem.Children = lstChildren.ToArray();
                }

                lstGrupItemLevel2.Add(item);
            }

            tGrupItem.Children = lstGrupItemLevel2.ToArray();
            pi.TGrupItem = tGrupItem;
            SerialModuleItem(pi, "outItem.xml");

            ///////////////////////////////////////////////////////////////////////////////////////
            ///
            ///////////////////////////////////////////////////////////////////////////////////////
            // prg
            StreamReader sr = new StreamReader(@"D:\04_Projects\ASDK-S32_SDK\sdk_codebase\tools\pex\Repositories\SDK_RELEASE_VERSION_ID_Repository\Beans\PinSettings\Drivers\S32K\PinSettings_S32K148_144.prg");

            string pat = @"(\s+)%:count=%get_item_config_sequence\(PT(\w+\d+)_(\w+),PinMuxInit\)";
            string str = sr.ReadToEnd();
            MatchCollection m = Regex.Matches(str, pat);

            string sepa = m[0].Groups[1].Value;

            StringBuilder sb = new StringBuilder();
            sb.Append(str);



            Lookup<String, String> ptLook;
            Lookup<String, String> lookMatch;
            List<KeyValuePair<string, string>> lstPT = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> lstMatch = new List<KeyValuePair<string, string>>();

            foreach (Match item in m)
            {
                lstPT.Add(new KeyValuePair<string, string>(item.Groups[2].Value, item.Groups[3].Value));
                lstMatch.Add(new KeyValuePair<string, string>(item.Groups[2].Value, item.Value));
            }
            ptLook = (Lookup<string, string>)lstPT.ToLookup((item) => item.Key, (item) => item.Value);
            lookMatch = (Lookup<string, string>)lstMatch.ToLookup((item) => item.Key, (item) => item.Value);

            List<string> lstKey = new List<string>();

            foreach (var item in ptLook)
            {
                lstKey.Add(item.Key);
            }
            

            foreach (var item in lstKey)
            {
                string[] a = ptLook[item.ToString()].ToArray();

                bool haveKeyInit = false;
                foreach (var item2 in a)
                {
                    if (item2.Contains("InitValue"))
                    {
                        haveKeyInit = true;
                        break;
                    }
                }

                if (!haveKeyInit)
                {
                    string s = string.Format("{0}{1}_{2},PinMuxInit)", sepa, "%:count=%get_item_config_sequence(PT" + item.ToString(), "InitValue");
                    string s2 = string.Format("{0}{1}", sepa, "%include Common\\GenInitConfigSequence.prg(PinMuxInit)");

                    sb.Replace(lookMatch[item.ToString()].ToArray()[0], s + s2 + lookMatch[item.ToString()].ToArray()[0]); 
                }
            }

            TextWriter sw = new StreamWriter("outPRG.prg");
            sw.Write(sb.ToString());
        }

        private static void SerialModuleSignal(ParserSignal.signal_configuration sc, string fileNameOut)
        {
            XmlSerializer xml = new XmlSerializer(typeof(ParserSignal.signal_configuration));

            using (TextWriter writer = new StreamWriter(fileNameOut))
            {
                xml.Serialize(writer, sc);
            }
        }

        private static ParserSignal.signal_configuration DeserialModuleSignal(string file)
        {
            XmlSerializer de = new XmlSerializer(typeof(ParserSignal.signal_configuration));
            TextReader reader = new StreamReader(file);

            object obj = de.Deserialize(reader);

            ParserSignal.signal_configuration config = (ParserSignal.signal_configuration)obj;

            reader.Close();

            return config;
        }


        private static void SerialModuleProperty(ParserProperty.property_configuration pc, string fileNameOut)
        {
            XmlSerializer xml = new XmlSerializer(typeof(ParserProperty.property_configuration));

            using (TextWriter writer = new StreamWriter(fileNameOut))
            {
                xml.Serialize(writer, pc);
            }
        }

        private static ParserProperty.property_configuration DeserialModuleProperty(string file)
        {
            XmlSerializer de = new XmlSerializer(typeof(ParserProperty.property_configuration));
            TextReader reader = new StreamReader(file);

            object obj = de.Deserialize(reader);

            ParserProperty.property_configuration config = (ParserProperty.property_configuration)obj;

            reader.Close();

            return config;
        }


        private static void SerialModuleItem(ParserItem.ListItem pi, string fileNameOut)
        {
            XmlSerializer xml = new XmlSerializer(typeof(ParserItem.ListItem));

            using (TextWriter writer = new StreamWriter(fileNameOut))
            {
                xml.Serialize(writer, pi);
            }
        }

        private static ParserItem.ListItem DeserialModuleItem(string file)
        {
            XmlSerializer de = new XmlSerializer(typeof(ParserItem.ListItem));
            TextReader reader = new StreamReader(file);

            object obj = de.Deserialize(reader);

            ParserItem.ListItem config = (ParserItem.ListItem)obj;

            reader.Close();

            return config;
        }

    }
}
