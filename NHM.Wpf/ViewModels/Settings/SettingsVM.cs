﻿using System.Collections.Generic;

namespace NHM.Wpf.ViewModels.Settings
{
    public class SettingsVM : BaseVM
    {
        private SettingsBaseVM _selectedPageVM;
        public SettingsBaseVM SelectedPageVM
        {
            get => _selectedPageVM;
            set
            {
                _selectedPageVM = value;
                OnPropertyChanged();
            }
        }

        public IReadOnlyList<SettingsBaseVM> PageVMs { get; }

        public SettingsVM()
        {
            // placeholder
            object settingsObj = null;

            PageVMs = new List<SettingsBaseVM>
            {
                new GeneralSettingsVM(settingsObj),
                new ProfitabilitySettingsVM(settingsObj),
                new MiningGeneralVM(settingsObj),
                SettingsContainerVM.AdvancedContainer(settingsObj)
            };

            SelectedPageVM = PageVMs[0];
        }

        public void SetDefaults()
        {
            // TODO
        }

        public void Revert()
        {
            // TODO
        }
    }
}
