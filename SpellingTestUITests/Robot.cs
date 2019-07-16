using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UITest.Input;

namespace SpellingTestUITests
{
    public class Robot
    {
        private static Dictionary<string, UITestControl> _cache;
        private static ApplicationUnderTest _aut;
        private static UITestControl _root;
        private const string CONTROL_NOT_FOUND_EXCEPTION = "The specific control is not found!!";
        private const string MSAA_TECHNOLOGY = "MSAA";

        //set delay between actions
        public static void SetDelayBetweenActions(int millisecond)
        {
            Playback.PlaybackSettings.DelayBetweenActions = millisecond;
        }

        //lunch winform application
        public static UITestControl Initialize(string path, string title)
        {
            Playback.PlaybackSettings.DelayBetweenActions = 0;
            Playback.PlaybackSettings.ThinkTimeMultiplier = 0.0d;
            Playback.PlaybackSettings.SkipSetPropertyVerification = true;
            Playback.PlaybackSettings.ShouldSearchFailFast = true;
            _aut = ApplicationUnderTest.Launch(path);

            _cache = new Dictionary<string, UITestControl>();
            WinWindow window = new WinWindow();
            window.SearchProperties.Add(WinWindow.PropertyNames.Name, title);
            CacheComponentFound(window, title);
            _root = window;
            return _root;
        }

        //Closes the launched program
        public static void CleanUp()
        {
            _cache.Clear();
            _root = null;
            _aut.Close();
        }

        //set form
        public static UITestControl SetForm(string formName)
        {
            WinWindow window = (WinWindow)Robot.FindWinControl(typeof(WinWindow), formName, null);
            window.SearchProperties[WinWindow.PropertyNames.Name] = formName;
            window.WindowTitles.Add(formName);
            _root = window;
            return _root;
        }

        //find win control
        private static WinControl FindWinControl(Type type, string name, UITestControl parent)
        {
            if (_cache.ContainsKey(name))
            {
                    return (WinControl)_cache[name];
            }
            else
            {
                WinControl control = (WinControl)Activator.CreateInstance(type, new Object[] { parent });
                control.SearchProperties.Add(WinControl.PropertyNames.Name, name);
                CacheComponentFound(control, name);
                return control;
            }
        }

        //find cache component
        private static void CacheComponentFound(UITestControl control, string name)
        {
            control.Find();
            if (!control.Exists)
            {
                throw new Exception(CONTROL_NOT_FOUND_EXCEPTION);
            }
            _cache.Add(name, control);
        }

        //click menu item
        public static void ClickMenuItem(string[] path)
        {
            foreach (string item in path)
            {
                Mouse.Click((WinMenuItem)Robot.FindWinControl(typeof(WinMenuItem), item, _root));
            }
        }

        //click button
        public static void ClickButton(string name)
        {
            WinButton button = (WinButton)Robot.FindWinControl(typeof(WinButton), name, _root);
            Mouse.Click(button);
        }

        //set edit
        public static void SetEdit(string name, string keys)
        {
            WinEdit edit = (WinEdit)Robot.FindWinControl(typeof(WinEdit), name, _root);
            if (edit.Text != keys)
                edit.Text = keys;
        }

        //close window without button
        public static void CloseWindowWithoutButton(string name)
        {
            WinWindow window = new WinWindow();
            window.SearchProperties[WinWindow.PropertyNames.Name] = name;
            window.WindowTitles.Add(name);
            WinTitleBar bar = new WinTitleBar(window);
            Keyboard.SendKeys("{Alt}{F4}");
        }

        //set numeric up & down
        public static void SetNumericUpDown(string name, string keys)
        {
            WinComboBox spinner = (WinComboBox)Robot.FindWinControl(typeof(WinComboBox), name, _root);
            if (spinner.SelectedItem != keys)
                spinner.SelectedItem = keys;
            //Keyboard.SendKeys("{Enter}");
        }

        //set combo box
        public static void SetComboBox(string name, string targetName)
        {
            WinComboBox comboBox = (WinComboBox)Robot.FindWinControl(typeof(WinComboBox), name, _root);
            if (comboBox.SelectedItem != targetName)
                comboBox.SelectedItem = targetName;
        }

        //assert text box
        public static void AssertEdit(string name, string assertValue)
        {
            WinEdit edit = (WinEdit)Robot.FindWinControl(typeof(WinEdit), name, _root);
            Assert.AreEqual(edit.Text, assertValue);
        }

        //assert label
        public static void AssertText(string name, string assertValue)
        {
            WinText edit = (WinText)Robot.FindWinControl(typeof(WinText), name, _root);
            Assert.AreEqual(edit.DisplayText, assertValue);
        }

        //assert numeric up & down
        public static void AssertNumericUpDown(string name, string keys)
        {
            WinComboBox spinner = (WinComboBox)Robot.FindWinControl(typeof(WinComboBox), name, _root);
            Assert.AreEqual(spinner.SelectedItem, keys);
        }

        //assert combo box
        public static void AssertComboBox(string name, string assertValue)
        {
            WinComboBox comboBox = (WinComboBox)Robot.FindWinControl(typeof(WinComboBox), name, _root);
            Assert.AreEqual(comboBox.SelectedItem, assertValue);
        }

        //assert button enable
        public static void AssertButtonEnable(string name, bool state)
        {
            WinButton button = (WinButton)Robot.FindWinControl(typeof(WinButton), name, _root);
            Assert.AreEqual(button.Enabled, state);
        }

        //assert text box enable
        public static void AssertEditEnable(string name, bool state)
        {
            WinEdit textBox = (WinEdit)Robot.FindWinControl(typeof(WinEdit), name, _root);
            Assert.AreEqual(textBox.Enabled, state);
        }

        //assert menu item enable
        public static void AssertMenuItemEnable(string name, bool state)
        {
            WinMenuItem menuItem = (WinMenuItem)Robot.FindWinControl(typeof(WinMenuItem), name, _root);
            Assert.AreEqual(menuItem.Enabled, state);
        }

        //assert window exist
        public static void AssertWindowExist(string title, bool state)
        {
            WinWindow window = new WinWindow();
            window.SearchProperties.Add(WinWindow.PropertyNames.Name, title);
            Assert.AreEqual(state, window.Exists);
        }
        
        //send key enter to message box
        public static void SendKeyEnterToMessageBox(string caption)
        {
            WinControl control = (WinControl)Robot.FindWinControl(typeof(WinControl), caption, null);
            Keyboard.SendKeys("{Enter}");
        }

        //click radio button
        public static void ClickRadioButton(string name)
        {
            WinRadioButton radio = (WinRadioButton)Robot.FindWinControl(typeof(WinRadioButton), name, _root);
            Mouse.Click(radio);
        }

        //assert radio button checked
        public static void AssertRadioButtonChecked(string name, bool state)
        {
            WinRadioButton radio = (WinRadioButton)Robot.FindWinControl(typeof(WinRadioButton), name, _root);
            Assert.AreEqual(state, radio.Selected);
        }

        //click hyper link
        public static void ClickHyperlink(string name)
        {
            WinHyperlink hyperink = (WinHyperlink)Robot.FindWinControl(typeof(WinHyperlink), name, _root);
            Mouse.Click(hyperink);
        }
    }
}
