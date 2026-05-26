using PatientAccounting.Interfaces;
using PatientAccounting.Models;
using PatientAccounting.Services;
using System;

namespace PatientAccounting.UserInterface
{
    public partial class HeadPhysician : UserControl, IPresenter
    {
        private Staff _headPhysician;
        public HeadPhysician(Staff headPhysician)
        {
            InitializeComponent();
            _headPhysician = headPhysician;
            InitializeFullName();
        }
        private void InitializeFullName()
            => FullNameLabel.Text = GeneralMethods.GetFullName(_headPhysician);

        private void GetAllListsButton_Click(object sender, EventArgs e)
        {
            var outputList = new GeneralListView("Главврач");
            ShowControl(outputList);
            SetPanelState(ChoiceActionPanel, false);
            SetPanelState(MainPanel, true);
            outputList.OnClosed += Reversion;
        }
        private void SetPanelState(Panel panel, bool visible)
        {
            panel.Visible = visible;
            panel.Enabled = visible;
        }
        public void ShowControl(IWindowClosed newControl)
        {
            foreach (Control control in MainPanel.Controls)
                control.Dispose();
            if (newControl is UserControl uiControl)
            {
                MainPanel.Controls.Clear();
                uiControl.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(uiControl);
            }
        }
        public void Reversion()
        {
            MainPanel.Controls.Clear();
            SetPanelState(ChoiceActionPanel, true);
            SetPanelState(MainPanel, false);
        }

        private void EditGuideButton_Click(object sender, EventArgs e)
        {
            OpenDictionarySelection();
            SetPanelState(ChoiceActionPanel, false);
            SetPanelState(MainPanel, true);
        }
        private void OpenDictionarySelection()
        {
            var selectionControl = new DictionarySelectionControl();
            selectionControl.OnClosed += Reversion;

            selectionControl.OnModeSelected += (selectedMode) =>
            {
                OpenDictionaryList(selectedMode);
            };

            ShowControl(selectionControl);
        }
        private void OpenDictionaryList(ViewListMode mode)
        {
            var dictionaryList = new DictionaryListView(mode);
            dictionaryList.OnClosed += OpenDictionarySelection;
            dictionaryList.OnEditRequested += (editControl) =>
            {
                editControl.OnClosed += () => OpenDictionaryList(mode);
                ShowControl(editControl);
            };
            ShowControl(dictionaryList);
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            var reportsControl = new ReportsSelectionControl();
            SetPanelState(ChoiceActionPanel, false);
            SetPanelState(MainPanel, true);
            reportsControl.OnClosed += Reversion;
            ShowControl(reportsControl);
        }
    }
}
