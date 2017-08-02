using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ParserItem
    {

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class ListItem
        {

            private ListItemTGrupItem tGrupItemField;

            private ListItemLink[] linksField;

            /// <remarks/>
            public ListItemTGrupItem TGrupItem
            {
                get
                {
                    return this.tGrupItemField;
                }
                set
                {
                    this.tGrupItemField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Link", IsNullable = false)]
            public ListItemLink[] Links
            {
                get
                {
                    return this.linksField;
                }
                set
                {
                    this.linksField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItem
        {

            private string nameField;

            private string symbolField;

            private object hintField;

            private string itemLevelField;

            private bool boldNameField;

            private bool editLineField;

            private ListItemTGrupItemEditorData editorDataField;

            private object descriptionField;

            private string expandedField;

            private ListItemTGrupItemGrupItem[] childrenField;

            /// <remarks/>
            public string Name
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
            public string Symbol
            {
                get
                {
                    return this.symbolField;
                }
                set
                {
                    this.symbolField = value;
                }
            }

            /// <remarks/>
            public object Hint
            {
                get
                {
                    return this.hintField;
                }
                set
                {
                    this.hintField = value;
                }
            }

            /// <remarks/>
            public string ItemLevel
            {
                get
                {
                    return this.itemLevelField;
                }
                set
                {
                    this.itemLevelField = value;
                }
            }

            /// <remarks/>
            public bool BoldName
            {
                get
                {
                    return this.boldNameField;
                }
                set
                {
                    this.boldNameField = value;
                }
            }

            /// <remarks/>
            public bool EditLine
            {
                get
                {
                    return this.editLineField;
                }
                set
                {
                    this.editLineField = value;
                }
            }

            /// <remarks/>
            public ListItemTGrupItemEditorData EditorData
            {
                get
                {
                    return this.editorDataField;
                }
                set
                {
                    this.editorDataField = value;
                }
            }

            /// <remarks/>
            public object Description
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
            public string Expanded
            {
                get
                {
                    return this.expandedField;
                }
                set
                {
                    this.expandedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("GrupItem", IsNullable = false)]
            public ListItemTGrupItemGrupItem[] Children
            {
                get
                {
                    return this.childrenField;
                }
                set
                {
                    this.childrenField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemEditorData
        {

            private ListItemTGrupItemEditorDataElectrical_properties_supported electrical_properties_supportedField;

            private ListItemTGrupItemEditorDataPeripheral_related_electrical_properties_supported peripheral_related_electrical_properties_supportedField;

            /// <remarks/>
            public ListItemTGrupItemEditorDataElectrical_properties_supported electrical_properties_supported
            {
                get
                {
                    return this.electrical_properties_supportedField;
                }
                set
                {
                    this.electrical_properties_supportedField = value;
                }
            }

            /// <remarks/>
            public ListItemTGrupItemEditorDataPeripheral_related_electrical_properties_supported peripheral_related_electrical_properties_supported
            {
                get
                {
                    return this.peripheral_related_electrical_properties_supportedField;
                }
                set
                {
                    this.peripheral_related_electrical_properties_supportedField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemEditorDataElectrical_properties_supported
        {

            private bool valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemEditorDataPeripheral_related_electrical_properties_supported
        {

            private bool valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemGrupItem
        {

            private ListItemTGrupItemGrupItemTGrupItem tGrupItemField;

            /// <remarks/>
            public ListItemTGrupItemGrupItemTGrupItem TGrupItem
            {
                get
                {
                    return this.tGrupItemField;
                }
                set
                {
                    this.tGrupItemField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemGrupItemTGrupItem
        {

            private string nameField;

            private string symbolField;

            private string hintField;

            private string itemLevelField;

            private bool boldNameField;

            private bool editLineField;

            private ListItemTGrupItemGrupItemTGrupItemEditorData editorDataField;

            private object descriptionField;

            private string expandedField;

            private ListItemTGrupItemGrupItemTGrupItemGrupItem[] childrenField;

            /// <remarks/>
            public string Name
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
            public string Symbol
            {
                get
                {
                    return this.symbolField;
                }
                set
                {
                    this.symbolField = value;
                }
            }

            /// <remarks/>
            public string Hint
            {
                get
                {
                    return this.hintField;
                }
                set
                {
                    this.hintField = value;
                }
            }

            /// <remarks/>
            public string ItemLevel
            {
                get
                {
                    return this.itemLevelField;
                }
                set
                {
                    this.itemLevelField = value;
                }
            }

            /// <remarks/>
            public bool BoldName
            {
                get
                {
                    return this.boldNameField;
                }
                set
                {
                    this.boldNameField = value;
                }
            }

            /// <remarks/>
            public bool EditLine
            {
                get
                {
                    return this.editLineField;
                }
                set
                {
                    this.editLineField = value;
                }
            }

            /// <remarks/>
            public ListItemTGrupItemGrupItemTGrupItemEditorData EditorData
            {
                get
                {
                    return this.editorDataField;
                }
                set
                {
                    this.editorDataField = value;
                }
            }

            /// <remarks/>
            public object Description
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
            public string Expanded
            {
                get
                {
                    return this.expandedField;
                }
                set
                {
                    this.expandedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("GrupItem", IsNullable = false)]
            public ListItemTGrupItemGrupItemTGrupItemGrupItem[] Children
            {
                get
                {
                    return this.childrenField;
                }
                set
                {
                    this.childrenField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemGrupItemTGrupItemEditorData
        {

            private ListItemTGrupItemGrupItemTGrupItemEditorDataElectrical_property[] electrical_properties_declarationsField;

            private object peripheral_related_electrical_properties_declarationsField;

            private ListItemTGrupItemGrupItemTGrupItemEditorDataInter_peripheral_signals_routing_supported inter_peripheral_signals_routing_supportedField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("electrical_property", IsNullable = false)]
            public ListItemTGrupItemGrupItemTGrupItemEditorDataElectrical_property[] electrical_properties_declarations
            {
                get
                {
                    return this.electrical_properties_declarationsField;
                }
                set
                {
                    this.electrical_properties_declarationsField = value;
                }
            }

            /// <remarks/>
            public object peripheral_related_electrical_properties_declarations
            {
                get
                {
                    return this.peripheral_related_electrical_properties_declarationsField;
                }
                set
                {
                    this.peripheral_related_electrical_properties_declarationsField = value;
                }
            }

            /// <remarks/>
            public ListItemTGrupItemGrupItemTGrupItemEditorDataInter_peripheral_signals_routing_supported inter_peripheral_signals_routing_supported
            {
                get
                {
                    return this.inter_peripheral_signals_routing_supportedField;
                }
                set
                {
                    this.inter_peripheral_signals_routing_supportedField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemGrupItemTGrupItemEditorDataElectrical_property
        {

            private string nameField;

            private string brief_nameField;

            private string symbol_suffixField;

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
            public string brief_name
            {
                get
                {
                    return this.brief_nameField;
                }
                set
                {
                    this.brief_nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string symbol_suffix
            {
                get
                {
                    return this.symbol_suffixField;
                }
                set
                {
                    this.symbol_suffixField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemGrupItemTGrupItemEditorDataInter_peripheral_signals_routing_supported
        {

            private bool valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemGrupItemTGrupItemGrupItem
        {

            private ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItem tGrupItemField;

            /// <remarks/>
            public ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItem TGrupItem
            {
                get
                {
                    return this.tGrupItemField;
                }
                set
                {
                    this.tGrupItemField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItem
        {

            private string nameField;

            private string symbolField;

            private string hintField;

            private string itemLevelField;

            private bool boldNameField;

            private bool editLineField;

            private ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemEditorData editorDataField;

            private object descriptionField;

            private string expandedField;

            private ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItem[] childrenField;

            /// <remarks/>
            public string Name
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
            public string Symbol
            {
                get
                {
                    return this.symbolField;
                }
                set
                {
                    this.symbolField = value;
                }
            }

            /// <remarks/>
            public string Hint
            {
                get
                {
                    return this.hintField;
                }
                set
                {
                    this.hintField = value;
                }
            }

            /// <remarks/>
            public string ItemLevel
            {
                get
                {
                    return this.itemLevelField;
                }
                set
                {
                    this.itemLevelField = value;
                }
            }

            /// <remarks/>
            public bool BoldName
            {
                get
                {
                    return this.boldNameField;
                }
                set
                {
                    this.boldNameField = value;
                }
            }

            /// <remarks/>
            public bool EditLine
            {
                get
                {
                    return this.editLineField;
                }
                set
                {
                    this.editLineField = value;
                }
            }

            /// <remarks/>
            public ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemEditorData EditorData
            {
                get
                {
                    return this.editorDataField;
                }
                set
                {
                    this.editorDataField = value;
                }
            }

            /// <remarks/>
            public object Description
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
            public string Expanded
            {
                get
                {
                    return this.expandedField;
                }
                set
                {
                    this.expandedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("GrupItem", IsNullable = false)]
            public ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItem[] Children
            {
                get
                {
                    return this.childrenField;
                }
                set
                {
                    this.childrenField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemEditorData
        {

            private ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemEditorDataCoords coordsField;

            private ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemEditorDataPin_function_property_ref[] pin_function_property_refField;

            private ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemEditorDataGui_color gui_colorField;

            /// <remarks/>
            public ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemEditorDataCoords coords
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

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("pin_function_property_ref")]
            public ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemEditorDataPin_function_property_ref[] pin_function_property_ref
            {
                get
                {
                    return this.pin_function_property_refField;
                }
                set
                {
                    this.pin_function_property_refField = value;
                }
            }

            /// <remarks/>
            public ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemEditorDataGui_color gui_color
            {
                get
                {
                    return this.gui_colorField;
                }
                set
                {
                    this.gui_colorField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemEditorDataCoords
        {

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemEditorDataPin_function_property_ref
        {

            private string symbolField;

            private string function_abbreviationField;

            private string directionsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string symbol
            {
                get
                {
                    return this.symbolField;
                }
                set
                {
                    this.symbolField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string function_abbreviation
            {
                get
                {
                    return this.function_abbreviationField;
                }
                set
                {
                    this.function_abbreviationField = value;
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
        public partial class ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemEditorDataGui_color
        {

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItem
        {

            private ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPinFuncPropItem tPinFuncPropItemField;

            private ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTGrupItem tGrupItemField;

            private ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPrphNameItem tPrphNameItemField;

            /// <remarks/>
            public ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPinFuncPropItem TPinFuncPropItem
            {
                get
                {
                    return this.tPinFuncPropItemField;
                }
                set
                {
                    this.tPinFuncPropItemField = value;
                }
            }

            /// <remarks/>
            public ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTGrupItem TGrupItem
            {
                get
                {
                    return this.tGrupItemField;
                }
                set
                {
                    this.tGrupItemField = value;
                }
            }

            /// <remarks/>
            public ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPrphNameItem TPrphNameItem
            {
                get
                {
                    return this.tPrphNameItemField;
                }
                set
                {
                    this.tPrphNameItemField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPinFuncPropItem
        {

            private string nameField;

            private string symbolField;

            private string hintField;

            private string itemLevelField;

            private bool editLineField;

            private string defaultValueField;

            private bool canDeleteField;

            private bool iconPopupField;

            private string sortStyleField;

            private string pinFunctionalPropertyIdField;

            private string forcePinNameField;

            /// <remarks/>
            public string Name
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
            public string Symbol
            {
                get
                {
                    return this.symbolField;
                }
                set
                {
                    this.symbolField = value;
                }
            }

            /// <remarks/>
            public string Hint
            {
                get
                {
                    return this.hintField;
                }
                set
                {
                    this.hintField = value;
                }
            }

            /// <remarks/>
            public string ItemLevel
            {
                get
                {
                    return this.itemLevelField;
                }
                set
                {
                    this.itemLevelField = value;
                }
            }

            /// <remarks/>
            public bool EditLine
            {
                get
                {
                    return this.editLineField;
                }
                set
                {
                    this.editLineField = value;
                }
            }

            /// <remarks/>
            public string DefaultValue
            {
                get
                {
                    return this.defaultValueField;
                }
                set
                {
                    this.defaultValueField = value;
                }
            }

            /// <remarks/>
            public bool CanDelete
            {
                get
                {
                    return this.canDeleteField;
                }
                set
                {
                    this.canDeleteField = value;
                }
            }

            /// <remarks/>
            public bool IconPopup
            {
                get
                {
                    return this.iconPopupField;
                }
                set
                {
                    this.iconPopupField = value;
                }
            }

            /// <remarks/>
            public string SortStyle
            {
                get
                {
                    return this.sortStyleField;
                }
                set
                {
                    this.sortStyleField = value;
                }
            }

            /// <remarks/>
            public string PinFunctionalPropertyId
            {
                get
                {
                    return this.pinFunctionalPropertyIdField;
                }
                set
                {
                    this.pinFunctionalPropertyIdField = value;
                }
            }

            /// <remarks/>
            public string ForcePinName
            {
                get
                {
                    return this.forcePinNameField;
                }
                set
                {
                    this.forcePinNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTGrupItem
        {

            private string nameField;

            private string symbolField;

            private string hintField;

            private string itemLevelField;

            private bool boldNameField;

            private bool editLineField;

            private object descriptionField;

            private string expandedField;

            private ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItem[] childrenField;

            /// <remarks/>
            public string Name
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
            public string Symbol
            {
                get
                {
                    return this.symbolField;
                }
                set
                {
                    this.symbolField = value;
                }
            }

            /// <remarks/>
            public string Hint
            {
                get
                {
                    return this.hintField;
                }
                set
                {
                    this.hintField = value;
                }
            }

            /// <remarks/>
            public string ItemLevel
            {
                get
                {
                    return this.itemLevelField;
                }
                set
                {
                    this.itemLevelField = value;
                }
            }

            /// <remarks/>
            public bool BoldName
            {
                get
                {
                    return this.boldNameField;
                }
                set
                {
                    this.boldNameField = value;
                }
            }

            /// <remarks/>
            public bool EditLine
            {
                get
                {
                    return this.editLineField;
                }
                set
                {
                    this.editLineField = value;
                }
            }

            /// <remarks/>
            public object Description
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
            public string Expanded
            {
                get
                {
                    return this.expandedField;
                }
                set
                {
                    this.expandedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("GrupItem", IsNullable = false)]
            public ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItem[] Children
            {
                get
                {
                    return this.childrenField;
                }
                set
                {
                    this.childrenField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItem
        {

            private ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPinRouteDirectionItem tPinRouteDirectionItemField;

            private ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPortItem tPortItemField;

            /// <remarks/>
            public ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPinRouteDirectionItem TPinRouteDirectionItem
            {
                get
                {
                    return this.tPinRouteDirectionItemField;
                }
                set
                {
                    this.tPinRouteDirectionItemField = value;
                }
            }

            /// <remarks/>
            public ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPortItem TPortItem
            {
                get
                {
                    return this.tPortItemField;
                }
                set
                {
                    this.tPortItemField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPinRouteDirectionItem
        {

            private string nameField;

            private string symbolField;

            private string hintField;

            private string itemLevelField;

            private bool editLineField;

            private string defaultValueField;

            private bool canDeleteField;

            private bool iconPopupField;

            private object sortStyleField;

            /// <remarks/>
            public string Name
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
            public string Symbol
            {
                get
                {
                    return this.symbolField;
                }
                set
                {
                    this.symbolField = value;
                }
            }

            /// <remarks/>
            public string Hint
            {
                get
                {
                    return this.hintField;
                }
                set
                {
                    this.hintField = value;
                }
            }

            /// <remarks/>
            public string ItemLevel
            {
                get
                {
                    return this.itemLevelField;
                }
                set
                {
                    this.itemLevelField = value;
                }
            }

            /// <remarks/>
            public bool EditLine
            {
                get
                {
                    return this.editLineField;
                }
                set
                {
                    this.editLineField = value;
                }
            }

            /// <remarks/>
            public string DefaultValue
            {
                get
                {
                    return this.defaultValueField;
                }
                set
                {
                    this.defaultValueField = value;
                }
            }

            /// <remarks/>
            public bool CanDelete
            {
                get
                {
                    return this.canDeleteField;
                }
                set
                {
                    this.canDeleteField = value;
                }
            }

            /// <remarks/>
            public bool IconPopup
            {
                get
                {
                    return this.iconPopupField;
                }
                set
                {
                    this.iconPopupField = value;
                }
            }

            /// <remarks/>
            public object SortStyle
            {
                get
                {
                    return this.sortStyleField;
                }
                set
                {
                    this.sortStyleField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPortItem
        {

            private string nameField;

            private string symbolField;

            private string hintField;

            private string itemLevelField;

            private bool readOnlyField;

            private bool readOnlyFieldSpecified;

            private bool editLineField;

            private ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPortItemEditorData editorDataField;

            private string defaultValueField;

            private bool canDeleteField;

            private bool iconPopupField;

            private string sortStyleField;

            private bool allocateField;

            private bool allowSharingField;

            private bool prphRequiredField;

            private string autoSetField;

            private bool hideNotConnectedField;

            private string portTypeField;

            private bool pinSignalsField;

            private string pinsModel_PeripheralField;

            private string pinsModel_PrphSignalField;

            private string pinsModel_ChannelField;

            private string pinsModel_DirectionField;

            /// <remarks/>
            public string Name
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
            public string Symbol
            {
                get
                {
                    return this.symbolField;
                }
                set
                {
                    this.symbolField = value;
                }
            }

            /// <remarks/>
            public string Hint
            {
                get
                {
                    return this.hintField;
                }
                set
                {
                    this.hintField = value;
                }
            }

            /// <remarks/>
            public string ItemLevel
            {
                get
                {
                    return this.itemLevelField;
                }
                set
                {
                    this.itemLevelField = value;
                }
            }

            /// <remarks/>
            public bool ReadOnly
            {
                get
                {
                    return this.readOnlyField;
                }
                set
                {
                    this.readOnlyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ReadOnlySpecified
            {
                get
                {
                    return this.readOnlyFieldSpecified;
                }
                set
                {
                    this.readOnlyFieldSpecified = value;
                }
            }

            /// <remarks/>
            public bool EditLine
            {
                get
                {
                    return this.editLineField;
                }
                set
                {
                    this.editLineField = value;
                }
            }

            /// <remarks/>
            public ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPortItemEditorData EditorData
            {
                get
                {
                    return this.editorDataField;
                }
                set
                {
                    this.editorDataField = value;
                }
            }

            /// <remarks/>
            public string DefaultValue
            {
                get
                {
                    return this.defaultValueField;
                }
                set
                {
                    this.defaultValueField = value;
                }
            }

            /// <remarks/>
            public bool CanDelete
            {
                get
                {
                    return this.canDeleteField;
                }
                set
                {
                    this.canDeleteField = value;
                }
            }

            /// <remarks/>
            public bool IconPopup
            {
                get
                {
                    return this.iconPopupField;
                }
                set
                {
                    this.iconPopupField = value;
                }
            }

            /// <remarks/>
            public string SortStyle
            {
                get
                {
                    return this.sortStyleField;
                }
                set
                {
                    this.sortStyleField = value;
                }
            }

            /// <remarks/>
            public bool Allocate
            {
                get
                {
                    return this.allocateField;
                }
                set
                {
                    this.allocateField = value;
                }
            }

            /// <remarks/>
            public bool AllowSharing
            {
                get
                {
                    return this.allowSharingField;
                }
                set
                {
                    this.allowSharingField = value;
                }
            }

            /// <remarks/>
            public bool PrphRequired
            {
                get
                {
                    return this.prphRequiredField;
                }
                set
                {
                    this.prphRequiredField = value;
                }
            }

            /// <remarks/>
            public string AutoSet
            {
                get
                {
                    return this.autoSetField;
                }
                set
                {
                    this.autoSetField = value;
                }
            }

            /// <remarks/>
            public bool HideNotConnected
            {
                get
                {
                    return this.hideNotConnectedField;
                }
                set
                {
                    this.hideNotConnectedField = value;
                }
            }

            /// <remarks/>
            public string PortType
            {
                get
                {
                    return this.portTypeField;
                }
                set
                {
                    this.portTypeField = value;
                }
            }

            /// <remarks/>
            public bool PinSignals
            {
                get
                {
                    return this.pinSignalsField;
                }
                set
                {
                    this.pinSignalsField = value;
                }
            }

            /// <remarks/>
            public string PinsModel_Peripheral
            {
                get
                {
                    return this.pinsModel_PeripheralField;
                }
                set
                {
                    this.pinsModel_PeripheralField = value;
                }
            }

            /// <remarks/>
            public string PinsModel_PrphSignal
            {
                get
                {
                    return this.pinsModel_PrphSignalField;
                }
                set
                {
                    this.pinsModel_PrphSignalField = value;
                }
            }

            /// <remarks/>
            public string PinsModel_Channel
            {
                get
                {
                    return this.pinsModel_ChannelField;
                }
                set
                {
                    this.pinsModel_ChannelField = value;
                }
            }

            /// <remarks/>
            public string PinsModel_Direction
            {
                get
                {
                    return this.pinsModel_DirectionField;
                }
                set
                {
                    this.pinsModel_DirectionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPortItemEditorData
        {

            private object default_pins_or_signal_routesField;

            private ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPortItemEditorDataPin_directions[] pins_directionsField;

            /// <remarks/>
            public object default_pins_or_signal_routes
            {
                get
                {
                    return this.default_pins_or_signal_routesField;
                }
                set
                {
                    this.default_pins_or_signal_routesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("pin_directions", IsNullable = false)]
            public ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPortItemEditorDataPin_directions[] pins_directions
            {
                get
                {
                    return this.pins_directionsField;
                }
                set
                {
                    this.pins_directionsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPortItemEditorDataPin_directions
        {

            private string pin_symbolField;

            private string directionsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string pin_symbol
            {
                get
                {
                    return this.pin_symbolField;
                }
                set
                {
                    this.pin_symbolField = value;
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
        public partial class ListItemTGrupItemGrupItemTGrupItemGrupItemTGrupItemGrupItemTPrphNameItem
        {

            private string nameField;

            private string symbolField;

            private string hintField;

            private string itemLevelField;

            private bool editLineField;

            private string peripheralNameField;

            /// <remarks/>
            public string Name
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
            public string Symbol
            {
                get
                {
                    return this.symbolField;
                }
                set
                {
                    this.symbolField = value;
                }
            }

            /// <remarks/>
            public string Hint
            {
                get
                {
                    return this.hintField;
                }
                set
                {
                    this.hintField = value;
                }
            }

            /// <remarks/>
            public string ItemLevel
            {
                get
                {
                    return this.itemLevelField;
                }
                set
                {
                    this.itemLevelField = value;
                }
            }

            /// <remarks/>
            public bool EditLine
            {
                get
                {
                    return this.editLineField;
                }
                set
                {
                    this.editLineField = value;
                }
            }

            /// <remarks/>
            public string PeripheralName
            {
                get
                {
                    return this.peripheralNameField;
                }
                set
                {
                    this.peripheralNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ListItemLink
        {

            private string itemField;

            private string pinsModel_DirectionLinkField;

            /// <remarks/>
            public string Item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }

            /// <remarks/>
            public string PinsModel_DirectionLink
            {
                get
                {
                    return this.pinsModel_DirectionLinkField;
                }
                set
                {
                    this.pinsModel_DirectionLinkField = value;
                }
            }
        }


    }
}
