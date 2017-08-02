using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ParserSignal
    {
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.freescale.com/ProcessorExpert/PinsModel")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.freescale.com/ProcessorExpert/PinsModel", IsNullable = false)]
        public partial class signal_configuration
        {

            private part_information part_informationField;

            private peripheral_typesPeripheral_type[] peripheral_typesField;

            private peripheralsPeripheral[] peripheralsField;

            private object routing_aliasesField;

            private package_functionsPackage_function[] package_functionsField;

            private non_peripheral_pin_functions non_peripheral_pin_functionsField;

            private functional_properties_declarationsFunctional_property_declaration[] functional_properties_declarationsField;

            private pinsPin[] pinsField;

            private object signal_routesField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
            public part_information part_information
            {
                get
                {
                    return this.part_informationField;
                }
                set
                {
                    this.part_informationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute(Namespace = "")]
            [System.Xml.Serialization.XmlArrayItemAttribute("peripheral_type", IsNullable = true)]
            public peripheral_typesPeripheral_type[] peripheral_types
            {
                get
                {
                    return this.peripheral_typesField;
                }
                set
                {
                    this.peripheral_typesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute(Namespace = "")]
            [System.Xml.Serialization.XmlArrayItemAttribute("peripheral", IsNullable = false)]
            public peripheralsPeripheral[] peripherals
            {
                get
                {
                    return this.peripheralsField;
                }
                set
                {
                    this.peripheralsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
            public object routing_aliases
            {
                get
                {
                    return this.routing_aliasesField;
                }
                set
                {
                    this.routing_aliasesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute(Namespace = "")]
            [System.Xml.Serialization.XmlArrayItemAttribute("package_function", IsNullable = false)]
            public package_functionsPackage_function[] package_functions
            {
                get
                {
                    return this.package_functionsField;
                }
                set
                {
                    this.package_functionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
            public non_peripheral_pin_functions non_peripheral_pin_functions
            {
                get
                {
                    return this.non_peripheral_pin_functionsField;
                }
                set
                {
                    this.non_peripheral_pin_functionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute(Namespace = "")]
            [System.Xml.Serialization.XmlArrayItemAttribute("functional_property_declaration", IsNullable = false)]
            public functional_properties_declarationsFunctional_property_declaration[] functional_properties_declarations
            {
                get
                {
                    return this.functional_properties_declarationsField;
                }
                set
                {
                    this.functional_properties_declarationsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute(Namespace = "")]
            [System.Xml.Serialization.XmlArrayItemAttribute("pin", IsNullable = false)]
            public pinsPin[] pins
            {
                get
                {
                    return this.pinsField;
                }
                set
                {
                    this.pinsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
            public object signal_routes
            {
                get
                {
                    return this.signal_routesField;
                }
                set
                {
                    this.signal_routesField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class part_information
        {

            private part_informationPart_number part_numberField;

            /// <remarks/>
            public part_informationPart_number part_number
            {
                get
                {
                    return this.part_numberField;
                }
                set
                {
                    this.part_numberField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class part_informationPart_number
        {

            private string packageField;

            private string idField;

            private byte pinsField;

            /// <remarks/>
            public string package
            {
                get
                {
                    return this.packageField;
                }
                set
                {
                    this.packageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte pins
            {
                get
                {
                    return this.pinsField;
                }
                set
                {
                    this.pinsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class peripheral_typesPeripheral_type
        {

            private peripheral_typesPeripheral_typeGui guiField;

            private peripheral_typesPeripheral_typePeripheral_signal[] peripheral_signalsField;

            private string idField;

            private string nameField;

            private string descriptionField;

            /// <remarks/>
            public peripheral_typesPeripheral_typeGui gui
            {
                get
                {
                    return this.guiField;
                }
                set
                {
                    this.guiField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("peripheral_signal", IsNullable = false)]
            public peripheral_typesPeripheral_typePeripheral_signal[] peripheral_signals
            {
                get
                {
                    return this.peripheral_signalsField;
                }
                set
                {
                    this.peripheral_signalsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class peripheral_typesPeripheral_typeGui
        {

            private string colorField;

            /// <remarks/>
            public string color
            {
                get
                {
                    return this.colorField;
                }
                set
                {
                    this.colorField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class peripheral_typesPeripheral_typePeripheral_signal
        {

            private peripheral_typesPeripheral_typePeripheral_signalSignal_channel[] signal_channelsField;

            private string idField;

            private string nameField;

            private string descriptionField;

            private string directionsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("signal_channel", IsNullable = false)]
            public peripheral_typesPeripheral_typePeripheral_signalSignal_channel[] signal_channels
            {
                get
                {
                    return this.signal_channelsField;
                }
                set
                {
                    this.signal_channelsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string directions
            {
                get
                {
                    return this.directionsField;
                }
                set
                {
                    this.directionsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class peripheral_typesPeripheral_typePeripheral_signalSignal_channel
        {

            private string idField;

            private string nameField;

            private string descriptionField;

            private string directionsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string directions
            {
                get
                {
                    return this.directionsField;
                }
                set
                {
                    this.directionsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class peripheralsPeripheral
        {

            private string idField;

            private string nameField;

            private string peripheral_typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string peripheral_type
            {
                get
                {
                    return this.peripheral_typeField;
                }
                set
                {
                    this.peripheral_typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class package_functionsPackage_function
        {

            private string idField;

            private string nameField;

            private string descriptionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class non_peripheral_pin_functions
        {

            private non_peripheral_pin_functionsNon_peripheral_pin_function non_peripheral_pin_functionField;

            /// <remarks/>
            public non_peripheral_pin_functionsNon_peripheral_pin_function non_peripheral_pin_function
            {
                get
                {
                    return this.non_peripheral_pin_functionField;
                }
                set
                {
                    this.non_peripheral_pin_functionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class non_peripheral_pin_functionsNon_peripheral_pin_function
        {

            private non_peripheral_pin_functionsNon_peripheral_pin_functionGui guiField;

            private string idField;

            private string nameField;

            private string descriptionField;

            /// <remarks/>
            public non_peripheral_pin_functionsNon_peripheral_pin_functionGui gui
            {
                get
                {
                    return this.guiField;
                }
                set
                {
                    this.guiField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class non_peripheral_pin_functionsNon_peripheral_pin_functionGui
        {

            private string colorField;

            private string iconField;

            /// <remarks/>
            public string color
            {
                get
                {
                    return this.colorField;
                }
                set
                {
                    this.colorField = value;
                }
            }

            /// <remarks/>
            public string icon
            {
                get
                {
                    return this.iconField;
                }
                set
                {
                    this.iconField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class functional_properties_declarationsFunctional_property_declaration
        {

            private functional_properties_declarationsFunctional_property_declarationState_declaration[] state_declarationField;

            private string idField;

            private string nameField;

            private string descriptionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("state_declaration")]
            public functional_properties_declarationsFunctional_property_declarationState_declaration[] state_declaration
            {
                get
                {
                    return this.state_declarationField;
                }
                set
                {
                    this.state_declarationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class functional_properties_declarationsFunctional_property_declarationState_declaration
        {

            private string idField;

            private string nameField;

            private string descriptionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class pinsPin
        {

            private pinsPinConnections[] connectionsField;

            private pinsPinFunctional_property[] functional_propertiesField;

            private string nameField;

            private string coordsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("connections")]
            public pinsPinConnections[] connections
            {
                get
                {
                    return this.connectionsField;
                }
                set
                {
                    this.connectionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("functional_property", IsNullable = false)]
            public pinsPinFunctional_property[] functional_properties
            {
                get
                {
                    return this.functional_propertiesField;
                }
                set
                {
                    this.functional_propertiesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string coords
            {
                get
                {
                    return this.coordsField;
                }
                set
                {
                    this.coordsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class pinsPinConnections
        {

            private pinsPinConnectionsConnection connectionField;

            private string name_partField;

            private string package_functionField;

            /// <remarks/>
            public pinsPinConnectionsConnection connection
            {
                get
                {
                    return this.connectionField;
                }
                set
                {
                    this.connectionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name_part
            {
                get
                {
                    return this.name_partField;
                }
                set
                {
                    this.name_partField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string package_function
            {
                get
                {
                    return this.package_functionField;
                }
                set
                {
                    this.package_functionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class pinsPinConnectionsConnection
        {

            private pinsPinConnectionsConnectionPeripheral_signal_ref peripheral_signal_refField;

            private pinsPinConnectionsConnectionConfiguration configurationField;

            private bool exclusiveField;

            private bool exclusiveFieldSpecified;

            /// <remarks/>
            public pinsPinConnectionsConnectionPeripheral_signal_ref peripheral_signal_ref
            {
                get
                {
                    return this.peripheral_signal_refField;
                }
                set
                {
                    this.peripheral_signal_refField = value;
                }
            }

            /// <remarks/>
            public pinsPinConnectionsConnectionConfiguration configuration
            {
                get
                {
                    return this.configurationField;
                }
                set
                {
                    this.configurationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool exclusive
            {
                get
                {
                    return this.exclusiveField;
                }
                set
                {
                    this.exclusiveField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool exclusiveSpecified
            {
                get
                {
                    return this.exclusiveFieldSpecified;
                }
                set
                {
                    this.exclusiveFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class pinsPinConnectionsConnectionPeripheral_signal_ref
        {

            private string signalField;

            private string peripheralField;

            private string channelField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string signal
            {
                get
                {
                    return this.signalField;
                }
                set
                {
                    this.signalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string peripheral
            {
                get
                {
                    return this.peripheralField;
                }
                set
                {
                    this.peripheralField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string channel
            {
                get
                {
                    return this.channelField;
                }
                set
                {
                    this.channelField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class pinsPinConnectionsConnectionConfiguration
        {

            private pinsPinConnectionsConnectionConfigurationAssign assignField;

            /// <remarks/>
            public pinsPinConnectionsConnectionConfigurationAssign assign
            {
                get
                {
                    return this.assignField;
                }
                set
                {
                    this.assignField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class pinsPinConnectionsConnectionConfigurationAssign
        {

            private string registerField;

            private string bit_fieldField;

            private string bit_field_maskField;

            private string bit_field_valueField;

            private string configuration_stepField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string register
            {
                get
                {
                    return this.registerField;
                }
                set
                {
                    this.registerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string bit_field
            {
                get
                {
                    return this.bit_fieldField;
                }
                set
                {
                    this.bit_fieldField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string bit_field_mask
            {
                get
                {
                    return this.bit_field_maskField;
                }
                set
                {
                    this.bit_field_maskField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string bit_field_value
            {
                get
                {
                    return this.bit_field_valueField;
                }
                set
                {
                    this.bit_field_valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string configuration_step
            {
                get
                {
                    return this.configuration_stepField;
                }
                set
                {
                    this.configuration_stepField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class pinsPinFunctional_property
        {

            private pinsPinFunctional_propertyState[] stateField;

            private string idField;

            private string defaultField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("state")]
            public pinsPinFunctional_propertyState[] state
            {
                get
                {
                    return this.stateField;
                }
                set
                {
                    this.stateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string @default
            {
                get
                {
                    return this.defaultField;
                }
                set
                {
                    this.defaultField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class pinsPinFunctional_propertyState
        {

            private pinsPinFunctional_propertyStateConfiguration configurationField;

            private string idField;

            /// <remarks/>
            public pinsPinFunctional_propertyStateConfiguration configuration
            {
                get
                {
                    return this.configurationField;
                }
                set
                {
                    this.configurationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class pinsPinFunctional_propertyStateConfiguration
        {

            private pinsPinFunctional_propertyStateConfigurationAssign assignField;

            /// <remarks/>
            public pinsPinFunctional_propertyStateConfigurationAssign assign
            {
                get
                {
                    return this.assignField;
                }
                set
                {
                    this.assignField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class pinsPinFunctional_propertyStateConfigurationAssign
        {

            private string registerField;

            private string bit_fieldField;

            private string bit_field_maskField;

            private string bit_field_valueField;

            private string configuration_stepField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string register
            {
                get
                {
                    return this.registerField;
                }
                set
                {
                    this.registerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string bit_field
            {
                get
                {
                    return this.bit_fieldField;
                }
                set
                {
                    this.bit_fieldField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string bit_field_mask
            {
                get
                {
                    return this.bit_field_maskField;
                }
                set
                {
                    this.bit_field_maskField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string bit_field_value
            {
                get
                {
                    return this.bit_field_valueField;
                }
                set
                {
                    this.bit_field_valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string configuration_step
            {
                get
                {
                    return this.configuration_stepField;
                }
                set
                {
                    this.configuration_stepField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class peripheral_types
        {

            private peripheral_typesPeripheral_type[] peripheral_typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("peripheral_type")]
            public peripheral_typesPeripheral_type[] peripheral_type
            {
                get
                {
                    return this.peripheral_typeField;
                }
                set
                {
                    this.peripheral_typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class peripherals
        {

            private peripheralsPeripheral[] peripheralField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("peripheral")]
            public peripheralsPeripheral[] peripheral
            {
                get
                {
                    return this.peripheralField;
                }
                set
                {
                    this.peripheralField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class package_functions
        {

            private package_functionsPackage_function[] package_functionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("package_function")]
            public package_functionsPackage_function[] package_function
            {
                get
                {
                    return this.package_functionField;
                }
                set
                {
                    this.package_functionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class functional_properties_declarations
        {

            private functional_properties_declarationsFunctional_property_declaration[] functional_property_declarationField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("functional_property_declaration")]
            public functional_properties_declarationsFunctional_property_declaration[] functional_property_declaration
            {
                get
                {
                    return this.functional_property_declarationField;
                }
                set
                {
                    this.functional_property_declarationField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class pins
        {

            private pinsPin[] pinField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("pin")]
            public pinsPin[] pin
            {
                get
                {
                    return this.pinField;
                }
                set
                {
                    this.pinField = value;
                }
            }
        }


    }
}
