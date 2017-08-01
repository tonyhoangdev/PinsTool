using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ParserProperty
    {

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.freescale.com/ProcessorExpert/PropertyConfiguration.xsd")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.freescale.com/ProcessorExpert/PropertyConfiguration.xsd", IsNullable = false)]
        public partial class property_configuration
        {

            private part_information part_informationField;

            private peripheralsPeripheral[] peripheralsField;

            private propertiesEnum_property[] propertiesField;

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
            [System.Xml.Serialization.XmlArrayAttribute(Namespace = "")]
            [System.Xml.Serialization.XmlArrayItemAttribute("enum_property", IsNullable = false)]
            public propertiesEnum_property[] properties
            {
                get
                {
                    return this.propertiesField;
                }
                set
                {
                    this.propertiesField = value;
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

            private string idField;

            private string familyField;

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
            public string family
            {
                get
                {
                    return this.familyField;
                }
                set
                {
                    this.familyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class peripheralsPeripheral
        {

            private peripheralsPeripheralPex_init_component pex_init_componentField;

            private string idField;

            private string nameField;

            /// <remarks/>
            public peripheralsPeripheralPex_init_component pex_init_component
            {
                get
                {
                    return this.pex_init_componentField;
                }
                set
                {
                    this.pex_init_componentField = value;
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class peripheralsPeripheralPex_init_component
        {

            private string nameField;

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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class propertiesEnum_property
        {

            private propertiesEnum_propertyState[] stateField;

            private string idField;

            private string captionField;

            private string descriptionField;

            private string defaultField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("state")]
            public propertiesEnum_propertyState[] state
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
            public string caption
            {
                get
                {
                    return this.captionField;
                }
                set
                {
                    this.captionField = value;
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
        public partial class propertiesEnum_propertyState
        {

            private propertiesEnum_propertyStateConfiguration configurationField;

            private string idField;

            private string captionField;

            private string descriptionField;

            /// <remarks/>
            public propertiesEnum_propertyStateConfiguration configuration
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string caption
            {
                get
                {
                    return this.captionField;
                }
                set
                {
                    this.captionField = value;
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
        public partial class propertiesEnum_propertyStateConfiguration
        {

            private propertiesEnum_propertyStateConfigurationConst_assign const_assignField;

            /// <remarks/>
            public propertiesEnum_propertyStateConfigurationConst_assign const_assign
            {
                get
                {
                    return this.const_assignField;
                }
                set
                {
                    this.const_assignField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class propertiesEnum_propertyStateConfigurationConst_assign
        {

            private string registerField;

            private string bit_fieldField;

            private string bit_field_maskField;

            private string configuration_stepField;

            private bool check_conflictField;

            private string bit_field_valueField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool check_conflict
            {
                get
                {
                    return this.check_conflictField;
                }
                set
                {
                    this.check_conflictField = value;
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
        public partial class properties
        {

            private propertiesEnum_property[] enum_propertyField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("enum_property")]
            public propertiesEnum_property[] enum_property
            {
                get
                {
                    return this.enum_propertyField;
                }
                set
                {
                    this.enum_propertyField = value;
                }
            }
        }


    }
}
