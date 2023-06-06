using System;
using JuliusSweetland.OptiKey.Enums;

namespace JuliusSweetland.OptiKey.EyeMine.Properties {

    class Settings : JuliusSweetland.OptiKey.Properties.Settings
    {
        
        public static void Initialise()
        {
            Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
            InitialiseWithDerivedSettings(defaultInstance);            
        }

        public override AppType GetApp()
        {
            // FIXME: HACK
            return AppType.Pro;
        }

        // If Settings.Default is requested from an instance of this object, return a cast version
        public new static Settings Default => (Settings)OptiKey.Properties.Settings.Default;



        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public new bool EnablePlugins
        {
            get
            {
                return false;
            }
            set
            {
                this["EnablePlugins"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("EyeMineAllKeyboards")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::JuliusSweetland.OptiKey.EyeMine.Enums.StartupKeyboardOptions EyeMineStartupKeyboard
        {
            get
            {
                return ((global::JuliusSweetland.OptiKey.EyeMine.Enums.StartupKeyboardOptions)(this["EyeMineStartupKeyboard"]));
            }
            set
            {
                this["EyeMineStartupKeyboard"] = value;
            }
        }

        // We'll internally use the existing DynamicKeyboardsLocation setting to pick the installed keyboards,
        // so we want an additional setting to remember user's own custom location
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string OwnDynamicKeyboardsLocation
        {
            get
            {
                return ((string)(this["OwnDynamicKeyboardsLocation"]));
            }
            set
            {
                this["OwnDynamicKeyboardsLocation"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("EnglishMinecraft")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public new global::JuliusSweetland.OptiKey.Enums.Languages KeyboardAndDictionaryLanguage
        {
            get
            {
                return ((global::JuliusSweetland.OptiKey.Enums.Languages)(this["KeyboardAndDictionaryLanguage"]));
            }
            set
            {
                this["KeyboardAndDictionaryLanguage"] = value;
            }
        }


        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public new bool SmoothWhenChangingGazeTarget
        {
            get
            {
                return ((bool)(this["SmoothWhenChangingGazeTarget"]));
            }
            set
            {
                this["SmoothWhenChangingGazeTarget"] = value;
            }
        }


        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public new bool SuppressTriggerWithoutPositionError
        {
            get
            {
                return ((bool)(this["SuppressTriggerWithoutPositionError"]));
            }
            set
            {
                this["SuppressTriggerWithoutPositionError"] = value;
            }
        }


        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public new bool PointsMousePositionHideCursor
        {
            get
            {
                return ((bool)(this["PointsMousePositionHideCursor"]));
            }
            set
            {
                this["PointsMousePositionHideCursor"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TobiiEyeX")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public new global::JuliusSweetland.OptiKey.Enums.PointsSources PointsSource
        {
            get
            {
                return ((global::JuliusSweetland.OptiKey.Enums.PointsSources)(this["PointsSource"]));
            }
            set
            {
                this["PointsSource"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("32")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public new double MainWindowFullDockThicknessAsPercentageOfScreen
        {
            get
            {
                return ((double)(this["MainWindowFullDockThicknessAsPercentageOfScreen"]));
            }
            set
            {
                this["MainWindowFullDockThicknessAsPercentageOfScreen"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Bottom")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public new global::JuliusSweetland.OptiKey.Enums.DockEdges MainWindowDockPosition
        {
            get
            {
                return ((global::JuliusSweetland.OptiKey.Enums.DockEdges)(this["MainWindowDockPosition"]));
            }
            set
            {
                this["MainWindowDockPosition"] = value;
            }
        }

        // TODO : own logic on top of the core startup keyboards
        // setting for 'selection' vs 'specific keyboard'

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DynamicKeyboard")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public new global::JuliusSweetland.OptiKey.Enums.Keyboards StartupKeyboard
        {
            get
            {
                return ((global::JuliusSweetland.OptiKey.Enums.Keyboards)(this["StartupKeyboard"]));
            }
            set
            {
                this["StartupKeyboard"] = value;
            }
        }


        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Title")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public new global::JuliusSweetland.OptiKey.Enums.Case KeyCase
        {
            get
            {
                return ((global::JuliusSweetland.OptiKey.Enums.Case)(this["KeyCase"]));
            }
            set
            {
                this["KeyCase"] = value;
            }
        }

        //TODO: reconsider? not sure if even relevant
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public new bool KeySelectionTriggerFixationCompleteTimesByIndividualKey
        {
            get
            {
                return ((bool)(this["KeySelectionTriggerFixationCompleteTimesByIndividualKey"]));
            }
            set
            {
                this["KeySelectionTriggerFixationCompleteTimesByIndividualKey"] = value;
            }
        }


        //TODO: there was some legacy backwards-compatibility handling in here, we don't need now
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string CustomDynamicKeyboardsLocation
        {
            get
            {
                return ((string)(this["CustomDynamicKeyboardsLocation"]));
            }
            set
            {
                this["CustomDynamicKeyboardsLocation"] = value;
            }
        }


        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public new string DynamicKeyboardsLocation
        {
            get
            {
                return ((string)(this["DynamicKeyboardsLocation"]));
            }
            set
            {
                this["DynamicKeyboardsLocation"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1,30,1,1")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.Windows.Thickness BorderThickness
        {
            get
            {
                return ((global::System.Windows.Thickness)(this["BorderThickness"]));
            }
            set
            {
                this["BorderThickness"] = value;
            }
        }

    }
}
