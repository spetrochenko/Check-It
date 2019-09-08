using CheckIt.Common.DataProvider;
using CheckIt.Droid.DataProvider;
using System;
using System.IO;
using Xamarin.Forms;
using CheckIt.Common.Constants;

[assembly: Dependency(typeof(AndroidDataProvider))]
namespace CheckIt.Droid.DataProvider
{
    public class AndroidDataProvider : IDataProvider
    {
        public string GetPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), Constants.DB_NAME);
        }
    }
}