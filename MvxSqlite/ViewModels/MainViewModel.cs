using System;
using MvvmCross.Core.ViewModels;
using MvxSqlite.Services;
using MvxSqlite.Models;

namespace MvxSqlite.ViewModels
{
    public class MainViewModel
        : MvxViewModel
    {
        private readonly IDataService _dataService;

        public MainViewModel(IDataService dataService)
        {
            this._dataService = dataService;
            
        }

        private string _value;

        public string Value
        {
            get { return this._value; }
            set { this.RaiseAndSetIfChanged(ref this._value, value); }
        }

        public MvxCommand Save
        {
            get
            {
                return new MvxCommand(DoSave);
            }
        }

        public MvxCommand Load
        {
            get
            {
                return new MvxCommand(DoLoad);
            }
        }

        void DoSave()
        {
            this._dataService.Save(new Item { Value = this.Value });
        }

        void DoLoad()
        {
            this.Value = this._dataService.Load()?.Value ?? "no value";
        }
    }
}

